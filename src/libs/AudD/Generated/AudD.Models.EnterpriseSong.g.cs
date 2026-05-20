
#nullable enable

namespace AudD
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EnterpriseSong
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public int? Score { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("artist")]
        public string? Artist { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("album")]
        public string? Album { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("release_date")]
        public string? ReleaseDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timecode")]
        public string? Timecode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isrc")]
        public string? Isrc { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upc")]
        public string? Upc { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("song_link")]
        public string? SongLink { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_offset")]
        public int? StartOffset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_offset")]
        public int? EndOffset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnterpriseSong" /> class.
        /// </summary>
        /// <param name="score"></param>
        /// <param name="artist"></param>
        /// <param name="title"></param>
        /// <param name="album"></param>
        /// <param name="releaseDate"></param>
        /// <param name="label"></param>
        /// <param name="timecode"></param>
        /// <param name="isrc"></param>
        /// <param name="upc"></param>
        /// <param name="songLink"></param>
        /// <param name="startOffset"></param>
        /// <param name="endOffset"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnterpriseSong(
            int? score,
            string? artist,
            string? title,
            string? album,
            string? releaseDate,
            string? label,
            string? timecode,
            string? isrc,
            string? upc,
            string? songLink,
            int? startOffset,
            int? endOffset)
        {
            this.Score = score;
            this.Artist = artist;
            this.Title = title;
            this.Album = album;
            this.ReleaseDate = releaseDate;
            this.Label = label;
            this.Timecode = timecode;
            this.Isrc = isrc;
            this.Upc = upc;
            this.SongLink = songLink;
            this.StartOffset = startOffset;
            this.EndOffset = endOffset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnterpriseSong" /> class.
        /// </summary>
        public EnterpriseSong()
        {
        }

    }
}