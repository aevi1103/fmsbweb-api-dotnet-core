using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FmsbwebCoreApi.Migrations.QualityCheckSheets
{
    public partial class addInitialValueColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsInitialValue",
                table: "ReChecks",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "ControlMethods",
                keyColumn: "ControlMethodId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 100, DateTimeKind.Local).AddTicks(6164));

            migrationBuilder.UpdateData(
                table: "ControlMethods",
                keyColumn: "ControlMethodId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 107, DateTimeKind.Local).AddTicks(9628));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 110, DateTimeKind.Local).AddTicks(1665));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 110, DateTimeKind.Local).AddTicks(3361));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 110, DateTimeKind.Local).AddTicks(3442));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 110, DateTimeKind.Local).AddTicks(3474));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 5,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 110, DateTimeKind.Local).AddTicks(3504));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 6,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 110, DateTimeKind.Local).AddTicks(3539));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 7,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 110, DateTimeKind.Local).AddTicks(3573));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 108, DateTimeKind.Local).AddTicks(3057));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 108, DateTimeKind.Local).AddTicks(5152));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 108, DateTimeKind.Local).AddTicks(5256));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 108, DateTimeKind.Local).AddTicks(5295));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 5,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(6385));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 6,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(7176));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 7,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(8020));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 8,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(8791));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 9,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(9602));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 108, DateTimeKind.Local).AddTicks(7405));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(5726));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(5851));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(5993));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 5,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(6160));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 6,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(6300));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 7,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(6439));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 8,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(6601));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 9,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(6684));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 10,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(6816));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 11,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(6965));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 12,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(7094));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 13,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(7221));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 14,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(7382));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 15,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(7464));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 16,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(7643));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 17,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(7728));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 18,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(7859));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 19,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(8067));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 20,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(8238));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 21,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(8320));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 22,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(8503));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 23,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(8584));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 24,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(8711));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 25,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(8832));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 26,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(8990));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 27,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(9071));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 28,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(9317));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 29,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(9400));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 30,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(9520));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 31,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(9649));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 32,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(9808));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 33,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(9889));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 34,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 110, DateTimeKind.Local).AddTicks(73));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 35,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 110, DateTimeKind.Local).AddTicks(152));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 36,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 110, DateTimeKind.Local).AddTicks(309));

            migrationBuilder.UpdateData(
                table: "OrganizationParts",
                keyColumn: "OrganizationPartId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 110, DateTimeKind.Local).AddTicks(5322));

            migrationBuilder.UpdateData(
                table: "OrganizationParts",
                keyColumn: "OrganizationPartId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 110, DateTimeKind.Local).AddTicks(8611));

            migrationBuilder.UpdateData(
                table: "OrganizationParts",
                keyColumn: "OrganizationPartId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 110, DateTimeKind.Local).AddTicks(8677));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(2049));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(5526));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(5639));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(5810));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 5,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(5904));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 6,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(5950));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 7,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(6113));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 8,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(6215));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 9,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(6253));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 10,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(6347));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 11,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(6483));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 12,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(6521));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 13,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(6556));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 14,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(6646));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 15,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(6734));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 16,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(6773));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 17,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(6921));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 18,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(7012));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 19,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(7052));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 20,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(7141));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 21,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(7264));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 22,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(7301));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 23,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(7337));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 24,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(7426));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 25,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(7508));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 26,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(7545));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 27,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(7689));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 28,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(7778));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 29,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(7817));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 30,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(7974));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 31,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(8112));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 32,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(8150));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 33,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(8190));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 34,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(8281));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 35,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(8364));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 36,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(8459));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 37,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(8545));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 38,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(8630));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 39,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(8668));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 40,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(8757));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 41,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(8873));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 42,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(8911));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 43,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(8947));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 44,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(9032));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 45,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(9115));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 46,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(9267));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 47,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(9361));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 48,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(9444));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 49,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(9480));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 50,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(9568));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 51,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(9691));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 52,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(9730));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 53,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(9765));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 54,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(9851));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 55,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 109, DateTimeKind.Local).AddTicks(9994));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 56,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 110, DateTimeKind.Local).AddTicks(32));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 57,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 110, DateTimeKind.Local).AddTicks(114));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 58,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 110, DateTimeKind.Local).AddTicks(231));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 59,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 110, DateTimeKind.Local).AddTicks(268));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 60,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 7, 35, 34, 110, DateTimeKind.Local).AddTicks(351));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsInitialValue",
                table: "ReChecks");

            migrationBuilder.UpdateData(
                table: "ControlMethods",
                keyColumn: "ControlMethodId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 279, DateTimeKind.Local).AddTicks(2222));

            migrationBuilder.UpdateData(
                table: "ControlMethods",
                keyColumn: "ControlMethodId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 285, DateTimeKind.Local).AddTicks(6191));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 287, DateTimeKind.Local).AddTicks(160));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 287, DateTimeKind.Local).AddTicks(1406));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 287, DateTimeKind.Local).AddTicks(1507));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 287, DateTimeKind.Local).AddTicks(1704));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 5,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 287, DateTimeKind.Local).AddTicks(1755));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 6,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 287, DateTimeKind.Local).AddTicks(1799));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 7,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 287, DateTimeKind.Local).AddTicks(1930));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 285, DateTimeKind.Local).AddTicks(7859));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 285, DateTimeKind.Local).AddTicks(9304));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 285, DateTimeKind.Local).AddTicks(9376));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 285, DateTimeKind.Local).AddTicks(9402));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 5,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(6776));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 6,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(7282));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 7,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(7769));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 8,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(8255));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 9,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(8737));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(730));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(6281));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(6491));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(6584));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 5,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(6637));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 6,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(6723));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 7,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(6810));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 8,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(6959));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 9,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(7016));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 10,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(7096));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 11,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(7150));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 12,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(7231));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 13,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(7311));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 14,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(7453));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 15,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(7507));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 16,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(7585));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 17,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 18,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(7719));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 19,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(7796));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 20,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(7942));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 21,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(7996));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 22,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(8073));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 23,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(8126));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 24,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(8205));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 25,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(8281));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 26,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(8425));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 27,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(8478));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 28,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(8556));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 29,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(8608));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 30,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(8686));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 31,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(8764));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 32,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(8934));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 33,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(8987));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 34,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(9065));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 35,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(9117));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 36,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(9216));

            migrationBuilder.UpdateData(
                table: "OrganizationParts",
                keyColumn: "OrganizationPartId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 287, DateTimeKind.Local).AddTicks(4052));

            migrationBuilder.UpdateData(
                table: "OrganizationParts",
                keyColumn: "OrganizationPartId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 287, DateTimeKind.Local).AddTicks(7186));

            migrationBuilder.UpdateData(
                table: "OrganizationParts",
                keyColumn: "OrganizationPartId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 287, DateTimeKind.Local).AddTicks(7275));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(4267));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(6139));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(6224));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(6461));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 5,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(6527));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 6,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(6556));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 7,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(6612));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 8,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(6669));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 9,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(6693));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 10,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(6753));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 11,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(6839));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 12,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(6863));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 13,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(6886));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 14,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(6991));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 15,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(7046));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 16,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(7070));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 17,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(7123));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 18,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(7180));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 19,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(7203));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 20,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(7260));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 21,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(7338));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 22,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(7361));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 23,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(7385));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 24,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(7482));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 25,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(7535));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 26,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(7559));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 27,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(7612));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 28,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(7667));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 29,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(7691));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 30,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(7747));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 31,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(7823));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 32,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(7848));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 33,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(7871));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 34,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(7971));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 35,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(8024));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 36,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(8047));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 37,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(8100));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 38,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(8154));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 39,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(8177));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 40,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(8233));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 41,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(8308));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 42,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(8369));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 43,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(8397));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 44,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(8454));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 45,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(8506));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 46,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(8529));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 47,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(8583));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 48,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(8636));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 49,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(8659));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 50,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(8714));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 51,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(8791));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 52,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(8877));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 53,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(8906));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 54,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(8962));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 55,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(9016));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 56,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(9039));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 57,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(9092));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 58,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(9164));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 59,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(9189));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 60,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(9245));
        }
    }
}
