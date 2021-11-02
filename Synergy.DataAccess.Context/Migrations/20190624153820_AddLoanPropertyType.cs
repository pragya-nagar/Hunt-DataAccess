using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Synergy.DataAccess.Context.Migrations
{
    public partial class AddLoanPropertyType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Loan_User_AssigneeId",
                schema: "main",
                table: "Loan");

            migrationBuilder.DropForeignKey(
                name: "FK_Loan_LoanType_LoanTypeId",
                schema: "main",
                table: "Loan");

            migrationBuilder.DropColumn(
                name: "Age",
                schema: "main",
                table: "BorrowerAudit");

            migrationBuilder.DropColumn(
                name: "Age",
                schema: "main",
                table: "Borrower");

            migrationBuilder.AlterColumn<int>(
                name: "LoanTypeId",
                schema: "main",
                table: "LoanAudit",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<Guid>(
                name: "AssigneeId",
                schema: "main",
                table: "LoanAudit",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AddColumn<int>(
                name: "LoanPropertyTypeId",
                schema: "main",
                table: "LoanAudit",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "LoanTypeId",
                schema: "main",
                table: "Loan",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<Guid>(
                name: "AssigneeId",
                schema: "main",
                table: "Loan",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AddColumn<int>(
                name: "LoanPropertyTypeId",
                schema: "main",
                table: "Loan",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                schema: "main",
                table: "BorrowerAudit",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AddColumn<string>(
                name: "MiddleName",
                schema: "main",
                table: "BorrowerAudit",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                schema: "main",
                table: "Borrower",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AddColumn<string>(
                name: "MiddleName",
                schema: "main",
                table: "Borrower",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "LoanPropertyType",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedById = table.Column<Guid>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    LoanId = table.Column<Guid>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanPropertyType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LoanPropertyType_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LoanPropertyType_Loan_LoanId",
                        column: x => x.LoanId,
                        principalSchema: "main",
                        principalTable: "Loan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LoanPropertyType_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LoanPropertyTypeAudit",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    InsertedOn = table.Column<DateTime>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedById = table.Column<Guid>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    InsertedBy = table.Column<Guid>(nullable: false),
                    OperationId = table.Column<Guid>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanPropertyTypeAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateIndex(
                name: "IX_Loan_LoanPropertyTypeId",
                schema: "main",
                table: "Loan",
                column: "LoanPropertyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_LoanPropertyType_CreatedById",
                schema: "main",
                table: "LoanPropertyType",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_LoanPropertyType_LoanId",
                schema: "main",
                table: "LoanPropertyType",
                column: "LoanId");

            migrationBuilder.CreateIndex(
                name: "IX_LoanPropertyType_ModifiedById",
                schema: "main",
                table: "LoanPropertyType",
                column: "ModifiedById");

            migrationBuilder.AddForeignKey(
                name: "FK_Loan_User_AssigneeId",
                schema: "main",
                table: "Loan",
                column: "AssigneeId",
                principalSchema: "main",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Loan_LoanPropertyType_LoanPropertyTypeId",
                schema: "main",
                table: "Loan",
                column: "LoanPropertyTypeId",
                principalSchema: "main",
                principalTable: "LoanPropertyType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Loan_LoanType_LoanTypeId",
                schema: "main",
                table: "Loan",
                column: "LoanTypeId",
                principalSchema: "main",
                principalTable: "LoanType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Loan_User_AssigneeId",
                schema: "main",
                table: "Loan");

            migrationBuilder.DropForeignKey(
                name: "FK_Loan_LoanPropertyType_LoanPropertyTypeId",
                schema: "main",
                table: "Loan");

            migrationBuilder.DropForeignKey(
                name: "FK_Loan_LoanType_LoanTypeId",
                schema: "main",
                table: "Loan");

            migrationBuilder.DropTable(
                name: "LoanPropertyType",
                schema: "main");

            migrationBuilder.DropTable(
                name: "LoanPropertyTypeAudit",
                schema: "main");

            migrationBuilder.DropIndex(
                name: "IX_Loan_LoanPropertyTypeId",
                schema: "main",
                table: "Loan");

            migrationBuilder.DropColumn(
                name: "LoanPropertyTypeId",
                schema: "main",
                table: "LoanAudit");

            migrationBuilder.DropColumn(
                name: "LoanPropertyTypeId",
                schema: "main",
                table: "Loan");

            migrationBuilder.DropColumn(
                name: "MiddleName",
                schema: "main",
                table: "BorrowerAudit");

            migrationBuilder.DropColumn(
                name: "MiddleName",
                schema: "main",
                table: "Borrower");

            migrationBuilder.AlterColumn<int>(
                name: "LoanTypeId",
                schema: "main",
                table: "LoanAudit",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "AssigneeId",
                schema: "main",
                table: "LoanAudit",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LoanTypeId",
                schema: "main",
                table: "Loan",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "AssigneeId",
                schema: "main",
                table: "Loan",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                schema: "main",
                table: "BorrowerAudit",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Age",
                schema: "main",
                table: "BorrowerAudit",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                schema: "main",
                table: "Borrower",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Age",
                schema: "main",
                table: "Borrower",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Loan_User_AssigneeId",
                schema: "main",
                table: "Loan",
                column: "AssigneeId",
                principalSchema: "main",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Loan_LoanType_LoanTypeId",
                schema: "main",
                table: "Loan",
                column: "LoanTypeId",
                principalSchema: "main",
                principalTable: "LoanType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
