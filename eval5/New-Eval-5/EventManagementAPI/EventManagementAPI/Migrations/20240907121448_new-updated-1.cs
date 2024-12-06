using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EventManagementAPI.Migrations
{
    /// <inheritdoc />
    public partial class newupdated1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "230fb890-6231-4236-9b92-5e9ab7bc39e2");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3a5b9a4d-5cbb-4944-a8f2-2a08c07c93f5", "b9414e24-68af-4346-8cf6-60dcf183ea1d" });

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("23c87921-3021-4189-b5d9-693a59c4f652"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("5f962df2-5054-4e07-bc43-b425effe71e6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("6f00ba8f-4b1b-4e13-bd1b-3605655c8491"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("db3581e1-4ded-4857-a93d-f01443e89502"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("f79a56c0-b72f-4be6-b561-54285d75c7ce"));

            migrationBuilder.DeleteData(
                table: "TicketTypes",
                keyColumn: "TicketTypeId",
                keyValue: new Guid("b5645b14-5bca-4463-9008-7e1bee1b8a17"));

            migrationBuilder.DeleteData(
                table: "TicketTypes",
                keyColumn: "TicketTypeId",
                keyValue: new Guid("b7451a16-ce7b-4e77-afcd-7984f7a55dc6"));

            migrationBuilder.DeleteData(
                table: "TicketTypes",
                keyColumn: "TicketTypeId",
                keyValue: new Guid("d9a337bf-9d23-41ea-a3b8-6fa40f7c1529"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3a5b9a4d-5cbb-4944-a8f2-2a08c07c93f5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b9414e24-68af-4346-8cf6-60dcf183ea1d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "c293706f-3421-4bbd-a8c3-409431c876b8", null, "admin", "ADMIN" },
                    { "d4f9fbc2-4bf2-458c-afe4-f55f8e130f70", null, "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "fd46847d-d5e3-4021-b01d-bea547ae5d43", 0, "9a2d0390-ca23-4881-9ae4-d6559b9c8b01", "admin@admin.com", true, "Admin", "User", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEFlKey2AsjEwERrHbVcu1GiWcXBi58+cOOMO3a/XbnrApoTQ4Avoo0PiccHl5FTChw==", null, false, "f52dd224-82e5-45ca-be9f-431718874e96", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryType" },
                values: new object[,]
                {
                    { new Guid("7cb008a6-7b19-4d63-b83d-31877ed6b6d3"), "Festivals" },
                    { new Guid("9b7ac0f5-5305-4234-82d9-c5b593723c28"), "Music concerts" },
                    { new Guid("a62ef713-86fc-4f8d-bba4-9c00bc64c0ef"), "Seminars" },
                    { new Guid("c168515a-f524-48f7-a327-ca2c670acbb1"), "Workshops" },
                    { new Guid("dc1cf351-4a41-4439-aea8-bdeb1bae2d7f"), "Exhibitions" }
                });

            migrationBuilder.InsertData(
                table: "TicketTypes",
                columns: new[] { "TicketTypeId", "Tickettype" },
                values: new object[,]
                {
                    { new Guid("5e87c003-a445-453f-a3ff-899c67e65c3f"), "General" },
                    { new Guid("61a09703-fe58-4abf-8190-d0ee848ab63c"), "Economic" },
                    { new Guid("d6217103-c626-4797-812f-ff11dc6fa300"), "VIP" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c293706f-3421-4bbd-a8c3-409431c876b8", "fd46847d-d5e3-4021-b01d-bea547ae5d43" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d4f9fbc2-4bf2-458c-afe4-f55f8e130f70");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c293706f-3421-4bbd-a8c3-409431c876b8", "fd46847d-d5e3-4021-b01d-bea547ae5d43" });

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("7cb008a6-7b19-4d63-b83d-31877ed6b6d3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("9b7ac0f5-5305-4234-82d9-c5b593723c28"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("a62ef713-86fc-4f8d-bba4-9c00bc64c0ef"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("c168515a-f524-48f7-a327-ca2c670acbb1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("dc1cf351-4a41-4439-aea8-bdeb1bae2d7f"));

            migrationBuilder.DeleteData(
                table: "TicketTypes",
                keyColumn: "TicketTypeId",
                keyValue: new Guid("5e87c003-a445-453f-a3ff-899c67e65c3f"));

            migrationBuilder.DeleteData(
                table: "TicketTypes",
                keyColumn: "TicketTypeId",
                keyValue: new Guid("61a09703-fe58-4abf-8190-d0ee848ab63c"));

            migrationBuilder.DeleteData(
                table: "TicketTypes",
                keyColumn: "TicketTypeId",
                keyValue: new Guid("d6217103-c626-4797-812f-ff11dc6fa300"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c293706f-3421-4bbd-a8c3-409431c876b8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd46847d-d5e3-4021-b01d-bea547ae5d43");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "230fb890-6231-4236-9b92-5e9ab7bc39e2", null, "user", "USER" },
                    { "3a5b9a4d-5cbb-4944-a8f2-2a08c07c93f5", null, "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b9414e24-68af-4346-8cf6-60dcf183ea1d", 0, "890629b8-b8ea-44f3-a62d-f91e5e746ab0", "admin@admin.com", true, "Admin", "User", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEPT/shAE4Jf11ml+5hN+SmGEu2zcM0gkMxLmKYf/e0Cm8/o5s73N74kDS1JNROscBQ==", null, false, "b78877c9-71b7-4948-8b72-075d83482b7f", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryType" },
                values: new object[,]
                {
                    { new Guid("23c87921-3021-4189-b5d9-693a59c4f652"), "Seminars" },
                    { new Guid("5f962df2-5054-4e07-bc43-b425effe71e6"), "Exhibitions" },
                    { new Guid("6f00ba8f-4b1b-4e13-bd1b-3605655c8491"), "Festivals" },
                    { new Guid("db3581e1-4ded-4857-a93d-f01443e89502"), "Music concerts" },
                    { new Guid("f79a56c0-b72f-4be6-b561-54285d75c7ce"), "Workshops" }
                });

            migrationBuilder.InsertData(
                table: "TicketTypes",
                columns: new[] { "TicketTypeId", "Tickettype" },
                values: new object[,]
                {
                    { new Guid("b5645b14-5bca-4463-9008-7e1bee1b8a17"), "General" },
                    { new Guid("b7451a16-ce7b-4e77-afcd-7984f7a55dc6"), "VIP" },
                    { new Guid("d9a337bf-9d23-41ea-a3b8-6fa40f7c1529"), "Economic" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3a5b9a4d-5cbb-4944-a8f2-2a08c07c93f5", "b9414e24-68af-4346-8cf6-60dcf183ea1d" });
        }
    }
}
