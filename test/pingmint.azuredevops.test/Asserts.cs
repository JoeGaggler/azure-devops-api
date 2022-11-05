using Pingmint.AzureDevOps.Model;

namespace Pingmint.AzureDevOps.Test;

public static class ApiAssert
{
    public static void CollectionResultHasItems<TResult>(TResult result)
        where TResult : IAzdoCountResult
    {
        Assert.That(result, Is.Not.Null);
        Assert.That(result, Has.Count.GreaterThan(0));
    }
}
