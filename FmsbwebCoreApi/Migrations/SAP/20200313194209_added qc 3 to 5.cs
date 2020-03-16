using Microsoft.EntityFrameworkCore.Migrations;

namespace FmsbwebCoreApi.Migrations.SAP
{
    public partial class addedqc3to5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "QC03",
                table: "SAP_Dump_With_SafetyStock",
                type: "decimal(18, 2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "QC04",
                table: "SAP_Dump_With_SafetyStock",
                type: "decimal(18, 2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "QC05",
                table: "SAP_Dump_With_SafetyStock",
                type: "decimal(18, 2)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QC03",
                table: "SAP_Dump_With_SafetyStock");

            migrationBuilder.DropColumn(
                name: "QC04",
                table: "SAP_Dump_With_SafetyStock");

            migrationBuilder.DropColumn(
                name: "QC05",
                table: "SAP_Dump_With_SafetyStock");
        }
    }
}
