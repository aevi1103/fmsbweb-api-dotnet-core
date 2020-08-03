using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FmsbwebCoreApi.Migrations.QualityCheckSheets
{
    public partial class AddControlMethodAndDisplayAsSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ControlMethods",
                columns: new[] { "ControlMethodId", "Method", "TimeStamp" },
                values: new object[,]
                {
                    { 1, "Machining Check Sheet", new DateTime(2020, 7, 31, 14, 40, 59, 73, DateTimeKind.Local).AddTicks(5294) },
                    { 2, "Quality Inspection Summary", new DateTime(2020, 7, 31, 14, 40, 59, 77, DateTimeKind.Local).AddTicks(9065) }
                });

            migrationBuilder.InsertData(
                table: "DisplayAs",
                columns: new[] { "DisplayAsId", "Display", "TimeStamp" },
                values: new object[,]
                {
                    { 1, "Number", new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(2049) },
                    { 2, "Percent", new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(2145) },
                    { 3, "Degrees", new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(2166) },
                    { 4, "PositiveNegative", new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(2184) },
                    { 5, "PassFail", new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(2202) }
                });

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 77, DateTimeKind.Local).AddTicks(9445));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 77, DateTimeKind.Local).AddTicks(9582));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 77, DateTimeKind.Local).AddTicks(9608));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 77, DateTimeKind.Local).AddTicks(9627));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 5,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(230));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 6,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(639));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 7,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(939));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 8,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(1278));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 9,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(1645));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 77, DateTimeKind.Local).AddTicks(9714));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(24));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(48));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(117));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 5,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(139));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 6,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(207));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 7,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(260));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 8,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(346));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 9,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(369));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 10,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(434));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 11,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(548));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 12,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(617));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 13,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(662));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 14,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(746));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 15,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(768));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 16,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(831));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 17,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(853));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 18,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(918));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 19,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(1001));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 20,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(1086));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 21,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(1109));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 22,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(1172));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 23,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(1194));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 24,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(1258));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 25,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(1301));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 26,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(1385));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 27,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(1407));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 28,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(1538));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 29,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(1560));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 30,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(1624));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 31,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(1668));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 32,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(1751));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 33,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(1773));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 34,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(1838));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 35,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(1901));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 36,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(1968));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 77, DateTimeKind.Local).AddTicks(9907));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 77, DateTimeKind.Local).AddTicks(9975));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 77, DateTimeKind.Local).AddTicks(9996));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(72));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 5,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(93));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 6,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(167));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 7,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(187));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 8,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(283));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 9,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(303));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 10,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(324));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 11,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(393));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 12,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(413));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 13,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(576));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 14,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(597));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 15,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(684));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 16,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(704));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 17,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 18,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(790));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 19,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(810));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 20,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(877));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 21,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(898));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 22,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(1025));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 23,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(1045));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 24,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(1065));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 25,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(1131));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 26,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(1151));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 27,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(1217));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 28,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(1237));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 29,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(1323));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 30,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(1344));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 31,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(1363));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 32,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(1494));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 33,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(1515));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 34,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(1583));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 35,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(1604));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 36,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(1690));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 37,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(1710));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 38,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(1730));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 39,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(1797));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 40,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(1817));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 41,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(1927));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 42,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(1947));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ControlMethods",
                keyColumn: "ControlMethodId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ControlMethods",
                keyColumn: "ControlMethodId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 934, DateTimeKind.Local).AddTicks(879));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(249));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(458));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(486));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 5,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1250));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 6,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1674));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 7,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1974));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 8,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2329));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 9,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2687));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(609));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1042));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1066));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1135));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 5,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1158));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 6,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1226));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 7,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1275));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 8,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1366));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 9,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1389));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 10,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1454));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 11,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1476));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 12,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1650));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 13,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1697));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 14,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1781));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 15,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1803));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 16,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1867));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 17,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1889));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 18,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1953));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 19,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2051));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 20,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2138));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 21,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2160));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 22,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2223));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 23,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2245));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 24,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2308));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 25,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2350));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 26,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2432));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 27,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2454));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 28,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2582));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 29,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2603));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 30,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2666));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 31,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2710));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 32,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2791));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 33,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2812));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 34,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2876));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 35,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2898));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 36,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(3005));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(909));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(990));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1015));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1092));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 5,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1112));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 6,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1186));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 7,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1206));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 8,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1302));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 9,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1323));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 10,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1344));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 11,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1413));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 12,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1433));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 13,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1607));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 14,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1630));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 15,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1719));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 16,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1739));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 17,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1758));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 18,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1826));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 19,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1846));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 20,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1913));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 21,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1933));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 22,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2076));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 23,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2096));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 24,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2116));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 25,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2183));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 26,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2203));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 27,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2268));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 28,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2288));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 29,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2372));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 30,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2392));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 31,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2411));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 32,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2533));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 33,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2558));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 34,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2627));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 35,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2646));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 36,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2731));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 37,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2751));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 38,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2770));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 39,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2836));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 40,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2855));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 41,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2963));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 42,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2983));
        }
    }
}
