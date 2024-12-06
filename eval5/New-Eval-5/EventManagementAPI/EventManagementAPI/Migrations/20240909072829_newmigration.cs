using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EventManagementAPI.Migrations
{
    /// <inheritdoc />
    public partial class newmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d8d4c074-6830-48bb-9bee-ea6d2d87165d");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9ee7b5f0-bfae-47cc-80f5-2087c02783e8", "2594e973-a402-44ba-82f5-de3999767d1c" });

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("0bf17997-7455-4482-a496-dd92e2d562a1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("2043ff2d-cd3e-41f0-9b10-c5174ef70247"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("3ae433e0-e93c-4782-bf09-8c7734f3b32e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("4545140d-c3c8-40f4-8855-9e7fb29baaf3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("776cc933-b93f-414e-94d9-b1e2c3422910"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("89ae65d5-fefe-467a-8f52-76f561bcdbad"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("8e5ff9e8-a11c-476e-a23d-7bba77126b66"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("dd737700-2cf1-47e3-89e0-435febc1e762"));

            migrationBuilder.DeleteData(
                table: "TicketTypes",
                keyColumn: "TicketTypeId",
                keyValue: new Guid("236aff3a-fb82-42ee-af9f-ccb78c1b98d1"));

            migrationBuilder.DeleteData(
                table: "TicketTypes",
                keyColumn: "TicketTypeId",
                keyValue: new Guid("4696a2fe-7397-4b48-a15b-60fb4cb33c70"));

            migrationBuilder.DeleteData(
                table: "TicketTypes",
                keyColumn: "TicketTypeId",
                keyValue: new Guid("77d2d3cf-1e57-4526-97db-569bd527a6d8"));

            migrationBuilder.DeleteData(
                table: "TicketTypes",
                keyColumn: "TicketTypeId",
                keyValue: new Guid("d3d9a4b6-846d-441a-9e7e-dd2fe09104ed"));

            migrationBuilder.DeleteData(
                table: "TicketTypes",
                keyColumn: "TicketTypeId",
                keyValue: new Guid("d7103960-9280-4696-bf77-b505144b6715"));

            migrationBuilder.DeleteData(
                table: "TicketTypes",
                keyColumn: "TicketTypeId",
                keyValue: new Guid("fd70ed16-ec0c-4252-9988-f0e073075abf"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "VenueId",
                keyValue: new Guid("725dd39b-6ca2-4d96-9bfa-16e779872509"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "VenueId",
                keyValue: new Guid("bdf44e73-8165-4206-9319-eab9053c7e13"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "VenueId",
                keyValue: new Guid("fb3dccb4-f0a7-44dc-ac1c-6c147cf00993"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9ee7b5f0-bfae-47cc-80f5-2087c02783e8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2594e973-a402-44ba-82f5-de3999767d1c");

            migrationBuilder.AddColumn<Guid>(
                name: "TicketTypeId",
                table: "Payments",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3a072fb5-f5bd-480e-b449-44500fadd661", null, "admin", "ADMIN" },
                    { "7b185712-2303-499a-a78e-9f0413ca0f6b", null, "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "03bd63a9-4378-42c5-a183-85c40eee1305", 0, "f847afb7-3743-4f93-9e60-872cd23749da", "admin@admin.com", true, "Admin", "User", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEG0lCRVjQiWUjrCeIN2IqdbXj8FXsqVI8EqzepoAZYR85MGefmzxJXSaB6UdYdWyjw==", null, false, "e57b9cda-190b-4e56-8f16-d177adea0b5e", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryType" },
                values: new object[,]
                {
                    { new Guid("0fbd2e3e-93eb-474a-9cfc-9eab12594f08"), "Music concerts" },
                    { new Guid("6a3e9825-91ee-411d-94c6-f6be8e5698e2"), "Music" },
                    { new Guid("6cd292f7-7651-4bf7-b6a2-c1ee12182428"), "Festivals" },
                    { new Guid("858556a0-30b6-446c-bb3b-9765b0003b37"), "Exhibitions" },
                    { new Guid("98a7b3fb-9ac7-4756-bce3-aabff85054c0"), "Seminars" },
                    { new Guid("b7557278-598b-498e-a381-a7040edb88b2"), "Career Fairs" },
                    { new Guid("d26007ff-19d0-44d3-91ea-c86a63bebec1"), "Workshops" },
                    { new Guid("e09154c3-1565-4d67-904c-3415c425a71b"), "Workshops" }
                });

            migrationBuilder.InsertData(
                table: "TicketTypes",
                columns: new[] { "TicketTypeId", "Price", "Tickettype" },
                values: new object[,]
                {
                    { new Guid("1c21c8c4-25f2-41af-8834-3f9d5b844f0d"), 0.0, "Economic" },
                    { new Guid("2f5646d7-14f4-4a41-b2b3-0e02150e1e7d"), 500.0, "Economy" },
                    { new Guid("35e8a8da-14e6-4539-9878-a4a7fc9d6b6c"), 0.0, "General" },
                    { new Guid("4aadc26e-53bb-43ea-8806-55e23d740791"), 0.0, "VIP" },
                    { new Guid("6e2c172e-a037-4f44-aa88-60b6c472eaf0"), 0.0, "General" },
                    { new Guid("79b1c485-165b-4ce7-a430-e4b886f15f5d"), 1000.0, "VIP" }
                });

            migrationBuilder.InsertData(
                table: "Venues",
                columns: new[] { "VenueId", "City", "MaxCapacity", "Pincode", "State", "VenueAddress1", "VenueAddress2", "VenueName" },
                values: new object[,]
                {
                    { new Guid("0d2d14fe-d0e3-424b-be5d-8959ef34cf5d"), "Chicago", 150, "60601", "IL", "789 Broadway", "Suite 100", "Auditorium Hall" },
                    { new Guid("4c2dc371-5b15-4270-b971-1abc748f62cf"), "Chicago", 1000, "60601", "IL", "789 Broadway", "Suite 100", "Auditorium Hall" },
                    { new Guid("9d48d8ec-472c-4c48-ad03-b30210285d2b"), "New York", 50, "10001", "NY", "123 Main St", "", "Convention Center" },
                    { new Guid("cc479167-7ff6-4bf8-8371-860280551aa5"), "New York", 5000, "10001", "NY", "123 Main St", "", "Convention Center" },
                    { new Guid("dc164059-dee4-417c-9c69-2714c63d72f5"), "Los Angeles", 200, "90001", "CA", "456 Park Ave", "Near Central Park", "Open Grounds" },
                    { new Guid("f611b1b0-3dda-4bc8-b43f-8d635c642890"), "Los Angeles", 2000, "90001", "CA", "456 Park Ave", "Near Central Park", "Open Grounds" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3a072fb5-f5bd-480e-b449-44500fadd661", "03bd63a9-4378-42c5-a183-85c40eee1305" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7b185712-2303-499a-a78e-9f0413ca0f6b");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3a072fb5-f5bd-480e-b449-44500fadd661", "03bd63a9-4378-42c5-a183-85c40eee1305" });

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("0fbd2e3e-93eb-474a-9cfc-9eab12594f08"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("6a3e9825-91ee-411d-94c6-f6be8e5698e2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("6cd292f7-7651-4bf7-b6a2-c1ee12182428"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("858556a0-30b6-446c-bb3b-9765b0003b37"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("98a7b3fb-9ac7-4756-bce3-aabff85054c0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("b7557278-598b-498e-a381-a7040edb88b2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("d26007ff-19d0-44d3-91ea-c86a63bebec1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("e09154c3-1565-4d67-904c-3415c425a71b"));

            migrationBuilder.DeleteData(
                table: "TicketTypes",
                keyColumn: "TicketTypeId",
                keyValue: new Guid("1c21c8c4-25f2-41af-8834-3f9d5b844f0d"));

            migrationBuilder.DeleteData(
                table: "TicketTypes",
                keyColumn: "TicketTypeId",
                keyValue: new Guid("2f5646d7-14f4-4a41-b2b3-0e02150e1e7d"));

            migrationBuilder.DeleteData(
                table: "TicketTypes",
                keyColumn: "TicketTypeId",
                keyValue: new Guid("35e8a8da-14e6-4539-9878-a4a7fc9d6b6c"));

            migrationBuilder.DeleteData(
                table: "TicketTypes",
                keyColumn: "TicketTypeId",
                keyValue: new Guid("4aadc26e-53bb-43ea-8806-55e23d740791"));

            migrationBuilder.DeleteData(
                table: "TicketTypes",
                keyColumn: "TicketTypeId",
                keyValue: new Guid("6e2c172e-a037-4f44-aa88-60b6c472eaf0"));

            migrationBuilder.DeleteData(
                table: "TicketTypes",
                keyColumn: "TicketTypeId",
                keyValue: new Guid("79b1c485-165b-4ce7-a430-e4b886f15f5d"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "VenueId",
                keyValue: new Guid("0d2d14fe-d0e3-424b-be5d-8959ef34cf5d"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "VenueId",
                keyValue: new Guid("4c2dc371-5b15-4270-b971-1abc748f62cf"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "VenueId",
                keyValue: new Guid("9d48d8ec-472c-4c48-ad03-b30210285d2b"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "VenueId",
                keyValue: new Guid("cc479167-7ff6-4bf8-8371-860280551aa5"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "VenueId",
                keyValue: new Guid("dc164059-dee4-417c-9c69-2714c63d72f5"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "VenueId",
                keyValue: new Guid("f611b1b0-3dda-4bc8-b43f-8d635c642890"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3a072fb5-f5bd-480e-b449-44500fadd661");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "03bd63a9-4378-42c5-a183-85c40eee1305");

            migrationBuilder.DropColumn(
                name: "TicketTypeId",
                table: "Payments");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9ee7b5f0-bfae-47cc-80f5-2087c02783e8", null, "admin", "ADMIN" },
                    { "d8d4c074-6830-48bb-9bee-ea6d2d87165d", null, "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2594e973-a402-44ba-82f5-de3999767d1c", 0, "4ff3ff44-4910-4e2a-960b-0ef489a78c6f", "admin@admin.com", true, "Admin", "User", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEHNF0K50pWGsLJRFazqlJJ2eSYUoevT+lBq9u5AoKa94W8mvOB8O1cUfLBNX7lnrTg==", null, false, "ef81f9ee-fa17-480d-adfd-4dfe17c761a8", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryType" },
                values: new object[,]
                {
                    { new Guid("0bf17997-7455-4482-a496-dd92e2d562a1"), "Workshops" },
                    { new Guid("2043ff2d-cd3e-41f0-9b10-c5174ef70247"), "Workshops" },
                    { new Guid("3ae433e0-e93c-4782-bf09-8c7734f3b32e"), "Festivals" },
                    { new Guid("4545140d-c3c8-40f4-8855-9e7fb29baaf3"), "Exhibitions" },
                    { new Guid("776cc933-b93f-414e-94d9-b1e2c3422910"), "Career Fairs" },
                    { new Guid("89ae65d5-fefe-467a-8f52-76f561bcdbad"), "Seminars" },
                    { new Guid("8e5ff9e8-a11c-476e-a23d-7bba77126b66"), "Music" },
                    { new Guid("dd737700-2cf1-47e3-89e0-435febc1e762"), "Music concerts" }
                });

            migrationBuilder.InsertData(
                table: "TicketTypes",
                columns: new[] { "TicketTypeId", "Price", "Tickettype" },
                values: new object[,]
                {
                    { new Guid("236aff3a-fb82-42ee-af9f-ccb78c1b98d1"), 0.0, "VIP" },
                    { new Guid("4696a2fe-7397-4b48-a15b-60fb4cb33c70"), 0.0, "General" },
                    { new Guid("77d2d3cf-1e57-4526-97db-569bd527a6d8"), 0.0, "Economic" },
                    { new Guid("d3d9a4b6-846d-441a-9e7e-dd2fe09104ed"), 0.0, "General" },
                    { new Guid("d7103960-9280-4696-bf77-b505144b6715"), 500.0, "Economy" },
                    { new Guid("fd70ed16-ec0c-4252-9988-f0e073075abf"), 1000.0, "VIP" }
                });

            migrationBuilder.InsertData(
                table: "Venues",
                columns: new[] { "VenueId", "City", "MaxCapacity", "Pincode", "State", "VenueAddress1", "VenueAddress2", "VenueName" },
                values: new object[,]
                {
                    { new Guid("725dd39b-6ca2-4d96-9bfa-16e779872509"), "Chicago", 1000, "60601", "IL", "789 Broadway", "Suite 100", "Auditorium Hall" },
                    { new Guid("bdf44e73-8165-4206-9319-eab9053c7e13"), "New York", 5000, "10001", "NY", "123 Main St", "", "Convention Center" },
                    { new Guid("fb3dccb4-f0a7-44dc-ac1c-6c147cf00993"), "Los Angeles", 2000, "90001", "CA", "456 Park Ave", "Near Central Park", "Open Grounds" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "9ee7b5f0-bfae-47cc-80f5-2087c02783e8", "2594e973-a402-44ba-82f5-de3999767d1c" });
        }
    }
}
