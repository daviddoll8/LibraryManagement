using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration;

public class PublisherTypeConfiguration : IEntityTypeConfiguration<Publisher>
{
    public void Configure(EntityTypeBuilder<Publisher> builder)
    {
        builder.HasKey(p => p.PublisherId);
        
        builder.Property(p => p.PublisherId).ValueGeneratedOnAdd();

        builder.Property(p => p.Name).IsRequired().HasMaxLength(75);

        builder.Property(p => p.Location).HasMaxLength(60);

        builder.Property(p => p.ContactInfo).HasMaxLength(100);
    }
}