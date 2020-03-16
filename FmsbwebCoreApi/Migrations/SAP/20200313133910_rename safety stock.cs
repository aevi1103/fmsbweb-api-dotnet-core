using Microsoft.EntityFrameworkCore.Migrations;

namespace FmsbwebCoreApi.Migrations.SAP
{
    public partial class renamesafetystock : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SafetyStock",
                table: "SAP_Dump_With_SafetyStock",
                newName: "Safety Stock");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Safety Stock",
                table: "SAP_Dump_With_SafetyStock",
                newName: "SafetyStock");
        }
    }
}
