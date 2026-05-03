
#nullable enable

namespace AudD
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddStreamRequest
    {
        /// <summary>
        /// Audio stream URL, twitch channel token, or YouTube live stream token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Caller-supplied integer stream identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("radio_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long RadioId { get; set; }

        /// <summary>
        /// Set to before to receive callbacks when a song starts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callbacks")]
        public string? Callbacks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddStreamRequest" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddStreamRequest(
            string url,
            long radioId,
            string? callbacks)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.RadioId = radioId;
            this.Callbacks = callbacks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddStreamRequest" /> class.
        /// </summary>
        public AddStreamRequest()
        {
        }
    }
}