using System.Reflection;
using System.Text.Json;
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
        AudioTransport.Json.ToValueString().Should().Be("json");
        AudioTransport.Binary.ToValueString().Should().Be("binary");
    }

    [TestMethod]
    public void StreamingClients_UseCanonicalBearerAuthenticationScheme()
    {
        using var realtimeClient = new XaiRealtimeClient("test-api-key");
        using var textToSpeechClient = new TextToSpeech.XaiTextToSpeechStreamingClient("test-api-key");

        GetStoredAuthorizationScheme(realtimeClient).Should().Be("Bearer");
        GetStoredAuthorizationScheme(textToSpeechClient).Should().Be("Bearer");
    }

    [TestMethod]
    public void RealtimeSessionConfiguration_HasTypedWireShape()
    {
        // --8<-- [start:typed-session-configuration]
        var sessionUpdate = new SessionUpdatePayload
        {
            Session = new SessionConfig
            {
                Voice = "eve",
                Modalities = ["text", "audio"],
                TurnDetection = new TurnDetection
                {
                    Type = "server_vad",
                    Threshold = 0.85,
                    SilenceDurationMs = 500,
                    PrefixPaddingMs = 333,
                    IdleTimeoutMs = 10_000,
                },
                Audio = new AudioConfig
                {
                    Input = new AudioDirectionConfig
                    {
                        Format = new AudioFormatConfig
                        {
                            Type = "audio/pcm",
                            Rate = 24_000,
                        },
                        Transport = AudioTransport.Json,
                        Transcription = new AudioTranscriptionConfig
                        {
                            Model = "grok-transcribe",
                            LanguageHint = "en-US",
                            Keyterms = ["xAI", "Grok"],
                        },
                    },
                    Output = new AudioDirectionConfig
                    {
                        Format = new AudioFormatConfig
                        {
                            Type = "audio/pcm",
                            Rate = 24_000,
                        },
                        Transport = AudioTransport.Json,
                        Speed = 1.1,
                    },
                },
                Resumption = new ResumptionConfig { Enabled = true },
                Replace = new Dictionary<string, string>
                {
                    ["SQL"] = "sequel",
                    ["tryAGI"] = "try A G I",
                },
            },
        };
        // --8<-- [end:typed-session-configuration]

        using var json = JsonDocument.Parse(sessionUpdate.ToJson());
        var session = json.RootElement.GetProperty("session");

        session.GetProperty("turn_detection").GetProperty("idle_timeout_ms").GetInt32().Should().Be(10_000);
        session.GetProperty("audio").GetProperty("input").GetProperty("transport").GetString().Should().Be("json");
        session.GetProperty("audio").GetProperty("input").GetProperty("transcription").GetProperty("language_hint").GetString().Should().Be("en-US");
        session.GetProperty("audio").GetProperty("output").GetProperty("speed").GetDouble().Should().Be(1.1);
        session.GetProperty("resumption").GetProperty("enabled").GetBoolean().Should().BeTrue();
        session.GetProperty("replace").GetProperty("SQL").GetString().Should().Be("sequel");
    }

    [TestMethod]
    public void ManualTurnDetection_SerializesExplicitNullAndCanSwitchBackToServerVad()
    {
        // --8<-- [start:manual-turn-detection]
        var sessionUpdate = new SessionUpdatePayload
        {
            Session = new SessionConfig
            {
                Voice = "eve",
                Modalities = ["text", "audio"],
            }.UseManualTurnDetection(),
        };
        // --8<-- [end:manual-turn-detection]

        using (var manualJson = JsonDocument.Parse(sessionUpdate.ToJson()))
        {
            manualJson.RootElement
                .GetProperty("session")
                .GetProperty("turn_detection")
                .ValueKind
                .Should()
                .Be(JsonValueKind.Null);
        }

        sessionUpdate.Session!.UseServerTurnDetection(new TurnDetection
        {
            Type = "server_vad",
        });

        using var serverVadJson = JsonDocument.Parse(sessionUpdate.ToJson());
        serverVadJson.RootElement
            .GetProperty("session")
            .GetProperty("turn_detection")
            .GetProperty("type")
            .GetString()
            .Should()
            .Be("server_vad");
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

    private static string? GetStoredAuthorizationScheme(object client)
    {
        return client
            .GetType()
            .GetField("_storedAuthorizationHeaderScheme", BindingFlags.Instance | BindingFlags.NonPublic)?
            .GetValue(client) as string;
    }
}
