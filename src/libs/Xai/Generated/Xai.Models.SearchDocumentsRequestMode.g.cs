
#nullable enable

namespace Xai
{
    /// <summary>
    /// Search mode.<br/>
    /// Default Value: hybrid
    /// </summary>
    public enum SearchDocumentsRequestMode
    {
        /// <summary>
        /// 
        /// </summary>
        Hybrid,
        /// <summary>
        /// 
        /// </summary>
        Keyword,
        /// <summary>
        /// 
        /// </summary>
        Semantic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchDocumentsRequestModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchDocumentsRequestMode value)
        {
            return value switch
            {
                SearchDocumentsRequestMode.Hybrid => "hybrid",
                SearchDocumentsRequestMode.Keyword => "keyword",
                SearchDocumentsRequestMode.Semantic => "semantic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchDocumentsRequestMode? ToEnum(string value)
        {
            return value switch
            {
                "hybrid" => SearchDocumentsRequestMode.Hybrid,
                "keyword" => SearchDocumentsRequestMode.Keyword,
                "semantic" => SearchDocumentsRequestMode.Semantic,
                _ => null,
            };
        }
    }
}