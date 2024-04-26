using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WorkingWithEFCore.Models;

namespace WorkingWithEFCore.Data;

public partial class WorkingWithEfcoreContext : DbContext
{
    public WorkingWithEfcoreContext()
    {
    }

    public WorkingWithEfcoreContext(DbContextOptions<WorkingWithEfcoreContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderedDetail> OrderedDetails { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=WorkingWithEFCore;Integrated Security=True;Encrypt=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasIndex(e => e.CustomerId, "IX_Orders_CustomerId");

            entity.HasOne(d => d.Customer).WithMany(p => p.Orders).HasForeignKey(d => d.CustomerId);
        });

        modelBuilder.Entity<OrderedDetail>(entity =>
        {
            entity.HasIndex(e => e.OrderId, "IX_OrderedDetails_OrderId");

            entity.HasIndex(e => e.ProductId, "IX_OrderedDetails_ProductId");

            entity.HasOne(d => d.Order).WithMany(p => p.OrderedDetails).HasForeignKey(d => d.OrderId);

            entity.HasOne(d => d.Product).WithMany(p => p.OrderedDetails).HasForeignKey(d => d.ProductId);
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.Property(e => e.Price).HasColumnType("decimal(6, 2)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
