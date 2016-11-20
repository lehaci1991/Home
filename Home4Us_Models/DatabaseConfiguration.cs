using Home4Us.Models;
<<<<<<< HEAD
using Home4Us_Models.Models;
=======
>>>>>>> c9e61d4b4903094bd14f1bae4b0705a5c3059269
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
        public virtual DbSet<PropertyStatus> PropertyStatus { get; set; }
        public virtual DbSet<Users> Users { get; set; }
<<<<<<< HEAD
        public virtual DbSet<Rooms> Rooms { get; set; }
=======
>>>>>>> c9e61d4b4903094bd14f1bae4b0705a5c3059269

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Property>()
                  .HasMany(e => e.Orders)
                  .WithRequired(e => e.Property);

<<<<<<< HEAD
=======

>>>>>>> c9e61d4b4903094bd14f1bae4b0705a5c3059269
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


            modelBuilder.Entity<PropertyStatus>()
                .Property(e => e.StardDate);

            modelBuilder.Entity<PropertyStatus>()
                .Property(e => e.EndDate);

            modelBuilder.Entity<PropertyStatus>()
                .HasMany(e => e.Property)
                .WithRequired(e => e.PropertyStatus)
                .HasForeignKey(e => e.StatusId);

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

<<<<<<< HEAD
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

=======
>>>>>>> c9e61d4b4903094bd14f1bae4b0705a5c3059269
        }
    }
}
