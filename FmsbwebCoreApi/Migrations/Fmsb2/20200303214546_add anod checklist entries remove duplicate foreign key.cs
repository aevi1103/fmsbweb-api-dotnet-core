using Microsoft.EntityFrameworkCore.Migrations;

namespace FmsbwebCoreApi.Migrations.Fmsb2
{
    public partial class addanodchecklistentriesremoveduplicateforeignkey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HrId",
                table: "AnodizeChecklistEntries");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HrId",
                table: "AnodizeChecklistEntries",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
