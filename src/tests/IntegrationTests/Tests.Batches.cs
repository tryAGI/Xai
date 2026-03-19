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

    [TestMethod]
    [Ignore("Long-running: creates a batch with requests and polls for results")]
    public async Task CreateBatchWithRequestsAndGetResults()
    {
        var client = GetAuthenticatedClient();
        var modelId = GetModelId();

        // Create a batch
        var batch = await client.Batches.CreateBatchAsync(
            name: "integration-test-e2e");

        batch.BatchId.Should().NotBeNullOrEmpty();

        // Add requests to the batch
        var updated = await client.Batches.AddBatchRequestsAsync(
            batchId: batch.BatchId!,
            batchRequests:
            [
                new BatchRequestItem
                {
                    BatchRequestId = "req-1",
                    BatchRequest = new
                    {
                        chat_get_completion = new
                        {
                            model = modelId,
                            messages = new[]
                            {
                                new { role = "user", content = "What is 2+2? Answer with just the number." },
                            },
                        },
                    },
                },
                new BatchRequestItem
                {
                    BatchRequestId = "req-2",
                    BatchRequest = new
                    {
                        chat_get_completion = new
                        {
                            model = modelId,
                            messages = new[]
                            {
                                new { role = "user", content = "What is 3+3? Answer with just the number." },
                            },
                        },
                    },
                },
            ]);

        updated.BatchId.Should().Be(batch.BatchId);

        // Poll for results (up to 5 minutes)
        using var cts = new CancellationTokenSource(TimeSpan.FromMinutes(5));
        BatchResultsResponse? results = null;

        while (!cts.Token.IsCancellationRequested)
        {
            await Task.Delay(TimeSpan.FromSeconds(10), cts.Token);

            var status = await client.Batches.GetBatchAsync(batch.BatchId!, cts.Token);

            if (status.State is { NumPending: 0 })
            {
                results = await client.Batches.GetBatchResultsAsync(batch.BatchId!, cancellationToken: cts.Token);
                break;
            }
        }

        results.Should().NotBeNull();
        results!.Succeeded.Should().NotBeNullOrEmpty();
        results.Succeeded!.Count.Should().Be(2);
    }
}
