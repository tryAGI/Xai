namespace Xai.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    [TestCategory("Smoke")]
    public async Task GetApiKeyInfo()
    {
        var client = GetAuthenticatedClient();

        var info = await client.Auth.GetApiKeyInfoAsync();

        info.RedactedApiKey.Should().NotBeNullOrEmpty();
        info.UserId.Should().NotBeNullOrEmpty();
    }
}
