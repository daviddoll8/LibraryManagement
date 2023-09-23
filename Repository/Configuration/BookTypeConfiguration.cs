﻿using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration;

public class BookTypeConfiguration : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.HasKey(b => b.Id);
        
        builder.Property(b => b.Id).ValueGeneratedOnAdd();

        builder.Property(b => b.BookTitle).IsRequired().HasMaxLength(20);

        builder.Property(b => b.ISBN).IsRequired().HasMaxLength(13);

        builder.Property(b => b.PublicationDate).IsRequired();

        builder.Property(b => b.Description).HasMaxLength(750);

        builder.Property(b => b.Availability).IsRequired();

        builder.Property(b => b.PageCount).IsRequired();

        builder.Property(b => b.CoverImageURL);

        builder.Property(b => b.CoverImageURL).HasMaxLength(255);

        //builder.Property(b => b.PublisherId).IsRequired();

        /*builder.HasMany(b => b.BookAuthors).WithOne(ba => ba.Book)
            .HasForeignKey(ba => ba.BookId);*/

        //builder.HasOne<Publisher>().WithMany().HasForeignKey(b => b.PublisherId);
    }
}