using Microsoft.EntityFrameworkCore.Migrations;

namespace FmsbwebCoreApi.Migrations.Overtime
{
    public partial class makeclocknumberaspk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Overtime_Employees_EmployeeId",
                table: "Overtime");

            migrationBuilder.DropIndex(
                name: "IX_Overtime_EmployeeId",
                table: "Overtime");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Overtime");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "ClockNumber",
                table: "Employees");

            migrationBuilder.AddColumn<int>(
                name: "ClockNumber",
                table: "Overtime",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeClockNumber",
                table: "Employees",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "EmployeeClockNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Overtime_ClockNumber",
                table: "Overtime",
                column: "ClockNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_Overtime_Employees_ClockNumber",
                table: "Overtime",
                column: "ClockNumber",
                principalTable: "Employees",
                principalColumn: "EmployeeClockNumber",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Overtime_Employees_ClockNumber",
                table: "Overtime");

            migrationBuilder.DropIndex(
                name: "IX_Overtime_ClockNumber",
                table: "Overtime");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "ClockNumber",
                table: "Overtime");

            migrationBuilder.DropColumn(
                name: "EmployeeClockNumber",
                table: "Employees");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Overtime",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ClockNumber",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Overtime_EmployeeId",
                table: "Overtime",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Overtime_Employees_EmployeeId",
                table: "Overtime",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
