namespace Pingmint.AzureDevOps;

partial class AzdoClient
{
    public async Task<Model.ReleasesResult> GetReleasesAsync(int? definitionId = null) => await GetterAsync<Model.ReleasesResult>(u => u.Releases(definitionId: definitionId), Model.JsonSerializer.Deserialize);
    public async Task<Model.ReleaseEnvironment> GetReleaseEnvironmentAsync(int releaseId, int environmentId) => await GetterAsync<Model.ReleaseEnvironment>(u => u.ReleaseEnvironment(releaseId, environmentId), Model.JsonSerializer.Deserialize);
    public async Task<Model.ReleaseDefinition> GetReleaseDefinitionAsync(Uri url) => await GetterAsync<Model.ReleaseDefinition>(_ => url, Model.JsonSerializer.Deserialize);
    public async Task<Model.ReleaseDefinitionsResult> GetReleaseDefinitionsAsync() => await GetterAsync<Model.ReleaseDefinitionsResult>(u => u.ReleaseDefinitions(), Model.JsonSerializer.Deserialize);

}
