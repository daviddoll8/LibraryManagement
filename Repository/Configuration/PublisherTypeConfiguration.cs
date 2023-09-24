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

        builder.HasData(
            new Publisher
            {
                PublisherId = new Guid("a1a4734d-cb76-41b2-92ef-237ff61c660a"),
                Name =  "Penguin Random House",
                Location = "USA",
                ContactInfo = "penguinpublishing@gmail.com"
            },
            new Publisher
            {
                PublisherId = new Guid("3bc0b331-5b25-49a4-a86c-c7d2142f0032"),
                Name = "Scholastic",
                Location = "France",
                ContactInfo = "contactscholastic@gmail.com"
            },
            new Publisher
            {
                PublisherId = new Guid("67d77f42-be53-4e4d-ac30-0b3010cdd7a2"),
                Name = "Pearson",
                Location = "Germany",
                ContactInfo = "personpublishing@gmail.com"
            },
            new Publisher
            {
                PublisherId = new Guid("327da642-0cdd-4dde-8adc-2cfb1a90795e"),
                Name = "Houghton Mifflin",
                Location = null,
                ContactInfo = null
            }
        );
    }
}