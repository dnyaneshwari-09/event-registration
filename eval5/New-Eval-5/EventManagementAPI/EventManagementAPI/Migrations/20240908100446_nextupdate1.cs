using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EventManagementAPI.Migrations
{
    /// <inheritdoc />
    public partial class nextupdate1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Organizers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bdc53ee1-adc7-427e-ae19-369048744257");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7640f232-4990-48fd-b64d-04440ea6c6f4", "e72d21d5-f183-4f44-8a69-d2bff5002d46" });

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("00395c75-7d3a-44b8-bdbd-ec1cc56562d8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("43a5d43b-51a8-46bd-9ad2-e73f44884537"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("86c4ba23-77f4-46fd-b186-1f0be9550da8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("8715b63c-223f-4b65-a24f-2910afb75ada"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("901212dd-6def-4d45-b63d-d18971203ecd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("9b819b16-7a36-4952-af03-2b39df53a889"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("f5beee69-1159-4e34-bc5f-0b8699447447"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("fb94fb2f-dbde-4ad4-91ff-3696892921e0"));

            migrationBuilder.DeleteData(
                table: "TicketTypes",
                keyColumn: "TicketTypeId",
                keyValue: new Guid("4ad4c709-ce3d-4ce4-ae23-58387a486fac"));

            migrationBuilder.DeleteData(
                table: "TicketTypes",
                keyColumn: "TicketTypeId",
                keyValue: new Guid("7c8fe573-308b-4226-9964-d0280c547393"));

            migrationBuilder.DeleteData(
                table: "TicketTypes",
                keyColumn: "TicketTypeId",
                keyValue: new Guid("8eb93732-fd3c-4764-822d-9c793f7d9072"));

            migrationBuilder.DeleteData(
                table: "TicketTypes",
                keyColumn: "TicketTypeId",
                keyValue: new Guid("d6f787f2-9d0a-45c8-8c88-bad27f8f95f8"));

            migrationBuilder.DeleteData(
                table: "TicketTypes",
                keyColumn: "TicketTypeId",
                keyValue: new Guid("f97c14dc-8868-496f-a10c-8a85b59543fb"));

            migrationBuilder.DeleteData(
                table: "TicketTypes",
                keyColumn: "TicketTypeId",
                keyValue: new Guid("fef4a94c-774c-484d-af6a-26431fc12cae"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "VenueId",
                keyValue: new Guid("0338cb42-06ee-4e8e-ac1f-d987ddc21ef3"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "VenueId",
                keyValue: new Guid("5ffef0be-bb91-4a2b-b136-b41df3bea391"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "VenueId",
                keyValue: new Guid("b1c7c254-ec73-4cda-ad24-3ea26c532a16"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7640f232-4990-48fd-b64d-04440ea6c6f4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e72d21d5-f183-4f44-8a69-d2bff5002d46");

            migrationBuilder.DropColumn(
                name: "OrganizerId",
                table: "Events");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "OrganizerId",
                table: "Events",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Organizers",
                columns: table => new
                {
                    OrganizerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EventId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Contact = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    OrganizerName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizers", x => x.OrganizerId);
                    table.ForeignKey(
                        name: "FK_Organizers_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7640f232-4990-48fd-b64d-04440ea6c6f4", null, "admin", "ADMIN" },
                    { "bdc53ee1-adc7-427e-ae19-369048744257", null, "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e72d21d5-f183-4f44-8a69-d2bff5002d46", 0, "7a6986a1-c3b8-456f-ae3a-3004fa0bd51d", "admin@admin.com", true, "Admin", "User", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEJCLsIX61f/RDMnw1QRnPhiDZITqbT355tq5o3/zxbuw7624q2NGX/Fb5/pPpPyRjg==", null, false, "8e689efb-b71a-468a-b476-b586ab230c8a", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryType" },
                values: new object[,]
                {
                    { new Guid("00395c75-7d3a-44b8-bdbd-ec1cc56562d8"), "Workshops" },
                    { new Guid("43a5d43b-51a8-46bd-9ad2-e73f44884537"), "Seminars" },
                    { new Guid("86c4ba23-77f4-46fd-b186-1f0be9550da8"), "Career Fairs" },
                    { new Guid("8715b63c-223f-4b65-a24f-2910afb75ada"), "Workshops" },
                    { new Guid("901212dd-6def-4d45-b63d-d18971203ecd"), "Festivals" },
                    { new Guid("9b819b16-7a36-4952-af03-2b39df53a889"), "Exhibitions" },
                    { new Guid("f5beee69-1159-4e34-bc5f-0b8699447447"), "Music concerts" },
                    { new Guid("fb94fb2f-dbde-4ad4-91ff-3696892921e0"), "Music" }
                });

            migrationBuilder.InsertData(
                table: "TicketTypes",
                columns: new[] { "TicketTypeId", "Price", "Tickettype" },
                values: new object[,]
                {
                    { new Guid("4ad4c709-ce3d-4ce4-ae23-58387a486fac"), 0.0, "General" },
                    { new Guid("7c8fe573-308b-4226-9964-d0280c547393"), 500.0, "Economy" },
                    { new Guid("8eb93732-fd3c-4764-822d-9c793f7d9072"), 0.0, "General" },
                    { new Guid("d6f787f2-9d0a-45c8-8c88-bad27f8f95f8"), 1000.0, "VIP" },
                    { new Guid("f97c14dc-8868-496f-a10c-8a85b59543fb"), 0.0, "VIP" },
                    { new Guid("fef4a94c-774c-484d-af6a-26431fc12cae"), 0.0, "Economic" }
                });

            migrationBuilder.InsertData(
                table: "Venues",
                columns: new[] { "VenueId", "City", "MaxCapacity", "Pincode", "State", "VenueAddress1", "VenueAddress2", "VenueName" },
                values: new object[,]
                {
                    { new Guid("0338cb42-06ee-4e8e-ac1f-d987ddc21ef3"), "Chicago", 1000, "60601", "IL", "789 Broadway", "Suite 100", "Auditorium Hall" },
                    { new Guid("5ffef0be-bb91-4a2b-b136-b41df3bea391"), "New York", 5000, "10001", "NY", "123 Main St", "", "Convention Center" },
                    { new Guid("b1c7c254-ec73-4cda-ad24-3ea26c532a16"), "Los Angeles", 2000, "90001", "CA", "456 Park Ave", "Near Central Park", "Open Grounds" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "7640f232-4990-48fd-b64d-04440ea6c6f4", "e72d21d5-f183-4f44-8a69-d2bff5002d46" });

            migrationBuilder.CreateIndex(
                name: "IX_Organizers_EventId",
                table: "Organizers",
                column: "EventId");
        }
    }
}
