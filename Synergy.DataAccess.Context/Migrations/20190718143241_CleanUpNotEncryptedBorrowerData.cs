using Microsoft.EntityFrameworkCore.Migrations;

namespace Synergy.DataAccess.Context.Migrations
{
    public partial class CleanUpNotEncryptedBorrowerData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sql = @"UPDATE main.""OpportunityBorrowerBase"" SET  ""SSN""= NULL, ""DateOfBirth""= NULL, ""TaxIdNumber""= NULL";
            migrationBuilder.Sql(sql, true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}
