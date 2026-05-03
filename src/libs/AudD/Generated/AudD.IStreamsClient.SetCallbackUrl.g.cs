#nullable enable

namespace AudD
{
    public partial interface IStreamsClient
    {
        /// <summary>
        /// Set callback URL
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AudD.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AudD.NullResultResponse> SetCallbackUrlAsync(

            global::AudD.SetCallbackUrlRequest request,
            global::AudD.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set callback URL
        /// </summary>
        /// <param name="url">
        /// URL that receives stream recognition callbacks.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AudD.NullResultResponse> SetCallbackUrlAsync(
            string url,
            global::AudD.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}