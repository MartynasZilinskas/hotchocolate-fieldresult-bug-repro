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
    }

    public static Author CreatedBy([Parent] Book book)
    {
        return new Author(book.CreatedBy, "Author Name");
    }

    public static FieldResult<Author> ModifiedBy([Parent] Book book)
    {
        return new Author(book.CreatedBy, "Author Name");
    }
}

