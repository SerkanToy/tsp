using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tsp.api.Migrations
{
    /// <inheritdoc />
    public partial class initone : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "SurName", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("ff4dbf3c-ce20-4e35-befd-1f1d89bd56d5"), 0, "ce83f710-bb94-4c40-86fc-3e470f6a056f", "stoy@windowslive.com", false, false, null, "Serkan", "STOY@WINDOWSLIVE.COM", "STOY", "AQAAAAIAAYagAAAAEH0WBIbbAiro1uoobHHMg2Rzkwg2S2mHJOupqco07mYy+W0l6akcYCa/nRCpGZV4Pg==", "0(533) 656 30 95", false, "34dba9ac-9429-46e5-b487-431fea750382", "TOY", false, "stoy" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ff4dbf3c-ce20-4e35-befd-1f1d89bd56d5"));
        }
    }
}
