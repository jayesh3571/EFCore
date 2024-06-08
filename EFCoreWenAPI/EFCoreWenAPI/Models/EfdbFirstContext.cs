using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EFCoreWenAPI.Models;

public partial class EfdbFirstContext : DbContext
{
    public EfdbFirstContext()
    {
    }

    public EfdbFirstContext(DbContextOptions<EfdbFirstContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>(entity =>
        {
            entity.ToTable("Customer");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Mobile)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
