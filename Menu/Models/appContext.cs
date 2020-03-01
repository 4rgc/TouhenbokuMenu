using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Menu.Models
{
    public partial class MenuContext : DbContext
    {
        public MenuContext(string dbPath)
        {
            path = dbPath;
        }

        string path;

        public MenuContext(DbContextOptions<MenuContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Appetizers> Appetizers { get; set; }
        public virtual DbSet<Desserts> Desserts { get; set; }
        public virtual DbSet<Donburi> Donburi { get; set; }
        public virtual DbSet<Drinks> Drinks { get; set; }
        public virtual DbSet<Meats> Meats { get; set; }
        public virtual DbSet<Noodles> Noodles { get; set; }
        public virtual DbSet<Ramen> Ramen { get; set; }
        public virtual DbSet<Seasonings> Seasonings { get; set; }
        public virtual DbSet<Soups> Soups { get; set; }
        public virtual DbSet<Toppings> Toppings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=" + path);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appetizers>(entity =>
            {
                entity.HasKey(e => e.AppetizerId);

                entity.Property(e => e.AppetizerId)
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppetizerIsCombo)
                    .IsRequired()
                    .HasColumnType("BIT");

                entity.Property(e => e.AppetizerName).HasColumnType("VARCHAR(20)");

                entity.Property(e => e.AppetizerPrice).HasColumnType("INT");
            });

            modelBuilder.Entity<Desserts>(entity =>
            {
                entity.HasKey(e => e.DessertId);

                entity.Property(e => e.DessertId)
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.DessertName).HasColumnType("VARCHAR(30)");

                entity.Property(e => e.DessertPrice).HasColumnType("INT");
            });

            modelBuilder.Entity<Donburi>(entity =>
            {
                entity.Property(e => e.DonburiId)
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.DonburiName).HasColumnType("VARCHAR(50)");
            });

            modelBuilder.Entity<Drinks>(entity =>
            {
                entity.HasKey(e => e.DrinkId);

                entity.Property(e => e.DrinkId)
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.DrinkIsCombo)
                    .IsRequired()
                    .HasColumnType("BIT");

                entity.Property(e => e.DrinkName).HasColumnType("VARCHAR(20)");

                entity.Property(e => e.DrinkPrice).HasColumnType("INT");
            });

            modelBuilder.Entity<Meats>(entity =>
            {
                entity.HasKey(e => e.MeatId);

                entity.Property(e => e.MeatId)
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.MeatName).HasColumnType("VARCHAR(20)");
            });

            modelBuilder.Entity<Noodles>(entity =>
            {
                entity.HasKey(e => e.NoodleId);

                entity.Property(e => e.NoodleId)
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.NoodleName).HasColumnType("VARCHAR(20)");
            });

            modelBuilder.Entity<Ramen>(entity =>
            {
                entity.Property(e => e.RamenId)
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.RamenIsPreset)
                    .IsRequired()
                    .HasColumnType("BIT");

                entity.Property(e => e.RamenIsVeggie)
                    .IsRequired()
                    .HasColumnType("BIT");

                entity.Property(e => e.RamenMeat).HasColumnType("INT");

                entity.Property(e => e.RamenName).HasColumnType("VARCHAR(50)");

                entity.Property(e => e.RamenNoodle).HasColumnType("INT");

                entity.Property(e => e.RamenPrice).HasColumnType("INT");

                entity.Property(e => e.RamenSeasoning).HasColumnType("INT");

                entity.Property(e => e.RamenSoup).HasColumnType("INT");

                entity.HasOne(d => d.RamenMeatNavigation)
                    .WithMany(p => p.Ramen)
                    .HasForeignKey(d => d.RamenMeat);

                entity.HasOne(d => d.RamenNoodleNavigation)
                    .WithMany(p => p.Ramen)
                    .HasForeignKey(d => d.RamenNoodle);

                entity.HasOne(d => d.RamenSeasoningNavigation)
                    .WithMany(p => p.Ramen)
                    .HasForeignKey(d => d.RamenSeasoning);

                entity.HasOne(d => d.RamenSoupNavigation)
                    .WithMany(p => p.Ramen)
                    .HasForeignKey(d => d.RamenSoup);
            });

            modelBuilder.Entity<Seasonings>(entity =>
            {
                entity.HasKey(e => e.SeasoningId);

                entity.Property(e => e.SeasoningId)
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.SeasoningName).HasColumnType("VARCHAR(20)");
            });

            modelBuilder.Entity<Soups>(entity =>
            {
                entity.HasKey(e => e.SoupId);

                entity.Property(e => e.SoupId)
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.SoupName).HasColumnType("VARCHAR(20)");
            });

            modelBuilder.Entity<Toppings>(entity =>
            {
                entity.HasKey(e => e.ToppingId);

                entity.Property(e => e.ToppingId)
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.ToppingName).HasColumnType("VARCHAR(20)");

                entity.Property(e => e.ToppingPrice).HasColumnType("INT");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
