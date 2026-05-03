
#nullable enable

namespace AudD
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EnterpriseRecognizeRequest
    {
        /// <summary>
        /// URL of the file or page to scan.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Audio or video file to scan.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        public byte[]? File { get; set; }

        /// <summary>
        /// Audio or video file to scan.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// Set to true to request accurate start and end offsets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accurate_offsets")]
        public string? AccurateOffsets { get; set; }

        /// <summary>
        /// Number of 12-second chunks skipped after recognized chunks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skip")]
        public int? Skip { get; set; }

        /// <summary>
        /// Number of chunks to recognize in a row.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("every")]
        public int? Every { get; set; }

        /// <summary>
        /// Upper bound for the number of chunks to recognize.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Seconds to skip before starting recognition.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skip_first_seconds")]
        public int? SkipFirstSeconds { get; set; }

        /// <summary>
        /// Set to true to use time information from the submitted URL as skip_first_seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_timecode")]
        public string? UseTimecode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnterpriseRecognizeRequest" /> class.
        /// </summary>
        /// <param name="url">
        /// URL of the file or page to scan.
        /// </param>
        /// <param name="file">
        /// Audio or video file to scan.
        /// </param>
        /// <param name="filename">
        /// Audio or video file to scan.
        /// </param>
        /// <param name="accurateOffsets">
        /// Set to true to request accurate start and end offsets.
        /// </param>
        /// <param name="skip">
        /// Number of 12-second chunks skipped after recognized chunks.
        /// </param>
        /// <param name="every">
        /// Number of chunks to recognize in a row.
        /// </param>
        /// <param name="limit">
        /// Upper bound for the number of chunks to recognize.
        /// </param>
        /// <param name="skipFirstSeconds">
        /// Seconds to skip before starting recognition.
        /// </param>
        /// <param name="useTimecode">
        /// Set to true to use time information from the submitted URL as skip_first_seconds.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnterpriseRecognizeRequest(
            string? url,
            byte[]? file,
            string? filename,
            string? accurateOffsets,
            int? skip,
            int? every,
            int? limit,
            int? skipFirstSeconds,
            string? useTimecode)
        {
            this.Url = url;
            this.File = file;
            this.Filename = filename;
            this.AccurateOffsets = accurateOffsets;
            this.Skip = skip;
            this.Every = every;
            this.Limit = limit;
            this.SkipFirstSeconds = skipFirstSeconds;
            this.UseTimecode = useTimecode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnterpriseRecognizeRequest" /> class.
        /// </summary>
        public EnterpriseRecognizeRequest()
        {
        }
    }
}