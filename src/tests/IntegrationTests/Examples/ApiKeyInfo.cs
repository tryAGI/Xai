/*
order: 200
title: API Key Info
slug: api-key-info

Retrieve information about the current API key.
*/

namespace Xai.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    [TestCategory("Smoke")]
    public async Task Example_ApiKeyInfo()
    {
        var client = GetAuthenticatedClient();

        //// Check the current API key's metadata — useful for diagnostics and validation.
        var info = await client.Auth.GetApiKeyInfoAsync();

        info.RedactedApiKey.Should().NotBeNullOrEmpty();
        info.UserId.Should().NotBeNullOrEmpty();

        Console.WriteLine($"Key: {info.RedactedApiKey}");
        Console.WriteLine($"User: {info.UserId}");
    }
}
