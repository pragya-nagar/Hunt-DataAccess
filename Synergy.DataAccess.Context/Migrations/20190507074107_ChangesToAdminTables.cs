using System;

using Microsoft.EntityFrameworkCore.Migrations;

namespace Synergy.DataAccess.Context.Migrations
{
    public partial class ChangesToAdminTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                schema: "main",
                table: "UserAudit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                schema: "main",
                table: "User",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                schema: "main",
                table: "RoleAudit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                schema: "main",
                table: "Role",
                nullable: false,
                defaultValue: true);

            migrationBuilder.UpdateData(
                schema: "main",
                table: "Module",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2019, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "main",
                table: "Module",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2019, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "main",
                table: "TemplateType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2019, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "main",
                table: "TemplateType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2019, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "main",
                table: "TemplateType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2019, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.CreateIndex(
                name: "IX_Role_Name",
                schema: "main",
                table: "Role",
                column: "Name",
                unique: true);

            migrationBuilder.Sql("ALTER SEQUENCE \"main\".\"RolePermission_Id_seq\" RESTART WITH 1000");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Role_Name",
                schema: "main",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "IsActive",
                schema: "main",
                table: "UserAudit");

            migrationBuilder.DropColumn(
                name: "IsActive",
                schema: "main",
                table: "User");

            migrationBuilder.DropColumn(
                name: "IsActive",
                schema: "main",
                table: "RoleAudit");

            migrationBuilder.DropColumn(
                name: "IsActive",
                schema: "main",
                table: "Role");

            migrationBuilder.UpdateData(
                schema: "main",
                table: "Module",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2019, 4, 24, 12, 2, 15, 869, DateTimeKind.Utc).AddTicks(9867), new DateTime(2019, 4, 24, 12, 2, 15, 869, DateTimeKind.Utc).AddTicks(9869) });

            migrationBuilder.UpdateData(
                schema: "main",
                table: "Module",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2019, 4, 24, 12, 2, 15, 869, DateTimeKind.Utc).AddTicks(9895), new DateTime(2019, 4, 24, 12, 2, 15, 869, DateTimeKind.Utc).AddTicks(9895) });

            migrationBuilder.UpdateData(
                schema: "main",
                table: "TemplateType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2019, 4, 24, 12, 2, 15, 877, DateTimeKind.Utc).AddTicks(5046), new DateTime(2019, 4, 24, 12, 2, 15, 877, DateTimeKind.Utc).AddTicks(5047) });

            migrationBuilder.UpdateData(
                schema: "main",
                table: "TemplateType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2019, 4, 24, 12, 2, 15, 877, DateTimeKind.Utc).AddTicks(5124), new DateTime(2019, 4, 24, 12, 2, 15, 877, DateTimeKind.Utc).AddTicks(5126) });

            migrationBuilder.UpdateData(
                schema: "main",
                table: "TemplateType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2019, 4, 24, 12, 2, 15, 877, DateTimeKind.Utc).AddTicks(5130), new DateTime(2019, 4, 24, 12, 2, 15, 877, DateTimeKind.Utc).AddTicks(5131) });
        }
    }
}
