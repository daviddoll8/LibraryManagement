﻿using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repository.Configuration;

namespace Repository;

public class RepositoryContext : DbContext
{
    public RepositoryContext(DbContextOptions options)
        : base(options)
    {
    }
    
    public DbSet<Author>? Author { get; set; }
    public DbSet<Book>? Book { get; set; }
    public DbSet<BookAuthor>? BookAuthor { get; set; }
    public DbSet<Publisher>? Publisher { get; set; }
    public DbSet<Genre>? Genre { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new AuthorTypeConfiguration());
        modelBuilder.ApplyConfiguration(new BookTypeConfiguration());
        modelBuilder.ApplyConfiguration(new BookAuthorTypeConfiguration());
        modelBuilder.ApplyConfiguration(new PublisherTypeConfiguration());
        modelBuilder.ApplyConfiguration(new GenreTypeConfiguration());
    }
}