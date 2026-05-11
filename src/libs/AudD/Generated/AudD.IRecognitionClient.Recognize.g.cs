#nullable enable

namespace AudD
{
    public partial interface IRecognitionClient
    {
        /// <summary>
        /// Recognize audio<br/>
        /// Recognizes music from a public URL, an uploaded file, or a base64-encoded audio string.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AudD.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AudD.RecognitionResponse> RecognizeAsync(

            global::AudD.RecognizeRequest request,
            global::AudD.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Recognize audio<br/>
        /// Recognizes music from a public URL, an uploaded file, or a base64-encoded audio string.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AudD.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AudD.AutoSDKHttpResponse<global::AudD.RecognitionResponse>> RecognizeAsResponseAsync(

            global::AudD.RecognizeRequest request,
            global::AudD.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
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
        global::System.Threading.Tasks.Task<global::AudD.RecognitionResponse> RecognizeAsync(
            string? url = default,
            byte[]? file = default,
            string? filename = default,
            string? audio = default,
            string? @return = default,
            string? market = default,
            global::AudD.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}