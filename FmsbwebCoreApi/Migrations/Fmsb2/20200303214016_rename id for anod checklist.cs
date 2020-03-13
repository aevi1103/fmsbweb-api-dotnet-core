using Microsoft.EntityFrameworkCore.Migrations;

namespace FmsbwebCoreApi.Migrations.Fmsb2
{
    public partial class renameidforanodchecklist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AnodizeChecklist",
                table: "AnodizeChecklist");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "AnodizeChecklist");

            migrationBuilder.AddColumn<int>(
                name: "AnodizeChecklistId",
                table: "AnodizeChecklist",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AnodizeChecklist",
                table: "AnodizeChecklist",
                column: "AnodizeChecklistId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AnodizeChecklist",
                table: "AnodizeChecklist");

            migrationBuilder.DropColumn(
                name: "AnodizeChecklistId",
                table: "AnodizeChecklist");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "AnodizeChecklist",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AnodizeChecklist",
                table: "AnodizeChecklist",
                column: "Id");
        }
    }
}
