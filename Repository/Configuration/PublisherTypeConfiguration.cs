﻿using Entities.Models;
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
                PublisherId = Guid.NewGuid(),
                Name =  "Penguin Random House",
                Location = "USA",
                ContactInfo = "penguinpublishing@gmail.com"
            },
            new Publisher
            {
                PublisherId = Guid.NewGuid(),
                Name = "Scholastic",
                Location = "France",
                ContactInfo = "contactscholastic@gmail.com"
            },
            new Publisher
            {
                PublisherId = Guid.NewGuid(),
                Name = "Pearson",
                Location = "Germany",
                ContactInfo = "personpublishing@gmail.com"
            },
            new Publisher
            {
                PublisherId = Guid.NewGuid(),
                Name = "Houghton Mifflin",
                Location = null,
                ContactInfo = null
            }
        );
    }
}