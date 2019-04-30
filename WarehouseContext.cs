using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AngularCSharp
{
    public partial class WarehouseContext : DbContext
    {
        public WarehouseContext()
        {
        }

        public WarehouseContext(DbContextOptions<WarehouseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Inventory> Inventory { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("Host=localhost;Database=Warehouse;Username=postgres;Password=mantine94");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<Inventory>(entity =>
            {
                entity.HasKey(e => e.ItemId)
                    .HasName("users_pkey");

                entity.ToTable("inventory");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.Aisle).HasColumnName("aisle");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.Shelf).HasColumnName("shelf");
            });
        }
    }
}
