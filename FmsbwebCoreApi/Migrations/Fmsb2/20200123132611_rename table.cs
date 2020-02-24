using Microsoft.EntityFrameworkCore.Migrations;

namespace FmsbwebCoreApi.Migrations.Fmsb2
{
    public partial class renametable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DepartmeKpiTarget",
                table: "DepartmeKpiTarget");

            migrationBuilder.DropColumn(
                name: "DepartmentKpiTargetsId",
                table: "DepartmeKpiTarget");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentKpiTargetId",
                table: "DepartmeKpiTarget",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DepartmeKpiTarget",
                table: "DepartmeKpiTarget",
                column: "DepartmentKpiTargetId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DepartmeKpiTarget",
                table: "DepartmeKpiTarget");

            migrationBuilder.DropColumn(
                name: "DepartmentKpiTargetId",
                table: "DepartmeKpiTarget");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentKpiTargetsId",
                table: "DepartmeKpiTarget",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DepartmeKpiTarget",
                table: "DepartmeKpiTarget",
                column: "DepartmentKpiTargetsId");
        }
    }
}
