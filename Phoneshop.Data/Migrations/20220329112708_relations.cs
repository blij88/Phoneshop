using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Phoneshop.Data.Migrations
{
    public partial class relations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDateTime",
                value: new DateTime(2022, 3, 29, 10, 56, 40, 712, DateTimeKind.Local).AddTicks(6427));

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDateTime",
                value: new DateTime(2022, 3, 29, 10, 56, 40, 712, DateTimeKind.Local).AddTicks(7036));

            migrationBuilder.UpdateData(
                table: "phones",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDateTime",
                value: new DateTime(2022, 3, 29, 10, 56, 40, 705, DateTimeKind.Local).AddTicks(8732));

            migrationBuilder.UpdateData(
                table: "phones",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDateTime",
                value: new DateTime(2022, 3, 29, 10, 56, 40, 710, DateTimeKind.Local).AddTicks(2104));

            migrationBuilder.UpdateData(
                table: "phones",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDateTime",
                value: new DateTime(2022, 3, 29, 10, 56, 40, 710, DateTimeKind.Local).AddTicks(2179));

            migrationBuilder.UpdateData(
                table: "phones",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDateTime",
                value: new DateTime(2022, 3, 29, 10, 56, 40, 710, DateTimeKind.Local).AddTicks(2184));

            migrationBuilder.UpdateData(
                table: "phones",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDateTime",
                value: new DateTime(2022, 3, 29, 10, 56, 40, 710, DateTimeKind.Local).AddTicks(2188));
        }
    }
}
