
#nullable enable

namespace AudD
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StreamInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("radio_id")]
        public long? RadioId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream_running")]
        public bool? StreamRunning { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("longpoll_category")]
        public string? LongpollCategory { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamInfo" /> class.
        /// </summary>
        /// <param name="radioId"></param>
        /// <param name="url"></param>
        /// <param name="streamRunning"></param>
        /// <param name="longpollCategory"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StreamInfo(
            long? radioId,
            string? url,
            bool? streamRunning,
            string? longpollCategory)
        {
            this.RadioId = radioId;
            this.Url = url;
            this.StreamRunning = streamRunning;
            this.LongpollCategory = longpollCategory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamInfo" /> class.
        /// </summary>
        public StreamInfo()
        {
        }

    }
}