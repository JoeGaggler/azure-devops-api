namespace Pingmint.AzureDevOps;

partial class AzdoClient
{
    public async Task<Model.PipelinesResult> GetPipelinesAsync()
    {
        var url = urlHelper.Pipelines(top: null);
        var json = await GetStringAsync(url);
        return Deserialize(json, Model.JsonSerializer.PipelinesResult);
    }

    public async Task<Model.PipelineRunsResult> GetPipelineRunsAsync(int pipelineId)
    {
        var url = urlHelper.PipelineRuns(pipelineId);
        var json = await GetStringAsync(url);
        return Deserialize(json, Model.JsonSerializer.PipelineRunsResult);
    }

    public async Task<Model.GitRepositoryResult> GetGitRepositoryAsync(String repositoryId)
    {
        var url = urlHelper.GitRepository(repositoryId);
        var json = await GetStringAsync(url);
        return Deserialize(json, Model.JsonSerializer.GitRepositoryResult);
    }

    public async Task<Model.GitBranchStatsResults> GetGitStatsAsync(String repositoryId, String branchName)
    {
        var url = urlHelper.GitBranchStats(repositoryId, branchName);
        var json = await GetStringAsync(url);
        return Deserialize(json, Model.JsonSerializer.GitBranchStatsResults);
    }

    public async Task<Model.GitDiffsResult> GetGitDiffsAsync(String repositoryId, String baseVersion, String targetVersion, String baseVersionType = "commit", String targetVersionType = "commit")
    {
        var url = urlHelper.GitDiffs(repositoryId, baseVersion: baseVersion, targetVersion: targetVersion, baseVersionType: baseVersionType, targetVersionType: targetVersionType);
        var json = await GetStringAsync(url);
        return Deserialize(json, Model.JsonSerializer.GitDiffsResult);
    }
}
