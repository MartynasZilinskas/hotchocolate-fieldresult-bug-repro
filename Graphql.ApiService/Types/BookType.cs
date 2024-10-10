using Graphql.ApiService.Contracts;

namespace Graphql.ApiService.Types;

[ObjectType<Book>]
public static partial class BookType
{
    static partial void Configure(IObjectTypeDescriptor<Book> descriptor)
    {
        descriptor.BindFieldsExplicitly();

        descriptor.Field(x => x.Id).ID();
        descriptor.Field(x => x.Title);
        descriptor.Field(x => x.CreatedBy).ResolveWith<AuthorResolver>(x => x.ResolveAuthor(default!));
        descriptor.Field(x => x.ModifiedBy).ResolveWith<AuthorResolver>(x => x.ResolveFieldResultAuthor(default!));
    }
}

public class AuthorResolver
{
    public FieldResult<Author> ResolveFieldResultAuthor([Parent] Book book)
    {
        return new Author(book.CreatedBy, "Author Name");
    }

    public Author ResolveAuthor([Parent] Book book)
    {
        return new Author(book.CreatedBy, "Author Name");
    }
}
