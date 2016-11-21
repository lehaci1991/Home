using Home4Us.Models;
using Home4Us_Models.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace Home4Us_Models
{
    public class DataBaseConfiguration : DbContext
    {
        public DataBaseConfiguration() : base("name=Test")
        {
        }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Property> Property { get; set; }
        public virtual DbSet<PropertyAddress> PropertyAddress { get; set; }
        public virtual DbSet<PropertyDetails> PropertyDetails { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Rooms> Rooms { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Property>()
                  .HasMany(e => e.Orders)
                  .WithRequired(e => e.Property);

            modelBuilder.Entity<PropertyAddress>()
                .Property(e => e.City);

            modelBuilder.Entity<PropertyAddress>()
                .Property(e => e.Street);

            modelBuilder.Entity<PropertyAddress>()
                .Property(e => e.Block);

            modelBuilder.Entity<PropertyAddress>()
                .HasMany(e => e.Property)
                .WithRequired(e => e.PropertyAddress)
                .HasForeignKey(e => e.AddressId);


            modelBuilder.Entity<PropertyDetails>()
                .Property(e => e.MoreDetails);


            modelBuilder.Entity<PropertyDetails>()
                .HasMany(e => e.Property)
                .WithRequired(e => e.PropertyDetails)
                .HasForeignKey(e => e.DetailsId);

            modelBuilder.Entity<Users>()
                .Property(e => e.Email);

            modelBuilder.Entity<Users>()
                .Property(e => e.FirstName);

            modelBuilder.Entity<Users>()
                .Property(e => e.LastName);

            modelBuilder.Entity<Users>()
                .Property(e => e.Passwrd);

            modelBuilder.Entity<Users>()
                .Property(e => e.ZipCode);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Users)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Rooms>()
                .Property(e=>e.Balconys);

            modelBuilder.Entity<Rooms>()
                .Property(e => e.Bathrooms);

            modelBuilder.Entity<Rooms>()
                .Property(e => e.Kitchens);

            modelBuilder.Entity<Rooms>()
                .Property(e => e.Livingrooms);

            modelBuilder.Entity<Rooms>()
                .Property(e => e.Storage);

        }
    }
}
