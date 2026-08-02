using System.Net;
using System.Net.Sockets;
using System.Net.WebSockets;
using System.Text;
using System.Text.Json;
using Xai.Realtime;

namespace Xai.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void ServerEventDeserializer_RejectsUnknownDiscriminatorInsteadOfSelectingFirstVariant()
    {
        using var client = new XaiRealtimeClient();

        var deserialize = () => JsonSerializer.Deserialize(
            "{\"type\":\"future.event\"}",
            typeof(ServerEvent),
            client.JsonSerializerContext);

        deserialize.Should().Throw<JsonException>()
            .WithMessage("*Unknown discriminator value 'future.event'*");
    }

    [TestMethod]
    public async Task ReceiveMessagesAsync_PreservesJsonEventsAndFragmentedBinaryAudioInWireOrder()
    {
        var port = ReserveLoopbackPort();
        using var listener = new HttpListener();
        listener.Prefixes.Add($"http://127.0.0.1:{port}/");
        listener.Start();

        using var cancellationTokenSource = new CancellationTokenSource(TimeSpan.FromSeconds(10));
        var serverTask = SendMixedRealtimeMessagesAsync(listener, cancellationTokenSource.Token);

        using var client = new XaiRealtimeClient();
        await client.ConnectAsync(
            uri: new Uri($"ws://127.0.0.1:{port}/"),
            cancellationToken: cancellationTokenSource.Token);

        var messages = new List<RealtimeServerMessage>();
        var unknownMessageCount = 0;
        client.UnknownMessage += (_, _) => unknownMessageCount++;
        await foreach (var message in client.ReceiveMessagesAsync(cancellationTokenSource.Token))
        {
            messages.Add(message);
            if (messages.Count == 4)
            {
                break;
            }
        }

        await serverTask;

        messages.Should().HaveCount(4);
        messages[0].IsText.Should().BeTrue();
        messages[0].Event.Should().NotBeNull();
        messages[0].Event!.Value.IsResponseCreated.Should().BeTrue();

        messages[1].IsBinaryAudio.Should().BeTrue();
        messages[1].BinaryAudio.ToArray().Should().Equal([0x01, 0x02, 0x03, 0x04, 0x05]);

        messages[2].IsText.Should().BeTrue();
        messages[2].RawText.Should().Be("{\"type\":\"ping\"}");
        messages[2].Event.Should().BeNull();
        unknownMessageCount.Should().Be(1);

        messages[3].IsText.Should().BeTrue();
        messages[3].Event.Should().NotBeNull();
        messages[3].Event!.Value.IsResponseDone.Should().BeTrue();
    }

    private static int ReserveLoopbackPort()
    {
        using var reservation = new TcpListener(IPAddress.Loopback, 0);
        reservation.Start();
        return ((IPEndPoint)reservation.LocalEndpoint).Port;
    }

    private static async Task SendMixedRealtimeMessagesAsync(
        HttpListener listener,
        CancellationToken cancellationToken)
    {
        var context = await listener.GetContextAsync().WaitAsync(cancellationToken);
        var webSocketContext = await context.AcceptWebSocketAsync(subProtocol: null);
        using var webSocket = webSocketContext.WebSocket;

        await SendTextAsync(webSocket, "{\"type\":\"response.created\"}", cancellationToken);
        await webSocket.SendAsync(
            new byte[] { 0x01, 0x02 },
            WebSocketMessageType.Binary,
            endOfMessage: false,
            cancellationToken);
        await webSocket.SendAsync(
            new byte[] { 0x03, 0x04, 0x05 },
            WebSocketMessageType.Binary,
            endOfMessage: true,
            cancellationToken);
        await SendTextAsync(webSocket, "{\"type\":\"ping\"}", cancellationToken);
        await SendTextAsync(webSocket, "{\"type\":\"response.done\"}", cancellationToken);
    }

    private static Task SendTextAsync(
        WebSocket webSocket,
        string text,
        CancellationToken cancellationToken)
    {
        return webSocket.SendAsync(
            Encoding.UTF8.GetBytes(text),
            WebSocketMessageType.Text,
            endOfMessage: true,
            cancellationToken);
    }
}
