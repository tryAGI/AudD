
#nullable enable

namespace AudD
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RecognitionResult
    {
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
        [global::System.Text.Json.Serialization.JsonPropertyName("song_link")]
        public string? SongLink { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RecognitionResult" /> class.
        /// </summary>
        /// <param name="artist"></param>
        /// <param name="title"></param>
        /// <param name="album"></param>
        /// <param name="releaseDate"></param>
        /// <param name="label"></param>
        /// <param name="timecode"></param>
        /// <param name="songLink"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RecognitionResult(
            string? artist,
            string? title,
            string? album,
            string? releaseDate,
            string? label,
            string? timecode,
            string? songLink)
        {
            this.Artist = artist;
            this.Title = title;
            this.Album = album;
            this.ReleaseDate = releaseDate;
            this.Label = label;
            this.Timecode = timecode;
            this.SongLink = songLink;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecognitionResult" /> class.
        /// </summary>
        public RecognitionResult()
        {
        }
    }
}