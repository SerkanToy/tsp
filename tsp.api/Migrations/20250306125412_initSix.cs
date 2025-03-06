using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace tsp.api.Migrations
{
    /// <inheritdoc />
    public partial class initSix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CategoryProduct",
                columns: table => new
                {
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryProduct", x => new { x.CategoryId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_CategoryProduct_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryProduct_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("a37170b1-88cb-476d-a6a5-04733e2d6134"),
                column: "ConcurrencyStamp",
                value: "67489700-e33f-4789-bc30-f4f334a62f42");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("a94d44f9-50d3-436b-a44c-54f8ade3e196"),
                column: "ConcurrencyStamp",
                value: "726cf17a-8742-434c-8d2e-c17ddd372efa");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ff4dbf3c-ce20-4e35-befd-1f1d89bd56d5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a0e55ac7-daa4-404b-92ff-e35cf82e6663", "AQAAAAIAAYagAAAAEB4SVwuCYEywcmQOY1Tcn4r4qNGdRmwdUshgGzbXMdH2IbLrs5Fui0EtOMRclnynlQ==", "dab94578-e039-4283-acee-58f63a3d5523" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("5aa8432b-992e-43cd-bc4c-da039e117217"), "Category 2" },
                    { new Guid("f4d3d3a3-3d3d-4d3d-3d3d-3d3d3d3d3d3d"), "Category 1" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0c4f2938-a450-4038-9c12-2270b30c1fd9"), "Product 3" },
                    { new Guid("2fd8acbe-8a33-43bc-9a8f-512162cd1993"), "Product 4" },
                    { new Guid("5aa8432b-992e-43cd-bc4c-da039e117217"), "Product 2" },
                    { new Guid("f4d3d3a3-3d3d-4d3d-3d3d-3d3d3d3d3d3d"), "Product 1" }
                });

            migrationBuilder.InsertData(
                table: "CategoryProduct",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { new Guid("5aa8432b-992e-43cd-bc4c-da039e117217"), new Guid("2fd8acbe-8a33-43bc-9a8f-512162cd1993") },
                    { new Guid("5aa8432b-992e-43cd-bc4c-da039e117217"), new Guid("5aa8432b-992e-43cd-bc4c-da039e117217") },
                    { new Guid("f4d3d3a3-3d3d-4d3d-3d3d-3d3d3d3d3d3d"), new Guid("0c4f2938-a450-4038-9c12-2270b30c1fd9") },
                    { new Guid("f4d3d3a3-3d3d-4d3d-3d3d-3d3d3d3d3d3d"), new Guid("f4d3d3a3-3d3d-4d3d-3d3d-3d3d3d3d3d3d") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryProduct_ProductId",
                table: "CategoryProduct",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryProduct");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Product");

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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ff4dbf3c-ce20-4e35-befd-1f1d89bd56d5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a92dac5e-8513-462d-a210-1cbf5edc866c", "AQAAAAIAAYagAAAAEMV+t4D+uHXE6jUxKL0/3LduoQGM3cinEL661Uyij3PiJ1YTj3KZ0r8KY6PkYhijpw==", "9b55804f-48eb-42c4-b949-3c96545ca9b3" });
        }
    }
}
