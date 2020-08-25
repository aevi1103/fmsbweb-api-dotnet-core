using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FmsbwebCoreApi.Migrations.QualityCheckSheets
{
    public partial class addRechecks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsReChecked",
                table: "CheckSheetEntries",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "ReChecks",
                columns: table => new
                {
                    ReCheckId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CheckSheetEntryId = table.Column<int>(nullable: false),
                    Value = table.Column<decimal>(nullable: true),
                    ValueBool = table.Column<bool>(nullable: true),
                    Comment = table.Column<string>(nullable: true),
                    TimeStamp = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReChecks", x => x.ReCheckId);
                    table.ForeignKey(
                        name: "FK_ReChecks_CheckSheetEntries_CheckSheetEntryId",
                        column: x => x.CheckSheetEntryId,
                        principalTable: "CheckSheetEntries",
                        principalColumn: "CheckSheetEntryId",
                        onDelete: ReferentialAction.Cascade);
                });

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
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 4, new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(6612), "Drill" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 8,
                columns: new[] { "TimeStamp", "Value" },
                values: new object[] { new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(6669), "DT1" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 9,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 5, new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(6693), "DT2" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 10,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 6, new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(6753), "Accuriser" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 11,
                columns: new[] { "TimeStamp", "Value" },
                values: new object[] { new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(6839), "OK1" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 12,
                columns: new[] { "TimeStamp", "Value" },
                values: new object[] { new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(6863), "OK2" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 13,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 7, new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(6886), "OK3" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 14,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 8, new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(6991), "Turmat" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 15,
                columns: new[] { "TimeStamp", "Value" },
                values: new object[] { new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(7046), "Chiron 1" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 16,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 9, new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(7070), "Chiron 2" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 17,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 10, new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(7123), "Drill" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 18,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 11, new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(7180), "DT1" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 19,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 11, new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(7203), "DT2" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 20,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 12, new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(7260), "Accuriser" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 21,
                columns: new[] { "TimeStamp", "Value" },
                values: new object[] { new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(7338), "OK1" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 22,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 13, new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(7361), "OK2" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 23,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 13, new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(7385), "OK3" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 24,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 14, new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(7482), "Turmat" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 25,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 15, new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(7535), "Chiron 1" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 26,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 15, new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(7559), "Chiron 2" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 27,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 16, new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(7612), "Drill" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 28,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 17, new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(7667), "DT1" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 29,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 17, new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(7691), "DT2" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 30,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 18, new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(7747), "Accuriser" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 31,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 19, new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(7823), "OK1" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 32,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 19, new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(7848), "OK2" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 33,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 19, new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(7871), "OK3" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 34,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 20, new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(7971), "Turmat" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 35,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 21, new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(8024), "Chiron 1" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 36,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 21, new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(8047), "Chiron 2" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 37,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 22, new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(8100), "Drill" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 38,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 23, new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(8154), "DT1" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 39,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 23, new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(8177), "DT2" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 40,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 24, new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(8233), "Accuriser" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 41,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 25, new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(8308), "OK1" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 42,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 25, new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(8369), "OK2" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 43,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 25, new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(8397), "OK3" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 44,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 26, new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(8454), "Turmat" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 45,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 27, new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(8506), "Chiron 1" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 46,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 27, new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(8529), "Chiron 2" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 47,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 28, new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(8583), "Drill" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 48,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 29, new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(8636), "DT1" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 49,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 29, new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(8659), "DT2" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 50,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 30, new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(8714), "Accuriser" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 51,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 31, new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(8791), "OK1" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 52,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 31, new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(8877), "OK2" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 53,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 31, new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(8906), "OK3" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 54,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 32, new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(8962), "Turmat" });

            migrationBuilder.InsertData(
                table: "SubMachines",
                columns: new[] { "SubMachineId", "MachineId", "TimeStamp", "Value" },
                values: new object[,]
                {
                    { 60, 36, new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(9245), "Accuriser" },
                    { 59, 35, new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(9189), "DT2" },
                    { 58, 35, new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(9164), "DT1" },
                    { 57, 34, new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(9092), "Drill" },
                    { 56, 33, new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(9039), "Chiron 2" },
                    { 55, 33, new DateTime(2020, 8, 24, 7, 27, 30, 286, DateTimeKind.Local).AddTicks(9016), "Chiron 1" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReChecks_CheckSheetEntryId",
                table: "ReChecks",
                column: "CheckSheetEntryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReChecks");

            migrationBuilder.DeleteData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 60);

            migrationBuilder.DropColumn(
                name: "IsReChecked",
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
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 5, new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(3017), "DT1" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 8,
                columns: new[] { "TimeStamp", "Value" },
                values: new object[] { new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(3038), "DT2" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 9,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 6, new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(3088), "Accuriser" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 10,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 7, new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(3162), "OK1" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 11,
                columns: new[] { "TimeStamp", "Value" },
                values: new object[] { new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(3183), "OK2" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 12,
                columns: new[] { "TimeStamp", "Value" },
                values: new object[] { new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(3203), "OK3" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 13,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 8, new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(3250), "Turmat" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 14,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 9, new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(3298), "Chiron 1" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 15,
                columns: new[] { "TimeStamp", "Value" },
                values: new object[] { new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(3319), "Chiron 2" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 16,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 11, new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(3441), "DT1" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 17,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 11, new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(3462), "DT2" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 18,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 12, new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(3511), "Accuriser" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 19,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 13, new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(3577), "OK1" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 20,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 13, new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(3597), "OK2" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 21,
                columns: new[] { "TimeStamp", "Value" },
                values: new object[] { new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(3617), "OK3" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 22,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 14, new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(3665), "Turmat" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 23,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 15, new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(3711), "Chiron 1" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 24,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 15, new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(3731), "Chiron 2" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 25,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 17, new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(3840), "DT1" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 26,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 17, new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(3862), "DT2" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 27,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 18, new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(3910), "Accuriser" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 28,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 19, new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(3975), "OK1" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 29,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 19, new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(3995), "OK2" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 30,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 19, new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(4015), "OK3" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 31,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 20, new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(4061), "Turmat" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 32,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 21, new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(4107), "Chiron 1" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 33,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 21, new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(4128), "Chiron 2" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 34,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 23, new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(4275), "DT1" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 35,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 23, new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(4298), "DT2" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 36,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 24, new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(4346), "Accuriser" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 37,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 25, new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(4409), "OK1" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 38,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 25, new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(4430), "OK2" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 39,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 25, new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(4449), "OK3" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 40,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 26, new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(4500), "Turmat" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 41,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 27, new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(4545), "Chiron 1" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 42,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 27, new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(4565), "Chiron 2" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 43,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 29, new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(4636), "DT1" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 44,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 29, new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(4690), "DT2" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 45,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 30, new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(4741), "Accuriser" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 46,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 31, new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(4807), "OK1" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 47,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 31, new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(4827), "OK2" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 48,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 31, new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(4847), "OK3" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 49,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 32, new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(4894), "Turmat" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 50,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 33, new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(4940), "Chiron 1" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 51,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 33, new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(4961), "Chiron 2" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 52,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 35, new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(5031), "DT1" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 53,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 35, new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(5084), "DT2" });

            migrationBuilder.UpdateData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 54,
                columns: new[] { "MachineId", "TimeStamp", "Value" },
                values: new object[] { 36, new DateTime(2020, 8, 14, 8, 1, 32, 986, DateTimeKind.Local).AddTicks(5135), "Accuriser" });
        }
    }
}
