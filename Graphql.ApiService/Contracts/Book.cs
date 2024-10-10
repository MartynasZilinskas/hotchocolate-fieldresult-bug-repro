namespace Graphql.ApiService.Contracts;

public record Book(Guid Id, string Title, Guid CreatedBy, Guid ModifiedBy);
