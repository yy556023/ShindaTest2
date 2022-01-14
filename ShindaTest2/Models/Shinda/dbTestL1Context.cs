using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ShindaTest2.Models.Shinda
{
    public partial class dbTestL1Context : DbContext
    {
        public dbTestL1Context()
        {
        }

        public dbTestL1Context(DbContextOptions<dbTestL1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<TblOrder> TblOrder { get; set; }
        public virtual DbSet<TblOrderDetails> TblOrderDetails { get; set; }
        public virtual DbSet<TblProduct> TblProduct { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblOrder>(entity =>
            {
                entity.HasKey(e => e.COrderId);

                entity.ToTable("tblOrder");

                entity.Property(e => e.COrderId)
                    .HasColumnName("cOrderID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CDt)
                    .HasColumnName("cDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.CName)
                    .HasColumnName("cName")
                    .HasMaxLength(10);

                entity.Property(e => e.CSubTotal)
                    .HasColumnName("cSubTotal")
                    .HasColumnType("decimal(7, 2)");
            });

            modelBuilder.Entity<TblOrderDetails>(entity =>
            {
                entity.HasKey(e => new { e.COrderId, e.CProductId });

                entity.ToTable("tblOrderDetails");

                entity.Property(e => e.COrderId)
                    .HasColumnName("cOrderID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CProductId).HasColumnName("cProductID");

                entity.Property(e => e.CCount).HasColumnName("cCount");

                entity.Property(e => e.CTotal)
                    .HasColumnName("cTotal")
                    .HasColumnType("decimal(7, 0)");
            });

            modelBuilder.Entity<TblProduct>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblProduct");

                entity.Property(e => e.CPrice)
                    .HasColumnName("cPrice")
                    .HasColumnType("decimal(7, 0)");

                entity.Property(e => e.CProdcutId).HasColumnName("cProdcutID");

                entity.Property(e => e.CProdcutName)
                    .HasColumnName("cProdcutName")
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
