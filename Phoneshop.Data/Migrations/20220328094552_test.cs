using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Phoneshop.Data.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDateTime", "Name" },
                values: new object[] { new DateTime(2022, 3, 28, 11, 45, 51, 501, DateTimeKind.Local).AddTicks(6939), "string" });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDateTime",
                value: new DateTime(2022, 3, 28, 11, 45, 51, 501, DateTimeKind.Local).AddTicks(7352));

            migrationBuilder.UpdateData(
                table: "phones",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDateTime",
                value: new DateTime(2022, 3, 28, 11, 45, 51, 494, DateTimeKind.Local).AddTicks(8816));

            migrationBuilder.UpdateData(
                table: "phones",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDateTime",
                value: new DateTime(2022, 3, 28, 11, 45, 51, 498, DateTimeKind.Local).AddTicks(6438));

            migrationBuilder.UpdateData(
                table: "phones",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDateTime",
                value: new DateTime(2022, 3, 28, 11, 45, 51, 498, DateTimeKind.Local).AddTicks(6478));

            migrationBuilder.UpdateData(
                table: "phones",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDateTime",
                value: new DateTime(2022, 3, 28, 11, 45, 51, 498, DateTimeKind.Local).AddTicks(6485));

            migrationBuilder.UpdateData(
                table: "phones",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDateTime",
                value: new DateTime(2022, 3, 28, 11, 45, 51, 498, DateTimeKind.Local).AddTicks(6488));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDateTime", "Name" },
                values: new object[] { new DateTime(2022, 3, 21, 11, 48, 17, 905, DateTimeKind.Local).AddTicks(1331), "Motorola" });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDateTime",
                value: new DateTime(2022, 3, 21, 11, 48, 17, 905, DateTimeKind.Local).AddTicks(1868));

            migrationBuilder.UpdateData(
                table: "phones",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDateTime",
                value: new DateTime(2022, 3, 21, 11, 48, 17, 894, DateTimeKind.Local).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "phones",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDateTime",
                value: new DateTime(2022, 3, 21, 11, 48, 17, 900, DateTimeKind.Local).AddTicks(7178));

            migrationBuilder.UpdateData(
                table: "phones",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDateTime",
                value: new DateTime(2022, 3, 21, 11, 48, 17, 900, DateTimeKind.Local).AddTicks(7232));

            migrationBuilder.UpdateData(
                table: "phones",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDateTime",
                value: new DateTime(2022, 3, 21, 11, 48, 17, 900, DateTimeKind.Local).AddTicks(7238));

            migrationBuilder.UpdateData(
                table: "phones",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDateTime",
                value: new DateTime(2022, 3, 21, 11, 48, 17, 900, DateTimeKind.Local).AddTicks(7243));
        }
    }
}
