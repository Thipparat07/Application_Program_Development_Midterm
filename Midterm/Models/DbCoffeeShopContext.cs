using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Midterm.Models;

public partial class DbCoffeeShopContext : DbContext
{
    public DbCoffeeShopContext()
    {
    }

    public DbCoffeeShopContext(DbContextOptions<DbCoffeeShopContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Menu> Menus { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<TypeCoffee> TypeCoffees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-6P7EBR1\\SQLEXPRESS;Database=dbCoffeeShop;Trusted_Connection=True;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Thai_CI_AS");

        modelBuilder.Entity<Menu>(entity =>
        {
            entity.HasKey(e => e.Idmenu);

            entity.ToTable("Menu");

            entity.Property(e => e.Idmenu).HasColumnName("idmenu");
            entity.Property(e => e.Idtype).HasColumnName("idtype");
            entity.Property(e => e.Image)
                .HasColumnType("image")
                .HasColumnName("image");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("name");
            entity.Property(e => e.Price).HasColumnName("price");

            entity.HasOne(d => d.IdtypeNavigation).WithMany(p => p.Menus)
                .HasForeignKey(d => d.Idtype)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Menu_TypeCoffee");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.Oid);

            entity.ToTable("Order");

            entity.Property(e => e.Oid).HasColumnName("oid");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.Idmenu).HasColumnName("idmenu");
            entity.Property(e => e.Number).HasColumnName("number");
            entity.Property(e => e.Priceamount).HasColumnName("priceamount");
            entity.Property(e => e.Trans).HasColumnName("trans");

            entity.HasOne(d => d.IdmenuNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.Idmenu)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Order_Menu");
        });

        modelBuilder.Entity<TypeCoffee>(entity =>
        {
            entity.HasKey(e => e.Idtype);

            entity.ToTable("TypeCoffee");

            entity.Property(e => e.Idtype).HasColumnName("idtype");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsFixedLength();
            entity.Property(e => e.Type)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("type");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
