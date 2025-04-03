namespace Pingmint.AzureDevOps;

partial class AzdoClient
{
    public async Task<Model.GitMergeResult> PostGitMergeAsync(String repositoryNameOrId, Model.GitMergeRequest request, Boolean includeLinks = true)
    {
        var json = Serialize(request);
        var url = urlHelper.GitMerges(repositoryNameOrId, includeLinks);
        var json2 = await PostJsonStringAsync(url, json);
        return Deserialize<Model.GitMergeResult>(json2, Model.JsonSerializer.Deserialize);
    }

    public async Task<Model.GitMergeResult> GetGitMergeOperationAsync(String repositoryNameOrId, int mergeOperationId, Boolean includeLinks = true) =>
        await GetterAsync<Model.GitMergeResult>(u => u.GitMergeOperation(repositoryNameOrId, mergeOperationId, includeLinks), Model.JsonSerializer.Deserialize);

    public async Task<Model.GitRefResult> GetGitRefsAsync(String repositoryNameOrId) =>
        await GetterAsync<Model.GitRefResult>(u => u.GitRefs(repositoryNameOrId), Model.JsonSerializer.Deserialize);

    public async Task<Model.GitRefUpdateResponse> PostGitRefsAsync(String repositoryNameOrId, Model.GitRefUpdate request)
    {
        var json = "[" + Serialize(request) + "]"; // HACK: array of one
        var url = urlHelper.GitRefs(repositoryNameOrId);
        var json2 = await PostJsonStringAsync(url, json);
        return Deserialize<Model.GitRefUpdateResponse>(json2, Model.JsonSerializer.Deserialize);
    }

    public async Task<Model.GitPullRequest> GetPullRequestByIdAsync(int prId) =>
        await GetterAsync<Model.GitPullRequest>(u => u.PullRequest(prId), Model.JsonSerializer.Deserialize);

    public async Task<Model.GitPullRequestResponse> GetPullRequestsByRepositoryAsync(String repositoryNameOrId) =>
        await GetterAsync<Model.GitPullRequestResponse>(u => u.GetPullRequests(repositoryNameOrId), Model.JsonSerializer.Deserialize);

    public async Task<Model.GitPullRequestStatusesResponse> GetPullRequestStatusesAsync(String repositoryNameOrId, Int32 pullRequestId) =>
        await GetterAsync<Model.GitPullRequestStatusesResponse>(u => u.GetPullRequestStatuses(repositoryNameOrId, pullRequestId), Model.JsonSerializer.Deserialize);

    public async Task<Model.GitPullRequestStatus> PostPullRequestStatusesAsync(String repositoryNameOrId, Int32 pullRequestId, Model.CreateGitPullRequestStatusesRequest request)
    {
        var json = Serialize(request);
        var url = urlHelper.GetPullRequestStatuses(repositoryNameOrId, pullRequestId);
        var json2 = await PostJsonStringAsync(url, json);
        return Deserialize<Model.GitPullRequestStatus>(json2, Model.JsonSerializer.Deserialize);
    }

    public async Task RemovePullRequestStatusesAsync(String repositoryNameOrId, Int32 pullRequestId, Int32 statusId)
    {
        var json = $$"""
            [
                {
                    "op": "remove",
                    "path": "/{{statusId}}",
                    "from": null,
                    "value": null
                }
            ]
            """;
        var url = urlHelper.GetPullRequestStatuses(repositoryNameOrId, pullRequestId);
        var json2 = await PatchJsonStringAsync(url, json);
    }
}
