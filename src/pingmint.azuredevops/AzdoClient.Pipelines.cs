namespace Pingmint.AzureDevOps;

partial class AzdoClient
{


    public async Task<Model.PipelinesResult> GetPipelinesAsync() => await GetterAsync(u => u.Pipelines(top: null), Model.JsonSerializer.PipelinesResult);

    public async Task<Model.Run> GetRunAsync(int pipelineId, int runId) => await GetterAsync(u => u.Run(pipelineId, runId), Model.JsonSerializer.Run);

    public async Task<Model.RunsResult> GetRunsAsync(int pipelineId) => await GetterAsync(u => u.Runs(pipelineId), Model.JsonSerializer.RunsResult);

    public async Task<Model.GitRepository> GetGitRepositoryAsync(String repositoryId) => await GetterAsync(u => u.GitRepository(repositoryId), Model.JsonSerializer.GitRepository);

    public async Task<Model.GitBranchStats> GetGitStatsAsync(String repositoryId, String branchName) => await GetterAsync(u => u.GitBranchStats(repositoryId, branchName), Model.JsonSerializer.GitBranchStats);

    public async Task<Model.GitDiffs> GetGitDiffsAsync(String repositoryId, String baseVersion, String targetVersion, String baseVersionType = "commit", String targetVersionType = "commit") =>
        await GetterAsync(u => u.GitDiffs(repositoryId, baseVersion: baseVersion, targetVersion: targetVersion, baseVersionType: baseVersionType, targetVersionType: targetVersionType), Model.JsonSerializer.GitDiffs);
}
