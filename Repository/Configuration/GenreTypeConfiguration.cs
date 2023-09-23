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
    }
}