using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FmsbwebCoreApi.Migrations.QualityCheckSheets
{
    public partial class makeClockNumberRequired : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ControlMethods",
                keyColumn: "ControlMethodId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 913, DateTimeKind.Local).AddTicks(4659));

            migrationBuilder.UpdateData(
                table: "ControlMethods",
                keyColumn: "ControlMethodId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 919, DateTimeKind.Local).AddTicks(8737));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 921, DateTimeKind.Local).AddTicks(2631));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 921, DateTimeKind.Local).AddTicks(3836));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 921, DateTimeKind.Local).AddTicks(3972));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 921, DateTimeKind.Local).AddTicks(3998));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 5,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 921, DateTimeKind.Local).AddTicks(4019));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 6,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 921, DateTimeKind.Local).AddTicks(4043));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 7,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 921, DateTimeKind.Local).AddTicks(4063));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 920, DateTimeKind.Local).AddTicks(732));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 920, DateTimeKind.Local).AddTicks(2168));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 920, DateTimeKind.Local).AddTicks(2237));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 920, DateTimeKind.Local).AddTicks(2264));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 5,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 920, DateTimeKind.Local).AddTicks(9286));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 6,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 920, DateTimeKind.Local).AddTicks(9925));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 7,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 921, DateTimeKind.Local).AddTicks(384));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 8,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 921, DateTimeKind.Local).AddTicks(838));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 9,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 921, DateTimeKind.Local).AddTicks(1308));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 920, DateTimeKind.Local).AddTicks(4091));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 920, DateTimeKind.Local).AddTicks(8936));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 920, DateTimeKind.Local).AddTicks(9032));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 920, DateTimeKind.Local).AddTicks(9117));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 5,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 920, DateTimeKind.Local).AddTicks(9144));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 6,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 920, DateTimeKind.Local).AddTicks(9227));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 7,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 920, DateTimeKind.Local).AddTicks(9524));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 8,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 920, DateTimeKind.Local).AddTicks(9634));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 9,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 920, DateTimeKind.Local).AddTicks(9686));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 10,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 920, DateTimeKind.Local).AddTicks(9768));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 11,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 920, DateTimeKind.Local).AddTicks(9794));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 12,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 920, DateTimeKind.Local).AddTicks(9875));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 13,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 920, DateTimeKind.Local).AddTicks(9996));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 14,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 921, DateTimeKind.Local).AddTicks(100));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 15,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 921, DateTimeKind.Local).AddTicks(151));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 16,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 921, DateTimeKind.Local).AddTicks(227));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 17,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 921, DateTimeKind.Local).AddTicks(254));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 18,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 921, DateTimeKind.Local).AddTicks(335));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 19,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 921, DateTimeKind.Local).AddTicks(449));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 20,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 921, DateTimeKind.Local).AddTicks(553));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 21,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 921, DateTimeKind.Local).AddTicks(604));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 22,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 921, DateTimeKind.Local).AddTicks(684));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 23,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 921, DateTimeKind.Local).AddTicks(710));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 24,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 921, DateTimeKind.Local).AddTicks(788));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 25,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 921, DateTimeKind.Local).AddTicks(922));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 26,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 921, DateTimeKind.Local).AddTicks(1027));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 27,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 921, DateTimeKind.Local).AddTicks(1078));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 28,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 921, DateTimeKind.Local).AddTicks(1153));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 29,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 921, DateTimeKind.Local).AddTicks(1180));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 30,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 921, DateTimeKind.Local).AddTicks(1259));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 31,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 921, DateTimeKind.Local).AddTicks(1335));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 32,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 921, DateTimeKind.Local).AddTicks(1480));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 33,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 921, DateTimeKind.Local).AddTicks(1532));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 34,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 921, DateTimeKind.Local).AddTicks(1612));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 35,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 921, DateTimeKind.Local).AddTicks(1639));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 36,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 921, DateTimeKind.Local).AddTicks(1718));

            migrationBuilder.UpdateData(
                table: "OrganizationParts",
                keyColumn: "OrganizationPartId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 921, DateTimeKind.Local).AddTicks(5332));

            migrationBuilder.UpdateData(
                table: "OrganizationParts",
                keyColumn: "OrganizationPartId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 921, DateTimeKind.Local).AddTicks(6519));

            migrationBuilder.UpdateData(
                table: "OrganizationParts",
                keyColumn: "OrganizationPartId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 921, DateTimeKind.Local).AddTicks(6556));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 920, DateTimeKind.Local).AddTicks(7154));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 920, DateTimeKind.Local).AddTicks(8798));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 920, DateTimeKind.Local).AddTicks(8881));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 920, DateTimeKind.Local).AddTicks(9005));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 5,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 920, DateTimeKind.Local).AddTicks(9064));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 6,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 920, DateTimeKind.Local).AddTicks(9091));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 7,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 920, DateTimeKind.Local).AddTicks(9175));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 8,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 920, DateTimeKind.Local).AddTicks(9199));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 9,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 920, DateTimeKind.Local).AddTicks(9256));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 10,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 920, DateTimeKind.Local).AddTicks(9558));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 11,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 920, DateTimeKind.Local).AddTicks(9582));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 12,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 920, DateTimeKind.Local).AddTicks(9606));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 13,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 920, DateTimeKind.Local).AddTicks(9661));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 14,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 920, DateTimeKind.Local).AddTicks(9715));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 15,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 920, DateTimeKind.Local).AddTicks(9741));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 16,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 920, DateTimeKind.Local).AddTicks(9823));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 17,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 920, DateTimeKind.Local).AddTicks(9847));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 18,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 920, DateTimeKind.Local).AddTicks(9902));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 19,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 921, DateTimeKind.Local).AddTicks(26));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 20,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 921, DateTimeKind.Local).AddTicks(50));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 21,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 921, DateTimeKind.Local).AddTicks(73));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 22,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 921, DateTimeKind.Local).AddTicks(126));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 23,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 921, DateTimeKind.Local).AddTicks(178));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 24,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 921, DateTimeKind.Local).AddTicks(201));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 25,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 921, DateTimeKind.Local).AddTicks(284));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 26,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 921, DateTimeKind.Local).AddTicks(308));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 27,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 921, DateTimeKind.Local).AddTicks(362));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 28,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 921, DateTimeKind.Local).AddTicks(479));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 29,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 921, DateTimeKind.Local).AddTicks(504));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 30,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 921, DateTimeKind.Local).AddTicks(527));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 31,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 921, DateTimeKind.Local).AddTicks(580));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 32,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 921, DateTimeKind.Local).AddTicks(632));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 33,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 921, DateTimeKind.Local).AddTicks(655));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 34,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 921, DateTimeKind.Local).AddTicks(739));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 35,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 921, DateTimeKind.Local).AddTicks(763));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 36,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 921, DateTimeKind.Local).AddTicks(816));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 37,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 921, DateTimeKind.Local).AddTicks(953));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 38,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 921, DateTimeKind.Local).AddTicks(977));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 39,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 921, DateTimeKind.Local).AddTicks(1001));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 40,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 921, DateTimeKind.Local).AddTicks(1053));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 41,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 921, DateTimeKind.Local).AddTicks(1104));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 42,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 921, DateTimeKind.Local).AddTicks(1128));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 43,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 921, DateTimeKind.Local).AddTicks(1208));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 44,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 921, DateTimeKind.Local).AddTicks(1233));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 45,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 921, DateTimeKind.Local).AddTicks(1286));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 46,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 921, DateTimeKind.Local).AddTicks(1405));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 47,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 921, DateTimeKind.Local).AddTicks(1430));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 48,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 921, DateTimeKind.Local).AddTicks(1453));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 49,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 921, DateTimeKind.Local).AddTicks(1507));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 50,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 921, DateTimeKind.Local).AddTicks(1562));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 51,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 921, DateTimeKind.Local).AddTicks(1587));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 52,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 921, DateTimeKind.Local).AddTicks(1668));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 53,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 921, DateTimeKind.Local).AddTicks(1692));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 54,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 14, 58, 47, 921, DateTimeKind.Local).AddTicks(1745));
        }
    }
}
