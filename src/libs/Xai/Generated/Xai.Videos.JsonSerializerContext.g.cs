
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Xai
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.CreateVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.CreateVideoRequestAspectRatio), TypeInfoPropertyName = "CreateVideoRequestAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.CreateVideoRequestResolution), TypeInfoPropertyName = "CreateVideoRequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.CreateVideoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.VideoStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.VideoStatusResponseStatus), TypeInfoPropertyName = "VideoStatusResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.VideoData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.CreateVideoRequestAspectRatio?), TypeInfoPropertyName = "NullableCreateVideoRequestAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.CreateVideoRequestResolution?), TypeInfoPropertyName = "NullableCreateVideoRequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.VideoStatusResponseStatus?), TypeInfoPropertyName = "NullableVideoStatusResponseStatus2")]
    internal sealed partial class VideosSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VideosSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static VideosSourceGenerationContext Default { get; } = new(DefaultOptions);

        private VideosSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Xai.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Xai.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Xai.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Xai.CreateVideoRequestAspectRatio)

                    || typeToConvert == typeof(global::Xai.CreateVideoRequestAspectRatio?)

                    || typeToConvert == typeof(global::Xai.CreateVideoRequestResolution)

                    || typeToConvert == typeof(global::Xai.CreateVideoRequestResolution?)

                    || typeToConvert == typeof(global::Xai.VideoStatusResponseStatus)

                    || typeToConvert == typeof(global::Xai.VideoStatusResponseStatus?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Xai.CreateVideoRequestAspectRatio))
                {
                    return new global::Xai.JsonConverters.CreateVideoRequestAspectRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::Xai.CreateVideoRequestAspectRatio?))
                {
                    return new global::Xai.JsonConverters.CreateVideoRequestAspectRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Xai.CreateVideoRequestResolution))
                {
                    return new global::Xai.JsonConverters.CreateVideoRequestResolutionJsonConverter();
                }

                if (typeToConvert == typeof(global::Xai.CreateVideoRequestResolution?))
                {
                    return new global::Xai.JsonConverters.CreateVideoRequestResolutionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Xai.VideoStatusResponseStatus))
                {
                    return new global::Xai.JsonConverters.VideoStatusResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Xai.VideoStatusResponseStatus?))
                {
                    return new global::Xai.JsonConverters.VideoStatusResponseStatusNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new VideosSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}