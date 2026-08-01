// --8<-- [start:json-using]
using System.Text.Json;
// --8<-- [end:json-using]
using Xai.Realtime;

namespace Xai.IntegrationTests;

internal static class RealtimeVoiceGuideSnippets
{
    private static async Task QuickStartAsync(string apiKey, CancellationToken cancellationToken)
    {
        // --8<-- [start:quick-start]
        await using var client = new XaiRealtimeClient(apiKey);
        await client.ConnectAsync(
            model: VoiceModel.GrokVoiceThinkFast20,
            reasoningEffort: VoiceReasoningEffort.High,
            cancellationToken: cancellationToken);

        await client.SendSessionUpdateAsync(new SessionUpdatePayload
        {
            Session = new SessionConfig
            {
                Voice = "eve",
                Instructions = "Be helpful and concise.",
                Modalities = ["text", "audio"],
                TurnDetection = new TurnDetection
                {
                    Type = "server_vad",
                    Threshold = 0.85,
                    SilenceDurationMs = 500,
                    PrefixPaddingMs = 333,
                },
            },
        }, cancellationToken);

        await client.SendConversationItemCreateAsync(new ConversationItemCreatePayload
        {
            Item = new ConversationItem
            {
                Type = "message",
                Role = "user",
                Content =
                [
                    new ContentPart
                    {
                        Type = "input_text",
                        Text = "Introduce yourself in one sentence.",
                    },
                ],
            },
        }, cancellationToken);

        await client.SendResponseCreateAsync(new ResponseCreatePayload
        {
            Response = new ResponseConfig { Modalities = ["text", "audio"] },
        }, cancellationToken);

        await foreach (var serverEvent in client.ReceiveUpdatesAsync(cancellationToken))
        {
            if (serverEvent.IsResponseOutputAudioTranscriptDelta)
            {
                Console.Write(serverEvent.ResponseOutputAudioTranscriptDelta?.Delta);
            }
            else if (serverEvent.IsResponseDone)
            {
                break;
            }
            else if (serverEvent.IsError)
            {
                throw new InvalidOperationException(serverEvent.Error?.Error?.Message);
            }
        }
        // --8<-- [end:quick-start]
    }

    private static async Task ApiKeyAuthenticationAsync(string apiKey)
    {
        // --8<-- [start:api-key-authentication]
        await using var client = new XaiRealtimeClient(apiKey);
        // --8<-- [end:api-key-authentication]

        await Task.CompletedTask;
    }

    private static async Task ClientSecretAuthenticationAsync(
        string clientSecret,
        CancellationToken cancellationToken)
    {
        // --8<-- [start:client-secret-authentication]
        await using var client = new XaiRealtimeClient();
        await client.ConnectAsync(
            model: VoiceModel.GrokVoiceLatest,
            additionalSubProtocols: [$"xai-client-secret.{clientSecret}"],
            cancellationToken: cancellationToken);
        // --8<-- [end:client-secret-authentication]
    }

    private static async Task ModelSelectionAsync(
        XaiRealtimeClient client,
        CancellationToken cancellationToken)
    {
        // --8<-- [start:model-selection]
        await client.ConnectAsync(
            model: VoiceModel.GrokVoiceThinkFast20,
            reasoningEffort: VoiceReasoningEffort.High,
            cancellationToken: cancellationToken);
        // --8<-- [end:model-selection]
    }

    private static SessionConfig ServerVad()
    {
        return new SessionConfig
        {
            // --8<-- [start:server-vad]
            TurnDetection = new TurnDetection
            {
                Type = "server_vad",
                Threshold = 0.85,
                SilenceDurationMs = 500,
                PrefixPaddingMs = 333,
                IdleTimeoutMs = 10_000,
            },
            // --8<-- [end:server-vad]
        };
    }

    private static async Task SendAudioAsync(
        XaiRealtimeClient client,
        CancellationToken cancellationToken)
    {
        // --8<-- [start:send-audio]
        ReadOnlyMemory<byte> audioChunk = await GetMicrophoneChunkAsync(cancellationToken);
        await client.SendInputAudioBufferAppendAsync(
            audio: audioChunk,
            cancellationToken: cancellationToken);
        // --8<-- [end:send-audio]
    }

    private static async Task CommitManualTurnAsync(
        XaiRealtimeClient client,
        CancellationToken cancellationToken)
    {
        // --8<-- [start:commit-manual-turn]
        await client.SendInputAudioBufferCommitAsync(
            new InputAudioBufferCommitPayload(),
            cancellationToken);

        await client.SendResponseCreateAsync(new ResponseCreatePayload
        {
            Response = new ResponseConfig { Modalities = ["text", "audio"] },
        }, cancellationToken);
        // --8<-- [end:commit-manual-turn]
    }

