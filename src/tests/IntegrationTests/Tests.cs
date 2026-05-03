namespace AudD.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static AudDClient GetAuthenticatedClient()
    {
        var apiToken =
            Environment.GetEnvironmentVariable("AUDD_API_TOKEN") is { Length: > 0 } tokenValue ? tokenValue :
            Environment.GetEnvironmentVariable("AUDD_API_KEY") is { Length: > 0 } keyValue ? keyValue :
            throw new AssertInconclusiveException("AUDD_API_TOKEN environment variable is not found.");

        var client = new AudDClient(apiToken);
        
        return client;
    }
}
