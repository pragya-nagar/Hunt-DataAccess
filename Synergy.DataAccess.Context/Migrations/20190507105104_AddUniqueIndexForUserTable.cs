using Microsoft.EntityFrameworkCore.Migrations;

namespace Synergy.DataAccess.Context.Migrations
{
    public partial class AddUniqueIndexForUserTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("CREATE UNIQUE INDEX \"IX_User_Email_IsActive\" ON main.\"User\" (\"Email\", \"IsActive\") WHERE \"DeletedOn\" IS NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}
