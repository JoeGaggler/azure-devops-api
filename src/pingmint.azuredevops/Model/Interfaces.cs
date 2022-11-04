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

partial class PipelinesResult : IAzdoValueCollectionResult<List<Pipeline>, Pipeline> { }
partial class RunsResult : IAzdoValueCollectionResult<List<Run>, Run> { }
