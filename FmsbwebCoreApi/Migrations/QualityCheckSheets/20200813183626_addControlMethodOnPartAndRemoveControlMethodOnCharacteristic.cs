using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FmsbwebCoreApi.Migrations.QualityCheckSheets
{
    public partial class addControlMethodOnPartAndRemoveControlMethodOnCharacteristic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characteristics_ControlMethods_ControlMethodId",
                table: "Characteristics");

            migrationBuilder.DropIndex(
                name: "IX_Characteristics_ControlMethodId",
                table: "Characteristics");

            migrationBuilder.DropColumn(
                name: "ControlMethodId",
                table: "Characteristics");

            migrationBuilder.AddColumn<int>(
                name: "ControlMethodId",
                table: "OrganizationParts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "ControlMethods",
                keyColumn: "ControlMethodId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 447, DateTimeKind.Local).AddTicks(4164));

            migrationBuilder.UpdateData(
                table: "ControlMethods",
                keyColumn: "ControlMethodId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 454, DateTimeKind.Local).AddTicks(7280));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(6221));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(6326));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(6363));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(6386));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 5,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(6409));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 6,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(6433));

            migrationBuilder.UpdateData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 7,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(6454));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 454, DateTimeKind.Local).AddTicks(8969));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 454, DateTimeKind.Local).AddTicks(9274));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 454, DateTimeKind.Local).AddTicks(9311));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 454, DateTimeKind.Local).AddTicks(9411));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 5,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(3441));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 6,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(3933));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 7,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(4525));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 8,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(5201));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 9,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(5619));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(958));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(2964));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(3023));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(3110));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 5,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(3138));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 6,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(3223));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 7,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(3479));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 8,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(3584));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 9,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(3637));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 10,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(3716));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 11,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(3745));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 12,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(3825));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 13,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(3961));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 14,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(4062));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 15,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(4121));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 16,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(4197));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 17,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(4225));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 18,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(4306));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 19,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(4602));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 20,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(4786));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 21,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(4853));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 22,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(4955));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 23,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(4990));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 24,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(5092));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 25,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(5232));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 26,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(5337));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 27,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(5389));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 28,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(5467));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 29,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(5494));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 30,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(5570));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 31,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(5691));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 32,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(5792));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 33,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(5845));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 34,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(5922));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 35,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(5949));

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 36,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(6025));

            migrationBuilder.UpdateData(
                table: "OrganizationParts",
                keyColumn: "OrganizationPartId",
                keyValue: 1,
                columns: new[] { "ControlMethodId", "TimeStamp" },
                values: new object[] { 1, new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(7664) });

            migrationBuilder.UpdateData(
                table: "OrganizationParts",
                keyColumn: "OrganizationPartId",
                keyValue: 2,
                columns: new[] { "ControlMethodId", "TimeStamp" },
                values: new object[] { 1, new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(7826) });

            migrationBuilder.UpdateData(
                table: "OrganizationParts",
                keyColumn: "OrganizationPartId",
                keyValue: 3,
                columns: new[] { "ControlMethodId", "TimeStamp" },
                values: new object[] { 1, new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(7834) });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(2609));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(2879));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(2921));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(2998));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 5,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(3055));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 6,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(3083));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 7,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(3170));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 8,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(3195));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 9,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(3401));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 10,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(3509));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 11,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(3533));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 12,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(3556));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 13,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(3611));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 14,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(3666));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 15,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(3690));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 16,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(3774));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 17,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(3797));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 18,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(3907));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 19,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(3989));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 20,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(4012));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 21,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(4035));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 22,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(4096));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 23,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(4148));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 24,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(4172));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 25,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(4255));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 26,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(4279));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 27,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(4416));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 28,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(4658));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 29,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(4714));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 30,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(4749));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 31,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(4821));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 32,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(4889));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 33,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(4920));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 34,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(5027));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 35,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(5058));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 36,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(5172));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 37,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(5263));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 38,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(5287));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 39,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(5311));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 40,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(5363));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 41,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(5416));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 42,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(5440));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 43,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(5522));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 44,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(5545));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 45,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(5597));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 46,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(5720));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 47,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(5743));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 48,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(5766));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 49,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(5820));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 50,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(5874));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 51,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(5897));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 52,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(5977));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 53,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(6000));

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 54,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 13, 14, 36, 25, 455, DateTimeKind.Local).AddTicks(6053));

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationParts_ControlMethodId",
                table: "OrganizationParts",
                column: "ControlMethodId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrganizationParts_ControlMethods_ControlMethodId",
                table: "OrganizationParts",
                column: "ControlMethodId",
                principalTable: "ControlMethods",
                principalColumn: "ControlMethodId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrganizationParts_ControlMethods_ControlMethodId",
                table: "OrganizationParts");

            migrationBuilder.DropIndex(
                name: "IX_OrganizationParts_ControlMethodId",
                table: "OrganizationParts");

            migrationBuilder.DropColumn(
                name: "ControlMethodId",
                table: "OrganizationParts");

            migrationBuilder.AddColumn<int>(
                name: "ControlMethodId",
                table: "Characteristics",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateIndex(
                name: "IX_Characteristics_ControlMethodId",
                table: "Characteristics",
                column: "ControlMethodId");

            migrationBuilder.AddForeignKey(
                name: "FK_Characteristics_ControlMethods_ControlMethodId",
                table: "Characteristics",
                column: "ControlMethodId",
                principalTable: "ControlMethods",
                principalColumn: "ControlMethodId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
