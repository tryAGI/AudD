
#nullable enable

namespace AudD
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EnterpriseRecognitionResponse
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
        public global::System.Collections.Generic.IList<global::AudD.EnterpriseSegment>? Result { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_time")]
        public string? ExecutionTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnterpriseRecognitionResponse" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="result"></param>
        /// <param name="executionTime"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnterpriseRecognitionResponse(
            string status,
            global::System.Collections.Generic.IList<global::AudD.EnterpriseSegment>? result,
            string? executionTime)
        {
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.Result = result;
            this.ExecutionTime = executionTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnterpriseRecognitionResponse" /> class.
        /// </summary>
        public EnterpriseRecognitionResponse()
        {
        }

    }
}