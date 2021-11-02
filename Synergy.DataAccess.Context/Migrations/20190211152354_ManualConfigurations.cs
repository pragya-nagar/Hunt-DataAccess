using Microsoft.EntityFrameworkCore.Migrations;

namespace Synergy.DataAccess.Context.Migrations
{
    public partial class ManualConfigurations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("drop index main.\"IX_Bid_EventId_Number\"");
            migrationBuilder.Sql("CREATE UNIQUE INDEX \"IX_Bid_EventId_Number\" ON main.\"Bid\" (\"EventId\", \"Number\") WHERE \"DeletedOn\" IS NULL");
            migrationBuilder.Sql("ALTER SEQUENCE \"main\".\"County_Id_seq\" RESTART WITH 1000");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}
