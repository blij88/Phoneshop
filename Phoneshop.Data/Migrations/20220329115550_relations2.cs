using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Phoneshop.Data.Migrations
{
    public partial class relations2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDateTime",
                value: new DateTime(2022, 3, 29, 13, 55, 49, 470, DateTimeKind.Local).AddTicks(6799));

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDateTime",
                value: new DateTime(2022, 3, 29, 13, 55, 49, 470, DateTimeKind.Local).AddTicks(7409));

            migrationBuilder.UpdateData(
                table: "phones",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDateTime",
                value: new DateTime(2022, 3, 29, 13, 55, 49, 463, DateTimeKind.Local).AddTicks(2265));

            migrationBuilder.UpdateData(
                table: "phones",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDateTime",
                value: new DateTime(2022, 3, 29, 13, 55, 49, 467, DateTimeKind.Local).AddTicks(6488));

            migrationBuilder.UpdateData(
                table: "phones",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDateTime",
                value: new DateTime(2022, 3, 29, 13, 55, 49, 467, DateTimeKind.Local).AddTicks(6540));

            migrationBuilder.UpdateData(
                table: "phones",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDateTime",
                value: new DateTime(2022, 3, 29, 13, 55, 49, 467, DateTimeKind.Local).AddTicks(6548));

            migrationBuilder.UpdateData(
                table: "phones",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDateTime",
                value: new DateTime(2022, 3, 29, 13, 55, 49, 467, DateTimeKind.Local).AddTicks(6553));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDateTime",
                value: new DateTime(2022, 3, 29, 13, 27, 7, 801, DateTimeKind.Local).AddTicks(6899));

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDateTime",
                value: new DateTime(2022, 3, 29, 13, 27, 7, 801, DateTimeKind.Local).AddTicks(7377));

            migrationBuilder.UpdateData(
                table: "phones",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDateTime",
                value: new DateTime(2022, 3, 29, 13, 27, 7, 794, DateTimeKind.Local).AddTicks(4073));

            migrationBuilder.UpdateData(
                table: "phones",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDateTime",
                value: new DateTime(2022, 3, 29, 13, 27, 7, 799, DateTimeKind.Local).AddTicks(555));

            migrationBuilder.UpdateData(
                table: "phones",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDateTime",
                value: new DateTime(2022, 3, 29, 13, 27, 7, 799, DateTimeKind.Local).AddTicks(626));

            migrationBuilder.UpdateData(
                table: "phones",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDateTime",
                value: new DateTime(2022, 3, 29, 13, 27, 7, 799, DateTimeKind.Local).AddTicks(631));

            migrationBuilder.UpdateData(
                table: "phones",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDateTime",
                value: new DateTime(2022, 3, 29, 13, 27, 7, 799, DateTimeKind.Local).AddTicks(635));
        }
    }
}
