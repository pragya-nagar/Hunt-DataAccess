using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Synergy.DataAccess.Context.Migrations
{
    public partial class AddProcessingRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "main",
                table: "Permission",
                columns: new[] { "Id", "Action", "CreatedById", "CreatedOn", "DeletedOn", "Description", "ModifiedById", "ModifiedOn" },
                values: new object[,]
                {
                    { 58, "Processing.Loan.Read", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 59, "Processing.Loan.Write", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 60, "Admin.ProcessingMailMerge.Read", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 61, "Admin.ProcessingMailMerge.Write", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 62, "Admin.ProcessingMailMerge.Delete", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                schema: "main",
                table: "Role",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DeletedOn", "IsActive", "ModifiedById", "ModifiedOn", "Name", "PermissionId" },
                values: new object[,]
                {
                    { new Guid("65f7a408-d363-41be-9b34-aa1c5d75225d"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Processing", null },
                    { new Guid("02a17713-34ed-4a18-9316-e0148d66c5f3"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Processing Manager", null }
                });

            migrationBuilder.InsertData(
                schema: "main",
                table: "DepartmentRole",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DeletedOn", "DepartmentId", "IsManager", "ModifiedById", "ModifiedOn", "RoleId" },
                values: new object[,]
                {
                    { new Guid("201adf09-631e-4dfa-a527-737c1f889e13"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, false, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("65f7a408-d363-41be-9b34-aa1c5d75225d") },
                    { new Guid("201adf09-631e-4dfa-a527-737c1f889e14"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, true, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("02a17713-34ed-4a18-9316-e0148d66c5f3") }
                });

            migrationBuilder.InsertData(
                schema: "main",
                table: "RolePermission",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DeletedOn", "ModifiedById", "ModifiedOn", "PermissionId", "RoleId" },
                values: new object[,]
                {
                    { 215, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, new Guid("02a17713-34ed-4a18-9316-e0148d66c5f3") },
                    { 216, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, new Guid("02a17713-34ed-4a18-9316-e0148d66c5f3") },
                    { 217, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, new Guid("02a17713-34ed-4a18-9316-e0148d66c5f3") },
                    { 218, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, new Guid("02a17713-34ed-4a18-9316-e0148d66c5f3") },
                    { 219, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, new Guid("02a17713-34ed-4a18-9316-e0148d66c5f3") },
                    { 220, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, new Guid("02a17713-34ed-4a18-9316-e0148d66c5f3") },
                    { 221, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, new Guid("02a17713-34ed-4a18-9316-e0148d66c5f3") },
                    { 222, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, new Guid("02a17713-34ed-4a18-9316-e0148d66c5f3") },
                    { 223, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, new Guid("02a17713-34ed-4a18-9316-e0148d66c5f3") },
                    { 224, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, new Guid("02a17713-34ed-4a18-9316-e0148d66c5f3") },
                    { 225, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 55, new Guid("02a17713-34ed-4a18-9316-e0148d66c5f3") },
                    { 226, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 58, new Guid("02a17713-34ed-4a18-9316-e0148d66c5f3") },
                    { 227, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 59, new Guid("02a17713-34ed-4a18-9316-e0148d66c5f3") },
                    { 228, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, new Guid("02a17713-34ed-4a18-9316-e0148d66c5f3") },
                    { 229, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 41, new Guid("02a17713-34ed-4a18-9316-e0148d66c5f3") },
                    { 230, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 42, new Guid("02a17713-34ed-4a18-9316-e0148d66c5f3") },
                    { 231, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 43, new Guid("02a17713-34ed-4a18-9316-e0148d66c5f3") },
                    { 232, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("02a17713-34ed-4a18-9316-e0148d66c5f3") },
                    { 214, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, new Guid("02a17713-34ed-4a18-9316-e0148d66c5f3") },
                    { 213, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, new Guid("02a17713-34ed-4a18-9316-e0148d66c5f3") },
                    { 212, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, new Guid("02a17713-34ed-4a18-9316-e0148d66c5f3") },
                    { 211, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new Guid("02a17713-34ed-4a18-9316-e0148d66c5f3") },
                    { 192, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new Guid("65f7a408-d363-41be-9b34-aa1c5d75225d") },
                    { 193, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new Guid("65f7a408-d363-41be-9b34-aa1c5d75225d") },
                    { 194, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, new Guid("65f7a408-d363-41be-9b34-aa1c5d75225d") },
                    { 195, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, new Guid("65f7a408-d363-41be-9b34-aa1c5d75225d") },
                    { 196, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, new Guid("65f7a408-d363-41be-9b34-aa1c5d75225d") },
                    { 197, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, new Guid("65f7a408-d363-41be-9b34-aa1c5d75225d") },
                    { 198, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, new Guid("65f7a408-d363-41be-9b34-aa1c5d75225d") },
                    { 199, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, new Guid("65f7a408-d363-41be-9b34-aa1c5d75225d") },
                    { 200, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, new Guid("65f7a408-d363-41be-9b34-aa1c5d75225d") },
                    { 201, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, new Guid("65f7a408-d363-41be-9b34-aa1c5d75225d") },
                    { 202, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, new Guid("65f7a408-d363-41be-9b34-aa1c5d75225d") },
                    { 203, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, new Guid("65f7a408-d363-41be-9b34-aa1c5d75225d") },
                    { 204, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, new Guid("65f7a408-d363-41be-9b34-aa1c5d75225d") },
                    { 205, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, new Guid("65f7a408-d363-41be-9b34-aa1c5d75225d") },
                    { 206, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, new Guid("65f7a408-d363-41be-9b34-aa1c5d75225d") },
                    { 207, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 55, new Guid("65f7a408-d363-41be-9b34-aa1c5d75225d") },
                    { 208, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 58, new Guid("65f7a408-d363-41be-9b34-aa1c5d75225d") },
                    { 209, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 59, new Guid("65f7a408-d363-41be-9b34-aa1c5d75225d") },
                    { 210, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new Guid("02a17713-34ed-4a18-9316-e0148d66c5f3") },
                    { 233, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 61, new Guid("02a17713-34ed-4a18-9316-e0148d66c5f3") },
                    { 234, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 62, new Guid("02a17713-34ed-4a18-9316-e0148d66c5f3") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "main",
                table: "DepartmentRole",
                keyColumn: "Id",
                keyValue: new Guid("201adf09-631e-4dfa-a527-737c1f889e13"));

            migrationBuilder.DeleteData(
                schema: "main",
                table: "DepartmentRole",
                keyColumn: "Id",
                keyValue: new Guid("201adf09-631e-4dfa-a527-737c1f889e14"));

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "Permission",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "Permission",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "Permission",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "Permission",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "Permission",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("02a17713-34ed-4a18-9316-e0148d66c5f3"));

            migrationBuilder.DeleteData(
                schema: "main",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("65f7a408-d363-41be-9b34-aa1c5d75225d"));
        }
    }
}
