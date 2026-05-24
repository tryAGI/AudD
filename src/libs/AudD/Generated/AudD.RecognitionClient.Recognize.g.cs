
#nullable enable

namespace AudD
{
    public partial class RecognitionClient
    {


        private static readonly global::AudD.EndPointSecurityRequirement s_RecognizeSecurityRequirement0 =
            new global::AudD.EndPointSecurityRequirement
            {
                Authorizations = new global::AudD.EndPointAuthorizationRequirement[]
                {                    new global::AudD.EndPointAuthorizationRequirement
                    {
                        Type = "ApiKey",
                        SchemeId = "ApikeyApiToken",
                        Location = "Query",
                        Name = "api_token",
                        FriendlyName = "ApiKeyInQuery",
                    },
                },
            };
        private static readonly global::AudD.EndPointSecurityRequirement[] s_RecognizeSecurityRequirements =
            new global::AudD.EndPointSecurityRequirement[]
            {                s_RecognizeSecurityRequirement0,
            };
        partial void PrepareRecognizeArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::AudD.RecognizeRequest request);
        partial void PrepareRecognizeRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::AudD.RecognizeRequest request);
        partial void ProcessRecognizeResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessRecognizeResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Recognize audio<br/>
        /// Recognizes music from a public URL, an uploaded file, or a base64-encoded audio string.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AudD.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::AudD.RecognitionResponse> RecognizeAsync(

            global::AudD.RecognizeRequest request,
            global::AudD.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await RecognizeAsResponseAsync(

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Recognize audio<br/>
        /// Recognizes music from a public URL, an uploaded file, or a base64-encoded audio string.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AudD.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::AudD.AutoSDKHttpResponse<global::AudD.RecognitionResponse>> RecognizeAsResponseAsync(

            global::AudD.RecognizeRequest request,
            global::AudD.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareRecognizeArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::AudD.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_RecognizeSecurityRequirements,
                operationName: "RecognizeAsync");

            using var __timeoutCancellationTokenSource = global::AudD.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::AudD.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::AudD.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: false);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::AudD.PathBuilder(
                                path: "/",
                                baseUri: HttpClient.BaseAddress);
                            foreach (var __authorization in __authorizations)
                            {
                                if (__authorization.Type == "ApiKey" &&
                                    __authorization.Location == "Query")
                                {
                                    __pathBuilder = __pathBuilder.AddRequiredParameter(__authorization.Name, __authorization.Value);
                                }
                            }
                            var __path = __pathBuilder.ToString();
                __path = global::AudD.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

                            var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
                            if (request.Url != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.Url ?? string.Empty),
                                    name: "\"url\"");

                            }
                            if (request.File != default)
                            {

                                var __contentFile = new global::System.Net.Http.ByteArrayContent(request.File ?? global::System.Array.Empty<byte>());
                                __contentFile.Headers.ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue(
                                    request.Filename is null
                                        ? "application/octet-stream"
                                        : (global::System.IO.Path.GetExtension(request.Filename) ?? string.Empty).ToLowerInvariant() switch
                                        {
                                            ".aac" => "audio/aac",
                                            ".flac" => "audio/flac",
                                            ".gif" => "image/gif",
                                            ".jpeg" => "image/jpeg",
                                            ".jpg" => "image/jpeg",
                                            ".json" => "application/json",
                                            ".m4a" => "audio/mp4",
                                            ".mp3" => "audio/mpeg",
                                            ".mp4" => "video/mp4",
                                            ".mpeg" => "audio/mpeg",
                                            ".mpga" => "audio/mpeg",
                                            ".oga" => "audio/ogg",
                                            ".ogg" => "audio/ogg",
                                            ".opus" => "audio/ogg",
                                            ".pdf" => "application/pdf",
                                            ".png" => "image/png",
                                            ".txt" => "text/plain",
                                            ".wav" => "audio/wav",
                                            ".weba" => "audio/webm",
                                            ".webm" => "video/webm",
                                            ".webp" => "image/webp",
                                            _ => "application/octet-stream",
                                        });
                                __httpRequestContent.Add(
                                    content: __contentFile,
                                    name: "\"file\"",
                                    fileName: request.Filename != null ? $"\"{request.Filename}\"" : string.Empty);
                                if (__contentFile.Headers.ContentDisposition != null)
                                {
                                    __contentFile.Headers.ContentDisposition.FileNameStar = null;
                                }

                            }
                            if (request.Audio != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.Audio ?? string.Empty),
                                    name: "\"audio\"");

                            }
                            if (request.Return != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.Return ?? string.Empty),
                                    name: "\"return\"");

                            }
                            if (request.Market != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.Market ?? string.Empty),
                                    name: "\"market\"");

                            }

                            __httpRequest.Content = __httpRequestContent;

                global::AudD.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareRecognizeRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    request: request);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::AudD.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::AudD.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "Recognize",
                                methodName: "RecognizeAsync",
                                pathTemplate: "\"/\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::AudD.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::AudD.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::AudD.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "Recognize",
                                methodName: "RecognizeAsync",
                                pathTemplate: "\"/\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::AudD.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::AudD.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::AudD.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::AudD.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::AudD.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "Recognize",
                                methodName: "RecognizeAsync",
                                pathTemplate: "\"/\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::AudD.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessRecognizeResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::AudD.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::AudD.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "Recognize",
                                methodName: "RecognizeAsync",
                                pathTemplate: "\"/\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::AudD.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::AudD.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "Recognize",
                                methodName: "RecognizeAsync",
                                pathTemplate: "\"/\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessRecognizeResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::AudD.RecognitionResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::AudD.AutoSDKHttpResponse<global::AudD.RecognitionResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::AudD.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw global::AudD.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    var __value = await global::AudD.RecognitionResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::AudD.AutoSDKHttpResponse<global::AudD.RecognitionResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::AudD.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
                #endif
                                        ).ConfigureAwait(false);
                                    }
                                    catch (global::System.Exception)
                                    {
                                    }

                                    throw global::AudD.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
        /// <summary>
        /// Recognize audio<br/>
        /// Recognizes music from a public URL, an uploaded file, or a base64-encoded audio string.
        /// </summary>
        /// <param name="url">
        /// URL of the file to recognize.
        /// </param>
        /// <param name="file">
        /// Audio or video file to recognize.
        /// </param>
        /// <param name="filename">
        /// Audio or video file to recognize.
        /// </param>
        /// <param name="audio">
        /// Base64-encoded audio. AudD discourages this transport and supports it only in limited cases.
        /// </param>
        /// <param name="return">
        /// Comma-separated additional metadata identifiers.
        /// </param>
        /// <param name="market">
        /// Country code for Apple Music, iTunes, and Spotify results.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::AudD.RecognitionResponse> RecognizeAsync(
            string? url = default,
            byte[]? file = default,
            string? filename = default,
            string? audio = default,
            string? @return = default,
            string? market = default,
            global::AudD.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::AudD.RecognizeRequest
            {
                Url = url,
                File = file,
                Filename = filename,
                Audio = audio,
                Return = @return,
                Market = market,
            };

            return await RecognizeAsync(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}