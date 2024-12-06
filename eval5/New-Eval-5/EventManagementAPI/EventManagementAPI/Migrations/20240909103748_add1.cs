using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EventManagementAPI.Migrations
{
    /// <inheritdoc />
    public partial class add1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "59f2c5bc-d596-4fcd-a40f-607e325cc479", null, "user", "USER" },
                    { "9498b13d-5afe-4201-b886-170d4406350f", null, "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e709ca82-8a7d-4a8e-8ad9-25d5a2b6fa7d", 0, "17dda0d4-1d26-4a21-89d5-71742fc3deda", "admin@admin.com", true, "Admin", "User", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEC5kuhCV3q/r44UYD/J8MAizmsW2RQBQ0bis5LPE+xNN6DheSjUAjtkn6J7OPLHQTQ==", null, false, "298ee598-69bf-4014-959e-2fb181e84fa9", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryType" },
                values: new object[,]
                {
                    { new Guid("098082f2-b7e1-46dd-bfae-e6e5e4961f65"), "Festivals" },
                    { new Guid("181be618-605a-41f3-b1ef-b7130ae7c57e"), "Music concerts" },
                    { new Guid("21423b8d-6457-49db-b09d-94f067223647"), "Workshops" },
                    { new Guid("583c8ad7-05dc-40b4-aeea-c517c47f9507"), "Seminars" },
                    { new Guid("a883f040-7b33-4fdc-9652-3566e1c02fba"), "Exhibitions" },
                    { new Guid("c865b9bb-886c-4208-8ea4-4a479d3b0407"), "Career Fairs" },
                    { new Guid("dd65cb96-b4ad-401d-a95d-14a506c0c79b"), "Music" },
                    { new Guid("fcb8989c-1568-40b3-a4f6-c9ec12954a59"), "Workshops" }
                });

            migrationBuilder.InsertData(
                table: "TicketTypes",
                columns: new[] { "TicketTypeId", "Price", "Tickettype" },
                values: new object[,]
                {
                    { new Guid("00ba7f6f-6fe2-4407-bc69-868ead37b580"), 1000.0, "VIP" },
                    { new Guid("5838cc5e-d73b-423a-92c8-541b10cd0385"), 500.0, "Economy" },
                    { new Guid("7eb43497-4573-408b-8098-6c86be527677"), 0.0, "Economic" },
                    { new Guid("b2726e35-db1d-43d5-aa53-039c33a092a1"), 0.0, "VIP" },
                    { new Guid("e0972fde-8415-4db0-a20e-c6fd9b44573e"), 0.0, "General" },
                    { new Guid("e46688d3-2299-4023-98a7-a28cdb933604"), 0.0, "General" }
                });

            migrationBuilder.InsertData(
                table: "Venues",
                columns: new[] { "VenueId", "City", "MaxCapacity", "Pincode", "State", "VenueAddress1", "VenueAddress2", "VenueName" },
                values: new object[,]
                {
                    { new Guid("188a0e44-fd5f-4668-8685-d090063ea7c5"), "Chicago", 150, "60601", "IL", "789 Broadway", "Suite 100", "Auditorium Hall" },
                    { new Guid("1c52b2f5-c323-49da-83dd-24bcfe69a50f"), "Chicago", 1000, "60601", "IL", "789 Broadway", "Suite 100", "Auditorium Hall" },
                    { new Guid("51a49c80-d53f-4036-bd68-c722ce7d38ce"), "New York", 5000, "10001", "NY", "123 Main St", "", "Convention Center" },
                    { new Guid("5efd1f9c-5e2c-4b1f-84a0-aecc7b3f0f03"), "Los Angeles", 200, "90001", "CA", "456 Park Ave", "Near Central Park", "Open Grounds" },
                    { new Guid("bcdfd5e4-5572-4c08-a4ee-c3d89abcf2a9"), "New York", 50, "10001", "NY", "123 Main St", "", "Convention Center" },
                    { new Guid("bff2f017-8be7-49b7-9502-24823fd40241"), "Los Angeles", 2000, "90001", "CA", "456 Park Ave", "Near Central Park", "Open Grounds" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "9498b13d-5afe-4201-b886-170d4406350f", "e709ca82-8a7d-4a8e-8ad9-25d5a2b6fa7d" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "59f2c5bc-d596-4fcd-a40f-607e325cc479");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9498b13d-5afe-4201-b886-170d4406350f", "e709ca82-8a7d-4a8e-8ad9-25d5a2b6fa7d" });

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("098082f2-b7e1-46dd-bfae-e6e5e4961f65"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("181be618-605a-41f3-b1ef-b7130ae7c57e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("21423b8d-6457-49db-b09d-94f067223647"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("583c8ad7-05dc-40b4-aeea-c517c47f9507"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("a883f040-7b33-4fdc-9652-3566e1c02fba"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("c865b9bb-886c-4208-8ea4-4a479d3b0407"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("dd65cb96-b4ad-401d-a95d-14a506c0c79b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("fcb8989c-1568-40b3-a4f6-c9ec12954a59"));

            migrationBuilder.DeleteData(
                table: "TicketTypes",
                keyColumn: "TicketTypeId",
                keyValue: new Guid("00ba7f6f-6fe2-4407-bc69-868ead37b580"));

            migrationBuilder.DeleteData(
                table: "TicketTypes",
                keyColumn: "TicketTypeId",
                keyValue: new Guid("5838cc5e-d73b-423a-92c8-541b10cd0385"));

            migrationBuilder.DeleteData(
                table: "TicketTypes",
                keyColumn: "TicketTypeId",
                keyValue: new Guid("7eb43497-4573-408b-8098-6c86be527677"));

            migrationBuilder.DeleteData(
                table: "TicketTypes",
                keyColumn: "TicketTypeId",
                keyValue: new Guid("b2726e35-db1d-43d5-aa53-039c33a092a1"));

            migrationBuilder.DeleteData(
                table: "TicketTypes",
                keyColumn: "TicketTypeId",
                keyValue: new Guid("e0972fde-8415-4db0-a20e-c6fd9b44573e"));

            migrationBuilder.DeleteData(
                table: "TicketTypes",
                keyColumn: "TicketTypeId",
                keyValue: new Guid("e46688d3-2299-4023-98a7-a28cdb933604"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "VenueId",
                keyValue: new Guid("188a0e44-fd5f-4668-8685-d090063ea7c5"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "VenueId",
                keyValue: new Guid("1c52b2f5-c323-49da-83dd-24bcfe69a50f"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "VenueId",
                keyValue: new Guid("51a49c80-d53f-4036-bd68-c722ce7d38ce"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "VenueId",
                keyValue: new Guid("5efd1f9c-5e2c-4b1f-84a0-aecc7b3f0f03"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "VenueId",
                keyValue: new Guid("bcdfd5e4-5572-4c08-a4ee-c3d89abcf2a9"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "VenueId",
                keyValue: new Guid("bff2f017-8be7-49b7-9502-24823fd40241"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9498b13d-5afe-4201-b886-170d4406350f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e709ca82-8a7d-4a8e-8ad9-25d5a2b6fa7d");

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
    }
}
