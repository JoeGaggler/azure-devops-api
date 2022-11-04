namespace Pingmint.AzureDevOps.Model;

public interface IAzdoCountResult
{
    int? Count { get; }
}

public interface IAzdoValueCollectionResult<TCollection, TItem> : IAzdoCountResult
    where TCollection : ICollection<TItem>
{
    TCollection? Value { get; }
}

partial class PipelinesResult : IAzdoValueCollectionResult<List<PipelinesResultItem>, PipelinesResultItem> { }
partial class PipelineRunsResult : IAzdoValueCollectionResult<List<PipelineRunsResultItem>, PipelineRunsResultItem> { }
