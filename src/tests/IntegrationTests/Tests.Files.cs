namespace Xai.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task UploadFile()
    {
        var client = GetAuthenticatedClient();

        var content = "Hello from xAI SDK integration test."u8.ToArray();

        var file = await client.Files.UploadFileAsync(
            file: content,
            filename: "test-upload.txt",
            purpose: "batch");

        file.Id.Should().NotBeNullOrEmpty();
        file.Filename.Should().Be("test-upload.txt");
        file.Bytes.Should().Be(content.Length);
    }
}
