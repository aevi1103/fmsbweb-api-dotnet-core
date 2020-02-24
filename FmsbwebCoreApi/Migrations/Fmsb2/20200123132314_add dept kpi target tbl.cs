using Microsoft.EntityFrameworkCore.Migrations;

namespace FmsbwebCoreApi.Migrations.Fmsb2
{
    public partial class adddeptkpitargettbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DepartmeKpiTarget",
                columns: table => new
                {
                    DepartmentKpiTargetsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(nullable: true),
                    MonthNumber = table.Column<int>(nullable: false),
                    OaeTarget = table.Column<decimal>(nullable: false),
                    ScrapRateTarget = table.Column<decimal>(nullable: false),
                    PpmhTarget = table.Column<decimal>(nullable: false),
                    DowntimeRateTarget = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmeKpiTarget", x => x.DepartmentKpiTargetsId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DepartmeKpiTarget");
        }
    }
}
