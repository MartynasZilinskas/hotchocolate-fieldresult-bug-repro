using Graphql.ApiService.Contracts;

namespace GettingStarted.Types;

[QueryType]
public static class Query
{
    public static Book GetBook()
        => new Book(Guid.NewGuid(), "C# in depth.", Guid.NewGuid(), Guid.NewGuid());
}
