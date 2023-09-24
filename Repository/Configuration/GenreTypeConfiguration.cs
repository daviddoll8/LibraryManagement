using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration;

public class GenreTypeConfiguration : IEntityTypeConfiguration<Genre>
{
    public void Configure(EntityTypeBuilder<Genre> builder)
    {
        builder.HasKey(g => g.GenreId);

        builder.Property(g => g.GenreId).ValueGeneratedOnAdd();

        builder.Property(g => g.Name).IsRequired().HasMaxLength(40);

        builder.HasMany(g => g.Books)
            .WithMany(g => g.Genres)
            .UsingEntity(
                l => l.HasOne(typeof(Book)).WithMany().HasForeignKey("BookForeignKey"),
                r => r.HasOne(typeof(Genre)).WithMany().HasForeignKey("GenreForeignKey"));

        builder.HasData(
            new Genre
            {
                GenreId = new Guid("08e95852-2773-4d33-bed7-0383215ab34a"),
                Name = "Sci-Fi",
            },
            new Genre
            {
                GenreId = new Guid("c40c9712-afd0-45e9-ad11-6b492933d633"),
                Name = "Fiction"
            },
            new Genre
            {
                GenreId = new Guid("290151b2-22b3-401e-a628-89daa9ec3541"),
                Name = "History"
            },
            new Genre
            {
                GenreId = new Guid("2f6ca172-ebe6-4111-9dc4-e631c9eae4ce"),
                Name = "Non-Fiction"
            },
            new Genre
            {
                GenreId = new Guid("607f26b3-33ae-44c3-923a-87925e640946"),
                Name = "Fantasy"
            },
            new Genre
            {
                GenreId = new Guid("8dd47f81-c0b8-4d69-98c4-792d42d34a22"),
                Name = "Mystery"
            },
            new Genre
            {
                GenreId = new Guid("2f8d230d-ce38-46e7-8ac4-6227d98d6d17"),
                Name = "Science"
            },
            new Genre
            {
                GenreId = new Guid("49c7e571-ff92-418d-8923-b5f069540749"),
                Name = "Novel"
            },
            new Genre
            {
                GenreId = new Guid("0d38c13b-451b-4ffe-9d6f-3949e43604ac"),
                Name = "Thriller"
            },
            new Genre
            {
                GenreId = new Guid("8a86eddd-6fa0-4ef5-a0d4-1984254ab3ff"),
                Name = "Horror"
            }
        );
    }
}