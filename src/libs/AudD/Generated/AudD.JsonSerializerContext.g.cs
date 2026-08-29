
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace AudD
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::AudD.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AudD.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AudD.RecognizeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AudD.EnterpriseRecognizeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AudD.RecognitionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AudD.RecognitionResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AudD.NullResultResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AudD.GetCallbackUrlResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AudD.GetStreamsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AudD.StreamInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AudD.StreamInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AudD.LongPollResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AudD.EnterpriseRecognitionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AudD.EnterpriseSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AudD.EnterpriseSegment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AudD.EnterpriseSong>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AudD.EnterpriseSong))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AudD.SetCallbackUrlRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AudD.AddStreamRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AudD.SetStreamUrlRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AudD.DeleteStreamRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AudD.StreamInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AudD.EnterpriseSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AudD.EnterpriseSong>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}