#nullable enable

using System.Text.Json.Serialization;

namespace Xai;

/// <summary>
/// Tool definition for the Realtime session.
/// Supports function, file_search, web_search, and x_search types.
/// </summary>
public sealed class RealtimeTool
{
    /// <summary>
    /// Tool type: "function", "file_search", "web_search", or "x_search".
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// Function name (for function tools).
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Function description (for function tools).
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Function parameters JSON Schema (for function tools).
    /// </summary>
    [JsonPropertyName("parameters")]
    public object? Parameters { get; set; }

    /// <summary>
    /// Collection/vector store IDs (for file_search tools).
    /// </summary>
    [JsonPropertyName("vector_store_ids")]
    public string[]? VectorStoreIds { get; set; }

    /// <summary>
    /// Max number of search results (for file_search tools).
    /// </summary>
    [JsonPropertyName("max_num_results")]
    public int? MaxNumResults { get; set; }

    /// <summary>
    /// Allowed X handles (for x_search tools).
    /// </summary>
    [JsonPropertyName("allowed_x_handles")]
    public string[]? AllowedXHandles { get; set; }

    /// <summary>Creates a web_search tool.</summary>
    public static RealtimeTool WebSearch() => new() { Type = "web_search" };

    /// <summary>Creates an x_search tool.</summary>
    public static RealtimeTool XSearch(string[]? allowedHandles = null) => new()
    {
        Type = "x_search",
        AllowedXHandles = allowedHandles,
    };

    /// <summary>Creates a file_search tool.</summary>
    public static RealtimeTool FileSearch(string[] collectionIds, int? maxResults = null) => new()
    {
        Type = "file_search",
        VectorStoreIds = collectionIds,
        MaxNumResults = maxResults,
    };

    /// <summary>Creates a function tool.</summary>
    public static RealtimeTool Function(string name, string description, object? parameters = null) => new()
    {
        Type = "function",
        Name = name,
        Description = description,
        Parameters = parameters,
    };
}
