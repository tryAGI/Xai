
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.CreateCustomVoiceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.CreateCustomVoiceRequestGender), TypeInfoPropertyName = "CreateCustomVoiceRequestGender2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.CreateCustomVoiceRequestAge), TypeInfoPropertyName = "CreateCustomVoiceRequestAge2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.CreateCustomVoiceRequestUseCase), TypeInfoPropertyName = "CreateCustomVoiceRequestUseCase2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.CreateCustomVoiceRequestTone), TypeInfoPropertyName = "CreateCustomVoiceRequestTone2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.UpdateCustomVoiceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.UpdateCustomVoiceRequestGender), TypeInfoPropertyName = "UpdateCustomVoiceRequestGender2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.UpdateCustomVoiceRequestAge), TypeInfoPropertyName = "UpdateCustomVoiceRequestAge2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.UpdateCustomVoiceRequestUseCase), TypeInfoPropertyName = "UpdateCustomVoiceRequestUseCase2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.UpdateCustomVoiceRequestTone), TypeInfoPropertyName = "UpdateCustomVoiceRequestTone2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.CustomVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.CustomVoiceGender), TypeInfoPropertyName = "CustomVoiceGender2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.CustomVoiceAge), TypeInfoPropertyName = "CustomVoiceAge2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.ListCustomVoicesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Xai.CustomVoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.DeleteCustomVoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.CreateCustomVoiceRequestGender?), TypeInfoPropertyName = "NullableCreateCustomVoiceRequestGender2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.CreateCustomVoiceRequestAge?), TypeInfoPropertyName = "NullableCreateCustomVoiceRequestAge2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.CreateCustomVoiceRequestUseCase?), TypeInfoPropertyName = "NullableCreateCustomVoiceRequestUseCase2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.CreateCustomVoiceRequestTone?), TypeInfoPropertyName = "NullableCreateCustomVoiceRequestTone2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.UpdateCustomVoiceRequestGender?), TypeInfoPropertyName = "NullableUpdateCustomVoiceRequestGender2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.UpdateCustomVoiceRequestAge?), TypeInfoPropertyName = "NullableUpdateCustomVoiceRequestAge2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.UpdateCustomVoiceRequestUseCase?), TypeInfoPropertyName = "NullableUpdateCustomVoiceRequestUseCase2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.UpdateCustomVoiceRequestTone?), TypeInfoPropertyName = "NullableUpdateCustomVoiceRequestTone2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.CustomVoiceGender?), TypeInfoPropertyName = "NullableCustomVoiceGender2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.CustomVoiceAge?), TypeInfoPropertyName = "NullableCustomVoiceAge2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Xai.CustomVoice>))]
    internal sealed partial class CustomVoicesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CustomVoicesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static CustomVoicesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private CustomVoicesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Xai.CreateCustomVoiceRequestGender)

                    || typeToConvert == typeof(global::Xai.CreateCustomVoiceRequestGender?)

                    || typeToConvert == typeof(global::Xai.CreateCustomVoiceRequestAge)

                    || typeToConvert == typeof(global::Xai.CreateCustomVoiceRequestAge?)

                    || typeToConvert == typeof(global::Xai.CreateCustomVoiceRequestUseCase)

                    || typeToConvert == typeof(global::Xai.CreateCustomVoiceRequestUseCase?)

                    || typeToConvert == typeof(global::Xai.CreateCustomVoiceRequestTone)

                    || typeToConvert == typeof(global::Xai.CreateCustomVoiceRequestTone?)

                    || typeToConvert == typeof(global::Xai.UpdateCustomVoiceRequestGender)

                    || typeToConvert == typeof(global::Xai.UpdateCustomVoiceRequestGender?)

                    || typeToConvert == typeof(global::Xai.UpdateCustomVoiceRequestAge)

                    || typeToConvert == typeof(global::Xai.UpdateCustomVoiceRequestAge?)

                    || typeToConvert == typeof(global::Xai.UpdateCustomVoiceRequestUseCase)

                    || typeToConvert == typeof(global::Xai.UpdateCustomVoiceRequestUseCase?)

                    || typeToConvert == typeof(global::Xai.UpdateCustomVoiceRequestTone)

                    || typeToConvert == typeof(global::Xai.UpdateCustomVoiceRequestTone?)

                    || typeToConvert == typeof(global::Xai.CustomVoiceGender)

                    || typeToConvert == typeof(global::Xai.CustomVoiceGender?)

                    || typeToConvert == typeof(global::Xai.CustomVoiceAge)

                    || typeToConvert == typeof(global::Xai.CustomVoiceAge?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Xai.CreateCustomVoiceRequestGender))
                {
                    return new global::Xai.JsonConverters.CreateCustomVoiceRequestGenderJsonConverter();
                }

                if (typeToConvert == typeof(global::Xai.CreateCustomVoiceRequestGender?))
                {
                    return new global::Xai.JsonConverters.CreateCustomVoiceRequestGenderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Xai.CreateCustomVoiceRequestAge))
                {
                    return new global::Xai.JsonConverters.CreateCustomVoiceRequestAgeJsonConverter();
                }

                if (typeToConvert == typeof(global::Xai.CreateCustomVoiceRequestAge?))
                {
                    return new global::Xai.JsonConverters.CreateCustomVoiceRequestAgeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Xai.CreateCustomVoiceRequestUseCase))
                {
                    return new global::Xai.JsonConverters.CreateCustomVoiceRequestUseCaseJsonConverter();
                }

                if (typeToConvert == typeof(global::Xai.CreateCustomVoiceRequestUseCase?))
                {
                    return new global::Xai.JsonConverters.CreateCustomVoiceRequestUseCaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Xai.CreateCustomVoiceRequestTone))
                {
                    return new global::Xai.JsonConverters.CreateCustomVoiceRequestToneJsonConverter();
                }

                if (typeToConvert == typeof(global::Xai.CreateCustomVoiceRequestTone?))
                {
                    return new global::Xai.JsonConverters.CreateCustomVoiceRequestToneNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Xai.UpdateCustomVoiceRequestGender))
                {
                    return new global::Xai.JsonConverters.UpdateCustomVoiceRequestGenderJsonConverter();
                }

                if (typeToConvert == typeof(global::Xai.UpdateCustomVoiceRequestGender?))
                {
                    return new global::Xai.JsonConverters.UpdateCustomVoiceRequestGenderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Xai.UpdateCustomVoiceRequestAge))
                {
                    return new global::Xai.JsonConverters.UpdateCustomVoiceRequestAgeJsonConverter();
                }

                if (typeToConvert == typeof(global::Xai.UpdateCustomVoiceRequestAge?))
                {
                    return new global::Xai.JsonConverters.UpdateCustomVoiceRequestAgeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Xai.UpdateCustomVoiceRequestUseCase))
                {
                    return new global::Xai.JsonConverters.UpdateCustomVoiceRequestUseCaseJsonConverter();
                }

                if (typeToConvert == typeof(global::Xai.UpdateCustomVoiceRequestUseCase?))
                {
                    return new global::Xai.JsonConverters.UpdateCustomVoiceRequestUseCaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Xai.UpdateCustomVoiceRequestTone))
                {
                    return new global::Xai.JsonConverters.UpdateCustomVoiceRequestToneJsonConverter();
                }

                if (typeToConvert == typeof(global::Xai.UpdateCustomVoiceRequestTone?))
                {
                    return new global::Xai.JsonConverters.UpdateCustomVoiceRequestToneNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Xai.CustomVoiceGender))
                {
                    return new global::Xai.JsonConverters.CustomVoiceGenderJsonConverter();
                }

                if (typeToConvert == typeof(global::Xai.CustomVoiceGender?))
                {
                    return new global::Xai.JsonConverters.CustomVoiceGenderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Xai.CustomVoiceAge))
                {
                    return new global::Xai.JsonConverters.CustomVoiceAgeJsonConverter();
                }

                if (typeToConvert == typeof(global::Xai.CustomVoiceAge?))
                {
                    return new global::Xai.JsonConverters.CustomVoiceAgeNullableJsonConverter();
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
                    0 => new CustomVoicesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}