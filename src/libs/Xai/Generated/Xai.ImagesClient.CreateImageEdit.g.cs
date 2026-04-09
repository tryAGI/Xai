
#nullable enable

namespace Xai
{
    public partial class ImagesClient
    {


        private static readonly global::Xai.EndPointSecurityRequirement s_CreateImageEditSecurityRequirement0 =
            new global::Xai.EndPointSecurityRequirement
            {
                Authorizations = new global::Xai.EndPointAuthorizationRequirement[]
                {                    new global::Xai.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Xai.EndPointSecurityRequirement[] s_CreateImageEditSecurityRequirements =
            new global::Xai.EndPointSecurityRequirement[]
            {                s_CreateImageEditSecurityRequirement0,
            };
        partial void PrepareCreateImageEditArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Xai.CreateImageEditRequest request);
        partial void PrepareCreateImageEditRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Xai.CreateImageEditRequest request);
        partial void ProcessCreateImageEditResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateImageEditResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Edit an image<br/>
        /// Creates an edited or extended image given source image(s) and a prompt.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Xai.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Xai.ImageResponse> CreateImageEditAsync(

            global::Xai.CreateImageEditRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateImageEditArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::Xai.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateImageEditSecurityRequirements,
                operationName: "CreateImageEditAsync");

            var __pathBuilder = new global::Xai.PathBuilder(
                path: "/images/edits",
                baseUri: HttpClient.BaseAddress);
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreateImageEditRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateImageEditResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessCreateImageEditResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Xai.ImageResponse.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::Xai.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::Xai.ImageResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::Xai.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
        /// <summary>
        /// Edit an image<br/>
        /// Creates an edited or extended image given source image(s) and a prompt.
        /// </summary>
        /// <param name="model">
        /// The model to use for image editing.
        /// </param>
        /// <param name="prompt">
        /// A text description of the desired edit.
        /// </param>
        /// <param name="image"></param>
        /// <param name="images">
        /// Source images (up to 5).
        /// </param>
        /// <param name="aspectRatio">
        /// Aspect ratio override for the output.
        /// </param>
        /// <param name="resolution"></param>
        /// <param name="responseFormat">
        /// Default Value: url
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Xai.ImageResponse> CreateImageEditAsync(
            string model,
            string prompt,
            global::Xai.ImageInput? image = default,
            global::System.Collections.Generic.IList<global::Xai.ImageInput>? images = default,
            global::Xai.CreateImageEditRequestAspectRatio? aspectRatio = default,
            global::Xai.CreateImageEditRequestResolution? resolution = default,
            global::Xai.CreateImageEditRequestResponseFormat? responseFormat = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Xai.CreateImageEditRequest
            {
                Model = model,
                Prompt = prompt,
                Image = image,
                Images = images,
                AspectRatio = aspectRatio,
                Resolution = resolution,
                ResponseFormat = responseFormat,
            };

            return await CreateImageEditAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}