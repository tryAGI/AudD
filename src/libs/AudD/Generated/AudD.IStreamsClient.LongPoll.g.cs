#nullable enable

namespace AudD
{
    public partial interface IStreamsClient
    {
        /// <summary>
        /// Long poll stream results<br/>
        /// Reads stream recognition callbacks via long polling. This endpoint uses a longpoll category, not the API token.
        /// </summary>
        /// <param name="category"></param>
        /// <param name="timeout">
        /// Default Value: 50
        /// </param>
        /// <param name="sinceTime"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AudD.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AudD.LongPollResponse> LongPollAsync(
            string category,
            int? timeout = default,
            long? sinceTime = default,
            global::AudD.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Long poll stream results<br/>
        /// Reads stream recognition callbacks via long polling. This endpoint uses a longpoll category, not the API token.
        /// </summary>
        /// <param name="category"></param>
        /// <param name="timeout">
        /// Default Value: 50
        /// </param>
        /// <param name="sinceTime"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AudD.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AudD.AutoSDKHttpResponse<global::AudD.LongPollResponse>> LongPollAsResponseAsync(
            string category,
            int? timeout = default,
            long? sinceTime = default,
            global::AudD.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}