using Microsoft.EntityFrameworkCore.Migrations;

namespace FmsbwebCoreApi.Migrations.Fmsb2
{
    public partial class REMOVEVALUEANDCOMForanodchecklist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comments",
                table: "AnodizeChecklist");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "AnodizeChecklist");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Comments",
                table: "AnodizeChecklist",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Value",
                table: "AnodizeChecklist",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
