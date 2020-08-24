using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FmsbwebCoreApi.Migrations.QualityCheckSheets
{
    public partial class addMoreSeeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ControlMethods",
                keyColumn: "ControlMethodId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 111, DateTimeKind.Local).AddTicks(5347));

            migrationBuilder.UpdateData(
                table: "ControlMethods",
                keyColumn: "ControlMethodId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 115, DateTimeKind.Local).AddTicks(9049));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(9614));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 117, DateTimeKind.Local).AddTicks(790));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 117, DateTimeKind.Local).AddTicks(850));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 4,
                columns: new[] { "Display", "TimeStamp" },
                values: new object[] { "NegativePositive", new DateTime(2020, 8, 12, 12, 7, 55, 117, DateTimeKind.Local).AddTicks(869) });

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 5,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 117, DateTimeKind.Local).AddTicks(886));

            migrationBuilder.InsertData(
                table: "DisplayAs",
                columns: new[] { "DisplayAsId", "Display", "TimeStamp" },
                values: new object[,]
                {
                    { 6, "Positive", new DateTime(2020, 8, 12, 12, 7, 55, 117, DateTimeKind.Local).AddTicks(905) },
                    { 7, "Reference", new DateTime(2020, 8, 12, 12, 7, 55, 117, DateTimeKind.Local).AddTicks(923) }
                });

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(307));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(1606));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(1666));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(1689));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 5,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(6823));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 6,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(7227));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 7,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(7659));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 8,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(8048));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 9,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(8436));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(2619));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(6469));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(6602));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(6679));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 5,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(6704));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 6,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(6777));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 7,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 8,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(6937));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 9,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(7017));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 10,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(7091));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 11,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(7114));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 12,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(7184));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 13,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(7251));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 14,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(7337));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 15,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(7381));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 16,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(7523));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 17,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(7546));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 18,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(7615));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 19,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(7681));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 20,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(7766));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 21,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(7809));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 22,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(7914));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 23,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(7939));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 24,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(8006));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 25,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(8070));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 26,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(8155));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 27,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(8199));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 28,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(8265));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 29,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(8288));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 30,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(8394));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 31,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 32,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(8547));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 33,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(8590));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 34,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(8657));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 35,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 36,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(8838));

            migrationBuilder.UpdateData(
                table: "OrganizationParts",
                keyColumn: "OrganizationPartId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 117, DateTimeKind.Local).AddTicks(1792));

            migrationBuilder.UpdateData(
                table: "OrganizationParts",
                keyColumn: "OrganizationPartId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 117, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "OrganizationParts",
                keyColumn: "OrganizationPartId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 117, DateTimeKind.Local).AddTicks(2860));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(4958));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(6359));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(6426));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(6578));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 5,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(6632));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 6,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(6656));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 7,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(6733));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 8,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(6753));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 9,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(6802));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 10,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(6876));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 11,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(6895));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 12,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 13,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(6961));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 14,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(7048));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 15,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(7068));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 16,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(7141));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 17,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(7160));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 18,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(7208));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 19,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(7275));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 20,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(7294));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 21,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(7313));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 22,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 23,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(7406));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 24,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(7498));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 25,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(7573));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 26,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(7592));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 27,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(7640));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 28,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(7705));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 29,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(7724));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 30,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(7743));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 31,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(7789));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 32,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(7833));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 33,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(7853));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 34,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(7964));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 35,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(7984));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 36,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(8030));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 37,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(8093));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 38,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(8113));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 39,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(8132));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 40,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(8179));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 41,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(8223));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 42,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(8243));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 43,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(8351));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 44,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(8372));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 45,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(8418));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 46,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(8485));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 47,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(8505));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 48,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(8524));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 49,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(8570));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 50,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(8615));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 51,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(8635));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 52,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(8705));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 53,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(8814));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 54,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 12, 12, 7, 55, 116, DateTimeKind.Local).AddTicks(8863));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "ControlMethods",
                keyColumn: "ControlMethodId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 149, DateTimeKind.Local).AddTicks(3317));

            migrationBuilder.UpdateData(
                table: "ControlMethods",
                keyColumn: "ControlMethodId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(4277));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(7660));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(7732));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(7765));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 4,
                columns: new[] { "Display", "TimeStamp" },
                values: new object[] { "PositiveNegative", new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(7785) });

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 5,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(7804));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(4560));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(4675));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(4702));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(4723));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 5,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(5624));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 6,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(6041));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 7,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(6446));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 8,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(6847));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 9,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(7199));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(4816));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(5267));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(5315));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 5,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(5500));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 6,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(5575));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 7,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(5649));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 8,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(5738));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 9,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(5783));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 10,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(5852));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 11,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(5876));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 12,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(5996));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 13,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(6065));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 14,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(6150));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 15,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(6194));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 16,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(6260));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 17,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(6284));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 18,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(6401));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 19,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(6470));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 20,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(6556));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 21,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(6600));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 22,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(6668));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 23,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(6692));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 24,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 25,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(6872));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 26,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(6957));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 27,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(7000));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 28,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(7065));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 29,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(7089));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 30,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(7156));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 31,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(7224));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 32,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(7354));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 33,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(7398));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 34,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(7465));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 35,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(7489));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 36,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(7555));

            migrationBuilder.UpdateData(
                table: "OrganizationParts",
                keyColumn: "OrganizationPartId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(7866));

            migrationBuilder.UpdateData(
                table: "OrganizationParts",
                keyColumn: "OrganizationPartId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(7876));

            migrationBuilder.UpdateData(
                table: "OrganizationParts",
                keyColumn: "OrganizationPartId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(7928));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(5132));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(5214));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(5237));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(5293));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 5,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(5341));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 6,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(5365));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 7,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(5529));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 8,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(5551));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 9,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(5601));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 10,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(5673));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 11,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(5694));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 12,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(5714));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 13,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(5762));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 14,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(5808));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 15,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(5829));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 16,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(5950));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 17,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(5971));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 18,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(6021));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 19,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(6088));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 20,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(6108));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 21,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(6128));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 22,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(6173));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 23,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(6217));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 24,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(6237));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 25,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(6310));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 26,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(6330));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 27,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(6427));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 28,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(6492));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 29,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(6513));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 30,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(6533));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 31,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(6579));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 32,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(6623));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 33,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(6643));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 34,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(6717));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 35,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(6738));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 36,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(6784));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 37,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(6895));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 38,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(6915));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 39,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(6934));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 40,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(6980));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 41,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(7023));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 42,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(7043));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 43,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(7113));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 44,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(7133));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 45,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(7180));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 46,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(7246));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 47,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(7310));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 48,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(7330));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 49,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(7377));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 50,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(7423));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 51,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(7443));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 52,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(7513));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 53,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(7533));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 54,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(7579));
        }
    }
}
