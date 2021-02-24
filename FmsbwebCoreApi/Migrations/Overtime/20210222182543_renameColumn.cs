using Microsoft.EntityFrameworkCore.Migrations;

namespace FmsbwebCoreApi.Migrations.Overtime
{
    public partial class renameColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Note",
                table: "Overtime");

            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "Overtime",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comment",
                table: "Overtime");

            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "Overtime",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
