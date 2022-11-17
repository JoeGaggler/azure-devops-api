namespace Pingmint.AzureDevOps;

public partial class UrlHelper
{
    private const String DefaultApiVersion = "7.1-preview.1";
    private readonly String organization;
    private readonly String project;

    public UrlHelper(String organization, String project)
    {
        this.organization = organization;
        this.project = project;
    }

    public String DevAzureUrlString => $"https://dev.azure.com/{organization}/{project}";

    public String ReleaseMgmtUrlString => $"https://vsrm.dev.azure.com/{organization}/{project}";

    public Uri GitBranchStats(String repositoryId, String branchName, String apiVersion = DefaultApiVersion) => new($"{DevAzureUrlString}/_apis/git/repositories/{repositoryId}/stats/branches?name={branchName}&{apiVersion}");

    // TODO: &diffCommonCommit={diffCommonCommit}
    public Uri GitDiffs(String repositoryId, String baseVersion, String targetVersion, String baseVersionOptions = "none", String baseVersionType = "commit", String targetVersionOptions = "none", String targetVersionType = "commit", int? top = null, int? skip = null, String apiVersion = DefaultApiVersion) => new($"{DevAzureUrlString}/_apis/git/repositories/{repositoryId}/diffs/commits?api-version={apiVersion}&baseVersion={baseVersion}&baseVersionOptions={baseVersionOptions}&baseVersionType={baseVersionType}&targetVersion={targetVersion}&targetVersionOptions={targetVersionOptions}&targetVersionType={targetVersionType}{Parameters.Top(top)}{Parameters.Skip(skip)}");

    public Uri GitRepository(String repositoryId, String apiVersion = DefaultApiVersion) => new($"{DevAzureUrlString}/_apis/git/repositories/{repositoryId}?api-version={apiVersion}");

    public Uri Pipelines(int? top = null, String apiVersion = DefaultApiVersion) => new($"{DevAzureUrlString}/_apis/pipelines?api-version={apiVersion}{Parameters.Top(top)}");

    public Uri PullRequestThreads(String repositoryId, int pullRequestId, String apiVersion = DefaultApiVersion) => new($"{DevAzureUrlString}/_apis/git/repositories/{repositoryId}/pullRequests/{pullRequestId}/threads?api-version={apiVersion}");

    public Uri PullRequestThread(String repositoryId, int pullRequestId, int threadId, String apiVersion = DefaultApiVersion) => new($"{DevAzureUrlString}/_apis/git/repositories/{repositoryId}/pullRequests/{pullRequestId}/threads/{threadId}?api-version={apiVersion}");

    public Uri PullRequestThreadComments(String repositoryId, int pullRequestId, int threadId, String apiVersion = DefaultApiVersion) => new($"{DevAzureUrlString}/_apis/git/repositories/{repositoryId}/pullRequests/{pullRequestId}/threads/{threadId}/comments?api-version={apiVersion}");

    public Uri Releases(int? definitionId = null, String apiVersion = DefaultApiVersion) =>
        new($"{ReleaseMgmtUrlString}/_apis/release/releases?$expand=environments,artifacts&{apiVersion}{Parameters.DefinitionId(definitionId)}");

    public Uri ReleaseEnvironment(int releaseId, int environmentId, String apiVersion = DefaultApiVersion) => new Uri($"{ReleaseMgmtUrlString}/_apis/Release/releases/{releaseId}/environments/{environmentId}?{apiVersion}");

    public Uri ReleaseDefinitions(String apiVersion = DefaultApiVersion) => new($"{ReleaseMgmtUrlString}/_apis/release/definitions?{apiVersion}");


    public Uri Run(int pipelineId, int runId, String apiVersion = DefaultApiVersion) => new($"{DevAzureUrlString}/_apis/pipelines/{pipelineId}/runs/{runId}?{apiVersion}");

    public Uri Runs(int pipelineId, String apiVersion = DefaultApiVersion) => new($"{DevAzureUrlString}/_apis/pipelines/{pipelineId}/runs?{apiVersion}");
}

partial class UrlHelper
{
    private static class Parameters
    {
        public static String Skip(Int32? top = null) => top is { } value ? $"&$skip={value}" : "";
        public static String Top(Int32? top = null) => top is { } value ? $"&$top={value}" : "";
        public static String DefinitionId(Int32? id = null) => id is { } value ? $"&definitionId={value}" : "";
    }
}