    private static async Task ReceiveAudioAsync(
        XaiRealtimeClient client,
        Stream playbackStream,
        CancellationToken cancellationToken)
    {
        // --8<-- [start:receive-audio]
        await foreach (var serverEvent in client.ReceiveUpdatesAsync(cancellationToken))
        {
            if (serverEvent.IsResponseOutputAudioDelta &&
                serverEvent.ResponseOutputAudioDelta?.Delta is { Length: > 0 } delta)
            {
                byte[] audioBytes = Convert.FromBase64String(delta);
                await playbackStream.WriteAsync(audioBytes, cancellationToken);
            }
            else if (serverEvent.IsResponseOutputAudioTranscriptDelta)
            {
                Console.Write(serverEvent.ResponseOutputAudioTranscriptDelta?.Delta);
            }
            else if (serverEvent.IsResponseOutputAudioDone)
            {
                await playbackStream.FlushAsync(cancellationToken);
            }
            else if (serverEvent.IsError)
            {
                var error = serverEvent.Error?.Error;
                throw new InvalidOperationException($"{error?.Code}: {error?.Message}");
            }
        }
        // --8<-- [end:receive-audio]
    }

    private static async Task ConfigureFunctionToolAsync(
        XaiRealtimeClient client,
        CancellationToken cancellationToken)
    {
        // --8<-- [start:configure-function-tool]
        using JsonDocument weatherSchema = JsonDocument.Parse(
            """
            {
              "type": "object",
              "properties": {
                "location": {
                  "type": "string",
                  "description": "City and country"
                }
              },
              "required": ["location"]
            }
            """);
        JsonElement weatherParameters = weatherSchema.RootElement.Clone();

        await client.SendSessionUpdateAsync(new SessionUpdatePayload
        {
            Session = new SessionConfig
            {
                Voice = "eve",
                Modalities = ["text", "audio"],
                Tools =
                [
                    new Tool
                    {
                        Type = "function",
                        Name = "get_weather",
                        Description = "Get the current weather for a location.",
                        Parameters = weatherParameters,
                    },
                ],
            },
        }, cancellationToken);
        // --8<-- [end:configure-function-tool]
    }

    private static async Task HandleFunctionToolAsync(
        XaiRealtimeClient client,
        ServerEvent serverEvent,
        CancellationToken cancellationToken)
    {
        // --8<-- [start:handle-function-tool]
        if (serverEvent.IsResponseFunctionCallArgumentsDone)
        {
            var functionCall = serverEvent.ResponseFunctionCallArgumentsDone!;
            string outputJson = await ExecuteToolAsync(
                functionCall.Name!,
                functionCall.Arguments!,
                cancellationToken);

            await client.SendConversationItemCreateAsync(new ConversationItemCreatePayload
            {
                Item = new ConversationItem
                {
                    Type = "function_call_output",
                    CallId = functionCall.CallId,
                    Output = outputJson,
                },
            }, cancellationToken);

            // Wait for audio already buffered by the player to finish before requesting
            // the follow-up response, otherwise the two spoken turns can overlap.
            await WaitForPlaybackCompletionAsync(cancellationToken);
            await client.SendResponseCreateAsync(new ResponseCreatePayload(), cancellationToken);
        }
        // --8<-- [end:handle-function-tool]
    }

    private static IList<Tool> BuiltInSearchTools()
    {
        // --8<-- [start:built-in-search-tools]
        IList<Tool> tools =
        [
            new Tool { Type = "web_search" },
            new Tool
            {
                Type = "x_search",
                AllowedXHandles = ["grok", "xai"],
            },
            new Tool
            {
                Type = "file_search",
                VectorStoreIds = ["collection_abc123"],
                MaxNumResults = 5,
            },
        ];
        // --8<-- [end:built-in-search-tools]

        return tools;
    }

    private static void ConfigureReconnects(XaiRealtimeClient client)
    {
        // --8<-- [start:configure-reconnects]
        client.ReconnectOptions.Enabled = true;
        client.ReconnectOptions.MaxAttempts = 5;
        client.ReconnectOptions.InitialDelay = TimeSpan.FromSeconds(1);
        client.ReconnectOptions.MaxDelay = TimeSpan.FromSeconds(20);
        client.ReconnectOptions.BackoffMultiplier = 2;
        // --8<-- [end:configure-reconnects]
    }

    private static async Task ClientLifetimeAsync(string apiKey)
    {
        // --8<-- [start:client-lifetime]
        await using var client = new XaiRealtimeClient(apiKey);
        // --8<-- [end:client-lifetime]

        await Task.CompletedTask;
    }

    private static Task<ReadOnlyMemory<byte>> GetMicrophoneChunkAsync(CancellationToken cancellationToken)
    {
        return Task.FromResult(ReadOnlyMemory<byte>.Empty);
    }

    private static Task<string> ExecuteToolAsync(
        string name,
        string arguments,
        CancellationToken cancellationToken)
    {
        return Task.FromResult("{}");
    }

    private static Task WaitForPlaybackCompletionAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
}
