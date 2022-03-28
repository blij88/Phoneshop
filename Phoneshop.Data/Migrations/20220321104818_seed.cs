using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Phoneshop.Data.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "phones",
                type: "decimal(38,17)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "brands",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "brands",
                columns: new[] { "Id", "CreateDateTime", "Name", "UpdateDateTime" },
                values: new object[] { 1, new DateTime(2022, 3, 21, 11, 48, 17, 905, DateTimeKind.Local).AddTicks(1331), "Motorola", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "brands",
                columns: new[] { "Id", "CreateDateTime", "Name", "UpdateDateTime" },
                values: new object[] { 2, new DateTime(2022, 3, 21, 11, 48, 17, 905, DateTimeKind.Local).AddTicks(1868), "Xiaomi", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "phones",
                columns: new[] { "Id", "BrandId", "Camera", "Color", "CreateDateTime", "Deleted", "Description", "Discount", "DiscountType", "Image", "Price", "Processor", "ScreenResolution", "Type", "UpdateDateTime" },
                values: new object[,]
                {
                    { 1, 1, null, "blood", new DateTime(2022, 3, 21, 11, 48, 17, 894, DateTimeKind.Local).AddTicks(2655), false, "testing", 0.0, 0, null, 54m, null, null, "test1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 1, null, "blood", new DateTime(2022, 3, 21, 11, 48, 17, 900, DateTimeKind.Local).AddTicks(7232), false, "testing", 0.0, 0, null, 54m, null, null, "test3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 1, null, "blood", new DateTime(2022, 3, 21, 11, 48, 17, 900, DateTimeKind.Local).AddTicks(7243), false, "testing", 0.0, 0, null, 54m, null, null, "test5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 2, null, "blood", new DateTime(2022, 3, 21, 11, 48, 17, 900, DateTimeKind.Local).AddTicks(7178), false, "testing", 0.0, 0, null, 54m, null, null, "test2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 2, null, "blood", new DateTime(2022, 3, 21, 11, 48, 17, 900, DateTimeKind.Local).AddTicks(7238), false, "testing", 0.0, 0, null, 54m, null, null, "test4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "phones",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "phones",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "phones",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "phones",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "phones",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "phones",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(38,17)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "brands",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
