using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EventManagementAPI.Migrations
{
    /// <inheritdoc />
    public partial class newupdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2dbb14ad-1ed8-4ac8-8a43-19a055613e11");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "28e7d83d-2718-4c8b-9c82-7ff1c1af3f54", "63fa27bc-b652-4568-a29a-78a48801b75e" });

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("05ce5746-437f-44d9-867f-9c82a7bc998c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("6fd1a66f-6402-4bad-9c92-48d100dea0a7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("7b8a0a20-a83e-4724-91ca-e665950e01ae"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("94bd6fd0-146a-4899-bb5c-65f7dced5c36"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("f6c8cb29-005c-4ad9-b738-b0c65973aef6"));

            migrationBuilder.DeleteData(
                table: "TicketTypes",
                keyColumn: "TicketTypeId",
                keyValue: new Guid("8becd15b-1c7c-47ba-9845-bb1db627e3d8"));

            migrationBuilder.DeleteData(
                table: "TicketTypes",
                keyColumn: "TicketTypeId",
                keyValue: new Guid("de8569ac-63ea-4a37-a38f-87dd9f424fa3"));

            migrationBuilder.DeleteData(
                table: "TicketTypes",
                keyColumn: "TicketTypeId",
                keyValue: new Guid("ea9f928c-2fc8-4a47-830c-696cf8dc811c"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "28e7d83d-2718-4c8b-9c82-7ff1c1af3f54");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "63fa27bc-b652-4568-a29a-78a48801b75e");

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

            migrationBuilder.CreateIndex(
                name: "IX_Events_VenueId",
                table: "Events",
                column: "VenueId");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Venues_VenueId",
                table: "Events",
                column: "VenueId",
                principalTable: "Venues",
                principalColumn: "VenueId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Venues_VenueId",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Events_VenueId",
                table: "Events");

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
                    { "28e7d83d-2718-4c8b-9c82-7ff1c1af3f54", null, "admin", "ADMIN" },
                    { "2dbb14ad-1ed8-4ac8-8a43-19a055613e11", null, "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "63fa27bc-b652-4568-a29a-78a48801b75e", 0, "5cd069fc-0df0-4342-bd84-a0cd5c0ed41c", "admin@admin.com", true, "Admin", "User", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEDIXOj0GS067gkCuAqf6c/braKnlkCVPLMviCmq9QUY3xHfytzzhQ2qEh+blYoSdKw==", null, false, "a68563f6-66b7-47a8-8633-c82b1244e985", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryType" },
                values: new object[,]
                {
                    { new Guid("05ce5746-437f-44d9-867f-9c82a7bc998c"), "Seminars" },
                    { new Guid("6fd1a66f-6402-4bad-9c92-48d100dea0a7"), "Music concerts" },
                    { new Guid("7b8a0a20-a83e-4724-91ca-e665950e01ae"), "Festivals" },
                    { new Guid("94bd6fd0-146a-4899-bb5c-65f7dced5c36"), "Exhibitions" },
                    { new Guid("f6c8cb29-005c-4ad9-b738-b0c65973aef6"), "Workshops" }
                });

            migrationBuilder.InsertData(
                table: "TicketTypes",
                columns: new[] { "TicketTypeId", "Tickettype" },
                values: new object[,]
                {
                    { new Guid("8becd15b-1c7c-47ba-9845-bb1db627e3d8"), "Economic" },
                    { new Guid("de8569ac-63ea-4a37-a38f-87dd9f424fa3"), "General" },
                    { new Guid("ea9f928c-2fc8-4a47-830c-696cf8dc811c"), "VIP" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "28e7d83d-2718-4c8b-9c82-7ff1c1af3f54", "63fa27bc-b652-4568-a29a-78a48801b75e" });
        }
    }
}
