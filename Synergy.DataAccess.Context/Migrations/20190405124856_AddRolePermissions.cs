using System;

using Microsoft.EntityFrameworkCore.Migrations;

namespace Synergy.DataAccess.Context.Migrations
{
    public partial class AddRolePermissions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "main",
                table: "RolePermission",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DeletedOn", "ModifiedById", "ModifiedOn", "PermissionId", "RoleId" },
                values: new object[,]
                {
                    { 160, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new Guid("20027277-8151-4ef3-85be-897d55299fd0") },
                    { 161, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new Guid("df712225-1e14-472e-b9b9-bef411113663") },
                    { 162, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new Guid("eb9745bd-1285-440d-b5d8-c35370b38906") },
                    { 163, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new Guid("2fbbc95e-576c-4acb-b811-e1e1eca5c76a") },
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 163);
        }
    }
}
