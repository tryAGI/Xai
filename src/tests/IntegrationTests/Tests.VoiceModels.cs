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

        sessionUpdate.Session!.GetValidationErrors().Should().BeEmpty();

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
    public void RealtimeSessionConfiguration_RejectsDocumentedLimitViolationsBeforeSerialization()
    {
        var keyterms = Enumerable.Repeat("valid", 101).ToList();
        keyterms[0] = new string('x', 51);
        var session = new SessionConfig
        {
            TurnDetection = new TurnDetection
            {
                Threshold = double.NaN,
                SilenceDurationMs = 10_001,
                PrefixPaddingMs = -1,
                IdleTimeoutMs = -1,
            },
            Audio = new AudioConfig
            {
                Input = new AudioDirectionConfig
                {
                    Speed = 1.0,
                    Transcription = new AudioTranscriptionConfig { Keyterms = keyterms },
                },
                Output = new AudioDirectionConfig
                {
                    Speed = 1.51,
                    Transcription = new AudioTranscriptionConfig(),
                },
            },
        };

        var errors = session.GetValidationErrors();
        errors.Should().HaveCount(9);
        errors.Should().Contain(error => error.StartsWith("turn_detection.threshold"));
        errors.Should().Contain(error => error.StartsWith("turn_detection.silence_duration_ms"));
        errors.Should().Contain(error => error.StartsWith("turn_detection.prefix_padding_ms"));
        errors.Should().Contain(error => error.StartsWith("turn_detection.idle_timeout_ms"));
        errors.Should().Contain(error => error.StartsWith("audio.input.speed"));
        errors.Should().Contain(error => error.Contains("more than 100 terms"));
        errors.Should().Contain(error => error.Contains("cannot exceed 50 characters"));
        errors.Should().Contain(error => error.StartsWith("audio.output.transcription"));
        errors.Should().Contain(error => error.StartsWith("audio.output.speed"));

        Action serialize = () => new SessionUpdatePayload { Session = session }.ToJson();
        serialize.Should()
            .Throw<ArgumentException>()
            .WithParameterName("session");
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

    [TestMethod]
    public async Task ResumeConversation_ConfiguresOptInAndEncodedHandshakeUri()
    {
        using var client = new XaiRealtimeClient();
        var session = new SessionConfig { Voice = "eve" };
        using var cancellationTokenSource = new CancellationTokenSource();
        cancellationTokenSource.Cancel();

        Func<Task> resume = () => client.ResumeConversationAsync(
            conversationId: "conversation 123/alpha",
            session: session,
            model: VoiceModel.GrokVoiceThinkFast20,
            reasoningEffort: VoiceReasoningEffort.High,
            cancellationToken: cancellationTokenSource.Token);

        await resume.Should().ThrowAsync<OperationCanceledException>();

        session.Resumption.Should().NotBeNull();
        session.Resumption!.Enabled.Should().BeTrue();
        GetLastConnectUri(client).AbsoluteUri.Should().Be(
            "wss://api.x.ai/v1/realtime?conversation_id=conversation%20123%2Falpha&model=grok-voice-think-fast-2.0&reasoning.effort=high");
    }

    [TestMethod]
    public async Task ResumeConversation_ValidatesBeforeConnecting()
    {
        using var client = new XaiRealtimeClient();

        Func<Task> resume = () => client.ResumeConversationAsync(
            conversationId: "conversation_123",
            session: new SessionConfig
            {
                Audio = new AudioConfig
                {
                    Output = new AudioDirectionConfig { Speed = 2.0 },
                },
            });

        await resume.Should()
            .ThrowAsync<ArgumentException>()
            .WithParameterName("session");

        GetLastConnectUri(client, required: false).Should().BeNull();
    }

    private static string? GetStoredAuthorizationScheme(object client)
    {
        return client
            .GetType()
            .GetField("_storedAuthorizationHeaderScheme", BindingFlags.Instance | BindingFlags.NonPublic)?
            .GetValue(client) as string;
    }

    private static Uri GetLastConnectUri(XaiRealtimeClient client)
    {
        return GetLastConnectUri(client, required: true)!;
    }

    private static Uri? GetLastConnectUri(XaiRealtimeClient client, bool required)
    {
        var uri = typeof(XaiRealtimeClient)
            .GetField("_lastConnectUri", BindingFlags.Instance | BindingFlags.NonPublic)?
            .GetValue(client) as Uri;

        if (required)
        {
            uri.Should().NotBeNull();
        }

        return uri;
    }
}
