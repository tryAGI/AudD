#nullable enable

namespace AudD
{
    public partial interface IStreamsClient
    {
        /// <summary>
        /// Get callback URL
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AudD.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AudD.GetCallbackUrlResponse> GetCallbackUrlAsync(
            global::AudD.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}