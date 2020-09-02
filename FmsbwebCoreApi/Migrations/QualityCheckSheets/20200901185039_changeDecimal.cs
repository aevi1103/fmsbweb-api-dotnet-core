using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FmsbwebCoreApi.Migrations.QualityCheckSheets
{
    public partial class changeDecimal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Nom",
                table: "Characteristics",
                type: "decimal(18, 5)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Min",
                table: "Characteristics",
                type: "decimal(18, 5)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Max",
                table: "Characteristics",
                type: "decimal(18, 5)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Nom",
                table: "Characteristics",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 5)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Min",
                table: "Characteristics",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 5)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Max",
                table: "Characteristics",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 5)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "ControlMethods",
                keyColumn: "ControlMethodId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 756, DateTimeKind.Local).AddTicks(1040));

            migrationBuilder.UpdateData(
                table: "ControlMethods",
                keyColumn: "ControlMethodId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 762, DateTimeKind.Local).AddTicks(86));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(8248));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 764, DateTimeKind.Local).AddTicks(109));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 764, DateTimeKind.Local).AddTicks(203));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 764, DateTimeKind.Local).AddTicks(264));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 5,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 764, DateTimeKind.Local).AddTicks(320));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 6,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 764, DateTimeKind.Local).AddTicks(395));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 7,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 764, DateTimeKind.Local).AddTicks(470));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 762, DateTimeKind.Local).AddTicks(2114));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 762, DateTimeKind.Local).AddTicks(3976));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 762, DateTimeKind.Local).AddTicks(4159));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 762, DateTimeKind.Local).AddTicks(4200));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 5,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(3021));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 6,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(3719));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 7,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(4395));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 8,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 9,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(6118));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 762, DateTimeKind.Local).AddTicks(5876));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(2420));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(2547));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(2674));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 5,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(2749));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 6,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(2941));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 7,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(3069));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 8,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(3217));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 9,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(3292));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 10,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(3406));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 11,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(3481));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 12,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(3648));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 13,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(3757));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 14,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(3902));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 15,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(3976));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 16,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(4086));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 17,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(4159));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 18,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(4326));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 19,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(4432));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 20,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(4579));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 21,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(4653));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 22,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(4766));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 23,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(4839));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 24,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(5104));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 25,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(5267));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 26,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(5511));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 27,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(5589));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 28,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(5771));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 29,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(5843));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 30,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(6043));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 31,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(6162));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 32,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(6311));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 33,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(6385));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 34,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(6499));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 35,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(6686));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 36,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(6905));

            migrationBuilder.UpdateData(
                table: "OrganizationParts",
                keyColumn: "OrganizationPartId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 764, DateTimeKind.Local).AddTicks(2297));

            migrationBuilder.UpdateData(
                table: "OrganizationParts",
                keyColumn: "OrganizationPartId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 764, DateTimeKind.Local).AddTicks(4568));

            migrationBuilder.UpdateData(
                table: "OrganizationParts",
                keyColumn: "OrganizationPartId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 764, DateTimeKind.Local).AddTicks(4641));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 762, DateTimeKind.Local).AddTicks(9826));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(2093));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(2308));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(2507));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 5,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(2596));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 6,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(2635));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 7,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(2714));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 8,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(2795));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 9,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(2830));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 10,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(2986));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 11,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(3110));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 12,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(3145));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 13,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(3178));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 14,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(3258));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 15,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(3333));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 16,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(3367));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 17,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(3445));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 18,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(3522));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 19,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(3606));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 20,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(3689));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 21,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(3796));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 22,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(3830));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 23,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(3864));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 24,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(3942));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 25,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(4015));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 26,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(4049));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 27,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(4125));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 28,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(4249));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 29,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(4288));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 30,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(4367));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 31,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(4470));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 32,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 33,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(4537));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 34,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(4618));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 35,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(4693));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 36,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(4727));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 37,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(4805));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 38,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(5028));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 39,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(5066));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 40,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(5146));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 41,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(5359));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 42,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(5435));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 43,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(5471));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 44,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(5552));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 45,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(5636));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 46,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(5722));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 47,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(5809));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 48,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(5964));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 49,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(6002));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 50,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(6085));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 51,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(6202));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 52,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(6237));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 53,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(6272));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 54,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 55,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(6427));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 56,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(6462));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 57,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(6538));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 58,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 59,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(6865));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 60,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 31, 14, 35, 1, 763, DateTimeKind.Local).AddTicks(6944));
        }
    }
}
