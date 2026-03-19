using System.Diagnostics.CodeAnalysis;

// Realtime DTO types use array properties for JSON serialization simplicity.
// IList<T>/List<T> trigger conflicting CA2227/CA1002 warnings on settable collection properties.
[assembly: SuppressMessage("Performance", "CA1819:PropertiesShouldNotReturnArrays", Scope = "namespaceanddescendants", Target = "~N:Xai")]
