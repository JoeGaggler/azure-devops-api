namespace Pingmint.AzureDevOps;

public partial class UrlHelper
{
    private const String DefaultApiVersion = "7.1-preview.1";
    private const String Version72preview1 = "7.2-preview.1";
    private readonly String organization;
    private readonly String project;

    public UrlHelper(String organization, String project)
    {
        this.organization = organization;
        this.project = project;
    }

    public String DevAzureUrlString => $"https://dev.azure.com/{organization}/{project}";

    public String ReleaseMgmtUrlString => $"https://vsrm.dev.azure.com/{organization}/{project}";

    public Uri GitBranchStats(String repositoryId, String branchName, String apiVersion = DefaultApiVersion) => new($"{DevAzureUrlString}/_apis/git/repositories/{repositoryId}/stats/branches?name={branchName}&api-version={apiVersion}");

    // TODO: &diffCommonCommit={diffCommonCommit}
    public Uri GitDiffs(String repositoryId, String baseVersion, String targetVersion, String baseVersionOptions = "none", String baseVersionType = "commit", String targetVersionOptions = "none", String targetVersionType = "commit", int? top = null, int? skip = null, String apiVersion = DefaultApiVersion) => new($"{DevAzureUrlString}/_apis/git/repositories/{repositoryId}/diffs/commits?api-version={apiVersion}&baseVersion={baseVersion}&baseVersionOptions={baseVersionOptions}&baseVersionType={baseVersionType}&targetVersion={targetVersion}&targetVersionOptions={targetVersionOptions}&targetVersionType={targetVersionType}{Parameters.Top(top)}{Parameters.Skip(skip)}");

    public Uri GitRepository(String repositoryId, String apiVersion = DefaultApiVersion) => new($"{DevAzureUrlString}/_apis/git/repositories/{repositoryId}?api-version={apiVersion}");

    public Uri Pipelines(int? top = null, String apiVersion = DefaultApiVersion) => new($"{DevAzureUrlString}/_apis/pipelines?api-version={apiVersion}{Parameters.Top(top)}");

    public Uri Releases(int? definitionId = null, String apiVersion = DefaultApiVersion) =>
        new($"{ReleaseMgmtUrlString}/_apis/release/releases?$expand=environments,artifacts&{apiVersion}{Parameters.DefinitionId(definitionId)}");

    public Uri ReleaseEnvironment(int releaseId, int environmentId, String apiVersion = DefaultApiVersion) => new Uri($"{ReleaseMgmtUrlString}/_apis/Release/releases/{releaseId}/environments/{environmentId}?api-version={apiVersion}");

    public Uri ReleaseDefinitions(String apiVersion = DefaultApiVersion) => new($"{ReleaseMgmtUrlString}/_apis/release/definitions?api-version={apiVersion}");


    public Uri Run(int pipelineId, int runId, String apiVersion = DefaultApiVersion) => new($"{DevAzureUrlString}/_apis/pipelines/{pipelineId}/runs/{runId}?api-version={apiVersion}");

    public Uri Runs(int pipelineId, String apiVersion = DefaultApiVersion) => new($"{DevAzureUrlString}/_apis/pipelines/{pipelineId}/runs?api-version={apiVersion}");

    public Uri GitMerges(String repositoryNameOrId, Boolean includeLinks = true, String apiVersion = Version72preview1) => new($"{DevAzureUrlString}/_apis/git/repositories/{repositoryNameOrId}/merges?includeLinks={includeLinks}&api-version={apiVersion}");

    public Uri GitMergeOperation(String repositoryNameOrId, int mergeOperationId, Boolean includeLinks = true, String apiVersion = Version72preview1) => new($"{DevAzureUrlString}/_apis/git/repositories/{repositoryNameOrId}/merges/{mergeOperationId}?includeLinks={includeLinks}&api-version={apiVersion}");

    public Uri GitRefs(String repositoryId, String? projectId = null, String apiVersion = Version72preview1) =>
        new($"{DevAzureUrlString}/_apis/git/repositories/{repositoryId}/refs?api-version={apiVersion}{Parameters.ProjectId(projectId)}");

    public Uri GetPullRequests(String repositoryId, String apiVersion = Version72preview1) =>
        new($"{DevAzureUrlString}/_apis/git/repositories/{repositoryId}/pullrequests?api-version={apiVersion}");

    public Uri GetPullRequestStatuses(String repositoryId, Int32 pullRequestId, String apiVersion = Version72preview1) =>
        new($"{DevAzureUrlString}/_apis/git/repositories/{repositoryId}/pullRequests/{pullRequestId}/statuses?api-version={apiVersion}");
}

partial class UrlHelper
{
    private static class Parameters
    {
        public static String Skip(Int32? top = null) => top is { } value ? $"&$skip={value}" : "";
        public static String Top(Int32? top = null) => top is { } value ? $"&$top={value}" : "";
        public static String DefinitionId(Int32? id = null) => id is { } value ? $"&definitionId={value}" : "";
        public static String ProjectId(String? id = null) => id is { } value ? $"&projectId={value}" : "";
        public static String Filter(String? filter = null) => filter is { } value ? $"&filter={Uri.EscapeDataString(value)}" : "";
    }
}
