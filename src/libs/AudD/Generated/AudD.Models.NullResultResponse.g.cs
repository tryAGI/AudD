
#nullable enable

namespace AudD
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class NullResultResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        public object? Result { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NullResultResponse" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="result"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NullResultResponse(
            string status,
            object? result)
        {
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.Result = result;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NullResultResponse" /> class.
        /// </summary>
        public NullResultResponse()
        {
        }

    }
}