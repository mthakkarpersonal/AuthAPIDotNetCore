using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AuthAPIDotNetCore.Migrations
{
    /// <inheritdoc />
    public partial class identityadded1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("2ef39f5e-8df2-4539-a98c-821345b9b1bf"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("da772f7f-ead6-4e28-aa69-eb4f4558cf41"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("36474c55-fb38-4784-a653-4401eaa5d43d"), null, "User", "USER" },
                    { new Guid("50d0df3b-1986-4198-a76a-555cd9b6e208"), null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("36474c55-fb38-4784-a653-4401eaa5d43d"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("50d0df3b-1986-4198-a76a-555cd9b6e208"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("2ef39f5e-8df2-4539-a98c-821345b9b1bf"), null, "User", "USER" },
                    { new Guid("da772f7f-ead6-4e28-aa69-eb4f4558cf41"), null, "Admin", "ADMIN" }
                });
        }
    }
}
