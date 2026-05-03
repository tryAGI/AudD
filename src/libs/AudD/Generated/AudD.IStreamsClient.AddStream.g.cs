#nullable enable

namespace AudD
{
    public partial interface IStreamsClient
    {
        /// <summary>
        /// Add stream
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AudD.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AudD.NullResultResponse> AddStreamAsync(

            global::AudD.AddStreamRequest request,
            global::AudD.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add stream
        /// </summary>
        /// <param name="url">
        /// Audio stream URL, twitch channel token, or YouTube live stream token.
        /// </param>
        /// <param name="radioId">
        /// Caller-supplied integer stream identifier.
        /// </param>
        /// <param name="callbacks">
        /// Set to before to receive callbacks when a song starts.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AudD.NullResultResponse> AddStreamAsync(
            string url,
            long radioId,
            string? callbacks = default,
            global::AudD.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}