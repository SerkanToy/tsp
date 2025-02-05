using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tsp.api.Migrations
{
    /// <inheritdoc />
    public partial class initFour : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
