namespace Pingmint.AzureDevOps.Test;

using Pingmint.AzureDevOps;

public class Tests
{
    private static String GetApiKey()
    {
        var value = Environment.GetEnvironmentVariable("AZDO_API_KEY");
        Assert.That(value, Is.Not.Null);
        return value!;
    }

    private static String GetOrg()
    {
        var value = Environment.GetEnvironmentVariable("AZDO_ORG");
        Assert.That(value, Is.Not.Null);
        return value!;
    }

    private static String GetProj()
    {
        var value = Environment.GetEnvironmentVariable("AZDO_PROJECT");
        Assert.That(value, Is.Not.Null);
        return value!;
    }

    private AzdoClient client = null!;

    [SetUp]
    public void Setup()
    {
        client = new(GetOrg(), GetProj(), GetApiKey());
    }

    [Test]
    public async Task Test_get_pipelines()
    {
        var all = await client.GetPipelinesAsync();
        Assert.That(all, Is.Not.Null);
        Assert.That(all, Has.Count.GreaterThan(0));

        var pipelines = all.Value;
        Assert.That(pipelines, Is.Not.Null);
        Assert.That(pipelines, Has.Count.GreaterThan(0));
    }
}
