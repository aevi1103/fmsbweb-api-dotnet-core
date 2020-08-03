using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FmsbwebCoreApi.Migrations.QualityCheckSheets
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ControlMethods",
                columns: table => new
                {
                    ControlMethodId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Method = table.Column<string>(nullable: false),
                    TimeStamp = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ControlMethods", x => x.ControlMethodId);
                });

            migrationBuilder.CreateTable(
                name: "DisplayAs",
                columns: table => new
                {
                    DisplayAsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Display = table.Column<string>(nullable: false),
                    TimeStamp = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DisplayAs", x => x.DisplayAsId);
                });

            migrationBuilder.CreateTable(
                name: "Lines",
                columns: table => new
                {
                    LineId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(nullable: false),
                    TimeStamp = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lines", x => x.LineId);
                });

            migrationBuilder.CreateTable(
                name: "OrganizationParts",
                columns: table => new
                {
                    OrganizationPartId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LeftHandPart = table.Column<string>(nullable: false),
                    RightHandPart = table.Column<string>(nullable: true),
                    TimeStamp = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizationParts", x => x.OrganizationPartId);
                });

            migrationBuilder.CreateTable(
                name: "Machines",
                columns: table => new
                {
                    MachineId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LineId = table.Column<int>(nullable: false),
                    Value = table.Column<string>(nullable: false),
                    TimeStamp = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Machines", x => x.MachineId);
                    table.ForeignKey(
                        name: "FK_Machines_Lines_LineId",
                        column: x => x.LineId,
                        principalTable: "Lines",
                        principalColumn: "LineId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Characteristics",
                columns: table => new
                {
                    CharacteristicId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ControlMethodId = table.Column<int>(nullable: false),
                    MachineId = table.Column<int>(nullable: false),
                    OrganizationPartId = table.Column<int>(nullable: false),
                    ReferenceNo = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: false),
                    Gauge = table.Column<string>(nullable: false),
                    Frequency = table.Column<int>(nullable: false),
                    Min = table.Column<decimal>(nullable: true),
                    Nom = table.Column<decimal>(nullable: true),
                    Max = table.Column<decimal>(nullable: true),
                    PassFail = table.Column<bool>(nullable: true),
                    DisplayAsId = table.Column<int>(nullable: false),
                    HelperText = table.Column<string>(nullable: true),
                    TimeStamp = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characteristics", x => x.CharacteristicId);
                    table.ForeignKey(
                        name: "FK_Characteristics_ControlMethods_ControlMethodId",
                        column: x => x.ControlMethodId,
                        principalTable: "ControlMethods",
                        principalColumn: "ControlMethodId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Characteristics_DisplayAs_DisplayAsId",
                        column: x => x.DisplayAsId,
                        principalTable: "DisplayAs",
                        principalColumn: "DisplayAsId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Characteristics_Machines_MachineId",
                        column: x => x.MachineId,
                        principalTable: "Machines",
                        principalColumn: "MachineId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Characteristics_OrganizationParts_OrganizationPartId",
                        column: x => x.OrganizationPartId,
                        principalTable: "OrganizationParts",
                        principalColumn: "OrganizationPartId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubMachines",
                columns: table => new
                {
                    SubMachineId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MachineId = table.Column<int>(nullable: false),
                    Value = table.Column<string>(nullable: false),
                    TimeStamp = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubMachines", x => x.SubMachineId);
                    table.ForeignKey(
                        name: "FK_SubMachines_Machines_MachineId",
                        column: x => x.MachineId,
                        principalTable: "Machines",
                        principalColumn: "MachineId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Lines",
                columns: new[] { "LineId", "TimeStamp", "Value" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 7, 31, 14, 34, 25, 934, DateTimeKind.Local).AddTicks(879), "1" },
                    { 2, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(249), "2" },
                    { 3, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(458), "3" },
                    { 4, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(486), "4" },
                    { 5, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1250), "5" },
                    { 6, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1674), "6" },
                    { 7, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1974), "7" },
                    { 8, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2329), "8" },
                    { 9, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2687), "9" }
                });

            migrationBuilder.InsertData(
                table: "Machines",
                columns: new[] { "MachineId", "LineId", "TimeStamp", "Value" },
                values: new object[,]
                {
                    { 1, 4, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(609), "Okuma SP" },
                    { 21, 7, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2160), "Chiron SP" },
                    { 22, 7, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2223), "Drill" },
                    { 23, 7, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2245), "Diamond Turn SP" },
                    { 24, 7, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2308), "Accuriser" },
                    { 25, 8, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2350), "Okuma SP" },
                    { 26, 8, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2432), "Turmat" },
                    { 20, 7, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2138), "Turmat" },
                    { 27, 8, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2454), "Chiron SP" },
                    { 29, 8, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2603), "Diamond Turn SP" },
                    { 30, 8, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2666), "Accuriser" },
                    { 31, 9, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2710), "Okuma SP" },
                    { 32, 9, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2791), "Turmat" },
                    { 33, 9, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2812), "Chiron SP" },
                    { 34, 9, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2876), "Drill" },
                    { 28, 8, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2582), "Drill" },
                    { 19, 7, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2051), "Okuma SP" },
                    { 18, 6, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1953), "Accuriser" },
                    { 17, 6, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1889), "Diamond Turn SP" },
                    { 2, 4, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1042), "Turmat" },
                    { 3, 4, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1066), "Chiron SP" },
                    { 4, 4, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1135), "Drill" },
                    { 5, 4, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1158), "Diamond Turn SP" },
                    { 6, 4, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1226), "Accuriser" },
                    { 7, 5, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1275), "Okuma SP" },
                    { 8, 5, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1366), "Turmat" },
                    { 9, 5, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1389), "Chiron SP" },
                    { 10, 5, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1454), "Drill" },
                    { 11, 5, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1476), "Diamond Turn SP" },
                    { 12, 5, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1650), "Accuriser" },
                    { 13, 6, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1697), "Okuma SP" },
                    { 14, 6, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1781), "Turmat" },
                    { 15, 6, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1803), "Chiron SP" },
                    { 16, 6, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1867), "Drill" },
                    { 35, 9, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2898), "Diamond Turn SP" },
                    { 36, 9, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(3005), "Accuriser" }
                });

            migrationBuilder.InsertData(
                table: "SubMachines",
                columns: new[] { "SubMachineId", "MachineId", "TimeStamp", "Value" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(909), "OK1" },
                    { 24, 19, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2116), "OK3" },
                    { 25, 21, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2183), "Chiron 1" },
                    { 26, 21, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2203), "Chiron 2" },
                    { 27, 23, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2268), "DT1" },
                    { 28, 23, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2288), "DT2" },
                    { 29, 25, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2372), "OK1" },
                    { 30, 25, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2392), "OK2" },
                    { 31, 25, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2411), "OK3" },
                    { 32, 27, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2533), "Chiron 1" },
                    { 33, 27, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2558), "Chiron 2" },
                    { 34, 29, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2627), "DT1" },
                    { 35, 29, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2646), "DT2" },
                    { 36, 31, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2731), "OK1" },
                    { 37, 31, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2751), "OK2" },
                    { 38, 31, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2770), "OK3" },
                    { 39, 33, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2836), "Chiron 1" },
                    { 40, 33, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2855), "Chiron 2" },
                    { 23, 19, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2096), "OK2" },
                    { 22, 19, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2076), "OK1" },
                    { 21, 17, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1933), "DT2" },
                    { 20, 17, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1913), "DT1" },
                    { 2, 1, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(990), "OK2" },
                    { 3, 1, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1015), "OK3" },
                    { 4, 3, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1092), "Chiron 1" },
                    { 5, 3, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1112), "Chiron 2" },
                    { 6, 5, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1186), "DT1" },
                    { 7, 5, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1206), "DT2" },
                    { 8, 7, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1302), "OK1" },
                    { 9, 7, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1323), "OK2" },
                    { 41, 35, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2963), "DT1" },
                    { 10, 7, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1344), "OK3" },
                    { 12, 9, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1433), "Chiron 2" },
                    { 13, 11, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1607), "DT1" },
                    { 14, 11, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1630), "DT2" },
                    { 15, 13, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1719), "OK1" },
                    { 16, 13, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1739), "OK2" },
                    { 17, 13, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1758), "OK3" },
                    { 18, 15, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1826), "Chiron 1" },
                    { 19, 15, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1846), "Chiron 2" },
                    { 11, 9, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1413), "Chiron 1" },
                    { 42, 35, new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2983), "DT2" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Characteristics_ControlMethodId",
                table: "Characteristics",
                column: "ControlMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_Characteristics_DisplayAsId",
                table: "Characteristics",
                column: "DisplayAsId");

            migrationBuilder.CreateIndex(
                name: "IX_Characteristics_MachineId",
                table: "Characteristics",
                column: "MachineId");

            migrationBuilder.CreateIndex(
                name: "IX_Characteristics_OrganizationPartId",
                table: "Characteristics",
                column: "OrganizationPartId");

            migrationBuilder.CreateIndex(
                name: "IX_Machines_LineId",
                table: "Machines",
                column: "LineId");

            migrationBuilder.CreateIndex(
                name: "IX_SubMachines_MachineId",
                table: "SubMachines",
                column: "MachineId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Characteristics");

            migrationBuilder.DropTable(
                name: "SubMachines");

            migrationBuilder.DropTable(
                name: "ControlMethods");

            migrationBuilder.DropTable(
                name: "DisplayAs");

            migrationBuilder.DropTable(
                name: "OrganizationParts");

            migrationBuilder.DropTable(
                name: "Machines");

            migrationBuilder.DropTable(
                name: "Lines");
        }
    }
}
