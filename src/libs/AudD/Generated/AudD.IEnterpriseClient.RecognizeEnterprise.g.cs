#nullable enable

namespace AudD
{
    public partial interface IEnterpriseClient
    {
        /// <summary>
        /// Recognize long audio or video<br/>
        /// Recognizes music from long audio and video files using AudD's enterprise endpoint.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AudD.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AudD.EnterpriseRecognitionResponse> RecognizeEnterpriseAsync(

            global::AudD.EnterpriseRecognizeRequest request,
            global::AudD.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Recognize long audio or video<br/>
        /// Recognizes music from long audio and video files using AudD's enterprise endpoint.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AudD.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AudD.AutoSDKHttpResponse<global::AudD.EnterpriseRecognitionResponse>> RecognizeEnterpriseAsResponseAsync(

            global::AudD.EnterpriseRecognizeRequest request,
            global::AudD.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Recognize long audio or video<br/>
        /// Recognizes music from long audio and video files using AudD's enterprise endpoint.
        /// </summary>
        /// <param name="url">
        /// URL of the file or page to scan.
        /// </param>
        /// <param name="file">
        /// Audio or video file to scan.
        /// </param>
        /// <param name="filename">
        /// Audio or video file to scan.
        /// </param>
        /// <param name="accurateOffsets">
        /// Set to true to request accurate start and end offsets.
        /// </param>
        /// <param name="skip">
        /// Number of 12-second chunks skipped after recognized chunks.
        /// </param>
        /// <param name="every">
        /// Number of chunks to recognize in a row.
        /// </param>
        /// <param name="limit">
        /// Upper bound for the number of chunks to recognize.
        /// </param>
        /// <param name="skipFirstSeconds">
        /// Seconds to skip before starting recognition.
        /// </param>
        /// <param name="useTimecode">
        /// Set to true to use time information from the submitted URL as skip_first_seconds.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AudD.EnterpriseRecognitionResponse> RecognizeEnterpriseAsync(
            string? url = default,
            byte[]? file = default,
            string? filename = default,
            string? accurateOffsets = default,
            int? skip = default,
            int? every = default,
            int? limit = default,
            int? skipFirstSeconds = default,
            string? useTimecode = default,
            global::AudD.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}