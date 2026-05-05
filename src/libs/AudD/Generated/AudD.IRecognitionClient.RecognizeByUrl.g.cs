#nullable enable

namespace AudD
{
    public partial interface IRecognitionClient
    {
        /// <summary>
        /// Recognize audio by URL<br/>
        /// Recognizes music from a public audio or video URL.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="return"></param>
        /// <param name="market">
        /// Default Value: us
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AudD.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AudD.RecognitionResponse> RecognizeByUrlAsync(
            string url,
            string? @return = default,
            string? market = default,
            global::AudD.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Recognize audio by URL<br/>
        /// Recognizes music from a public audio or video URL.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="return"></param>
        /// <param name="market">
        /// Default Value: us
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AudD.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AudD.AutoSDKHttpResponse<global::AudD.RecognitionResponse>> RecognizeByUrlAsResponseAsync(
            string url,
            string? @return = default,
            string? market = default,
            global::AudD.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}