namespace Pingmint.AzureDevOps;

partial class AzdoClient
{
    public async Task<Model.PipelinesResult> GetPipelinesAsync()
    {
        var url = urlHelper.Pipelines(top: null);
        var json = await GetStringAsync(url);
        return Deserialize(json, Model.JsonSerializer.PipelinesResult);
    }

    public async Task<Model.RunsResult> GetPipelineRunsAsync(int pipelineId)
    {
        var url = urlHelper.PipelineRuns(pipelineId);
        var json = await GetStringAsync(url);
        return Deserialize(json, Model.JsonSerializer.RunsResult);
    }

    public async Task<Model.GitRepository> GetGitRepositoryAsync(String repositoryId)
    {
        var url = urlHelper.GitRepository(repositoryId);
        var json = await GetStringAsync(url);
        return Deserialize(json, Model.JsonSerializer.GitRepository);
    }

    public async Task<Model.GitBranchStats> GetGitStatsAsync(String repositoryId, String branchName)
    {
        var url = urlHelper.GitBranchStats(repositoryId, branchName);
        var json = await GetStringAsync(url);
        return Deserialize(json, Model.JsonSerializer.GitBranchStats);
    }

    public async Task<Model.GitDiffs> GetGitDiffsAsync(String repositoryId, String baseVersion, String targetVersion, String baseVersionType = "commit", String targetVersionType = "commit")
    {
        var url = urlHelper.GitDiffs(repositoryId, baseVersion: baseVersion, targetVersion: targetVersion, baseVersionType: baseVersionType, targetVersionType: targetVersionType);
        var json = await GetStringAsync(url);
        return Deserialize(json, Model.JsonSerializer.GitDiffs);
    }
}
