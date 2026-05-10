
#nullable enable

namespace AudD
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SetStreamUrlRequest
    {
        /// <summary>
        /// New URL of the audio stream.
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SetStreamUrlRequest" /> class.
        /// </summary>
        /// <param name="url">
        /// New URL of the audio stream.
        /// </param>
        /// <param name="radioId">
        /// Caller-supplied integer stream identifier.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SetStreamUrlRequest(
            string url,
            long radioId)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.RadioId = radioId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetStreamUrlRequest" /> class.
        /// </summary>
        public SetStreamUrlRequest()
        {
        }

    }
}