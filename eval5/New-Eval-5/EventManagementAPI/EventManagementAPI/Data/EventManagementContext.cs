using System.Reflection.Emit;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using EventManagementAPI.Models;
namespace EventManagementAPI.Data
{
    public class EventManagementContext : IdentityDbContext<ApplicationUser>
    {
        public EventManagementContext(DbContextOptions<EventManagementContext> options)
            : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Registration> Registrations { get; set; }
        public DbSet<Payment> Payments { get; set; }
       
        public DbSet<TicketType> TicketTypes { get; set; }

        public DbSet<Venue> Venues { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Register default user and roles
            SeedDefaultUser.RegisterDefaultUser(builder);

            // Call base method to ensure Identity configurations are applied
            base.OnModelCreating(builder);
            // Configure relationships if needed
            builder.Entity<Event>()
                .HasOne(e => e.Category)
                .WithMany(c => c.Events)
                .HasForeignKey(e => e.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

              // Seed Category Data
              builder.Entity<Category>().HasData(
                  new Category
                  {
                    CategoryId = Guid.NewGuid(),
                    CategoryType = "Music"
                  },
                  new Category
                  {
                    CategoryId = Guid.NewGuid(),
                    CategoryType = "Career Fairs"
                  },
                  new Category
                  {
                    CategoryId = Guid.NewGuid(),
                    CategoryType = "Workshops"
                  }
              );

      // Seed TicketType Data
      builder.Entity<TicketType>().HasData(
          new TicketType
          {
            TicketTypeId = Guid.NewGuid(),
            Tickettype = "General",
            Price = 0.00
          },
          new TicketType
          {
            TicketTypeId = Guid.NewGuid(),
            Tickettype = "VIP",
            Price = 1000.00
          },
          new TicketType
          {
            TicketTypeId = Guid.NewGuid(),
            Tickettype = "Economy",
            Price = 500.00
          }
      );
      // Seed Venue Data
      builder.Entity<Venue>().HasData(
          new Venue
          {
            VenueId = Guid.NewGuid(),
            VenueName = "Convention Center",
            VenueAddress1 = "123 Main St",
            VenueAddress2 = "",
            City = "New York",
            State = "NY",
            Pincode = "10001",
            MaxCapacity = 5000
          },
          new Venue
          {
            VenueId = Guid.NewGuid(),
            VenueName = "Open Grounds",
            VenueAddress1 = "456 Park Ave",
            VenueAddress2 = "Near Central Park",
            City = "Los Angeles",
            State = "CA",
            Pincode = "90001",
            MaxCapacity = 2000
          },
          new Venue
          {
            VenueId = Guid.NewGuid(),
            VenueName = "Auditorium Hall",
            VenueAddress1 = "789 Broadway",
            VenueAddress2 = "Suite 100",
            City = "Chicago",
            State = "IL",
            Pincode = "60601",
            MaxCapacity = 1000
          }
      );
      


    }
  }

}
