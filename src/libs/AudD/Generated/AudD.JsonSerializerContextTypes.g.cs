
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace AudD
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::AudD.RecognizeRequest? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AudD.EnterpriseRecognizeRequest? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AudD.RecognitionResponse? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AudD.RecognitionResult? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AudD.NullResultResponse? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AudD.GetCallbackUrlResponse? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AudD.GetStreamsResponse? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::AudD.StreamInfo>? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AudD.StreamInfo? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AudD.LongPollResponse? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AudD.EnterpriseRecognitionResponse? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::AudD.EnterpriseSegment>? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AudD.EnterpriseSegment? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::AudD.EnterpriseSong>? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AudD.EnterpriseSong? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AudD.SetCallbackUrlRequest? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AudD.AddStreamRequest? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AudD.SetStreamUrlRequest? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AudD.DeleteStreamRequest? Type24 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::AudD.StreamInfo>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::AudD.EnterpriseSegment>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::AudD.EnterpriseSong>? ListType2 { get; set; }
    }
}