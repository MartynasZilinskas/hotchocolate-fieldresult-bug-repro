using Graphql.ApiService.Contracts;

namespace Graphql.ApiService.Types;

[ObjectType<Author>]
public static partial class AuthorType
{
    static partial void Configure(IObjectTypeDescriptor<Author> descriptor)
    {
        descriptor.BindFieldsExplicitly();

        descriptor.Field(x => x.Id).ID();
        descriptor.Field(x => x.Name);
        // descriptor.Field(x => x.CreatedBy).ResolveUserWithCreatableResolver();
    }
}