
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.CreateChatCompletionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Xai.ChatCompletionMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.ChatCompletionMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.OneOf<string, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "OneOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Xai.ChatCompletionTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.ChatCompletionTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.OneOf<global::Xai.CreateChatCompletionRequestToolChoice?, global::Xai.ChatCompletionNamedToolChoice>), TypeInfoPropertyName = "OneOfCreateChatCompletionRequestToolChoiceChatCompletionNamedToolChoice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.CreateChatCompletionRequestToolChoice), TypeInfoPropertyName = "CreateChatCompletionRequestToolChoice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.ChatCompletionNamedToolChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.ResponseFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.CreateChatCompletionRequestReasoningEffort), TypeInfoPropertyName = "CreateChatCompletionRequestReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.ChatCompletionMessageRole), TypeInfoPropertyName = "ChatCompletionMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.OneOf<string, global::System.Collections.Generic.IList<global::Xai.ChatCompletionContentPart>>), TypeInfoPropertyName = "OneOfStringIListChatCompletionContentPart2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Xai.ChatCompletionContentPart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.ChatCompletionContentPart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Xai.ChatCompletionMessageToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.ChatCompletionMessageToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.ChatCompletionContentPartType), TypeInfoPropertyName = "ChatCompletionContentPartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.ChatCompletionContentPartImageUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.ChatCompletionContentPartImageUrlDetail), TypeInfoPropertyName = "ChatCompletionContentPartImageUrlDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.ChatCompletionToolType), TypeInfoPropertyName = "ChatCompletionToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.FunctionDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.ChatCompletionNamedToolChoiceType), TypeInfoPropertyName = "ChatCompletionNamedToolChoiceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.ChatCompletionNamedToolChoiceFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.ChatCompletionMessageToolCallType), TypeInfoPropertyName = "ChatCompletionMessageToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.ChatCompletionMessageToolCallFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.ResponseFormatType), TypeInfoPropertyName = "ResponseFormatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.ResponseFormatJsonSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.CreateChatCompletionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Xai.ChatCompletionChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.ChatCompletionChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.CompletionUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.ChatCompletionChoiceMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.ChatCompletionChoiceFinishReason), TypeInfoPropertyName = "ChatCompletionChoiceFinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.CompletionUsagePromptTokensDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.CompletionUsageCompletionTokensDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.CreateChatCompletionStreamResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Xai.ChatCompletionStreamChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.ChatCompletionStreamChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.ChatCompletionStreamDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.ChatCompletionStreamChoiceFinishReason), TypeInfoPropertyName = "ChatCompletionStreamChoiceFinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.OneOf<string, global::System.Collections.Generic.IList<string>>?), TypeInfoPropertyName = "NullableOneOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.OneOf<global::Xai.CreateChatCompletionRequestToolChoice?, global::Xai.ChatCompletionNamedToolChoice>?), TypeInfoPropertyName = "NullableOneOfCreateChatCompletionRequestToolChoiceChatCompletionNamedToolChoice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.CreateChatCompletionRequestToolChoice?), TypeInfoPropertyName = "NullableCreateChatCompletionRequestToolChoice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.CreateChatCompletionRequestReasoningEffort?), TypeInfoPropertyName = "NullableCreateChatCompletionRequestReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.ChatCompletionMessageRole?), TypeInfoPropertyName = "NullableChatCompletionMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.OneOf<string, global::System.Collections.Generic.IList<global::Xai.ChatCompletionContentPart>>?), TypeInfoPropertyName = "NullableOneOfStringIListChatCompletionContentPart2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.ChatCompletionContentPartType?), TypeInfoPropertyName = "NullableChatCompletionContentPartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.ChatCompletionContentPartImageUrlDetail?), TypeInfoPropertyName = "NullableChatCompletionContentPartImageUrlDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.ChatCompletionToolType?), TypeInfoPropertyName = "NullableChatCompletionToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.ChatCompletionNamedToolChoiceType?), TypeInfoPropertyName = "NullableChatCompletionNamedToolChoiceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.ChatCompletionMessageToolCallType?), TypeInfoPropertyName = "NullableChatCompletionMessageToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.ResponseFormatType?), TypeInfoPropertyName = "NullableResponseFormatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.ChatCompletionChoiceFinishReason?), TypeInfoPropertyName = "NullableChatCompletionChoiceFinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.ChatCompletionStreamChoiceFinishReason?), TypeInfoPropertyName = "NullableChatCompletionStreamChoiceFinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Xai.ChatCompletionMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.OneOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Xai.ChatCompletionTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.OneOf<string, global::System.Collections.Generic.List<global::Xai.ChatCompletionContentPart>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Xai.ChatCompletionContentPart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Xai.ChatCompletionMessageToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Xai.ChatCompletionChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Xai.ChatCompletionStreamChoice>))]
    internal sealed partial class ChatSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ChatSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ChatSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ChatSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Xai.JsonConverters.OneOfJsonConverter<global::Xai.CreateChatCompletionRequestToolChoice?, global::Xai.ChatCompletionNamedToolChoice>());
            options.Converters.Add(new global::Xai.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Xai.ChatCompletionContentPart>>());
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
                    typeToConvert == typeof(global::Xai.CreateChatCompletionRequestToolChoice)

                    || typeToConvert == typeof(global::Xai.CreateChatCompletionRequestToolChoice?)

                    || typeToConvert == typeof(global::Xai.CreateChatCompletionRequestReasoningEffort)

                    || typeToConvert == typeof(global::Xai.CreateChatCompletionRequestReasoningEffort?)

                    || typeToConvert == typeof(global::Xai.ChatCompletionMessageRole)

                    || typeToConvert == typeof(global::Xai.ChatCompletionMessageRole?)

                    || typeToConvert == typeof(global::Xai.ChatCompletionContentPartType)

                    || typeToConvert == typeof(global::Xai.ChatCompletionContentPartType?)

                    || typeToConvert == typeof(global::Xai.ChatCompletionContentPartImageUrlDetail)

                    || typeToConvert == typeof(global::Xai.ChatCompletionContentPartImageUrlDetail?)

                    || typeToConvert == typeof(global::Xai.ChatCompletionToolType)

                    || typeToConvert == typeof(global::Xai.ChatCompletionToolType?)

                    || typeToConvert == typeof(global::Xai.ChatCompletionNamedToolChoiceType)

                    || typeToConvert == typeof(global::Xai.ChatCompletionNamedToolChoiceType?)

                    || typeToConvert == typeof(global::Xai.ChatCompletionMessageToolCallType)

                    || typeToConvert == typeof(global::Xai.ChatCompletionMessageToolCallType?)

                    || typeToConvert == typeof(global::Xai.ResponseFormatType)

                    || typeToConvert == typeof(global::Xai.ResponseFormatType?)

                    || typeToConvert == typeof(global::Xai.ChatCompletionChoiceFinishReason)

                    || typeToConvert == typeof(global::Xai.ChatCompletionChoiceFinishReason?)

                    || typeToConvert == typeof(global::Xai.ChatCompletionStreamChoiceFinishReason)

                    || typeToConvert == typeof(global::Xai.ChatCompletionStreamChoiceFinishReason?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Xai.CreateChatCompletionRequestToolChoice))
                {
                    return new global::Xai.JsonConverters.CreateChatCompletionRequestToolChoiceJsonConverter();
                }

                if (typeToConvert == typeof(global::Xai.CreateChatCompletionRequestToolChoice?))
                {
                    return new global::Xai.JsonConverters.CreateChatCompletionRequestToolChoiceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Xai.CreateChatCompletionRequestReasoningEffort))
                {
                    return new global::Xai.JsonConverters.CreateChatCompletionRequestReasoningEffortJsonConverter();
                }

                if (typeToConvert == typeof(global::Xai.CreateChatCompletionRequestReasoningEffort?))
                {
                    return new global::Xai.JsonConverters.CreateChatCompletionRequestReasoningEffortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Xai.ChatCompletionMessageRole))
                {
                    return new global::Xai.JsonConverters.ChatCompletionMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Xai.ChatCompletionMessageRole?))
                {
                    return new global::Xai.JsonConverters.ChatCompletionMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Xai.ChatCompletionContentPartType))
                {
                    return new global::Xai.JsonConverters.ChatCompletionContentPartTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Xai.ChatCompletionContentPartType?))
                {
                    return new global::Xai.JsonConverters.ChatCompletionContentPartTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Xai.ChatCompletionContentPartImageUrlDetail))
                {
                    return new global::Xai.JsonConverters.ChatCompletionContentPartImageUrlDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::Xai.ChatCompletionContentPartImageUrlDetail?))
                {
                    return new global::Xai.JsonConverters.ChatCompletionContentPartImageUrlDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Xai.ChatCompletionToolType))
                {
                    return new global::Xai.JsonConverters.ChatCompletionToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Xai.ChatCompletionToolType?))
                {
                    return new global::Xai.JsonConverters.ChatCompletionToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Xai.ChatCompletionNamedToolChoiceType))
                {
                    return new global::Xai.JsonConverters.ChatCompletionNamedToolChoiceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Xai.ChatCompletionNamedToolChoiceType?))
                {
                    return new global::Xai.JsonConverters.ChatCompletionNamedToolChoiceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Xai.ChatCompletionMessageToolCallType))
                {
                    return new global::Xai.JsonConverters.ChatCompletionMessageToolCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Xai.ChatCompletionMessageToolCallType?))
                {
                    return new global::Xai.JsonConverters.ChatCompletionMessageToolCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Xai.ResponseFormatType))
                {
                    return new global::Xai.JsonConverters.ResponseFormatTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Xai.ResponseFormatType?))
                {
                    return new global::Xai.JsonConverters.ResponseFormatTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Xai.ChatCompletionChoiceFinishReason))
                {
                    return new global::Xai.JsonConverters.ChatCompletionChoiceFinishReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::Xai.ChatCompletionChoiceFinishReason?))
                {
                    return new global::Xai.JsonConverters.ChatCompletionChoiceFinishReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Xai.ChatCompletionStreamChoiceFinishReason))
                {
                    return new global::Xai.JsonConverters.ChatCompletionStreamChoiceFinishReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::Xai.ChatCompletionStreamChoiceFinishReason?))
                {
                    return new global::Xai.JsonConverters.ChatCompletionStreamChoiceFinishReasonNullableJsonConverter();
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
                    0 => new ChatSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}