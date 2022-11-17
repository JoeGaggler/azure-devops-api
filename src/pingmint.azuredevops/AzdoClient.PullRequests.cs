namespace Pingmint.AzureDevOps;

partial class AzdoClient
{
    public async Task<Model.PullRequestThreadsResult> GetPullRequestThreadsAsync(String repositoryId, int pullRequestId) => await GetterAsync(u => u.PullRequestThreads(repositoryId, pullRequestId), Model.JsonSerializer.PullRequestThreadsResult);

    public async Task<Model.PullRequestThread> UpdatePullRequestThreadsAsync(String repositoryId, int pullRequestId, int threadId, Model.PullRequestThread model)
    {
        var url = urlHelper.PullRequestThread(repositoryId, pullRequestId, threadId);
        var response = await SendJsonAsync(url, Serialize(model, Model.JsonSerializer.PullRequestThread), HttpMethod.Patch);
        response.EnsureSuccessStatusCode();
        var responseString = await response.Content.ReadAsStringAsync();
        return Deserialize(responseString, Model.JsonSerializer.PullRequestThread);
    }

    public async Task<Model.PullRequestThreadComment> PostPullRequestThreadCommentAsync(String repositoryId, int pullRequestId, int threadId, Model.PullRequestThreadComment model)
    {
        var url = urlHelper.PullRequestThreadComments(repositoryId, pullRequestId, threadId);
        var response = await SendJsonAsync(url, Serialize(model, Model.JsonSerializer.PullRequestThreadComment), HttpMethod.Post);
        response.EnsureSuccessStatusCode();
        var responseString = await response.Content.ReadAsStringAsync();
        return Deserialize(responseString, Model.JsonSerializer.PullRequestThreadComment);
    }
}
