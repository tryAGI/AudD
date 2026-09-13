
#nullable enable

namespace AudD
{
    public partial interface IRecognitionClient
    {
        /// <summary>
        /// Authorize using ApiKey authentication.
        /// </summary>
        /// <param name="apiKey"></param>

        public void AuthorizeUsingApiKeyInQuery(
            string apiKey);
    }
}