using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FmsbwebCoreApi.Migrations.QualityCheckSheets
{
    public partial class AddPartSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(7785));

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

            migrationBuilder.InsertData(
                table: "OrganizationParts",
                columns: new[] { "OrganizationPartId", "LeftHandPart", "RightHandPart", "TimeStamp" },
                values: new object[,]
                {
                    { 1, "81309", "81310", new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(7866) },
                    { 3, "81313", "81314", new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(7928) },
                    { 2, "81311", "81312", new DateTime(2020, 7, 31, 15, 0, 11, 153, DateTimeKind.Local).AddTicks(7876) }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrganizationParts",
                keyColumn: "OrganizationPartId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrganizationParts",
                keyColumn: "OrganizationPartId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrganizationParts",
                keyColumn: "OrganizationPartId",
                keyValue: 3);

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
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(1241));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 5,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(1330));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 6,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(1368));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 7,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(1493));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 8,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(1551));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 9,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(1641));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 10,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(1754));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 11,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(1789));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 12,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(1821));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 13,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(1900));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 14,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(2049));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 15,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(2087));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 16,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(2208));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 17,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(2240));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 18,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(2324));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 19,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(2463));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 20,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(2498));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 21,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(2531));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 22,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(2614));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 23,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(2693));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 24,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(2725));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 25,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(2949));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 26,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(2988));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 27,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(3071));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 28,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(3181));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 29,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(3213));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 30,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(3245));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 31,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(3323));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 32,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(3421));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 33,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(3453));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 34,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(3632));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 35,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(3675));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 36,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(3756));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 37,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(3865));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 38,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(3899));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 39,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(3936));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 40,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(4033));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 41,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(4112));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 42,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(4144));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 43,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(4286));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 44,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(4322));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 45,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(4456));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 46,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(4579));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 47,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(4613));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 48,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(4646));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 49,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(4726));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 50,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(4805));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 51,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(4840));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 52,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(4976));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 53,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(5011));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 54,
                column: "TimeStamp",
                value: new DateTime(2020, 7, 31, 14, 44, 4, 789, DateTimeKind.Local).AddTicks(5087));
        }
    }
}
