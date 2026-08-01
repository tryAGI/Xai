using System.Reflection;
using Xai.Realtime;

namespace Xai.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void VoiceModels_HaveExpectedWireValues()
    {
        VoiceModel.GrokVoiceLatest.ToValueString().Should().Be("grok-voice-latest");
        VoiceModel.GrokVoiceThinkFast20.ToValueString().Should().Be("grok-voice-think-fast-2.0");
        VoiceModel.GrokVoiceThinkFast10.ToValueString().Should().Be("grok-voice-think-fast-1.0");
        VoiceReasoningEffort.High.ToValueString().Should().Be("high");
        VoiceReasoningEffort.None.ToValueString().Should().Be("none");
    }

    [TestMethod]
    public async Task VoiceModelOptions_AreAddedToHandshakeUri()
    {
        using var client = new XaiRealtimeClient();
        using var cancellationTokenSource = new CancellationTokenSource();
        cancellationTokenSource.Cancel();

        Func<Task> connect = () => client.ConnectAsync(
            model: VoiceModel.GrokVoiceThinkFast20,
            reasoningEffort: VoiceReasoningEffort.High,
            cancellationToken: cancellationTokenSource.Token);

        await connect.Should().ThrowAsync<OperationCanceledException>();

        var connectUriField = typeof(XaiRealtimeClient)
            .GetField("_lastConnectUri", BindingFlags.Instance | BindingFlags.NonPublic);
        connectUriField.Should().NotBeNull();

        var connectUri = connectUriField!
            .GetValue(client)
            .Should()
            .BeOfType<Uri>()
            .Subject;

        connectUri.Should().Be(
            new Uri("wss://api.x.ai/v1/realtime?model=grok-voice-think-fast-2.0&reasoning.effort=high"));
    }
}
