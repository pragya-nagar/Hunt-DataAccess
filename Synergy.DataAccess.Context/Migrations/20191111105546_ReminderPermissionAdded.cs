using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Synergy.DataAccess.Context.Migrations
{
    public partial class ReminderPermissionAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "main",
                table: "Permission",
                columns: new[] { "Id", "Action", "CreatedById", "CreatedOn", "DeletedOn", "Description", "ModifiedById", "ModifiedOn" },
                values: new object[,]
                {
                    { 64, "CRM.Reminder.Read", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 65, "CRM.Reminder.Write", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "main",
                table: "Permission",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "Permission",
                keyColumn: "Id",
                keyValue: 65);
        }
    }
}
