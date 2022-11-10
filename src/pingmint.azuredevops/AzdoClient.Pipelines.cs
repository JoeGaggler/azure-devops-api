namespace Pingmint.AzureDevOps;

partial class AzdoClient
{
    public async Task<Model.PipelinesResult> GetPipelinesAsync() => await GetterAsync(u => u.Pipelines(top: null), Model.JsonSerializer.PipelinesResult);

    public async Task<Model.Run> GetRunAsync(int pipelineId, int runId) => await GetterAsync(u => u.Run(pipelineId, runId), Model.JsonSerializer.Run);

    public async Task<Model.RunsResult> GetRunsAsync(int pipelineId) => await GetterAsync(u => u.Runs(pipelineId), Model.JsonSerializer.RunsResult);

    public async Task<Model.GitRepository> GetGitRepositoryAsync(String repositoryId) => await GetterAsync(u => u.GitRepository(repositoryId), Model.JsonSerializer.GitRepository);

    public async Task<Model.Run> GetRunFromPipelineResourceAsync(Model.Run run, String resourceId, Int32 pipelineIdForResource)
    {
        if (run.Resources?.Pipelines?.All?[resourceId] is not { } otherResource)
        {
            throw new InvalidOperationException($"Run does not have pipeline resource: {resourceId}");
        }

        if (otherResource.Pipeline is not {} otherPipeline || otherPipeline.Id is not {} runId)
        {
            throw new InvalidOperationException($"Run does not have pipeline id for resource: {resourceId}");
        }

        return await GetRunAsync(pipelineIdForResource, runId);
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
        return await GetterAsync(u => u.GitBranchStats(repositoryId, branchName), Model.JsonSerializer.GitBranchStats);
    }

    public async Task<Model.GitDiffs> GetGitDiffsAsync(String repositoryId, String baseVersion, String targetVersion, String baseVersionType = "commit", String targetVersionType = "commit") =>
        await GetterAsync(u => u.GitDiffs(repositoryId, baseVersion: baseVersion, targetVersion: targetVersion, baseVersionType: baseVersionType, targetVersionType: targetVersionType), Model.JsonSerializer.GitDiffs);
}
