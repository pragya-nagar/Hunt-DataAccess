using System;

using Microsoft.EntityFrameworkCore.Migrations;

namespace Synergy.DataAccess.Context.Migrations
{
    public partial class SatIsActiveForRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "main",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("046fe758-8915-4697-8d97-26024d0357ed"),
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                schema: "main",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("0648e7b1-f99e-415d-8055-3978690cbc48"),
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                schema: "main",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("12a97928-3f1c-4980-887e-678ed0f7f46b"),
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                schema: "main",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("20027277-8151-4ef3-85be-897d55299fd0"),
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                schema: "main",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("2fac0431-b3af-41db-a8ad-38b3b3450d5a"),
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                schema: "main",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("5b33ee78-382c-41e2-8c5d-1e8e7a438ff2"),
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                schema: "main",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("6bb98555-2725-48fd-bc41-6fdde5ef369f"),
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                schema: "main",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("6fd53327-8211-4f26-a292-b7c3bb9bb1e8"),
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                schema: "main",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("8913025b-bd62-42f7-964d-a9904ff0d8e9"),
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                schema: "main",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("99f44ca4-57ed-4310-89cf-4700c29cf649"),
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                schema: "main",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("a4c28fdc-4799-48a5-a2f2-8462a6bc52bd"),
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                schema: "main",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("b5aa4adb-dae2-4d98-b790-d699ae6d598a"),
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                schema: "main",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("df712225-1e14-472e-b9b9-bef411113663"),
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                schema: "main",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("eb9745bd-1285-440d-b5d8-c35370b38906"),
                column: "IsActive",
                value: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "main",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("046fe758-8915-4697-8d97-26024d0357ed"),
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                schema: "main",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("0648e7b1-f99e-415d-8055-3978690cbc48"),
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                schema: "main",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("12a97928-3f1c-4980-887e-678ed0f7f46b"),
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                schema: "main",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("20027277-8151-4ef3-85be-897d55299fd0"),
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                schema: "main",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("2fac0431-b3af-41db-a8ad-38b3b3450d5a"),
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                schema: "main",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("5b33ee78-382c-41e2-8c5d-1e8e7a438ff2"),
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                schema: "main",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("6bb98555-2725-48fd-bc41-6fdde5ef369f"),
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                schema: "main",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("6fd53327-8211-4f26-a292-b7c3bb9bb1e8"),
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                schema: "main",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("8913025b-bd62-42f7-964d-a9904ff0d8e9"),
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                schema: "main",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("99f44ca4-57ed-4310-89cf-4700c29cf649"),
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                schema: "main",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("a4c28fdc-4799-48a5-a2f2-8462a6bc52bd"),
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                schema: "main",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("b5aa4adb-dae2-4d98-b790-d699ae6d598a"),
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                schema: "main",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("df712225-1e14-472e-b9b9-bef411113663"),
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                schema: "main",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("eb9745bd-1285-440d-b5d8-c35370b38906"),
                column: "IsActive",
                value: false);
        }
    }
}
