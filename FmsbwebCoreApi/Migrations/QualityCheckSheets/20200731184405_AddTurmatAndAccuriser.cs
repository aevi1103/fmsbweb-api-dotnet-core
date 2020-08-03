using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FmsbwebCoreApi.Migrations.QualityCheckSheets
{
    public partial class AddTurmatAndAccuriser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ControlMethods",
                keyColumn: "ControlMethodId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 783, DateTimeKind.Local).AddTicks(4535));

            migrationBuilder.UpdateData(
                table: "ControlMethods",
                keyColumn: "ControlMethodId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 788, DateTimeKind.Local).AddTicks(9797));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(5225));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(5437));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(5493));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(5552));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 5,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(5586));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(162));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(358));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(402));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(435));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 5,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(1676));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 6,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(2359));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 7,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(3103));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 8,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(3787));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 9,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(4496));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(589));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(1110));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(1287));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(1408));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 5,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(1447));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 6,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(1601));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 7,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(1716));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 8,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(1858));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 9,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(1950));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 10,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(2126));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 11,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(2166));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 12,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(2280));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 13,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(2399));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 14,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(2572));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 15,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(2652));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 16,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(2762));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 17,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(2862));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 18,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(3029));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 19,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(3144));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 20,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(3283));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 21,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(3383));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 22,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(3495));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 23,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(3534));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 24,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(3715));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 25,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(3827));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 26,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(3975));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 27,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(4071));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 28,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(4181));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 29,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 30,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(4362));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 31,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(4538));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 32,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(4687));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 33,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(4761));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 34,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(4880));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 35,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(4936));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 36,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(5047));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(904));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(1025));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(1063));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 4,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 2, new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(1241), "Turmat" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 5,
                columns: new[] { "TimeStamp", "Value" },
                values: new object[] { new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(1330), "Chiron 1" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 6,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 3, new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(1368), "Chiron 2" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 7,
                columns: new[] { "TimeStamp", "Value" },
                values: new object[] { new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(1493), "DT1" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 8,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 5, new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(1551), "DT2" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 9,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 6, new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(1641), "Accuriser" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 10,
                columns: new[] { "TimeStamp", "Value" },
                values: new object[] { new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(1754), "OK1" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 11,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 7, new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(1789), "OK2" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 12,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 7, new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(1821), "OK3" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 13,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 8, new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(1900), "Turmat" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 14,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 9, new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(2049), "Chiron 1" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 15,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 9, new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(2087), "Chiron 2" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 16,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 11, new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(2208), "DT1" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 17,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 11, new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(2240), "DT2" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 18,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 12, new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(2324), "Accuriser" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 19,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 13, new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(2463), "OK1" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 20,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 13, new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(2498), "OK2" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 21,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 13, new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(2531), "OK3" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 22,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 14, new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(2614), "Turmat" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 23,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 15, new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(2693), "Chiron 1" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 24,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 15, new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(2725), "Chiron 2" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 25,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 17, new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(2949), "DT1" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 26,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 17, new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(2988), "DT2" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 27,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 18, new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(3071), "Accuriser" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 28,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 19, new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(3181), "OK1" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 29,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 19, new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(3213), "OK2" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 30,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 19, new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(3245), "OK3" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 31,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 20, new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(3323), "Turmat" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 32,
                columns: new[] { "MachineId", "TimeStamp" },
                values: new object[] { 21, new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(3421) });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 33,
                columns: new[] { "MachineId", "TimeStamp" },
                values: new object[] { 21, new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(3453) });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 34,
                columns: new[] { "MachineId", "TimeStamp" },
                values: new object[] { 23, new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(3632) });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 35,
                columns: new[] { "MachineId", "TimeStamp" },
                values: new object[] { 23, new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(3675) });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 36,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 24, new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(3756), "Accuriser" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 37,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 25, new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(3865), "OK1" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 38,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 25, new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(3899), "OK2" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 39,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 25, new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(3936), "OK3" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 40,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 26, new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(4033), "Turmat" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 41,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 27, new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(4112), "Chiron 1" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 42,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 27, new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(4144), "Chiron 2" });

            migrationBuilder.InsertData(
                table: "SubMachines",
                columns: new[] { "SubMachineId", "MachineId", "TimeStamp", "Value" },
                values: new object[,]
                {
                    { 54, 36, new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(5087), "Accuriser" },
                    { 53, 35, new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(5011), "DT2" },
                    { 52, 35, new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(4976), "DT1" },
                    { 51, 33, new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(4840), "Chiron 2" },
                    { 50, 33, new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(4805), "Chiron 1" },
                    { 49, 32, new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(4726), "Turmat" },
                    { 48, 31, new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(4646), "OK3" },
                    { 47, 31, new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(4613), "OK2" },
                    { 46, 31, new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(4579), "OK1" },
                    { 45, 30, new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(4456), "Accuriser" },
                    { 44, 29, new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(4322), "DT2" },
                    { 43, 29, new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(4286), "DT1" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 54);

            migrationBuilder.UpdateData(
                table: "ControlMethods",
                keyColumn: "ControlMethodId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 73, DateTimeKind.Local).AddTicks(5294));

            migrationBuilder.UpdateData(
                table: "ControlMethods",
                keyColumn: "ControlMethodId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 77, DateTimeKind.Local).AddTicks(9065));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(2049));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(2145));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(2166));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(2184));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 5,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(2202));

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
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 3, new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(72), "Chiron 1" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 5,
                columns: new[] { "TimeStamp", "Value" },
                values: new object[] { new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(93), "Chiron 2" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 6,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 5, new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(167), "DT1" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 7,
                columns: new[] { "TimeStamp", "Value" },
                values: new object[] { new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(187), "DT2" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 8,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 7, new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(283), "OK1" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 9,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 7, new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(303), "OK2" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 10,
                columns: new[] { "TimeStamp", "Value" },
                values: new object[] { new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(324), "OK3" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 11,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 9, new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(393), "Chiron 1" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 12,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 9, new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(413), "Chiron 2" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 13,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 11, new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(576), "DT1" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 14,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 11, new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(597), "DT2" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 15,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 13, new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(684), "OK1" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 16,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 13, new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(704), "OK2" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 17,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 13, new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(723), "OK3" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 18,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 15, new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(790), "Chiron 1" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 19,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 15, new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(810), "Chiron 2" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 20,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 17, new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(877), "DT1" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 21,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 17, new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(898), "DT2" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 22,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 19, new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(1025), "OK1" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 23,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 19, new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(1045), "OK2" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 24,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 19, new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(1065), "OK3" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 25,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 21, new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(1131), "Chiron 1" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 26,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 21, new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(1151), "Chiron 2" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 27,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 23, new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(1217), "DT1" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 28,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 23, new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(1237), "DT2" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 29,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 25, new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(1323), "OK1" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 30,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 25, new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(1344), "OK2" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 31,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 25, new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(1363), "OK3" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 32,
                columns: new[] { "MachineId", "TimeStamp" },
                values: new object[] { 27, new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(1494) });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 33,
                columns: new[] { "MachineId", "TimeStamp" },
                values: new object[] { 27, new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(1515) });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 34,
                columns: new[] { "MachineId", "TimeStamp" },
                values: new object[] { 29, new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(1583) });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 35,
                columns: new[] { "MachineId", "TimeStamp" },
                values: new object[] { 29, new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(1604) });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 36,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 31, new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(1690), "OK1" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 37,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 31, new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(1710), "OK2" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 38,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 31, new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(1730), "OK3" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 39,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 33, new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(1797), "Chiron 1" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 40,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 33, new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(1817), "Chiron 2" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 41,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 35, new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(1927), "DT1" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 42,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 35, new DateTime(2020, 7, 31, 14, 40, 59, 78, DateTimeKind.Local).AddTicks(1947), "DT2" });
        }
    }
}
