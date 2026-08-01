/*
order: 130
title: Realtime Voice
slug: realtime-voice

Connect to the Realtime Voice Agent WebSocket API for bidirectional text/audio streaming.
*/

using Xai.Realtime;

namespace Xai.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    [TestCategory("Explicit")]
    public async Task Example_RealtimeVoice()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("XAI_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("XAI_API_KEY environment variable is not found.");

        //// Create a WebSocket client and pin Grok Voice Think Fast 2.0 with reasoning enabled.
        using var client = new XaiRealtimeClient(apiKey);
        await client.ConnectAsync(
            model: VoiceModel.GrokVoiceThinkFast20,
            reasoningEffort: VoiceReasoningEffort.High);

        client.IsConnected.Should().BeTrue();

        //// Configure the session with typed audio, transcription, resumption, and pronunciation options.
        await client.SendSessionUpdateAsync(new SessionUpdatePayload
        {
            Session = new SessionConfig
            {
                Voice = "eve",
                Instructions = "You are a helpful assistant. Respond briefly.",
                Modalities = ["text", "audio"],
                TurnDetection = new TurnDetection
                {
                    Type = "server_vad",
                    Threshold = 0.85,
                    SilenceDurationMs = 500,
                    IdleTimeoutMs = 10_000,
                },
                Audio = new AudioConfig
                {
                    Input = new AudioDirectionConfig
                    {
                        Format = new AudioFormatConfig { Type = "audio/pcm", Rate = 24_000 },
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
                        Format = new AudioFormatConfig { Type = "audio/pcm", Rate = 24_000 },
                        Transport = AudioTransport.Json,
                        Speed = 1.0,
                    },
                },
                Resumption = new ResumptionConfig { Enabled = true },
                Replace = new Dictionary<string, string> { ["SQL"] = "sequel" },
            },
        });

        //// Send a text message and request a text response.
        await client.SendConversationItemCreateAsync(new ConversationItemCreatePayload
        {
            Item = new ConversationItem
            {
                Type = "message",
                Role = "user",
                Content = [new ContentPart { Type = "input_text", Text = "Say hello!" }],
            },
        });
        await client.SendResponseCreateAsync(new ResponseCreatePayload
        {
            Response = new ResponseConfig
            {
                Modalities = ["text"],
            },
        });

        //// Receive server events until the response is complete.
        using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(30));
        string? selectedModel = null;
        var receivedSessionUpdated = false;
        var receivedResponseDone = false;
        string? transcriptText = null;

        await foreach (var serverEvent in client.ReceiveUpdatesAsync(cts.Token))
        {
            if (serverEvent.IsSessionCreated)
            {
                selectedModel = serverEvent.SessionCreated?.Session?.Model;
            }
            else if (serverEvent.IsSessionUpdated)
            {
                receivedSessionUpdated = true;
            }
            else if (serverEvent.IsResponseOutputAudioTranscriptDelta)
            {
                transcriptText = (transcriptText ?? "") + serverEvent.ResponseOutputAudioTranscriptDelta?.Delta;
                Console.Write(serverEvent.ResponseOutputAudioTranscriptDelta?.Delta);
            }
            else if (serverEvent.IsResponseDone)
            {
                receivedResponseDone = true;
                break;
            }
            else if (serverEvent.IsError)
            {
                throw new InvalidOperationException($"Received error: {serverEvent.Error?.Error?.Message}");
            }
        }

        selectedModel.Should().Be("grok-voice-think-fast-2.0");
        receivedSessionUpdated.Should().BeTrue();
        receivedResponseDone.Should().BeTrue();
    }
}
