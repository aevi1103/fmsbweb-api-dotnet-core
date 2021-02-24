using Microsoft.EntityFrameworkCore.Migrations;

namespace FmsbwebCoreApi.Migrations.Overtime
{
    public partial class removeIdentitykey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Overtime_Employees_ClockNumber",
                table: "Overtime");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "ClockNumber",
                table: "Employees");

            migrationBuilder.AddColumn<int>(
                name: "ClockNumberId",
                table: "Employees",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "ClockNumberId");

            migrationBuilder.AddForeignKey(
                name: "FK_Overtime_Employees_ClockNumber",
                table: "Overtime",
                column: "ClockNumber",
                principalTable: "Employees",
                principalColumn: "ClockNumberId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Overtime_Employees_ClockNumber",
                table: "Overtime");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "ClockNumberId",
                table: "Employees");

            migrationBuilder.AddColumn<int>(
                name: "ClockNumber",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "ClockNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_Overtime_Employees_ClockNumber",
                table: "Overtime",
                column: "ClockNumber",
                principalTable: "Employees",
                principalColumn: "ClockNumber",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
