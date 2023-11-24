using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace McNameeLab3.Models;

public partial class KitchenContext : DbContext
{
    public KitchenContext()
    { /* 
       Scaffolding command:

        Scaffold-DbContext -Connection "Data Source=(local)\SQLEXPRESS;Initial Catalog=KitchenSupply;
        Integrated Security=True;TrustServerCertificate=True" -Provider Microsoft.EntityFrameworkCore.
        SqlServer -OutputDir Models -Context KitchenContext -DataAnnotations -Force

      */
    }

    public KitchenContext(DbContextOptions<KitchenContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderItem> OrderItems { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Service> Services { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(local)\\SQLEXPRESS;Initial Catalog=KitchenSupply;Integrated Security=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PK__Customer__A4AE64B8843B20F8");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.OrderId).HasName("PK__Orders__C3905BAFD34DA970");

            entity.HasOne(d => d.Customer).WithMany(p => p.Orders).HasConstraintName("FK_Orders_Customers");
        });

        modelBuilder.Entity<OrderItem>(entity =>
        {
            entity.HasKey(e => e.LineId).HasName("PK__OrderIte__2EAE64C9A6F99A94");

            entity.HasOne(d => d.Order).WithMany(p => p.OrderItems).HasConstraintName("FK_OrderItems_Orders");

            entity.HasOne(d => d.Product).WithMany(p => p.OrderItems).HasConstraintName("FK_OrderItems_Products");

            entity.HasOne(d => d.Service).WithMany(p => p.OrderItems).HasConstraintName("FK_OrderItems_Services");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK__Products__B40CC6ED1373CE2A");
        });

        modelBuilder.Entity<Service>(entity =>
        {
            entity.HasKey(e => e.ServiceId).HasName("PK__Services__C51BB0EAC9DF3D6A");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
