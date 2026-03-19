/*
order: 190
title: File Upload
slug: file-upload

Upload a file for use with the Batch API.
*/

namespace Xai.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_FileUpload()
    {
        var client = GetAuthenticatedClient();

        //// Upload a file by providing its content, filename, and purpose.
        var content = "Hello from xAI SDK integration test."u8.ToArray();

        var file = await client.Files.UploadFileAsync(
            file: content,
            filename: "test-upload.txt",
            purpose: "batch");

        file.Id.Should().NotBeNullOrEmpty();
        file.Filename.Should().Be("test-upload.txt");
        file.Bytes.Should().Be(content.Length);

        Console.WriteLine($"Uploaded: {file.Id} ({file.Bytes} bytes)");
    }
}
