
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
            typeof(global::Xai.JsonConverters.CreateChatCompletionRequestToolChoiceJsonConverter),

            typeof(global::Xai.JsonConverters.CreateChatCompletionRequestToolChoiceNullableJsonConverter),

            typeof(global::Xai.JsonConverters.CreateChatCompletionRequestReasoningEffortJsonConverter),

            typeof(global::Xai.JsonConverters.CreateChatCompletionRequestReasoningEffortNullableJsonConverter),

            typeof(global::Xai.JsonConverters.ChatCompletionMessageRoleJsonConverter),

            typeof(global::Xai.JsonConverters.ChatCompletionMessageRoleNullableJsonConverter),

            typeof(global::Xai.JsonConverters.ChatCompletionContentPartTypeJsonConverter),

            typeof(global::Xai.JsonConverters.ChatCompletionContentPartTypeNullableJsonConverter),

            typeof(global::Xai.JsonConverters.ChatCompletionContentPartImageUrlDetailJsonConverter),

            typeof(global::Xai.JsonConverters.ChatCompletionContentPartImageUrlDetailNullableJsonConverter),

            typeof(global::Xai.JsonConverters.ChatCompletionToolTypeJsonConverter),

            typeof(global::Xai.JsonConverters.ChatCompletionToolTypeNullableJsonConverter),

            typeof(global::Xai.JsonConverters.ChatCompletionNamedToolChoiceTypeJsonConverter),

            typeof(global::Xai.JsonConverters.ChatCompletionNamedToolChoiceTypeNullableJsonConverter),

            typeof(global::Xai.JsonConverters.ChatCompletionMessageToolCallTypeJsonConverter),

            typeof(global::Xai.JsonConverters.ChatCompletionMessageToolCallTypeNullableJsonConverter),

            typeof(global::Xai.JsonConverters.ResponseFormatTypeJsonConverter),

            typeof(global::Xai.JsonConverters.ResponseFormatTypeNullableJsonConverter),

            typeof(global::Xai.JsonConverters.ChatCompletionChoiceFinishReasonJsonConverter),

            typeof(global::Xai.JsonConverters.ChatCompletionChoiceFinishReasonNullableJsonConverter),

            typeof(global::Xai.JsonConverters.ChatCompletionStreamChoiceFinishReasonJsonConverter),

            typeof(global::Xai.JsonConverters.ChatCompletionStreamChoiceFinishReasonNullableJsonConverter),

            typeof(global::Xai.JsonConverters.CreateResponseRequestReasoningEffortJsonConverter),

            typeof(global::Xai.JsonConverters.CreateResponseRequestReasoningEffortNullableJsonConverter),

            typeof(global::Xai.JsonConverters.ResponseInputMessageRoleJsonConverter),

            typeof(global::Xai.JsonConverters.ResponseInputMessageRoleNullableJsonConverter),

            typeof(global::Xai.JsonConverters.ResponseObjectStatusJsonConverter),

            typeof(global::Xai.JsonConverters.ResponseObjectStatusNullableJsonConverter),

            typeof(global::Xai.JsonConverters.CreateEmbeddingRequestEncodingFormatJsonConverter),

            typeof(global::Xai.JsonConverters.CreateEmbeddingRequestEncodingFormatNullableJsonConverter),

            typeof(global::Xai.JsonConverters.CreateImageRequestAspectRatioJsonConverter),

            typeof(global::Xai.JsonConverters.CreateImageRequestAspectRatioNullableJsonConverter),

            typeof(global::Xai.JsonConverters.CreateImageRequestResolutionJsonConverter),

            typeof(global::Xai.JsonConverters.CreateImageRequestResolutionNullableJsonConverter),

            typeof(global::Xai.JsonConverters.CreateImageRequestResponseFormatJsonConverter),

            typeof(global::Xai.JsonConverters.CreateImageRequestResponseFormatNullableJsonConverter),

            typeof(global::Xai.JsonConverters.CreateImageEditRequestAspectRatioJsonConverter),

            typeof(global::Xai.JsonConverters.CreateImageEditRequestAspectRatioNullableJsonConverter),

            typeof(global::Xai.JsonConverters.CreateImageEditRequestResolutionJsonConverter),

            typeof(global::Xai.JsonConverters.CreateImageEditRequestResolutionNullableJsonConverter),

            typeof(global::Xai.JsonConverters.CreateImageEditRequestResponseFormatJsonConverter),

            typeof(global::Xai.JsonConverters.CreateImageEditRequestResponseFormatNullableJsonConverter),

            typeof(global::Xai.JsonConverters.ImageInputTypeJsonConverter),

            typeof(global::Xai.JsonConverters.ImageInputTypeNullableJsonConverter),

            typeof(global::Xai.JsonConverters.CreateVideoRequestAspectRatioJsonConverter),

            typeof(global::Xai.JsonConverters.CreateVideoRequestAspectRatioNullableJsonConverter),

            typeof(global::Xai.JsonConverters.CreateVideoRequestResolutionJsonConverter),

            typeof(global::Xai.JsonConverters.CreateVideoRequestResolutionNullableJsonConverter),

            typeof(global::Xai.JsonConverters.VideoStatusResponseStatusJsonConverter),

            typeof(global::Xai.JsonConverters.VideoStatusResponseStatusNullableJsonConverter),

            typeof(global::Xai.JsonConverters.CreateSpeechRequestVoiceJsonConverter),

            typeof(global::Xai.JsonConverters.CreateSpeechRequestVoiceNullableJsonConverter),

            typeof(global::Xai.JsonConverters.CreateSpeechRequestResponseFormatJsonConverter),

            typeof(global::Xai.JsonConverters.CreateSpeechRequestResponseFormatNullableJsonConverter),

            typeof(global::Xai.JsonConverters.BatchRequestMetadataStateJsonConverter),

            typeof(global::Xai.JsonConverters.BatchRequestMetadataStateNullableJsonConverter),

            typeof(global::Xai.JsonConverters.SearchDocumentsRequestModeJsonConverter),

            typeof(global::Xai.JsonConverters.SearchDocumentsRequestModeNullableJsonConverter),

            typeof(global::Xai.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Xai.JsonConverters.OneOfJsonConverter<global::Xai.CreateChatCompletionRequestToolChoice?, global::Xai.ChatCompletionNamedToolChoice>),

            typeof(global::Xai.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Xai.ChatCompletionContentPart>>),

            typeof(global::Xai.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Xai.ResponseInputMessage>>),

            typeof(global::Xai.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Xai.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.JsonSerializerContextTypes))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.CreateResponseRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.OneOf<string, global::System.Collections.Generic.IList<global::Xai.ResponseInputMessage>>), TypeInfoPropertyName = "OneOfStringIListResponseInputMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Xai.ResponseInputMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.ResponseInputMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.CreateResponseRequestReasoning))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.CreateResponseRequestReasoningEffort), TypeInfoPropertyName = "CreateResponseRequestReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.ResponseInputMessageRole), TypeInfoPropertyName = "ResponseInputMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.ResponseObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.ResponseObjectStatus), TypeInfoPropertyName = "ResponseObjectStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Xai.ResponseOutputItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.ResponseOutputItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Xai.ResponseContentPart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.ResponseContentPart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.DeleteResponseResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.CreateEmbeddingRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.CreateEmbeddingRequestEncodingFormat), TypeInfoPropertyName = "CreateEmbeddingRequestEncodingFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.CreateEmbeddingResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Xai.EmbeddingData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.EmbeddingData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.CreateEmbeddingResponseUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.CreateImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.CreateImageRequestAspectRatio), TypeInfoPropertyName = "CreateImageRequestAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.CreateImageRequestResolution), TypeInfoPropertyName = "CreateImageRequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.CreateImageRequestResponseFormat), TypeInfoPropertyName = "CreateImageRequestResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.CreateImageEditRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.ImageInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Xai.ImageInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.CreateImageEditRequestAspectRatio), TypeInfoPropertyName = "CreateImageEditRequestAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.CreateImageEditRequestResolution), TypeInfoPropertyName = "CreateImageEditRequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.CreateImageEditRequestResponseFormat), TypeInfoPropertyName = "CreateImageEditRequestResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.ImageInputType), TypeInfoPropertyName = "ImageInputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.ImageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Xai.ImageData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.ImageData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.CreateVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.CreateVideoRequestAspectRatio), TypeInfoPropertyName = "CreateVideoRequestAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.CreateVideoRequestResolution), TypeInfoPropertyName = "CreateVideoRequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.CreateVideoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.VideoStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.VideoStatusResponseStatus), TypeInfoPropertyName = "VideoStatusResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.VideoData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.CreateSpeechRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.CreateSpeechRequestVoice), TypeInfoPropertyName = "CreateSpeechRequestVoice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.CreateSpeechRequestResponseFormat), TypeInfoPropertyName = "CreateSpeechRequestResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.ListModelsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Xai.Model>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.Model))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.ListSpecificModelsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.ApiKeyInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.CreateClientSecretRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.CreateClientSecretRequestExpiresAfter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.ClientSecretResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.ClientSecretResponseClientSecret))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.FileObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.CreateBatchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.BatchObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.BatchState))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.BatchObjectCostBreakdown))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.ListBatchesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Xai.BatchObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.AddBatchRequestsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Xai.BatchRequestItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.BatchRequestItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.ListBatchRequestsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Xai.BatchRequestMetadata>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.BatchRequestMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.BatchRequestMetadataState), TypeInfoPropertyName = "BatchRequestMetadataState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.BatchResultsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Xai.BatchResultSuccess>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.BatchResultSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Xai.BatchResultFailure>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.BatchResultFailure))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.SearchDocumentsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.SearchDocumentsRequestMode), TypeInfoPropertyName = "SearchDocumentsRequestMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.SearchDocumentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Xai.SearchResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.SearchResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.UploadFileRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Xai.ChatCompletionMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.OneOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Xai.ChatCompletionTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.OneOf<string, global::System.Collections.Generic.List<global::Xai.ChatCompletionContentPart>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Xai.ChatCompletionContentPart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Xai.ChatCompletionMessageToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Xai.ChatCompletionChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Xai.ChatCompletionStreamChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.OneOf<string, global::System.Collections.Generic.List<global::Xai.ResponseInputMessage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Xai.ResponseInputMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Xai.ResponseOutputItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Xai.ResponseContentPart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Xai.EmbeddingData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Xai.ImageInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Xai.ImageData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Xai.Model>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Xai.BatchObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Xai.BatchRequestItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Xai.BatchRequestMetadata>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Xai.BatchResultSuccess>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Xai.BatchResultFailure>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Xai.SearchResult>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}