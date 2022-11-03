namespace Pingmint.AzureDevOps;

public partial class UrlHelper
{
    private readonly String organization;
    private readonly String project;

    public UrlHelper(String organization, String project)
    {
        this.organization = organization;
        this.project = project;
    }

    public String ProjectUrlString => $"https://dev.azure.com/{organization}/{project}";

    public Uri Pipelines(int? top = null, String apiVersion = "7.1-preview.1") => new($"{ProjectUrlString}/_apis/pipelines?api-version={apiVersion}{Parameters.Top(top)}");
}

partial class UrlHelper
{
    private static class Parameters
    {
        public static String Top(Int32? top = null) => top is { } value ? $"&$top={value}" : "";
    }
}
