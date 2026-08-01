using Xai.Realtime;

namespace Xai.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    [TestCategory("Explicit")]
    public async Task RealtimeVoice_BinaryOutputAndConversationResumption()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("XAI_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("XAI_API_KEY environment variable is not found.");

        string? conversationId = null;
        var firstResponseBinaryBytes = 0;

        await using (var client = new XaiRealtimeClient(apiKey))
        {
            await client.ConnectAsync(
                model: VoiceModel.GrokVoiceThinkFast20,
                reasoningEffort: VoiceReasoningEffort.High);
            await client.SendSessionUpdateAsync(new SessionUpdatePayload
            {
                Session = CreateBinaryResumableSession(),
            });
            using (var readyCancellationTokenSource = new CancellationTokenSource(TimeSpan.FromSeconds(30)))
            {
                conversationId = await WaitForSessionReadyAsync(
                    client,
                    readyCancellationTokenSource.Token);
            }

            await SendTextTurnAsync(client, "Confirm this resumable session in one word.");

            using var cancellationTokenSource = new CancellationTokenSource(TimeSpan.FromSeconds(30));
            await foreach (var message in client.ReceiveMessagesAsync(cancellationTokenSource.Token))
            {
                if (message.IsBinaryAudio)
                {
                    firstResponseBinaryBytes += message.BinaryAudio.Length;
                }
                else if (message.Event is { } serverEvent)
                {
                    if (serverEvent.IsError)
                    {
                        throw new InvalidOperationException(serverEvent.Error?.Error?.Message);
                    }
                    else if (serverEvent.IsResponseDone)
                    {
                        break;
                    }
                }
            }
        }

        conversationId.Should().NotBeNullOrWhiteSpace();
        firstResponseBinaryBytes.Should().BeGreaterThan(0);

        var resumedResponseBinaryBytes = 0;

        await using (var resumedClient = new XaiRealtimeClient(apiKey))
        {
            await resumedClient.ResumeConversationAsync(
                conversationId: conversationId!,
                session: CreateBinaryResumableSession(),
                model: VoiceModel.GrokVoiceThinkFast20,
                reasoningEffort: VoiceReasoningEffort.High);
            using (var readyCancellationTokenSource = new CancellationTokenSource(TimeSpan.FromSeconds(30)))
            {
                var resumedConversationId = await WaitForSessionReadyAsync(
                    resumedClient,
                    readyCancellationTokenSource.Token);
                resumedConversationId.Should().Be(conversationId);
            }

            await SendTextTurnAsync(
                resumedClient,
                "Confirm this resumed connection in one word.");

            using var cancellationTokenSource = new CancellationTokenSource(TimeSpan.FromSeconds(30));
            await foreach (var message in resumedClient.ReceiveMessagesAsync(cancellationTokenSource.Token))
            {
                if (message.IsBinaryAudio)
                {
                    resumedResponseBinaryBytes += message.BinaryAudio.Length;
                }
                else if (message.Event is { } serverEvent)
                {
                    if (serverEvent.IsError)
                    {
                        throw new InvalidOperationException(serverEvent.Error?.Error?.Message);
                    }
                    else if (serverEvent.IsResponseDone)
                    {
                        break;
                    }
                }
            }
        }

        resumedResponseBinaryBytes.Should().BeGreaterThan(0);
    }

    private static SessionConfig CreateBinaryResumableSession()
    {
        return new SessionConfig
        {
            Voice = "eve",
            Modalities = ["text", "audio"],
            Audio = new AudioConfig
            {
                Output = new AudioDirectionConfig
                {
                    Format = new AudioFormatConfig { Type = "audio/pcm", Rate = 24_000 },
                    Transport = AudioTransport.Binary,
                },
            },
            Resumption = new ResumptionConfig { Enabled = true },
        };
    }

    private static async Task SendTextTurnAsync(XaiRealtimeClient client, string text)
    {
        await client.SendConversationItemCreateAsync(new ConversationItemCreatePayload
        {
            Item = new ConversationItem
            {
                Type = "message",
                Role = "user",
                Content = [new ContentPart { Type = "input_text", Text = text }],
            },
        });
        await client.SendResponseCreateAsync(new ResponseCreatePayload
        {
            Response = new ResponseConfig { Modalities = ["text", "audio"] },
        });
    }

    private static async Task<string> WaitForSessionReadyAsync(
        XaiRealtimeClient client,
        CancellationToken cancellationToken)
    {
        string? conversationId = null;

        await foreach (var message in client.ReceiveMessagesAsync(cancellationToken))
        {
            if (message.Event is not { } serverEvent)
            {
                continue;
            }

            if (serverEvent.ConversationCreated?.Conversation?.Id is { Length: > 0 } id)
            {
                conversationId = id;
            }
            else if (serverEvent.IsError)
            {
                throw new InvalidOperationException(serverEvent.Error?.Error?.Message);
            }
            else if (serverEvent.IsSessionUpdated)
            {
                break;
            }
        }

        return conversationId ?? throw new InvalidOperationException(
            "The server did not provide a conversation ID before session.updated.");
    }
}
