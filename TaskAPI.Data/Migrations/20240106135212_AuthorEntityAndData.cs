using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TaskAPI.Data.Migrations
{
    /// <inheritdoc />
    public partial class AuthorEntityAndData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "Todos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "FullName" },
                values: new object[,]
                {
                    { 1, "Name 1" },
                    { 2, "Name 2" },
                    { 3, "Name 3" },
                    { 4, "Name 4" }
                });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "Created", "Due" },
                values: new object[] { 1, new DateTime(2024, 1, 6, 19, 22, 12, 134, DateTimeKind.Local).AddTicks(5654), new DateTime(2024, 1, 8, 19, 22, 12, 134, DateTimeKind.Local).AddTicks(5663) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "Created", "Due" },
                values: new object[] { 2, new DateTime(2024, 1, 6, 19, 22, 12, 134, DateTimeKind.Local).AddTicks(5668), new DateTime(2024, 1, 8, 19, 22, 12, 134, DateTimeKind.Local).AddTicks(5669) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "Created", "Due" },
                values: new object[] { 3, new DateTime(2024, 1, 6, 19, 22, 12, 134, DateTimeKind.Local).AddTicks(5671), new DateTime(2024, 1, 8, 19, 22, 12, 134, DateTimeKind.Local).AddTicks(5672) });

            migrationBuilder.CreateIndex(
                name: "IX_Todos_AuthorId",
                table: "Todos",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Todos_Authors_AuthorId",
                table: "Todos",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todos_Authors_AuthorId",
                table: "Todos");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropIndex(
                name: "IX_Todos_AuthorId",
                table: "Todos");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Todos");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2024, 1, 6, 11, 11, 5, 912, DateTimeKind.Local).AddTicks(3587), new DateTime(2024, 1, 8, 11, 11, 5, 912, DateTimeKind.Local).AddTicks(3596) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2024, 1, 6, 11, 11, 5, 912, DateTimeKind.Local).AddTicks(3603), new DateTime(2024, 1, 8, 11, 11, 5, 912, DateTimeKind.Local).AddTicks(3604) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2024, 1, 6, 11, 11, 5, 912, DateTimeKind.Local).AddTicks(3605), new DateTime(2024, 1, 8, 11, 11, 5, 912, DateTimeKind.Local).AddTicks(3605) });
        }
    }
}
