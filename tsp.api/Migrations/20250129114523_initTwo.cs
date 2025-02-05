using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace tsp.api.Migrations
{
    /// <inheritdoc />
    public partial class initTwo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("a37170b1-88cb-476d-a6a5-04733e2d6134"), "a414ce02-a099-4682-bf86-ff99f51ae72d", "superuser", "SUPERUSER" },
                    { new Guid("a94d44f9-50d3-436b-a44c-54f8ade3e196"), "34e202e7-e627-409b-8312-ea7bd442bb37", "admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ff4dbf3c-ce20-4e35-befd-1f1d89bd56d5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b2b7cca-61c0-4d94-b537-6c584a6834ce", "AQAAAAIAAYagAAAAEGdtLA8puFLl6vQIcJ3kaun2+Vm965R/VnY8KWvrZoNR8Pl58mRayx0cyzbjGvRN7g==", "302e6420-9c8a-47f3-b8ca-d2320d8148e0" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("a37170b1-88cb-476d-a6a5-04733e2d6134"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("a94d44f9-50d3-436b-a44c-54f8ade3e196"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ff4dbf3c-ce20-4e35-befd-1f1d89bd56d5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ce83f710-bb94-4c40-86fc-3e470f6a056f", "AQAAAAIAAYagAAAAEH0WBIbbAiro1uoobHHMg2Rzkwg2S2mHJOupqco07mYy+W0l6akcYCa/nRCpGZV4Pg==", "34dba9ac-9429-46e5-b487-431fea750382" });
        }
    }
}
