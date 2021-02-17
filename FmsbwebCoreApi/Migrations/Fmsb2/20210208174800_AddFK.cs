using Microsoft.EntityFrameworkCore.Migrations;

namespace FmsbwebCoreApi.Migrations.Fmsb2
{
    public partial class AddFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_CreateHxH_machineid",
                table: "CreateHxH",
                column: "machineid");

            migrationBuilder.AddForeignKey(
                name: "FK_CreateHxH_Department_deptid",
                table: "CreateHxH",
                column: "deptid",
                principalTable: "Department",
                principalColumn: "deptId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CreateHxH_Machines_machineid",
                table: "CreateHxH",
                column: "machineid",
                principalTable: "Machines",
                principalColumn: "machineId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CreateHxH_Department_deptid",
                table: "CreateHxH");

            migrationBuilder.DropForeignKey(
                name: "FK_CreateHxH_Machines_machineid",
                table: "CreateHxH");

            migrationBuilder.DropIndex(
                name: "IX_CreateHxH_machineid",
                table: "CreateHxH");
        }
    }
}
