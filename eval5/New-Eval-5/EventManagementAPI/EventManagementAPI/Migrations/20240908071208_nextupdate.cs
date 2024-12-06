using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EventManagementAPI.Migrations
{
    /// <inheritdoc />
    public partial class nextupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "TicketTypes",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "Price",
                table: "TicketTypes");

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
    }
}
