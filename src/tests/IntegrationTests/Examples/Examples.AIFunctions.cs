namespace Polar.IntegrationTests;

[TestClass]
public partial class Examples
{
    [TestMethod]
    public void AIFunctions()
    {
        //// Use Polar tools with any MEAI-compatible AI provider
        using var client = new PolarClient(apiKey: "test");
        var tools = client.AsTools();
        tools.Count.Should().BeGreaterThan(0);
    }
}
