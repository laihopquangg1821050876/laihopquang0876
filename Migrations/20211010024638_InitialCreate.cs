using Microsoft.EntityFrameworkCore.Migrations;

namespace Laihopquang876.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LHQ0876",
                columns: table => new
                {
                    LHQid = table.Column<string>(type: "TEXT", nullable: false),
                    LHQName = table.Column<string>(type: "TEXT", nullable: true),
                    LHQGendeR = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LHQ0876", x => x.LHQid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LHQ0876");
        }
    }
}
