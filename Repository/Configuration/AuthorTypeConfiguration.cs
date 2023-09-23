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
    }
}