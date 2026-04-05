namespace Polar.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static PolarClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("POLAR_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("POLAR_API_KEY environment variable is not found.");

        var client = new PolarClient(apiKey);
        
        return client;
    }
}
