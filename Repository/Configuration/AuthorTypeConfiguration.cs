using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration;

public class AuthorTypeConfiguration : IEntityTypeConfiguration<Author>
{
    public void Configure(EntityTypeBuilder<Author> builder)
    {
        builder.HasKey(a => a.AuthorId);

        builder.Property(a => a.AuthorId).ValueGeneratedOnAdd();

        builder.Property(a => a.Name).IsRequired().HasMaxLength(50);

        builder.Property(a => a.Birthdate).IsRequired();

        builder.Property(a => a.Biography).HasMaxLength(750);

        builder.HasMany(a => a.Books)
            .WithMany(b => b.Authors)
            .UsingEntity<BookAuthor>();

        builder.HasData(
            new Author
            {
                AuthorId = new Guid("0cabada2-7f0c-45bb-8440-c9b3cf8c3972"),
                Name = "Frank Herbert",
                Birthdate = new DateTime(1920, 10, 8),
                Biography = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt " +
                            "ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco " +
                            "laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in " +
                            "voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat" +
                            "non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
            },
            new Author
            {
                AuthorId = new Guid("0a0f05b1-3dd9-4121-9b67-b6c0b609d748"),
                Name = "Jane Doe",
                Birthdate = new DateTime(1965, 3, 24),
                Biography = null
            },
            new Author
            {
                AuthorId = new Guid("44ddfe62-bd28-403f-9825-533f5f90e93f"),
                Name = "Jeff Willis",
                Birthdate = new DateTime(1995, 4, 3),
                Biography = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt " +
                            "ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco " +
                            "laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in " +
                            "voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat" +
                            "non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."
            },
            new Author
            {
                AuthorId = new Guid("6cf4f63f-0167-4395-81f4-bb5c4969a622"),
                Name = "Jennifer Smith",
                Birthdate = new DateTime(1955, 6, 10),
                Biography = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt" +
                            " ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco" +
                            " laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in" +
                            " voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat" +
                            " non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."
            },
            new Author
            {
                AuthorId = new Guid("9aed9ba0-83a6-4b0f-b409-2401ab3e59bf"),
                Name = "David Jones",
                Birthdate = new DateTime(2000, 8, 20),
                Biography = null
            },
            new Author
            {
                AuthorId = new Guid("afc764d1-9a45-4104-a10d-5626b39d770a"),
                Name = "Rico Rodriguez",
                Birthdate = new DateTime(1983, 6, 13),
                Biography = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt" +
                            " ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco" +
                            " laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in" +
                            " voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat" +
                            " non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."
            },
            new Author
            {
                AuthorId = new Guid("f6633cae-34f2-48e0-a87a-825747490d0b"),
                Name = "Ashley Louis",
                Birthdate = new DateTime(1975, 8, 13),
                Biography = null
            },
            new Author
            {
                AuthorId = new Guid("4050a949-3f77-43ec-8b3a-ac71bf23b5bd"),
                Name = "Jerry Williams",
                Birthdate = new DateTime(1988, 3, 28),
                Biography = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt" +
                            " ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco" +
                            " laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in" +
                            " voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat" +
                            " non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."
            }
        );
    }
}