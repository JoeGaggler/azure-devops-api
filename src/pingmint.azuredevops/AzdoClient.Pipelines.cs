namespace Pingmint.AzureDevOps;

partial class AzdoClient
{
    public async Task<Model.BuildResult> GetBuildAsync(int buildId) => await GetterAsync<Model.BuildResult>(u => u.Build(buildId), Model.JsonSerializer.Deserialize);
    public async Task<Model.Pipeline> GetPipelineAsync(int pipelineId) => await GetterAsync<Model.Pipeline>(u => u.Pipeline(pipelineId), Model.JsonSerializer.Deserialize);
    public async Task<Model.PipelinesResult> GetPipelinesAsync() => await GetterAsync<Model.PipelinesResult>(u => u.Pipelines(top: null), Model.JsonSerializer.Deserialize);

    public async Task<Model.Run> GetRunAsync(Uri uri) => await GetterAsync<Model.Run>(uri, Model.JsonSerializer.Deserialize);
    public async Task<Model.Run> GetRunAsync(int pipelineId, int runId) => await GetterAsync<Model.Run>(u => u.Run(pipelineId, runId), Model.JsonSerializer.Deserialize);
    public async Task<Model.Run> StartRunAsync(int pipelineId, Model.PipelineRunRequest request) =>
        await PostJsonForJsonAsync<Model.Run>(u => u.Runs(pipelineId), SerializeToString(request, Model.JsonSerializer.Serialize), Model.JsonSerializer.Deserialize);

    public async Task<Model.RunsResult> GetRunsAsync(Uri uri) => await GetterAsync<Model.RunsResult>(uri, Model.JsonSerializer.Deserialize);
    public async Task<Model.RunsResult> GetRunsAsync(int pipelineId) => await GetterAsync<Model.RunsResult>(u => u.Runs(pipelineId), Model.JsonSerializer.Deserialize);

    public async Task<Model.GitRepository> GetGitRepositoryAsync(String repositoryId) => await GetterAsync<Model.GitRepository>(u => u.GitRepository(repositoryId), Model.JsonSerializer.Deserialize);

    public async Task<Model.Run> GetRunFromPipelineResourceAsync(Model.Run run, String resourceId, Int32 pipelineIdForResource)
    {
        if (run.Resources?.Pipelines?.All?[resourceId] is not { } otherResource)
        {
            throw new InvalidOperationException($"Run does not have pipeline resource: {resourceId}");
        }

        if (otherResource.Pipeline is not { } otherPipeline || otherPipeline.Id is not { } runId)
        {
            throw new InvalidOperationException($"Run does not have pipeline id for resource: {resourceId}");
        }

        return await GetRunAsync(pipelineIdForResource, runId);
    }

    public async Task<Model.GitDiffs> GetGitDiffsFromRunAsync(Model.Run run, String baseCommitId)
    {
        if (run.Resources is not { } runResources) { throw new InvalidOperationException("no run resources"); }
        if (runResources.Repositories is not { } runRepos) { throw new InvalidOperationException("no run repos"); }
        if (runRepos.All?["self"] is not { } self) { throw new InvalidOperationException("no selfRepo"); }
        if (self.Version is not { } targetId) { throw new InvalidOperationException("no target version"); }
        if (self.Repository?.Id is not { } repositoryId) { throw new InvalidOperationException("no repositoryId"); }
        var diffs = await this.GetGitDiffsAsync(repositoryId, baseVersion: baseCommitId, baseVersionType: "commit", targetVersion: targetId, targetVersionType: "commit");
        return diffs;
    }

    /// <summary>
    ///
    /// </summary>
    /// <param name="repositoryId">repository id, can be the repository name</param>
    /// <param name="branchName">branch name</param>
    /// <returns></returns>
    /// <remarks>
    /// It is valid for the branch name to include 'refs/heads' as a prefix.
    /// </remarks>
    public async Task<Model.GitBranchStats> GetGitStatsAsync(String repositoryId, String branchName)
    {
        const String refsHeads = "refs/heads/";
        if (branchName.StartsWith(refsHeads)) { branchName = branchName[refsHeads.Length..]; }
        return await GetterAsync<Model.GitBranchStats>(u => u.GitBranchStats(repositoryId, branchName), Model.JsonSerializer.Deserialize);
    }

    public async Task<Model.GitDiffs> GetGitDiffsAsync(String repositoryId, String baseVersion, String targetVersion, String baseVersionType = "commit", String targetVersionType = "commit") =>
        await GetterAsync<Model.GitDiffs>(u => u.GitDiffs(repositoryId, baseVersion: baseVersion, targetVersion: targetVersion, baseVersionType: baseVersionType, targetVersionType: targetVersionType), Model.JsonSerializer.Deserialize);
}
