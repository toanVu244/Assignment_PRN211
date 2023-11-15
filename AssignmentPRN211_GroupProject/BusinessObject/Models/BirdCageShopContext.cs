using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BusinessObject.Models
{
    public partial class BirdCageShopContext : DbContext
    {
        public BirdCageShopContext()
        {
        }

        public BirdCageShopContext(DbContextOptions<BirdCageShopContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; } = null!;
        public virtual DbSet<Equipment> Equipment { get; set; } = null!;
        public virtual DbSet<OrderDetail> OrderDetails { get; set; } = null!;
        public virtual DbSet<OrderInfo> OrderInfos { get; set; } = null!;
        public virtual DbSet<Payment> Payments { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<ProductEquipment> ProductEquipments { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(local);Database= BirdCageShop;Uid=sa;Pwd=123;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__Account__1788CCAC39E1BDFE");

                entity.ToTable("Account");

                entity.HasIndex(e => e.Username, "UQ__Account__536C85E4C7AD2A74")
                    .IsUnique();

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(255);

                entity.Property(e => e.PhoneNumber).HasMaxLength(50);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.Username).HasMaxLength(50);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK__Account__RoleID__5070F446");
            });

            modelBuilder.Entity<Equipment>(entity =>
            {
                entity.Property(e => e.EquipmentId)
                    .HasMaxLength(200)
                    .HasColumnName("EquipmentID");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.Type).HasMaxLength(200);
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.ToTable("OrderDetail");

                entity.Property(e => e.OrderDetailId).HasColumnName("OrderDetailID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ProductId)
                    .HasMaxLength(200)
                    .HasColumnName("ProductID");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OrderDeta__Order__6C190EBB");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__OrderDeta__Produ__6D0D32F4");
            });

            modelBuilder.Entity<OrderInfo>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK__OrderInf__C3905BAFA1ECEA79");

                entity.ToTable("OrderInfo");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.Address).HasMaxLength(200);

                entity.Property(e => e.Country).HasMaxLength(200);

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.ExpectedDeliveryDate).HasColumnType("date");

                entity.Property(e => e.Method).HasMaxLength(50);

                entity.Property(e => e.OrderDate).HasColumnType("date");

                entity.Property(e => e.OrderStatus).HasMaxLength(50);

                entity.Property(e => e.State).HasMaxLength(200);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.OrderInfos)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderInfo_Account");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.ToTable("Payment");

                entity.Property(e => e.PaymentId).HasColumnName("PaymentID");

                entity.Property(e => e.CardNumber)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Cvv)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CVV");

                entity.Property(e => e.ExpirationDate).HasMaxLength(10);

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.PaymentMethod).HasMaxLength(50);

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Payment_OrderInfo");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.ProductId)
                    .HasMaxLength(200)
                    .HasColumnName("ProductID");

                entity.Property(e => e.BirdCageType)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.BirdType).HasMaxLength(255);

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ProductMaterial).HasMaxLength(100);

                entity.Property(e => e.ProductName).HasMaxLength(255);
            });

            modelBuilder.Entity<ProductEquipment>(entity =>
            {
                entity.ToTable("ProductEquipment");

                entity.Property(e => e.ProductEquipmentId)
                    .HasMaxLength(200)
                    .HasColumnName("ProductEquipmentID");

                entity.Property(e => e.EquipmentId)
                    .HasMaxLength(200)
                    .HasColumnName("EquipmentID");

                entity.Property(e => e.ProductId)
                    .HasMaxLength(200)
                    .HasColumnName("ProductID");

                entity.HasOne(d => d.Equipment)
                    .WithMany(p => p.ProductEquipments)
                    .HasForeignKey(d => d.EquipmentId)
                    .HasConstraintName("FK__ProductEq__Equip__6EF57B66");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductEquipments)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__ProductEq__Produ__6FE99F9F");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
