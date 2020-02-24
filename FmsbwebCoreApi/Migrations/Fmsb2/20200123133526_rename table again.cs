using Microsoft.EntityFrameworkCore.Migrations;

namespace FmsbwebCoreApi.Migrations.Fmsb2
{
    public partial class renametableagain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DepartmeKpiTarget");

            migrationBuilder.CreateTable(
                name: "KpiTarget",
                columns: table => new
                {
                    KpiTargetId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TargetType = table.Column<string>(nullable: true),
                    Department = table.Column<string>(nullable: true),
                    MonthNumber = table.Column<int>(nullable: false),
                    OaeTarget = table.Column<decimal>(nullable: false),
                    ScrapRateTarget = table.Column<decimal>(nullable: false),
                    PpmhTarget = table.Column<decimal>(nullable: false),
                    DowntimeRateTarget = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KpiTarget", x => x.KpiTargetId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KpiTarget");

            migrationBuilder.CreateTable(
                name: "DepartmeKpiTarget",
                columns: table => new
                {
                    DepartmentKpiTargetId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DowntimeRateTarget = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MonthNumber = table.Column<int>(type: "int", nullable: false),
                    OaeTarget = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PpmhTarget = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ScrapRateTarget = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmeKpiTarget", x => x.DepartmentKpiTargetId);
                });
        }
    }
}
