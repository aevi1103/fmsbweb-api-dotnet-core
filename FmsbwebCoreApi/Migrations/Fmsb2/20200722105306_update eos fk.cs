using Microsoft.EntityFrameworkCore.Migrations;

namespace FmsbwebCoreApi.Migrations.Fmsb2
{
    public partial class updateeosfk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EndOfShiftReports_Machines_MachinesMachineId",
                table: "EndOfShiftReports");

            migrationBuilder.DropIndex(
                name: "IX_EndOfShiftReports_MachinesMachineId",
                table: "EndOfShiftReports");

            migrationBuilder.DropColumn(
                name: "MachineId",
                table: "EndOfShiftReports");

            migrationBuilder.DropColumn(
                name: "MachinesMachineId",
                table: "EndOfShiftReports");

            migrationBuilder.AddColumn<int>(
                name: "MachineId1",
                table: "EndOfShiftReports",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_EndOfShiftReports_MachineId1",
                table: "EndOfShiftReports",
                column: "MachineId1");

            migrationBuilder.AddForeignKey(
                name: "FK_EndOfShiftReports_Machines_MachineId1",
                table: "EndOfShiftReports",
                column: "MachineId1",
                principalTable: "Machines",
                principalColumn: "machineId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EndOfShiftReports_Machines_MachineId1",
                table: "EndOfShiftReports");

            migrationBuilder.DropIndex(
                name: "IX_EndOfShiftReports_MachineId1",
                table: "EndOfShiftReports");

            migrationBuilder.DropColumn(
                name: "MachineId1",
                table: "EndOfShiftReports");

            migrationBuilder.AddColumn<int>(
                name: "MachineId",
                table: "EndOfShiftReports",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MachinesMachineId",
                table: "EndOfShiftReports",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_EndOfShiftReports_MachinesMachineId",
                table: "EndOfShiftReports",
                column: "MachinesMachineId");

            migrationBuilder.AddForeignKey(
                name: "FK_EndOfShiftReports_Machines_MachinesMachineId",
                table: "EndOfShiftReports",
                column: "MachinesMachineId",
                principalTable: "Machines",
                principalColumn: "machineId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
