using Microsoft.EntityFrameworkCore.Migrations;

namespace FmsbwebCoreApi.Migrations.SAP
{
    public partial class renamepktoid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SAP_Dump_With_SafetyStock",
                table: "SAP_Dump_With_SafetyStock");

            migrationBuilder.DropColumn(
                name: "InventoryId",
                table: "SAP_Dump_With_SafetyStock");

            migrationBuilder.AddColumn<int>(
                name: "id",
                table: "SAP_Dump_With_SafetyStock",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SAP_Dump_With_SafetyStock",
                table: "SAP_Dump_With_SafetyStock",
                column: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SAP_Dump_With_SafetyStock",
                table: "SAP_Dump_With_SafetyStock");

            migrationBuilder.DropColumn(
                name: "id",
                table: "SAP_Dump_With_SafetyStock");

            migrationBuilder.AddColumn<int>(
                name: "InventoryId",
                table: "SAP_Dump_With_SafetyStock",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SAP_Dump_With_SafetyStock",
                table: "SAP_Dump_With_SafetyStock",
                column: "InventoryId");
        }
    }
}
