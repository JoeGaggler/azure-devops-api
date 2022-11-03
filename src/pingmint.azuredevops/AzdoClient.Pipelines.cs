namespace Pingmint.AzureDevOps;

partial class AzdoClient
{
    public async Task<Model.PipelinesResults> GetPipelinesAsync()
    {
        var url = urlHelper.Pipelines(top: null);
        var json = await GetStringAsync(url);
        return Deserialize(json, Model.JsonSerializer.PipelinesResults);
    }
}
