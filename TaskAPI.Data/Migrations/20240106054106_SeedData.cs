using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TaskAPI.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "Created", "Description", "Due", "Status", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 6, 11, 11, 5, 912, DateTimeKind.Local).AddTicks(3587), "Test", new DateTime(2024, 1, 8, 11, 11, 5, 912, DateTimeKind.Local).AddTicks(3596), 0, "Db record 1" },
                    { 2, new DateTime(2024, 1, 6, 11, 11, 5, 912, DateTimeKind.Local).AddTicks(3603), "Test2", new DateTime(2024, 1, 8, 11, 11, 5, 912, DateTimeKind.Local).AddTicks(3604), 0, "Db record 2" },
                    { 3, new DateTime(2024, 1, 6, 11, 11, 5, 912, DateTimeKind.Local).AddTicks(3605), "Test3", new DateTime(2024, 1, 8, 11, 11, 5, 912, DateTimeKind.Local).AddTicks(3605), 0, "Db record 3" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
