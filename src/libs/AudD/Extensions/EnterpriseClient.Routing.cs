#nullable enable

namespace AudD;

public partial class EnterpriseClient
{
#pragma warning disable CA1822 // Partial method signature is generated as an instance method.
    partial void PrepareRecognizeEnterpriseRequest(
        global::System.Net.Http.HttpClient httpClient,
        global::System.Net.Http.HttpRequestMessage httpRequestMessage,
        global::AudD.EnterpriseRecognizeRequest request)
    {
        var uri = httpRequestMessage.RequestUri;
        if (uri is null)
        {
            return;
        }

        var builder = uri.IsAbsoluteUri
            ? new global::System.UriBuilder(uri)
            : new global::System.UriBuilder(new global::System.Uri(httpClient.BaseAddress!, uri));

        builder.Scheme = global::System.Uri.UriSchemeHttps;
        builder.Host = "enterprise.audd.io";
        builder.Port = -1;
        builder.Path = "/";

        httpRequestMessage.RequestUri = builder.Uri;
    }
#pragma warning restore CA1822
}
