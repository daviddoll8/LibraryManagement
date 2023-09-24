using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration;

public class BookAuthorTypeConfiguration : IEntityTypeConfiguration<BookAuthor>
{
    public void Configure(EntityTypeBuilder<BookAuthor> builder)
    {
        builder.HasKey(ba => new { ba.BookId, ba.AuthorId });

        builder.HasData(
            new BookAuthor
            {
                BookId = new Guid("33d274bd-2d9d-472a-b595-4ff4d0bf8c87"),
                AuthorId = new Guid("9aed9ba0-83a6-4b0f-b409-2401ab3e59bf")
            },
            new BookAuthor
            {
                BookId = new Guid("33d274bd-2d9d-472a-b595-4ff4d0bf8c87"),
                AuthorId = new Guid("afc764d1-9a45-4104-a10d-5626b39d770a")
            },
            new BookAuthor
            {
                BookId = new Guid("a2bb0fd5-5d9b-4b11-a3a3-4948b2f1a5c5"),
                AuthorId = new Guid("4050a949-3f77-43ec-8b3a-ac71bf23b5bd")
            },
            new BookAuthor
            {
                BookId = new Guid("9a2aa24e-19d4-4cbe-bf90-96d625d012e0"),
                AuthorId = new Guid("6cf4f63f-0167-4395-81f4-bb5c4969a622")
            },
            new BookAuthor
            {
                BookId = new Guid("3c51ad1c-66e6-4daa-a20e-5c2e72c59802"),
                AuthorId = new Guid("0cabada2-7f0c-45bb-8440-c9b3cf8c3972")
            },
            new BookAuthor
            {
                BookId = new Guid("1be983b8-34cc-41bf-aad0-ff83113c1ca6"),
                AuthorId = new Guid("44ddfe62-bd28-403f-9825-533f5f90e93f")
            },
            new BookAuthor
            {
                BookId = new Guid("1be983b8-34cc-41bf-aad0-ff83113c1ca6"),
                AuthorId = new Guid("f6633cae-34f2-48e0-a87a-825747490d0b")
            },
            new BookAuthor
            {
                BookId = new Guid("1be983b8-34cc-41bf-aad0-ff83113c1ca6"),
                AuthorId = new Guid("0a0f05b1-3dd9-4121-9b67-b6c0b609d748")
            },
            new BookAuthor
            {
                BookId = new Guid("a499294c-5f69-404f-91b7-c85db7f0a330"),
                AuthorId = new Guid("4050a949-3f77-43ec-8b3a-ac71bf23b5bd")                
            },
            new BookAuthor
            {
                BookId = new Guid("c79f76c0-8409-4d73-a830-9ece06fb078d"),
                AuthorId = new Guid("4050a949-3f77-43ec-8b3a-ac71bf23b5bd")                
            },
            new BookAuthor
            {
                BookId = new Guid("6e8b727f-ecde-4876-916d-e81f12dfa3be"),
                AuthorId = new Guid("0cabada2-7f0c-45bb-8440-c9b3cf8c3972")
            }
        );
    }
}