using Microsoft.EntityFrameworkCore.Migrations;

namespace FmsbwebCoreApi.Migrations.Fmsb2
{
    public partial class updateeosrenamemachineprop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EndOfShiftReports_Machines_MachinesId",
                table: "EndOfShiftReports");

            migrationBuilder.DropIndex(
                name: "IX_EndOfShiftReports_MachinesId",
                table: "EndOfShiftReports");

            migrationBuilder.DropColumn(
                name: "MachinesId",
                table: "EndOfShiftReports");

            migrationBuilder.AddColumn<int>(
                name: "MachineId",
                table: "EndOfShiftReports",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_EndOfShiftReports_MachineId",
                table: "EndOfShiftReports",
                column: "MachineId");

            migrationBuilder.AddForeignKey(
                name: "FK_EndOfShiftReports_Machines_MachineId",
                table: "EndOfShiftReports",
                column: "MachineId",
                principalTable: "Machines",
                principalColumn: "machineId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EndOfShiftReports_Machines_MachineId",
                table: "EndOfShiftReports");

            migrationBuilder.DropIndex(
                name: "IX_EndOfShiftReports_MachineId",
                table: "EndOfShiftReports");

            migrationBuilder.DropColumn(
                name: "MachineId",
                table: "EndOfShiftReports");

            migrationBuilder.AddColumn<int>(
                name: "MachinesId",
                table: "EndOfShiftReports",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_EndOfShiftReports_MachinesId",
                table: "EndOfShiftReports",
                column: "MachinesId");

            migrationBuilder.AddForeignKey(
                name: "FK_EndOfShiftReports_Machines_MachinesId",
                table: "EndOfShiftReports",
                column: "MachinesId",
                principalTable: "Machines",
                principalColumn: "machineId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
