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
        var all = await client.GetRunsAsync(1652);
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

        Console.WriteLine(repo.DefaultBranch);
        var stats = await client.GetGitStatsAsync(repositoryId, repo.DefaultBranch);
        var commit = stats.Commit;
        Assert.That(commit, Is.Not.Null);
        var commitId = commit.commitId;
        Assert.That(commitId, Is.Not.Empty);
        var parentId = "f65b40b840e3531f9edb7d879d53481de987bfe9";

        var pipelineId = 1274;
        var runs = await client.GetRunsAsync(1274);
        var firstRun = runs.Value.First();
        var runId = firstRun.Id.Value;
        var run = await client.GetRunAsync(pipelineId, runId);
        // var json1 = AzdoClient.Serialize(run, Model.JsonSerializer.Run);
        // Console.WriteLine(client.Urls.Run(pipelineId, runId));
        // Console.WriteLine(json1);
        var targetId = run.Resources.Repositories.All["self"].Version;


        var diffs = await client.GetGitDiffsAsync(repositoryId, baseVersion: commitId, baseVersionType: "commit", targetVersion: targetId, targetVersionType: "commit");
        // var json = AzdoClient.Serialize(diffs, Model.JsonSerializer.GitDiffs);
        // Console.WriteLine(json);
    }

    [Test]
    public async Task Test_get_releases()
    {
        var all = await client.GetReleasesAsync(43);
        var json = AzdoClient.Serialize(all, Model.JsonSerializer.ReleasesResult);

        // Console.WriteLine(json);
        // File.WriteAllText("../../../all.json", json);
        var sql = all.Value;
        foreach (var s in sql)
        {
            // var env = await client.GetReleaseEnvironmentAsync(s.Id.Value, 282);
            var env = s.environments.First(i => i.definitionEnvironmentId == 282);
            var art = s.artifacts.First(i => i.alias == "sql");
            Console.WriteLine($"{s.name} - {s.status} - {env.status} - {art.alias} - {art.definitionReference.sourceVersion.id}");
        }
    }

    [Test]
    public async Task Test_get_release_definitions()
    {
        var all = await client.GetReleaseDefinitionsAsync();

        var sql = all.Value.First(i => i.Id == 43);
        var sql2 = await client.GetReleaseDefinitionAsync(new Uri(sql.url));
        var json = await client.GetStringAsync(new Uri(sql.url));
        File.WriteAllText("../../../all.json", json);
    }
}
