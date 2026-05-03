
#nullable enable

namespace AudD
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SetCallbackUrlRequest
    {
        /// <summary>
        /// URL that receives stream recognition callbacks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SetCallbackUrlRequest" /> class.
        /// </summary>
        /// <param name="url">
        /// URL that receives stream recognition callbacks.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SetCallbackUrlRequest(
            string url)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetCallbackUrlRequest" /> class.
        /// </summary>
        public SetCallbackUrlRequest()
        {
        }
    }
}