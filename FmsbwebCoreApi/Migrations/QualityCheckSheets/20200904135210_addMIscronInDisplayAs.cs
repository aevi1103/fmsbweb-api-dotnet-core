using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FmsbwebCoreApi.Migrations.QualityCheckSheets
{
    public partial class addMIscronInDisplayAs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ControlMethods",
                keyColumn: "ControlMethodId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 25, DateTimeKind.Local).AddTicks(6598));

            migrationBuilder.UpdateData(
                table: "ControlMethods",
                keyColumn: "ControlMethodId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(3121));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 31, DateTimeKind.Local).AddTicks(461));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 31, DateTimeKind.Local).AddTicks(551));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 31, DateTimeKind.Local).AddTicks(572));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 31, DateTimeKind.Local).AddTicks(589));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 5,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 31, DateTimeKind.Local).AddTicks(606));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 6,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 31, DateTimeKind.Local).AddTicks(625));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 7,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 31, DateTimeKind.Local).AddTicks(643));

            migrationBuilder.InsertData(
                table: "DisplayAs",
                columns: new[] { "DisplayAsId", "Display", "TimeStamp" },
                values: new object[] { 8, "Micron", new DateTime(2020, 9, 4, 9, 52, 10, 31, DateTimeKind.Local).AddTicks(718) });

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(4525));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(4809));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(4840));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(4862));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 5,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(7883));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 6,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(8322));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 7,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(8991));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 8,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(9457));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 9,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(9875));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(5864));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(7519));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(7569));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(7709));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 5,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(7756));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 6,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(7834));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 7,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(7910));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 8,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(8002));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 9,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(8048));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 10,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(8157));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 11,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(8206));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 12,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(8277));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 13,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(8345));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 14,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(8434));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 15,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(8592));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 16,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(8811));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 17,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(8863));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 18,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(8943));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 19,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(9017));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 20,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(9115));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 21,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(9233));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 22,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(9299));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 23,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(9344));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 24,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(9413));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 25,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(9480));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 26,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(9569));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 27,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(9652));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 28,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(9719));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 29,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(9764));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 30,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(9833));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 31,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(9900));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 32,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(9986));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 33,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 31, DateTimeKind.Local).AddTicks(110));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 34,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 31, DateTimeKind.Local).AddTicks(181));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 35,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 31, DateTimeKind.Local).AddTicks(225));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 36,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 31, DateTimeKind.Local).AddTicks(320));

            migrationBuilder.UpdateData(
                table: "OrganizationParts",
                keyColumn: "OrganizationPartId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 31, DateTimeKind.Local).AddTicks(1873));

            migrationBuilder.UpdateData(
                table: "OrganizationParts",
                keyColumn: "OrganizationPartId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 31, DateTimeKind.Local).AddTicks(2009));

            migrationBuilder.UpdateData(
                table: "OrganizationParts",
                keyColumn: "OrganizationPartId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 31, DateTimeKind.Local).AddTicks(2014));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(7158));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(7454));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(7483));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(7547));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 5,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(7596));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 6,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(7683));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 7,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(7734));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 8,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(7785));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 9,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(7806));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 10,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(7862));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 11,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(7935));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 12,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(7957));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 13,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(7978));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 14,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(8027));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 15,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(8111));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 16,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(8134));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 17,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(8180));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 18,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(8231));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 19,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(8252));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 20,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(8302));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 21,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(8368));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 22,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(8389));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 23,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(8410));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 24,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(8458));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 25,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(8751));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 26,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(8783));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 27,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(8838));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 28,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(8895));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 29,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(8917));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 30,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(8969));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 31,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(9043));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 32,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(9066));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 33,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(9088));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 34,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(9210));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 35,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(9257));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 36,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(9277));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 37,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(9322));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 38,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(9370));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 39,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(9390));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 40,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(9437));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 41,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(9505));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 42,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(9525));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 43,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(9546));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 44,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(9629));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 45,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(9677));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 46,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(9697));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 47,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(9742));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 48,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(9789));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 49,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(9810));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 50,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(9857));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 51,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(9923));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 52,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(9944));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 53,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 30, DateTimeKind.Local).AddTicks(9964));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 54,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 31, DateTimeKind.Local).AddTicks(84));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 55,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 31, DateTimeKind.Local).AddTicks(137));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 56,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 31, DateTimeKind.Local).AddTicks(157));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 57,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 31, DateTimeKind.Local).AddTicks(204));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 58,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 31, DateTimeKind.Local).AddTicks(274));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 59,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 31, DateTimeKind.Local).AddTicks(297));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 60,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 4, 9, 52, 10, 31, DateTimeKind.Local).AddTicks(346));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "ControlMethods",
                keyColumn: "ControlMethodId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 216, DateTimeKind.Local).AddTicks(8877));

            migrationBuilder.UpdateData(
                table: "ControlMethods",
                keyColumn: "ControlMethodId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 223, DateTimeKind.Local).AddTicks(8872));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(9191));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 226, DateTimeKind.Local).AddTicks(1049));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 226, DateTimeKind.Local).AddTicks(1125));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 226, DateTimeKind.Local).AddTicks(1157));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 5,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 226, DateTimeKind.Local).AddTicks(1188));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 6,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 226, DateTimeKind.Local).AddTicks(1224));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 7,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 226, DateTimeKind.Local).AddTicks(1255));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 224, DateTimeKind.Local).AddTicks(1468));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 224, DateTimeKind.Local).AddTicks(3604));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 224, DateTimeKind.Local).AddTicks(3708));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 224, DateTimeKind.Local).AddTicks(3748));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 5,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(3838));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 6,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(4618));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 7,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(5338));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 8,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(6189));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 9,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(6910));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 224, DateTimeKind.Local).AddTicks(5887));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(3206));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(3330));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(3470));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 5,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(3549));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 6,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(3679));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 7,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(3899));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 8,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(4055));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 9,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(4133));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 10,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(4254));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 11,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(4334));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 12,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(4457));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 13,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(4660));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 14,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(4814));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 15,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(4889));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 16,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(5007));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 17,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(5085));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 18,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(5209));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 19,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(5380));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 20,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(5540));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 21,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(5620));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 22,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(5737));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 23,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(5817));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 24,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(6105));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 25,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(6235));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 26,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(6391));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 27,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(6467));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 28,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(6586));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 29,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(6663));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 30,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(6833));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 31,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(6956));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 32,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(7110));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 33,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(7186));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 34,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(7308));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 35,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(7384));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 36,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(7714));

            migrationBuilder.UpdateData(
                table: "OrganizationParts",
                keyColumn: "OrganizationPartId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 226, DateTimeKind.Local).AddTicks(3222));

            migrationBuilder.UpdateData(
                table: "OrganizationParts",
                keyColumn: "OrganizationPartId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 226, DateTimeKind.Local).AddTicks(5463));

            migrationBuilder.UpdateData(
                table: "OrganizationParts",
                keyColumn: "OrganizationPartId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 226, DateTimeKind.Local).AddTicks(5530));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(508));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(3020));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(3125));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(3292));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 5,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(3383));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 6,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(3427));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 7,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(3512));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 8,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(3598));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 9,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(3634));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 10,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(3723));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 11,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(3943));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 12,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(3978));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 13,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(4013));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 14,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(4097));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 15,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(4178));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 16,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(4214));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 17,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(4294));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 18,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(4380));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 19,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(4415));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 20,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(4583));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 21,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(4704));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 22,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(4739));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 23,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(4774));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 24,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(4855));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 25,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(4931));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 26,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(4968));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 27,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(5047));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 28,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(5132));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 29,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(5168));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 30,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(5306));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 31,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(5425));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 32,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(5461));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 33,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(5495));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 34,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(5584));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 35,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(5662));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 36,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(5697));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 37,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(5779));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 38,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(5864));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 39,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(5900));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 40,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(6152));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 41,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(6278));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 42,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(6315));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 43,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(6349));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 44,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(6432));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 45,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(6510));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 46,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(6545));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 47,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(6626));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 48,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(6708));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 49,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(6743));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 50,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(6879));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 51,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(6999));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 52,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(7035));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 53,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(7070));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 54,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(7151));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 55,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(7232));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 56,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(7268));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 57,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(7348));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 58,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(7464));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 59,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(7660));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 60,
                column: "TimeStamp",
                value: new DateTime(2020, 9, 1, 14, 50, 38, 225, DateTimeKind.Local).AddTicks(7757));
        }
    }
}
