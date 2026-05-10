
#nullable enable

namespace AudD
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EnterpriseSegment
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset")]
        public string? Offset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("songs")]
        public global::System.Collections.Generic.IList<global::AudD.EnterpriseSong>? Songs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnterpriseSegment" /> class.
        /// </summary>
        /// <param name="offset"></param>
        /// <param name="songs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnterpriseSegment(
            string? offset,
            global::System.Collections.Generic.IList<global::AudD.EnterpriseSong>? songs)
        {
            this.Offset = offset;
            this.Songs = songs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnterpriseSegment" /> class.
        /// </summary>
        public EnterpriseSegment()
        {
        }

    }
}