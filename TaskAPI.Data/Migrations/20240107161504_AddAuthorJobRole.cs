using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskAPI.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddAuthorJobRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "JobRole",
                table: "Authors",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "JobRole",
                value: "Developer");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddressNo", "JobRole" },
                values: new object[] { "11", "Developer" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddressNo", "JobRole" },
                values: new object[] { "12", "System Enginner" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddressNo", "JobRole" },
                values: new object[] { "13", "QA" });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2024, 1, 7, 21, 45, 4, 768, DateTimeKind.Local).AddTicks(5185), new DateTime(2024, 1, 9, 21, 45, 4, 768, DateTimeKind.Local).AddTicks(5194) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2024, 1, 7, 21, 45, 4, 768, DateTimeKind.Local).AddTicks(5201), new DateTime(2024, 1, 9, 21, 45, 4, 768, DateTimeKind.Local).AddTicks(5201) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2024, 1, 7, 21, 45, 4, 768, DateTimeKind.Local).AddTicks(5203), new DateTime(2024, 1, 9, 21, 45, 4, 768, DateTimeKind.Local).AddTicks(5203) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JobRole",
                table: "Authors");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddressNo",
                value: "10");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddressNo",
                value: "10");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddressNo",
                value: "10");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2024, 1, 7, 10, 10, 40, 47, DateTimeKind.Local).AddTicks(5089), new DateTime(2024, 1, 9, 10, 10, 40, 47, DateTimeKind.Local).AddTicks(5103) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2024, 1, 7, 10, 10, 40, 47, DateTimeKind.Local).AddTicks(5108), new DateTime(2024, 1, 9, 10, 10, 40, 47, DateTimeKind.Local).AddTicks(5109) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2024, 1, 7, 10, 10, 40, 47, DateTimeKind.Local).AddTicks(5110), new DateTime(2024, 1, 9, 10, 10, 40, 47, DateTimeKind.Local).AddTicks(5110) });
        }
    }
}
