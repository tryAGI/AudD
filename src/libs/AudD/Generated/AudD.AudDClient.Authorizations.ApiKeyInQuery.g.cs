
#nullable enable

namespace AudD
{
    public sealed partial class AudDClient
    {

        /// <inheritdoc/>
        public void AuthorizeUsingApiKeyInQuery(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            for (var i = Authorizations.Count - 1; i >= 0; i--)
            {
                var __authorization = Authorizations[i];
                if (__authorization.Type == "ApiKey" &&
                    __authorization.Location == "Query" &&
                    __authorization.Name == "api_token")
                {
                    Authorizations.RemoveAt(i);
                }
            }

            Authorizations.Add(new global::AudD.EndPointAuthorization
            {
                Type = "ApiKey",
                SchemeId = "ApikeyApiToken",
                Location = "Query",
                Name = "api_token",
                Value = apiKey,
            });
        }
    }
}