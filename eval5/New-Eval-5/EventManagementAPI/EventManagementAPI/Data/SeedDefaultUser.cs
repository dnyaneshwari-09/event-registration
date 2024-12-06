using EventManagementAPI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;

namespace EventManagementAPI.Data
{
    public static class SeedDefaultUser
    {
        public static void RegisterDefaultUser(ModelBuilder modelBuilder)
        {

            // Seed data into TicketType table
            modelBuilder.Entity<TicketType>().HasData(
                new TicketType
                {
                    TicketTypeId = Guid.NewGuid(), // Generate a unique ID
                    Tickettype = "General"
                },
                new TicketType
                {
                    TicketTypeId = Guid.NewGuid(), // Generate a unique ID
                    Tickettype = "VIP"
                },
                new TicketType
                {
                    TicketTypeId = Guid.NewGuid(), // Generate a unique ID
                    Tickettype = "Economic"
                }
            );

      // Seed Venue Data
      modelBuilder.Entity<Venue>().HasData(
          new Venue
          {
            VenueId = Guid.NewGuid(),
            VenueName = "Convention Center",
            VenueAddress1 = "123 Main St",
            VenueAddress2 = "",
            City = "New York",
            State = "NY",
            Pincode = "10001",
            MaxCapacity = 50
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
            MaxCapacity = 200
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
            MaxCapacity = 150
          }
      );



      // Seed data into Category table
      modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    CategoryId = Guid.NewGuid(), // Generate a unique ID
                    CategoryType = "Music concerts"
                },
                new Category
                {
                    CategoryId = Guid.NewGuid(), // Generate a unique ID
                    CategoryType = "Seminars"
                },
                new Category
                {
                    CategoryId = Guid.NewGuid(), // Generate a unique ID
                    CategoryType = "Workshops"
                },
                new Category
                {
                    CategoryId = Guid.NewGuid(), // Generate a unique ID
                    CategoryType = "Exhibitions"
                },
                new Category
                {
                    CategoryId = Guid.NewGuid(), // Generate a unique ID
                    CategoryType = "Festivals"
                }
            );
            var adminRole = new IdentityRole
            {
                Id = Guid.NewGuid().ToString(),
                Name = "admin",
                NormalizedName = "ADMIN"
            };

            var userRole = new IdentityRole
            {
                Id = Guid.NewGuid().ToString(),
                Name = "user",
                NormalizedName = "USER"
            };

            var adminUser = new ApplicationUser
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "admin@admin.com",
                NormalizedUserName = "ADMIN@ADMIN.COM",
                Email = "admin@admin.com",
                NormalizedEmail = "ADMIN@ADMIN.COM",
                EmailConfirmed = true,
                FirstName = "Admin",
                LastName = "User",
                SecurityStamp = Guid.NewGuid().ToString("D")
            };

            var passwordHasher = new PasswordHasher<ApplicationUser>();
            adminUser.PasswordHash = passwordHasher.HashPassword(adminUser, "Admin@123");

            modelBuilder.Entity<IdentityRole>().HasData(adminRole, userRole);
            modelBuilder.Entity<ApplicationUser>().HasData(adminUser);

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = adminRole.Id,
                UserId = adminUser.Id
            });
        }
    }

}
