using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace nha3.Data.Migrations
{
    public partial class nhap3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", "6a671ec0-27c2-4a5e-a3af-fa54dbbf8316", "Admin", "Admin" },
                    { "2", "da337f13-dc68-4130-803c-e2bf88c52f7a", "Customer", "Customer" },
                    { "3", "4aad6e11-5799-4026-9659-0454fb45c0ee", "StoreOwner", "StoreOwner" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "3e5dcaee-89f1-4ef0-9fd9-45b8a90ba381", "admin@gmail.com", false, false, null, null, "admin@gmail.com", "AQAAAAEAACcQAAAAECPyii/DiNA1JAlR+UWq1XtMNvJOh9i6g3IJbPcGraCvGBUV7L7D758nu7ZnwVQLjw==", null, false, "637c2b37-ce7c-492a-87f2-109eb9e82273", false, "admin@gmail.com" },
                    { "2", 0, "0b291c6d-8ba4-4f32-bc9c-fd8dd7d8fbe2", "customer@gmail.com", false, false, null, null, "customer@gmail.com", "AQAAAAEAACcQAAAAEIW8vG9UYdD5SanI0+0yGZOJfURQBZ9JWTf/1+5nCbkRm9fdsCzyxJu9548NGtCMCg==", null, false, "03c28842-0785-44f0-966d-e33bcd41a90b", false, "customer@gmail.com" },
                    { "3", 0, "ddb89678-af3b-4e20-8c68-9a7b359bc51f", "storeowner@gmail.com", false, false, null, null, "storeowner@gmail.com", "AQAAAAEAACcQAAAAEI9XwHchhBNG2UTZqXo4aAv+B3DOZIfm+HgXw03e+JUmj5vOPCt3zn01M5D0zwToFQ==", null, false, "b9ecc395-3a1e-4c7e-90cf-61caff835688", false, "storeowner@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "1" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2", "2" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3", "3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "3" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3");
        }
    }
}
