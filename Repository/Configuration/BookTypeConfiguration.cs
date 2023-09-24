using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration;

public class BookTypeConfiguration : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.HasKey(b => b.BookId);
        
        builder.Property(b => b.BookId).ValueGeneratedOnAdd();

        builder.Property(b => b.BookTitle).IsRequired().HasMaxLength(100);

        builder.Property(b => b.ISBN).IsRequired().HasMaxLength(13);

        builder.Property(b => b.PublicationDate).IsRequired();

        builder.Property(b => b.Description).HasMaxLength(1000);

        builder.Property(b => b.Availability).IsRequired();

        builder.Property(b => b.PageCount).IsRequired();

        builder.Property(b => b.CoverImageURL);

        builder.Property(b => b.CoverImageURL).HasMaxLength(255);

        builder.HasData(
            new Book
            {
                BookId = Guid.NewGuid(),
                BookTitle = "Dune",
                ISBN = "9780233660615",
                PublicationDate = new DateTime(1990, 9, 15),
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor" +
                              " incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud" +
                              " exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure " +
                              "dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. " +
                              "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit " +
                              "anim id est laborum.",
                Availability = true,
                PageCount = 894,
                CoverImageURL = null,
                PublisherId = new Guid("67d77f42-be53-4e4d-ac30-0b3010cdd7a2")
            },
            new Book
            {
                BookId = Guid.NewGuid(),
                BookTitle = "Dune",
                ISBN = "9780233660615",
                PublicationDate = new DateTime(1990, 9, 15),
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor" +
                              " incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud" +
                              " exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure " +
                              "dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. " +
                              "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit " +
                              "anim id est laborum.",
                Availability = true,
                PageCount = 894,
                CoverImageURL = null,
                PublisherId = new Guid("67d77f42-be53-4e4d-ac30-0b3010cdd7a2")
            },
            new Book
            {
                BookId = Guid.NewGuid(),
                BookTitle = "The Catcher in the Rye",
                ISBN = "9787360328388",
                PublicationDate = new DateTime(1980, 4, 6),
                Description = null,
                Availability = true,
                PageCount = 510,
                CoverImageURL = null,
                PublisherId = new Guid("3bc0b331-5b25-49a4-a86c-c7d2142f0032")
            },
            new Book
            {
                BookId = Guid.NewGuid(),
                BookTitle = "The Catcher in the Rye",
                ISBN = "9787360328388",
                PublicationDate = new DateTime(1980, 4, 6),
                Description = null,
                Availability = true,
                PageCount = 510,
                CoverImageURL = null,
                PublisherId = new Guid("3bc0b331-5b25-49a4-a86c-c7d2142f0032")
            },
            new Book
            {
                BookId = Guid.NewGuid(),
                BookTitle = "The Catcher in the Rye",
                ISBN = "9787360328388",
                PublicationDate = new DateTime(1980, 4, 6),
                Description = null,
                Availability = false,
                PageCount = 510,
                CoverImageURL = null,
                PublisherId = new Guid("3bc0b331-5b25-49a4-a86c-c7d2142f0032")
            },
            new Book
            {
                BookId = Guid.NewGuid(),
                BookTitle = "Sample SciFi",
                ISBN = "9780277097484",
                PublicationDate = new DateTime(1994, 11, 8),
                Description = null,
                Availability = true,
                PageCount = 421,
                CoverImageURL = null,
                PublisherId = new Guid("a1a4734d-cb76-41b2-92ef-237ff61c660a")
            },
            new Book
            {
                BookId = Guid.NewGuid(),
                BookTitle = "Sample Horror",
                ISBN = "9781677732098",
                PublicationDate = new DateTime(2010, 12, 15),
                Description = null,
                Availability = true,
                PageCount = 710,
                CoverImageURL = null,
                PublisherId = new Guid("327da642-0cdd-4dde-8adc-2cfb1a90795e")
            },
            new Book
            {
                BookId = Guid.NewGuid(),
                BookTitle = "Sample ScienceHistory",
                ISBN = "9783981372724",
                PublicationDate = new DateTime(2004, 5, 23),
                Description = null,
                Availability = true,
                PageCount = 543,
                CoverImageURL = null,
                PublisherId = new Guid("3bc0b331-5b25-49a4-a86c-c7d2142f0032")
            }
        );
    }
}