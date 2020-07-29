using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FmsbwebCoreApi.Migrations.Fmsb2
{
    public partial class addendofshifttable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EndOfShiftReports",
                columns: table => new
                {
                    EndOfShiftReportId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShiftDate = table.Column<DateTime>(nullable: false),
                    Shift = table.Column<string>(nullable: true),
                    MachineId = table.Column<int>(nullable: false),
                    MachinesMachineId = table.Column<int>(nullable: true),
                    ScrapComment = table.Column<string>(nullable: true),
                    DowntimeComment = table.Column<string>(nullable: true),
                    TimeStamp = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EndOfShiftReports", x => x.EndOfShiftReportId);
                    table.ForeignKey(
                        name: "FK_EndOfShiftReports_Machines_MachinesMachineId",
                        column: x => x.MachinesMachineId,
                        principalTable: "Machines",
                        principalColumn: "machineId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EndOfShiftReports_MachinesMachineId",
                table: "EndOfShiftReports",
                column: "MachinesMachineId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EndOfShiftReports");
        }
    }
}
