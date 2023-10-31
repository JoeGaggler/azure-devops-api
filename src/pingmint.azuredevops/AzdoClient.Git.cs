namespace Pingmint.AzureDevOps;

partial class AzdoClient
{
    public async Task<Model.GitMergeResult> PostGitMergeAsync(String repositoryNameOrId, Model.GitMergeRequest request, Boolean includeLinks = true)
    {
        var json = Serialize(request, Model.JsonSerializer.GitMergeRequest);
        var url = urlHelper.GitMerges(repositoryNameOrId, includeLinks);
        var json2 = await PostJsonStringAsync(url, json);
        return Deserialize(json2, Model.JsonSerializer.GitMergeResult);
    }

    public async Task<Model.GitMergeResult> GetGitMergeOperationAsync(String repositoryNameOrId, int mergeOperationId, Boolean includeLinks = true) =>
        await GetterAsync(u => u.GitMergeOperation(repositoryNameOrId, mergeOperationId, includeLinks), Model.JsonSerializer.GitMergeResult);

    public async Task<Model.GitRefResult> GetGitRefsAsync(String repositoryNameOrId) =>
        await GetterAsync(u => u.GitRefs(repositoryNameOrId), Model.JsonSerializer.GitRefResult);

    public async Task<Model.GitRefUpdateResponse> PostGitRefsAsync(String repositoryNameOrId, Model.GitRefUpdate request)
    {
        var json = "[" + Serialize(request, Model.JsonSerializer.GitRefUpdate) + "]"; // HACK: array of one
        var url = urlHelper.GitRefs(repositoryNameOrId);
        var json2 = await PostJsonStringAsync(url, json);
        return Deserialize(json2, Model.JsonSerializer.GitRefUpdateResponse);
    }

    public async Task<Model.GitPullRequestResponse> GetPullRequestsByRepositoryAsync(String repositoryNameOrId) =>
        await GetterAsync(u => u.GetPullRequests(repositoryNameOrId), Model.JsonSerializer.GitPullRequestResponse);
}
