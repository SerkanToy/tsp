using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tsp.api.Migrations
{
    /// <inheritdoc />
    public partial class initThere : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUserRoles",
                type: "nvarchar(34)",
                maxLength: 34,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("a37170b1-88cb-476d-a6a5-04733e2d6134"),
                column: "ConcurrencyStamp",
                value: "8656c29a-f762-4f48-b8f2-39096c45419a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("a94d44f9-50d3-436b-a44c-54f8ade3e196"),
                column: "ConcurrencyStamp",
                value: "1ac8b658-dbe1-4500-ab2f-086054afb068");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ff4dbf3c-ce20-4e35-befd-1f1d89bd56d5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4e85f555-df78-4807-aa8e-f6476fe26899", "AQAAAAIAAYagAAAAEBy0Q6rgjSLR1zm/Z/X2yCw8sE48eF1WXvYTBvqVnMOB0qRpcVE4tayDNUv2/MhteQ==", "d734b110-641f-4f5b-96d9-e1252e15f8f9" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUserRoles");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("a37170b1-88cb-476d-a6a5-04733e2d6134"),
                column: "ConcurrencyStamp",
                value: "a414ce02-a099-4682-bf86-ff99f51ae72d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("a94d44f9-50d3-436b-a44c-54f8ade3e196"),
                column: "ConcurrencyStamp",
                value: "34e202e7-e627-409b-8312-ea7bd442bb37");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ff4dbf3c-ce20-4e35-befd-1f1d89bd56d5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b2b7cca-61c0-4d94-b537-6c584a6834ce", "AQAAAAIAAYagAAAAEGdtLA8puFLl6vQIcJ3kaun2+Vm965R/VnY8KWvrZoNR8Pl58mRayx0cyzbjGvRN7g==", "302e6420-9c8a-47f3-b8ca-d2320d8148e0" });
        }
    }
}
