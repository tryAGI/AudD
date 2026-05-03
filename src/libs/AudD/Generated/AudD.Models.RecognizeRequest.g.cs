
#nullable enable

namespace AudD
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RecognizeRequest
    {
        /// <summary>
        /// URL of the file to recognize.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Audio or video file to recognize.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        public byte[]? File { get; set; }

        /// <summary>
        /// Audio or video file to recognize.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// Base64-encoded audio. AudD discourages this transport and supports it only in limited cases.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public string? Audio { get; set; }

        /// <summary>
        /// Comma-separated additional metadata identifiers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("return")]
        public string? Return { get; set; }

        /// <summary>
        /// Country code for Apple Music, iTunes, and Spotify results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("market")]
        public string? Market { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RecognizeRequest" /> class.
        /// </summary>
        /// <param name="url">
        /// URL of the file to recognize.
        /// </param>
        /// <param name="file">
        /// Audio or video file to recognize.
        /// </param>
        /// <param name="filename">
        /// Audio or video file to recognize.
        /// </param>
        /// <param name="audio">
        /// Base64-encoded audio. AudD discourages this transport and supports it only in limited cases.
        /// </param>
        /// <param name="return">
        /// Comma-separated additional metadata identifiers.
        /// </param>
        /// <param name="market">
        /// Country code for Apple Music, iTunes, and Spotify results.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RecognizeRequest(
            string? url,
            byte[]? file,
            string? filename,
            string? audio,
            string? @return,
            string? market)
        {
            this.Url = url;
            this.File = file;
            this.Filename = filename;
            this.Audio = audio;
            this.Return = @return;
            this.Market = market;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecognizeRequest" /> class.
        /// </summary>
        public RecognizeRequest()
        {
        }
    }
}