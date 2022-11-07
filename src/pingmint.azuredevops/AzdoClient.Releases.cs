namespace Pingmint.AzureDevOps;

partial class AzdoClient
{
    public async Task<Model.ReleasesResult> GetReleasesAsync(int? definitionId = null) => await GetterAsync(u => u.Releases(definitionId: definitionId), Model.JsonSerializer.ReleasesResult);
    public async Task<Model.ReleaseEnvironment> GetReleaseEnvironmentAsync(int releaseId, int environmentId) => await GetterAsync(u => u.ReleaseEnvironment(releaseId, environmentId), Model.JsonSerializer.ReleaseEnvironment);
    public async Task<Model.ReleaseDefinition> GetReleaseDefinitionAsync(Uri url) => await GetterAsync(_ => url, Model.JsonSerializer.ReleaseDefinition);
    public async Task<Model.ReleaseDefinitionsResult> GetReleaseDefinitionsAsync() => await GetterAsync(u => u.ReleaseDefinitions(), Model.JsonSerializer.ReleaseDefinitionsResult);

}
