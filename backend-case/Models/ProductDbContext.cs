using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace backend_case.Models;

public partial class ProductDbContext : DbContext
{
    public ProductDbContext()
    {
    }

    public ProductDbContext(DbContextOptions<ProductDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=ProductDb;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Product__3214EC075B9D1604");

            entity.ToTable("Product");

            entity.Property(e => e.Barcode).HasMaxLength(100);
            entity.Property(e => e.CurrencyName).HasMaxLength(50);
            entity.Property(e => e.OtherCode).HasMaxLength(100);
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PriceDiscounted).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PriceDiscountedDomestic).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProductStatusName).HasMaxLength(255);
            entity.Property(e => e.ProductUrl).HasMaxLength(500);
            entity.Property(e => e.Sku).HasMaxLength(100);
            entity.Property(e => e.Title).HasMaxLength(255);
            entity.Property(e => e.TitleDomestic).HasMaxLength(255);
            entity.Property(e => e.WhenMade).HasMaxLength(100);
            entity.Property(e => e.WhoMade).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
