using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tsp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class createdatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorie",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateOnly>(type: "date", nullable: false),
                    CreateTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    UpdateDate = table.Column<DateOnly>(type: "date", nullable: true),
                    UpdateTime = table.Column<TimeOnly>(type: "time", nullable: true),
                    DeleteDate = table.Column<DateOnly>(type: "date", nullable: true),
                    DeleteTime = table.Column<TimeOnly>(type: "time", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorie", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Forms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FormNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateOnly>(type: "date", nullable: false),
                    CreateTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    UpdateDate = table.Column<DateOnly>(type: "date", nullable: true),
                    UpdateTime = table.Column<TimeOnly>(type: "time", nullable: true),
                    DeleteDate = table.Column<DateOnly>(type: "date", nullable: true),
                    DeleteTime = table.Column<TimeOnly>(type: "time", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Forms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateOnly>(type: "date", nullable: false),
                    CreateTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    UpdateDate = table.Column<DateOnly>(type: "date", nullable: true),
                    UpdateTime = table.Column<TimeOnly>(type: "time", nullable: true),
                    DeleteDate = table.Column<DateOnly>(type: "date", nullable: true),
                    DeleteTime = table.Column<TimeOnly>(type: "time", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductInfo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateOnly>(type: "date", nullable: false),
                    CreateTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    UpdateDate = table.Column<DateOnly>(type: "date", nullable: true),
                    UpdateTime = table.Column<TimeOnly>(type: "time", nullable: true),
                    DeleteDate = table.Column<DateOnly>(type: "date", nullable: true),
                    DeleteTime = table.Column<TimeOnly>(type: "time", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stock",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Pieces = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateOnly>(type: "date", nullable: false),
                    CreateTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    UpdateDate = table.Column<DateOnly>(type: "date", nullable: true),
                    UpdateTime = table.Column<TimeOnly>(type: "time", nullable: true),
                    DeleteDate = table.Column<DateOnly>(type: "date", nullable: true),
                    DeleteTime = table.Column<TimeOnly>(type: "time", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stock", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Unit",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateOnly>(type: "date", nullable: false),
                    CreateTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    UpdateDate = table.Column<DateOnly>(type: "date", nullable: true),
                    UpdateTime = table.Column<TimeOnly>(type: "time", nullable: true),
                    DeleteDate = table.Column<DateOnly>(type: "date", nullable: true),
                    DeleteTime = table.Column<TimeOnly>(type: "time", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateOnly>(type: "date", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateOnly>(type: "date", nullable: false),
                    CreateTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    UpdateDate = table.Column<DateOnly>(type: "date", nullable: true),
                    UpdateTime = table.Column<TimeOnly>(type: "time", nullable: true),
                    DeleteDate = table.Column<DateOnly>(type: "date", nullable: true),
                    DeleteTime = table.Column<TimeOnly>(type: "time", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubCategory",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateOnly>(type: "date", nullable: false),
                    CreateTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    UpdateDate = table.Column<DateOnly>(type: "date", nullable: true),
                    UpdateTime = table.Column<TimeOnly>(type: "time", nullable: true),
                    DeleteDate = table.Column<DateOnly>(type: "date", nullable: true),
                    DeleteTime = table.Column<TimeOnly>(type: "time", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubCategory_Categorie_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categorie",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreateDate", "CreateTime", "DateOfBirth", "DeleteDate", "DeleteTime", "Email", "FirstName", "IsActive", "LastName", "Password", "PhoneNumber", "Salt", "UpdateDate", "UpdateTime" },
                values: new object[] { new Guid("e633e5a9-06b6-4442-ab4c-63436d35a0f4"), new DateOnly(2025, 5, 27), new TimeOnly(15, 23, 52, 784).Add(TimeSpan.FromTicks(6172)), new DateOnly(1, 1, 1), null, null, "stoy@windowslive.com", "TOY", true, "Serkan", "8TeA/OjdEFEz5rCvVGS5t+uAWUIblWHst4+tXSJ8GnA=", "0(533) 656 30 95", "System.Byte[]", null, null });

            migrationBuilder.CreateIndex(
                name: "IX_SubCategory_CategoryId",
                table: "SubCategory",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Forms");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "ProductInfo");

            migrationBuilder.DropTable(
                name: "Stock");

            migrationBuilder.DropTable(
                name: "SubCategory");

            migrationBuilder.DropTable(
                name: "Unit");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Categorie");
        }
    }
}
