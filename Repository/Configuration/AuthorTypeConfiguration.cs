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
            new Author()
            {
                AuthorId = Guid.NewGuid(),
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
                AuthorId = Guid.NewGuid(),
                Name = "Jane Doe",
                Birthdate = new DateTime(1965, 3, 24),
                Biography = null
            },
            new Author
            {
                AuthorId = Guid.NewGuid(),
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
                AuthorId = Guid.NewGuid(),
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
                AuthorId = Guid.NewGuid(),
                Name = "David Jones",
                Birthdate = new DateTime(2000, 8, 20),
                Biography = null
            },
            new Author
            {
                AuthorId = Guid.NewGuid(),
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
                AuthorId = Guid.NewGuid(),
                Name = "Ashley Louis",
                Birthdate = new DateTime(1975, 8, 13),
                Biography = null
            },
            new Author
            {
                AuthorId = Guid.NewGuid(),
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