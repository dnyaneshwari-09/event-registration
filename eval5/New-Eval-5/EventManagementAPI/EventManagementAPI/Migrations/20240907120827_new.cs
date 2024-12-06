using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EventManagementAPI.Migrations
{
    /// <inheritdoc />
    public partial class @new : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Registrations_UserEventSelections_UserEventSelectionId",
                table: "Registrations");

            migrationBuilder.DropTable(
                name: "UserEventSelections");

            migrationBuilder.DropIndex(
                name: "IX_Registrations_UserEventSelectionId",
                table: "Registrations");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b1eea35f-eecc-441a-a264-c658bdeba44b");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fefa3925-c282-47c9-8e20-ee2307ac6127", "69157985-a25d-4e91-84ce-f3484e6a977e" });

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("28945ff4-e7c0-4d86-9641-f740982ab3f8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("8c8dd9bb-80be-40d3-af7e-829c71f0964b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("936d7afa-7ace-4bdd-b1b1-876f81763f7d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("a3b7b941-6f63-413f-9819-811ee9e9a392"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("f21a3050-300b-4b20-945e-8e7cb7b05280"));

            migrationBuilder.DeleteData(
                table: "TicketTypes",
                keyColumn: "TicketTypeId",
                keyValue: new Guid("206a868f-3c8c-49d7-816d-fefeeb57012d"));

            migrationBuilder.DeleteData(
                table: "TicketTypes",
                keyColumn: "TicketTypeId",
                keyValue: new Guid("21f06520-07cf-48d8-811e-c5808f09e918"));

            migrationBuilder.DeleteData(
                table: "TicketTypes",
                keyColumn: "TicketTypeId",
                keyValue: new Guid("2b7e178a-7eab-46a5-9a6a-bdde27ddb414"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fefa3925-c282-47c9-8e20-ee2307ac6127");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69157985-a25d-4e91-84ce-f3484e6a977e");

            migrationBuilder.DropColumn(
                name: "UserEventSelectionId",
                table: "Registrations");

            migrationBuilder.DropColumn(
                name: "EventAddress",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "EventCity",
                table: "Events");

            migrationBuilder.RenameColumn(
                name: "MaxCapacity",
                table: "Events",
                newName: "VipTicketCount");

            migrationBuilder.AddColumn<int>(
                name: "CapacityAvailable",
                table: "Events",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EconomyTicketCount",
                table: "Events",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GeneralTicketCount",
                table: "Events",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "OrganizerId",
                table: "Events",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "VenueId",
                table: "Events",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Venues",
                columns: table => new
                {
                    VenueId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VenueName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    VenueAddress1 = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    VenueAddress2 = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    City = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    State = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Pincode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    MaxCapacity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Venues", x => x.VenueId);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Venues");

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

            migrationBuilder.DropColumn(
                name: "CapacityAvailable",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "EconomyTicketCount",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "GeneralTicketCount",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "OrganizerId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "VenueId",
                table: "Events");

            migrationBuilder.RenameColumn(
                name: "VipTicketCount",
                table: "Events",
                newName: "MaxCapacity");

            migrationBuilder.AddColumn<Guid>(
                name: "UserEventSelectionId",
                table: "Registrations",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EventAddress",
                table: "Events",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EventCity",
                table: "Events",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "UserEventSelections",
                columns: table => new
                {
                    UserEventSelectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EventId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserEventSelections", x => x.UserEventSelectionId);
                    table.ForeignKey(
                        name: "FK_UserEventSelections_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserEventSelections_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b1eea35f-eecc-441a-a264-c658bdeba44b", null, "user", "USER" },
                    { "fefa3925-c282-47c9-8e20-ee2307ac6127", null, "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "69157985-a25d-4e91-84ce-f3484e6a977e", 0, "8f668285-a13c-4c6d-ae21-fac19849a4e3", "admin@admin.com", true, "Admin", "User", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEPqNjaIrW0BnhOixj/drsrDEISAytqeZyzxB3iFATVhPAx0tOs4BaK2JZnKCOcem4Q==", null, false, "c2af0cf9-9d26-4cf8-a508-ded1839c90cf", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryType" },
                values: new object[,]
                {
                    { new Guid("28945ff4-e7c0-4d86-9641-f740982ab3f8"), "Seminars" },
                    { new Guid("8c8dd9bb-80be-40d3-af7e-829c71f0964b"), "Workshops" },
                    { new Guid("936d7afa-7ace-4bdd-b1b1-876f81763f7d"), "Exhibitions" },
                    { new Guid("a3b7b941-6f63-413f-9819-811ee9e9a392"), "Music concerts" },
                    { new Guid("f21a3050-300b-4b20-945e-8e7cb7b05280"), "Festivals" }
                });

            migrationBuilder.InsertData(
                table: "TicketTypes",
                columns: new[] { "TicketTypeId", "Tickettype" },
                values: new object[,]
                {
                    { new Guid("206a868f-3c8c-49d7-816d-fefeeb57012d"), "Economic" },
                    { new Guid("21f06520-07cf-48d8-811e-c5808f09e918"), "General" },
                    { new Guid("2b7e178a-7eab-46a5-9a6a-bdde27ddb414"), "VIP" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "fefa3925-c282-47c9-8e20-ee2307ac6127", "69157985-a25d-4e91-84ce-f3484e6a977e" });

            migrationBuilder.CreateIndex(
                name: "IX_Registrations_UserEventSelectionId",
                table: "Registrations",
                column: "UserEventSelectionId");

            migrationBuilder.CreateIndex(
                name: "IX_UserEventSelections_EventId",
                table: "UserEventSelections",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_UserEventSelections_UserId",
                table: "UserEventSelections",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Registrations_UserEventSelections_UserEventSelectionId",
                table: "Registrations",
                column: "UserEventSelectionId",
                principalTable: "UserEventSelections",
                principalColumn: "UserEventSelectionId");
        }
    }
}
