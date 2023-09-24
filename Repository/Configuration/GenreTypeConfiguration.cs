using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration;

public class GenreTypeConfiguration : IEntityTypeConfiguration<Genre>
{
    public void Configure(EntityTypeBuilder<Genre> builder)
    {
        builder.HasKey(g => g.GenreId);

        builder.Property(g => g.Name).IsRequired().HasMaxLength(40);

        builder.HasMany(g => g.Books)
            .WithMany(g => g.Genres)
            .UsingEntity(
                l => l.HasOne(typeof(Book)).WithMany().HasForeignKey("BookForeignKey"),
                r => r.HasOne(typeof(Genre)).WithMany().HasForeignKey("GenreForeignKey"));

        builder.HasData(
            new Genre
            {
                GenreId = Guid.NewGuid(),
                Name = "Sci-Fi"
            },
            new Genre
            {
                GenreId = Guid.NewGuid(),
                Name = "Fiction"
            },
            new Genre
            {
                GenreId = Guid.NewGuid(),
                Name = "History"
            },
            new Genre
            {
                GenreId = Guid.NewGuid(),
                Name = "Non-Fiction"
            },
            new Genre
            {
                GenreId = Guid.NewGuid(),
                Name = "Fantasy"
            },
            new Genre
            {
                GenreId = Guid.NewGuid(),
                Name = "Mystery"
            },
            new Genre
            {
                GenreId = Guid.NewGuid(),
                Name = "Science"
            },
            new Genre
            {
                GenreId = Guid.NewGuid(),
                Name = "Novel"
            },
            new Genre
            {
                GenreId = Guid.NewGuid(),
                Name = "Thriller"
            },
            new Genre
            {
                GenreId = Guid.NewGuid(),
                Name = "Horror"
            }
        );
    }
}