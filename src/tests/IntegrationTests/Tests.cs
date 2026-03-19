namespace Xai.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static XaiClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("XAI_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("XAI_API_KEY environment variable is not found.");

        var client = new XaiClient(apiKey);

        return client;
    }

    private static string GetModelId()
    {
        return Environment.GetEnvironmentVariable("XAI_CHAT_MODEL") is { Length: > 0 } modelValue
            ? modelValue
            : "grok-3-mini";
    }
}
