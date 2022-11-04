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

    // [Test]
    // public async Task Test_get_pipeline_runs()
    // {
    //     var url = client.Urls.Pipelines();
    //     var json = await client.GetStringAsync(url);
    //     Console.WriteLine(json);
    //     File.WriteAllText("../../../all.json", json);
    // }

    [Test]
    public async Task Test_get_pipelines()
    {
        var all = await client.GetPipelinesAsync();
        ApiAssert.CollectionResultHasItems(all);

        var pipelines = all.Value;
        Assert.That(pipelines, Is.Not.Null);
        Assert.That(pipelines, Has.Count.GreaterThan(0));

        var first = pipelines.First();
        Assert.Multiple(() =>
        {
            Assert.That(first.Folder, Is.Not.Empty);
            Assert.That(first.Name, Is.Not.Empty);
            Assert.That(first.Id, Is.Not.Null);
            Assert.That(first.Revision, Is.Not.Null);
            Assert.That(first.Url, Is.Not.Empty);
            Assert.That(first.Links, Is.Not.Null);
        });
    }

    [Test]
    public async Task Test_get_pipeline_runs()
    {
        var all = await client.GetPipelineRunsAsync(1652);
        ApiAssert.CollectionResultHasItems(all);

        var first = all.Value.First();
    }

    [Test]
    public async Task Test_get_repository()
    {
        var repositoryId = "terraform";
        var repo = await client.GetGitRepositoryAsync(repositoryId);
        Assert.That(repo, Is.Not.Null);
        Assert.That(repo.DefaultBranch, Is.Not.Empty);

        var stats = await client.GetGitStatsAsync(repositoryId, "master");
        var commitId = stats.Commit.commitId;
        var parentId = "f65b40b840e3531f9edb7d879d53481de987bfe9";

        var diffs = await client.GetGitDiffsAsync(repositoryId, baseVersion: commitId, baseVersionType: "commit", targetVersion: parentId, targetVersionType: "commit");
        var json = AzdoClient.Serialize(diffs, Model.JsonSerializer.GitDiffs);
        Console.WriteLine(json);
    }
}
