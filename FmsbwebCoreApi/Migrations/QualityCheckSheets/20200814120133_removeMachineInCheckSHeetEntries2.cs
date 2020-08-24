using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FmsbwebCoreApi.Migrations.QualityCheckSheets
{
    public partial class removeMachineInCheckSHeetEntries2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CheckSheetEntries_Machines_MachineId",
                table: "CheckSheetEntries");

            migrationBuilder.DropIndex(
                name: "IX_CheckSheetEntries_MachineId",
                table: "CheckSheetEntries");

            migrationBuilder.DropColumn(
                name: "MachineId",
                table: "CheckSheetEntries");

            migrationBuilder.UpdateData(
                table: "ControlMethods",
                keyColumn: "ControlMethodId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 980, DateTimeKind.Local).AddTicks(5726));

            migrationBuilder.UpdateData(
                table: "ControlMethods",
                keyColumn: "ControlMethodId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 985, DateTimeKind.Local).AddTicks(7711));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(5236));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(5313));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(5345));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(5363));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 5,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(5380));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 6,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(5399));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 7,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(5416));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 985, DateTimeKind.Local).AddTicks(9275));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 985, DateTimeKind.Local).AddTicks(9581));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 985, DateTimeKind.Local).AddTicks(9613));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 985, DateTimeKind.Local).AddTicks(9634));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 5,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(3112));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 6,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(3531));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 7,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(3929));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 8,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(4365));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 9,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(4760));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(875));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(2730));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(2784));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(2956));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 5,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(2987));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 6,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(3062));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 7,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(3138));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 8,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(3226));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 9,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(3273));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 10,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(3342));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 11,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(3413));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 12,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(3487));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 13,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(3554));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 14,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(3641));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 15,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(3687));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 16,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(3754));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 17,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(3778));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 18,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(3886));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 19,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(3952));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 20,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(4038));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 21,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(4084));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 22,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(4152));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 23,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(4177));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 24,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(4321));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 25,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(4387));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 26,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(4476));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 27,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(4522));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 28,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(4587));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 29,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(4611));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 30,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 31,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(4784));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 32,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(4870));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 33,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(4915));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 34,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(4983));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 35,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(5007));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 36,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "OrganizationParts",
                keyColumn: "OrganizationPartId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(6435));

            migrationBuilder.UpdateData(
                table: "OrganizationParts",
                keyColumn: "OrganizationPartId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(6567));

            migrationBuilder.UpdateData(
                table: "OrganizationParts",
                keyColumn: "OrganizationPartId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(6573));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(2364));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(2663));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(2693));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(2759));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 5,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(2814));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 6,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(2838));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 7,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(3017));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 8,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(3038));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 9,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(3088));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 10,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(3162));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 11,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(3183));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 12,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(3203));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 13,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(3250));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 14,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(3298));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 15,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(3319));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 16,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(3441));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 17,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(3462));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 18,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(3511));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 19,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(3577));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 20,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(3597));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 21,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(3617));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 22,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(3665));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 23,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(3711));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 24,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(3731));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 25,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(3840));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 26,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(3862));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 27,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 28,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(3975));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 29,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(3995));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 30,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(4015));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 31,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(4061));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 32,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(4107));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 33,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(4128));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 34,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(4275));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 35,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(4298));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 36,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(4346));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 37,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(4409));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 38,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(4430));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 39,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(4449));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 40,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(4500));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 41,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(4545));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 42,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(4565));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 43,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(4636));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 44,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(4690));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 45,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(4741));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 46,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(4807));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 47,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(4827));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 48,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(4847));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 49,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(4894));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 50,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(4940));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 51,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(4961));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 52,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(5031));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 53,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(5084));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 54,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(5135));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MachineId",
                table: "CheckSheetEntries",
                type: "int",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_CheckSheetEntries_MachineId",
                table: "CheckSheetEntries",
                column: "MachineId");

            migrationBuilder.AddForeignKey(
                name: "FK_CheckSheetEntries_Machines_MachineId",
                table: "CheckSheetEntries",
                column: "MachineId",
                principalTable: "Machines",
                principalColumn: "MachineId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
