using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace tsp.api.Migrations
{
    /// <inheritdoc />
    public partial class initFive : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("a37170b1-88cb-476d-a6a5-04733e2d6134"),
                column: "ConcurrencyStamp",
                value: "1877e9a2-c68a-43ea-9c07-3145392bc350");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("a94d44f9-50d3-436b-a44c-54f8ade3e196"),
                column: "ConcurrencyStamp",
                value: "e0dc075a-3021-4444-9a45-7603bcc5285e");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId", "Discriminator" },
                values: new object[,]
                {
                    { new Guid("a37170b1-88cb-476d-a6a5-04733e2d6134"), new Guid("ff4dbf3c-ce20-4e35-befd-1f1d89bd56d5"), "UserRole" },
                    { new Guid("a94d44f9-50d3-436b-a44c-54f8ade3e196"), new Guid("ff4dbf3c-ce20-4e35-befd-1f1d89bd56d5"), "UserRole" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ff4dbf3c-ce20-4e35-befd-1f1d89bd56d5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a92dac5e-8513-462d-a210-1cbf5edc866c", "AQAAAAIAAYagAAAAEMV+t4D+uHXE6jUxKL0/3LduoQGM3cinEL661Uyij3PiJ1YTj3KZ0r8KY6PkYhijpw==", "9b55804f-48eb-42c4-b949-3c96545ca9b3" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("a37170b1-88cb-476d-a6a5-04733e2d6134"), new Guid("ff4dbf3c-ce20-4e35-befd-1f1d89bd56d5") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("a94d44f9-50d3-436b-a44c-54f8ade3e196"), new Guid("ff4dbf3c-ce20-4e35-befd-1f1d89bd56d5") });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("a37170b1-88cb-476d-a6a5-04733e2d6134"),
                column: "ConcurrencyStamp",
                value: "df85f96a-192f-43fb-9dab-c32f7191c8c4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("a94d44f9-50d3-436b-a44c-54f8ade3e196"),
                column: "ConcurrencyStamp",
                value: "9fe5bcfd-09cf-4250-97ef-d5cb2f561e0a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ff4dbf3c-ce20-4e35-befd-1f1d89bd56d5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bbb700f9-111b-4bce-bcfa-24cf589cba9d", "AQAAAAIAAYagAAAAEGcFsghtyoR1ABTR/Ge4kW89vrmTdLNwE2v+YzWXEDF+kdv51YjIJEZkLWIWT2aHFA==", "77105301-8c20-4037-bd84-a8ccdb3272b5" });
        }
    }
}
