
#nullable enable

namespace AudD
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DeleteStreamRequest
    {
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
        /// Initializes a new instance of the <see cref="DeleteStreamRequest" /> class.
        /// </summary>
        /// <param name="radioId">
        /// Caller-supplied integer stream identifier.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteStreamRequest(
            long radioId)
        {
            this.RadioId = radioId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteStreamRequest" /> class.
        /// </summary>
        public DeleteStreamRequest()
        {
        }

    }
}