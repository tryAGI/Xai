namespace Xai.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task CreateAndListBatches()
    {
        var client = GetAuthenticatedClient();

        // Create a batch
        var batch = await client.Batches.CreateBatchAsync(
            name: "integration-test-batch");

        batch.BatchId.Should().NotBeNullOrEmpty();
        batch.Name.Should().Be("integration-test-batch");

        // Get batch status
        var status = await client.Batches.GetBatchAsync(batch.BatchId!);
        status.BatchId.Should().Be(batch.BatchId);

        // List batches
        var list = await client.Batches.ListBatchesAsync();
        list.Batches.Should().NotBeNullOrEmpty();

        // Cancel the batch
        var cancelled = await client.Batches.CancelBatchAsync(batch.BatchId!);
        cancelled.BatchId.Should().Be(batch.BatchId);
    }
}
