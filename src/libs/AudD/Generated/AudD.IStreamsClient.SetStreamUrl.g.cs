#nullable enable

namespace AudD
{
    public partial interface IStreamsClient
    {
        /// <summary>
        /// Update stream URL
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AudD.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AudD.NullResultResponse> SetStreamUrlAsync(

            global::AudD.SetStreamUrlRequest request,
            global::AudD.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update stream URL
        /// </summary>
        /// <param name="url">
        /// New URL of the audio stream.
        /// </param>
        /// <param name="radioId">
        /// Caller-supplied integer stream identifier.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AudD.NullResultResponse> SetStreamUrlAsync(
            string url,
            long radioId,
            global::AudD.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}