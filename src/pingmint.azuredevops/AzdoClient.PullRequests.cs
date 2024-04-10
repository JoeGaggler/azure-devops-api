namespace Pingmint.AzureDevOps;

partial class AzdoClient
{
    public async Task<Model.PullRequestThreadsResult> GetPullRequestThreadsAsync(String repositoryId, int pullRequestId) =>
        await GetterAsync<Model.PullRequestThreadsResult>(u => u.PullRequestThreads(repositoryId, pullRequestId), Model.JsonSerializer.Deserialize);

    public async Task<Model.PullRequestThread> UpdatePullRequestThreadsAsync(String repositoryId, int pullRequestId, int threadId, Model.PullRequestThread model)
    {
        var url = urlHelper.PullRequestThread(repositoryId, pullRequestId, threadId);
        var responseString = await SendJsonStringAsync(url, Serialize(model), HttpMethod.Patch);
        return Deserialize<Model.PullRequestThread>(responseString, Model.JsonSerializer.Deserialize);
    }

    public async Task<Model.PullRequestThreadComment> PostPullRequestThreadCommentAsync(String repositoryId, int pullRequestId, int threadId, Model.PullRequestThreadComment model)
    {
        var url = urlHelper.PullRequestThreadComments(repositoryId, pullRequestId, threadId);
        var responseString = await SendJsonStringAsync(url, Serialize(model), HttpMethod.Post);
        return Deserialize<Model.PullRequestThreadComment>(responseString, Model.JsonSerializer.Deserialize);
    }
}
