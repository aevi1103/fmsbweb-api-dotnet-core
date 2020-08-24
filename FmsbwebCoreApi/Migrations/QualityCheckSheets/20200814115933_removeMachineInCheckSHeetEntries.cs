using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FmsbwebCoreApi.Migrations.QualityCheckSheets
{
    public partial class removeMachineInCheckSHeetEntries : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "MachineId",
                table: "CheckSheetEntries",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "ControlMethods",
                keyColumn: "ControlMethodId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 641, DateTimeKind.Local).AddTicks(2611));

            migrationBuilder.UpdateData(
                table: "ControlMethods",
                keyColumn: "ControlMethodId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(3173));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 647, DateTimeKind.Local).AddTicks(440));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 647, DateTimeKind.Local).AddTicks(533));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 647, DateTimeKind.Local).AddTicks(568));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 647, DateTimeKind.Local).AddTicks(586));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 5,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 647, DateTimeKind.Local).AddTicks(604));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 6,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 647, DateTimeKind.Local).AddTicks(661));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 7,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 647, DateTimeKind.Local).AddTicks(682));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(4702));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(4976));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(5011));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(5033));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 5,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(8208));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 6,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(8629));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 7,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(9075));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 8,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(9476));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 9,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(9878));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(6286));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(7936));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(7986));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(8063));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 5,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(8087));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 6,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(8159));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 7,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(8235));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 8,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(8375));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 9,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(8421));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 10,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(8490));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 11,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(8514));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 12,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(8584));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 13,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(8652));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 14,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(8821));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 15,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(8867));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 16,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(8935));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 17,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(8961));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 18,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(9031));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 19,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(9099));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 20,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(9224));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 21,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(9270));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 22,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(9340));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 23,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(9364));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 24,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(9432));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 25,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(9500));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 26,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(9628));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 27,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(9674));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 28,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(9742));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 29,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(9767));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 30,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(9835));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 31,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(9903));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 32,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 647, DateTimeKind.Local).AddTicks(111));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 33,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 647, DateTimeKind.Local).AddTicks(157));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 34,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 647, DateTimeKind.Local).AddTicks(226));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 35,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 647, DateTimeKind.Local).AddTicks(250));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 36,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 647, DateTimeKind.Local).AddTicks(317));

            migrationBuilder.UpdateData(
                table: "OrganizationParts",
                keyColumn: "OrganizationPartId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 647, DateTimeKind.Local).AddTicks(1658));

            migrationBuilder.UpdateData(
                table: "OrganizationParts",
                keyColumn: "OrganizationPartId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 647, DateTimeKind.Local).AddTicks(1782));

            migrationBuilder.UpdateData(
                table: "OrganizationParts",
                keyColumn: "OrganizationPartId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 647, DateTimeKind.Local).AddTicks(1787));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(7676));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(7868));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(7900));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(7964));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 5,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(8013));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 6,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(8038));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 7,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(8114));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 8,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(8135));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 9,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(8185));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 10,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(8305));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 11,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(8330));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 12,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(8350));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 13,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(8400));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 14,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(8446));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 15,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(8467));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 16,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(8539));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 17,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(8560));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 18,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(8609));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 19,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(8675));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 20,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(8773));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 21,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(8796));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 22,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(8845));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 23,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(8891));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 24,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(8912));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 25,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(8986));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 26,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(9008));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 27,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(9056));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 28,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(9122));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 29,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(9176));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 30,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(9200));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 31,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(9248));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 32,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(9294));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 33,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(9315));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 34,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(9388));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 35,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(9409));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 36,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(9456));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 37,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(9524));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 38,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(9579));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 39,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(9603));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 40,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(9652));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 41,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(9698));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 42,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(9719));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 43,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(9792));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 44,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(9812));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 45,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(9859));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 46,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(9926));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 47,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 646, DateTimeKind.Local).AddTicks(9947));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 48,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 647, DateTimeKind.Local).AddTicks(79));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 49,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 647, DateTimeKind.Local).AddTicks(135));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 50,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 647, DateTimeKind.Local).AddTicks(182));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 51,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 647, DateTimeKind.Local).AddTicks(203));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 52,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 647, DateTimeKind.Local).AddTicks(274));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 53,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 647, DateTimeKind.Local).AddTicks(294));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 54,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 7, 59, 32, 647, DateTimeKind.Local).AddTicks(342));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "MachineId",
                table: "CheckSheetEntries",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "ControlMethods",
                keyColumn: "ControlMethodId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 183, DateTimeKind.Local).AddTicks(9538));

            migrationBuilder.UpdateData(
                table: "ControlMethods",
                keyColumn: "ControlMethodId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(3400));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(1457));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(1555));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(1594));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(1614));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 5,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(1634));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 6,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(1656));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 7,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(1677));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(4966));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(5267));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(5303));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(5328));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 5,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(8610));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 6,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(9074));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 7,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(9529));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 8,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(206));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 9,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(890));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(6706));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(8249));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(8445));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 5,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(8471));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 6,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(8554));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 7,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(8641));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 8,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(8740));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 9,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(8792));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 10,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(8914));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 11,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(8941));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 12,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(9022));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 13,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(9100));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 14,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(9198));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 15,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(9250));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 16,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(9371));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 17,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(9398));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 18,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(9477));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 19,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(9554));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 20,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(9653));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 21,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(9704));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 22,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(9826));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 23,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(9853));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 24,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(9998));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 25,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(259));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 26,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(519));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 27,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(573));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 28,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(731));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 29,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(758));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 30,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(839));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 31,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(919));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 32,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(1022));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 33,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(1074));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 34,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(1198));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 35,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(1225));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 36,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(1301));

            migrationBuilder.UpdateData(
                table: "OrganizationParts",
                keyColumn: "OrganizationPartId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(3019));

            migrationBuilder.UpdateData(
                table: "OrganizationParts",
                keyColumn: "OrganizationPartId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(3240));

            migrationBuilder.UpdateData(
                table: "OrganizationParts",
                keyColumn: "OrganizationPartId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(3254));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(7944));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(8124));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(8156));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(8224));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 5,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(8387));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 6,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(8417));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 7,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(8503));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 8,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(8527));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 9,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(8584));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 10,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(8668));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 11,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(8691));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 12,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(8714));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 13,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(8768));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 14,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(8863));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 15,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(8888));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 16,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(8971));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 17,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(8994));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 18,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(9051));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 19,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(9126));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 20,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(9149));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 21,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(9172));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 22,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(9225));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 23,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(9321));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 24,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(9346));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 25,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(9428));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 26,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(9451));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 27,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(9506));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 28,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 29,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(9603));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 30,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(9626));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 31,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(9680));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 32,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(9769));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 33,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(9797));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 34,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(9881));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 35,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(9935));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 36,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(148));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 37,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(319));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 38,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(458));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 39,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(488));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 40,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(548));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 41,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(671));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 42,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(703));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 43,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(788));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 44,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(813));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 45,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(867));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 46,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(947));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 47,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(971));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 48,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(995));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 49,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(1049));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 50,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(1146));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 51,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(1171));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 52,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(1252));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 53,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(1275));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 54,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(1328));
        }
    }
}
