using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FmsbwebCoreApi.Migrations.QualityCheckSheets
{
    public partial class updateCharacterteristicModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characteristics_Machines_MachineId",
                table: "Characteristics");

            migrationBuilder.DropIndex(
                name: "IX_Characteristics_MachineId",
                table: "Characteristics");

            migrationBuilder.DropColumn(
                name: "MachineId",
                table: "Characteristics");

            migrationBuilder.AddColumn<string>(
                name: "MachineName",
                table: "Characteristics",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "ControlMethods",
                keyColumn: "ControlMethodId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 588, DateTimeKind.Local).AddTicks(3344));

            migrationBuilder.UpdateData(
                table: "ControlMethods",
                keyColumn: "ControlMethodId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 593, DateTimeKind.Local).AddTicks(5625));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(3212));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(3298));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(3333));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(3353));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 5,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(3373));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 6,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(3394));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 7,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(3414));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 593, DateTimeKind.Local).AddTicks(7164));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 593, DateTimeKind.Local).AddTicks(7437));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 593, DateTimeKind.Local).AddTicks(7471));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 593, DateTimeKind.Local).AddTicks(7496));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 5,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(762));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 6,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(1244));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 7,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(1739));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 8,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(2201));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 9,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(2657));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 593, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(390));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(446));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(593));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 5,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(620));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 6,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(704));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 7,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(793));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 8,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(891));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 9,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(944));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 10,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(1088));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 11,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(1116));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 12,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(1194));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 13,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(1272));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 14,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(1369));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 15,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(1420));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 16,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(1580));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 17,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(1609));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 18,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(1689));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 19,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(1767));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 20,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(1865));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 21,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(1916));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 22,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(2045));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 23,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(2074));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 24,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(2151));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 25,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(2227));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 26,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(2325));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 27,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(2376));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 28,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(2501));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 29,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(2531));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 30,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(2608));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 31,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(2685));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 32,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(2783));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 33,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(2835));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 34,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(2974));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 35,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(3002));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 36,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(3079));

            migrationBuilder.UpdateData(
                table: "OrganizationParts",
                keyColumn: "OrganizationPartId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(4532));

            migrationBuilder.UpdateData(
                table: "OrganizationParts",
                keyColumn: "OrganizationPartId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(4676));

            migrationBuilder.UpdateData(
                table: "OrganizationParts",
                keyColumn: "OrganizationPartId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(4683));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(138));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(319));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(352));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(420));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 5,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(475));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 6,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(563));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 7,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(652));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 8,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(676));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 9,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(734));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 10,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(819));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 11,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(842));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 12,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(864));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 13,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(919));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 14,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(973));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 15,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(1058));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 16,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(1144));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 17,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(1167));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 18,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(1223));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 19,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(1298));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 20,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(1322));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 21,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(1343));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 22,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(1396));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 23,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(1447));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 24,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(1545));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 25,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(1639));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 26,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(1663));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 27,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(1717));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 28,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(1793));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 29,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(1816));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 30,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(1838));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 31,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(1891));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 32,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(1943));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 33,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(1966));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 34,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(2101));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 35,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(2124));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 36,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(2178));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 37,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(2254));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 38,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(2277));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 39,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(2299));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 40,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(2351));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 41,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(2402));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 42,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(2425));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 43,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(2559));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 44,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(2582));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 45,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(2636));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 46,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(2712));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 47,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(2735));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 48,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(2758));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 49,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(2810));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 50,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(2863));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 51,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(2887));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 52,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(3029));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 53,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(3053));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 54,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 13, 40, 10, 594, DateTimeKind.Local).AddTicks(3106));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MachineName",
                table: "Characteristics");

            migrationBuilder.AddColumn<int>(
                name: "MachineId",
                table: "Characteristics",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "ControlMethods",
                keyColumn: "ControlMethodId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 157, DateTimeKind.Local).AddTicks(7887));

            migrationBuilder.UpdateData(
                table: "ControlMethods",
                keyColumn: "ControlMethodId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 163, DateTimeKind.Local).AddTicks(8910));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(9416));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 166, DateTimeKind.Local).AddTicks(730));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 166, DateTimeKind.Local).AddTicks(805));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 166, DateTimeKind.Local).AddTicks(829));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 5,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 166, DateTimeKind.Local).AddTicks(851));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 6,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 166, DateTimeKind.Local).AddTicks(874));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 7,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 166, DateTimeKind.Local).AddTicks(894));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 164, DateTimeKind.Local).AddTicks(1856));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 164, DateTimeKind.Local).AddTicks(4063));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 164, DateTimeKind.Local).AddTicks(4188));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 164, DateTimeKind.Local).AddTicks(4242));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 5,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(5935));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 6,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(6507));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 7,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(6957));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 8,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(7409));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 9,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(7986));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 164, DateTimeKind.Local).AddTicks(6799));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(5485));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(5579));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(5771));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 5,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(5798));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 6,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(5878));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 7,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(5970));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 8,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(6070));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 9,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(6119));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 10,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(6351));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 11,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(6378));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 12,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(6457));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 13,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(6535));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 14,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(6634));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 15,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(6682));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 16,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(6807));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 17,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(6833));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 18,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(6909));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 19,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(6983));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 20,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(7080));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 21,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(7129));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 22,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(7265));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 23,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(7290));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 24,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(7363));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 25,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(7435));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 26,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(7532));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 27,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(7691));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 28,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(7835));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 29,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(7861));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 30,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(7938));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 31,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(8015));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 32,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(8115));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 33,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(8163));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 34,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(8282));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 35,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(8308));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 36,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(8382));

            migrationBuilder.UpdateData(
                table: "OrganizationParts",
                keyColumn: "OrganizationPartId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 166, DateTimeKind.Local).AddTicks(2365));

            migrationBuilder.UpdateData(
                table: "OrganizationParts",
                keyColumn: "OrganizationPartId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 166, DateTimeKind.Local).AddTicks(3858));

            migrationBuilder.UpdateData(
                table: "OrganizationParts",
                keyColumn: "OrganizationPartId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 166, DateTimeKind.Local).AddTicks(3916));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(1965));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(5171));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(5368));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(5552));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 5,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(5715));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 6,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(5744));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 7,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(5830));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 8,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(5852));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 9,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(5907));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 10,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(5998));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 11,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(6021));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 12,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(6044));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 13,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(6096));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 14,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(6300));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 15,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(6325));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 16,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(6407));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 17,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(6430));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 18,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(6485));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 19,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(6562));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 20,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(6585));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 21,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(6608));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 22,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(6659));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 23,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(6758));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 24,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(6781));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 25,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(6863));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 26,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(6885));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 27,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 28,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(7009));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 29,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(7032));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 30,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(7055));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 31,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(7106));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 32,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(7212));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 33,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(7238));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 34,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(7317));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 35,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(7339));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 36,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(7389));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 37,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(7461));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 38,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(7485));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 39,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(7507));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 40,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(7662));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 41,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(7780));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 42,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(7808));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 43,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(7889));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 44,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(7912));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 45,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(7964));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 46,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(8042));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 47,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(8065));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 48,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(8089));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 49,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(8140));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 50,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(8233));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 51,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(8257));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 52,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(8335));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 53,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(8358));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 54,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 15, 9, 52, 165, DateTimeKind.Local).AddTicks(8408));

            migrationBuilder.CreateIndex(
                name: "IX_Characteristics_MachineId",
                table: "Characteristics",
                column: "MachineId");

            migrationBuilder.AddForeignKey(
                name: "FK_Characteristics_Machines_MachineId",
                table: "Characteristics",
                column: "MachineId",
                principalTable: "Machines",
                principalColumn: "MachineId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
