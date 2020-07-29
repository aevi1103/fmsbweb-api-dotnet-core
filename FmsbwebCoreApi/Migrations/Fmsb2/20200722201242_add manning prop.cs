using Microsoft.EntityFrameworkCore.Migrations;

namespace FmsbwebCoreApi.Migrations.Fmsb2
{
    public partial class addmanningprop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Manning",
                table: "EndOfShiftReports",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Manning",
                table: "EndOfShiftReports");
        }
    }
}
