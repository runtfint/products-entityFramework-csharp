using Microsoft.EntityFrameworkCore;
using Products;
using System;

public class CatalogDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=D:/Проекты/4 КУРС/Products/Products/Products/Catalog.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Guid);
            entity.Property(e => e.Name).IsRequired();
            entity.Property(e => e.ExpiryDate).IsRequired();
            entity.Property(e => e.Quantity).IsRequired();
        });
    }
}
