/*
order: 140
title: Batch API
slug: batch-api

Create, manage, and retrieve results from batch requests.
*/

namespace Xai.IntegrationTests;

public partial class Tests
{
    //// Create a batch, check its status, list all batches, and cancel it.
    [TestMethod]
    public async Task Example_Batches_Lifecycle()
    {
        var client = GetAuthenticatedClient();

        //// Create a new batch with a descriptive name.
        var batch = await client.Batches.CreateBatchAsync(
            name: "integration-test-batch");

        batch.BatchId.Should().NotBeNullOrEmpty();
        batch.Name.Should().Be("integration-test-batch");

        //// Get the batch status by ID.
        var status = await client.Batches.GetBatchAsync(batch.BatchId!);
        status.BatchId.Should().Be(batch.BatchId);

        //// List all batches on the account.
        var list = await client.Batches.ListBatchesAsync();
        list.Batches.Should().NotBeNullOrEmpty();

        //// Cancel a batch that is no longer needed.
        var cancelled = await client.Batches.CancelBatchAsync(batch.BatchId!);
        cancelled.BatchId.Should().Be(batch.BatchId);

        Console.WriteLine($"Created and cancelled batch: {batch.BatchId}");
    }

    //// Submit multiple chat completion requests in a batch and poll for results.
    [TestMethod]
    [Ignore("Long-running: creates a batch with requests and polls for results")]
    public async Task Example_Batches_EndToEnd()
    {
        var client = GetAuthenticatedClient();
        var modelId = GetModelId();

        var batch = await client.Batches.CreateBatchAsync(
            name: "integration-test-e2e");

        batch.BatchId.Should().NotBeNullOrEmpty();

        //// Add requests to the batch. Each request needs a unique `BatchRequestId` for correlation.
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

        //// Poll until all requests are processed, then retrieve results.
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

        Console.WriteLine($"Batch {batch.BatchId}: {results.Succeeded.Count} succeeded");
    }
}
