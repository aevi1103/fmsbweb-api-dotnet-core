using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FmsbwebCoreApi.Migrations.QualityCheckSheets
{
    public partial class addSeed2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ControlMethods",
                columns: new[] { "ControlMethodId", "Method", "TimeStamp" },
                values: new object[,]
                {
                    { 1, "Machining Check Sheet", new DateTime(2020, 8, 13, 14, 42, 43, 183, DateTimeKind.Local).AddTicks(9538) },
                    { 2, "Quality Inspection Summary", new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(3400) }
                });

            migrationBuilder.InsertData(
                table: "DisplayAs",
                columns: new[] { "DisplayAsId", "Display", "TimeStamp" },
                values: new object[,]
                {
                    { 6, "Positive", new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(1656) },
                    { 5, "PassFail", new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(1634) },
                    { 4, "NegativePositive", new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(1614) },
                    { 7, "Reference", new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(1677) },
                    { 2, "Percent", new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(1555) },
                    { 1, "Number", new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(1457) },
                    { 3, "Degrees", new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(1594) }
                });

            migrationBuilder.InsertData(
                table: "Lines",
                columns: new[] { "LineId", "TimeStamp", "Value" },
                values: new object[,]
                {
                    { 8, new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(206), "8" },
                    { 1, new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(4966), "1" },
                    { 2, new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(5267), "2" },
                    { 3, new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(5303), "3" },
                    { 4, new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(5328), "4" },
                    { 5, new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(8610), "5" },
                    { 6, new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(9074), "6" },
                    { 7, new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(9529), "7" },
                    { 9, new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(890), "9" }
                });

            migrationBuilder.InsertData(
                table: "Machines",
                columns: new[] { "MachineId", "LineId", "TimeStamp", "Value" },
                values: new object[,]
                {
                    { 17, 6, new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(9398), "Diamond Turn SP" },
                    { 19, 7, new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(9554), "Okuma SP" },
                    { 20, 7, new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(9653), "Turmat" },
                    { 21, 7, new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(9704), "Chiron SP" },
                    { 22, 7, new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(9826), "Drill" },
                    { 23, 7, new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(9853), "Diamond Turn SP" },
                    { 24, 7, new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(9998), "Accuriser" },
                    { 25, 8, new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(259), "Okuma SP" },
                    { 18, 6, new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(9477), "Accuriser" },
                    { 26, 8, new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(519), "Turmat" },
                    { 28, 8, new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(731), "Drill" },
                    { 29, 8, new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(758), "Diamond Turn SP" },
                    { 30, 8, new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(839), "Accuriser" },
                    { 31, 9, new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(919), "Okuma SP" },
                    { 32, 9, new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(1022), "Turmat" },
                    { 33, 9, new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(1074), "Chiron SP" },
                    { 34, 9, new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(1198), "Drill" },
                    { 27, 8, new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(573), "Chiron SP" },
                    { 35, 9, new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(1225), "Diamond Turn SP" },
                    { 36, 9, new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(1301), "Accuriser" },
                    { 15, 6, new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(9250), "Chiron SP" },
                    { 1, 4, new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(6706), "Okuma SP" },
                    { 2, 4, new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(8193), "Turmat" },
                    { 3, 4, new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(8249), "Chiron SP" },
                    { 4, 4, new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(8445), "Drill" },
                    { 5, 4, new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(8471), "Diamond Turn SP" },
                    { 16, 6, new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(9371), "Drill" },
                    { 7, 5, new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(8641), "Okuma SP" },
                    { 6, 4, new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(8554), "Accuriser" },
                    { 9, 5, new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(8792), "Chiron SP" },
                    { 10, 5, new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(8914), "Drill" },
                    { 11, 5, new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(8941), "Diamond Turn SP" },
                    { 12, 5, new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(9022), "Accuriser" },
                    { 13, 6, new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(9100), "Okuma SP" },
                    { 14, 6, new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(9198), "Turmat" },
                    { 8, 5, new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(8740), "Turmat" }
                });

            migrationBuilder.InsertData(
                table: "OrganizationParts",
                columns: new[] { "OrganizationPartId", "ControlMethodId", "LeftHandPart", "RightHandPart", "TimeStamp" },
                values: new object[,]
                {
                    { 3, 1, "81313", "81314", new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(3254) },
                    { 2, 1, "81311", "81312", new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(3240) },
                    { 1, 1, "81309", "81310", new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(3019) }
                });

            migrationBuilder.InsertData(
                table: "SubMachines",
                columns: new[] { "SubMachineId", "MachineId", "TimeStamp", "Value" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(7944), "OK1" },
                    { 30, 19, new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(9626), "OK3" },
                    { 31, 20, new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(9680), "Turmat" },
                    { 32, 21, new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(9769), "Chiron 1" },
                    { 33, 21, new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(9797), "Chiron 2" },
                    { 34, 23, new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(9881), "DT1" },
                    { 35, 23, new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(9935), "DT2" },
                    { 36, 24, new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(148), "Accuriser" },
                    { 37, 25, new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(319), "OK1" },
                    { 38, 25, new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(458), "OK2" },
                    { 39, 25, new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(488), "OK3" },
                    { 40, 26, new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(548), "Turmat" },
                    { 41, 27, new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(671), "Chiron 1" },
                    { 42, 27, new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(703), "Chiron 2" },
                    { 43, 29, new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(788), "DT1" },
                    { 44, 29, new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(813), "DT2" },
                    { 45, 30, new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(867), "Accuriser" },
                    { 46, 31, new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(947), "OK1" },
                    { 47, 31, new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(971), "OK2" },
                    { 48, 31, new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(995), "OK3" },
                    { 49, 32, new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(1049), "Turmat" },
                    { 50, 33, new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(1146), "Chiron 1" },
                    { 51, 33, new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(1171), "Chiron 2" },
                    { 52, 35, new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(1252), "DT1" },
                    { 29, 19, new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(9603), "OK2" },
                    { 28, 19, new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(9580), "OK1" },
                    { 27, 18, new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(9506), "Accuriser" },
                    { 26, 17, new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(9451), "DT2" },
                    { 2, 1, new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(8124), "OK2" },
                    { 3, 1, new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(8156), "OK3" },
                    { 4, 2, new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(8224), "Turmat" },
                    { 5, 3, new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(8387), "Chiron 1" },
                    { 6, 3, new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(8417), "Chiron 2" },
                    { 7, 5, new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(8503), "DT1" },
                    { 8, 5, new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(8527), "DT2" },
                    { 9, 6, new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(8584), "Accuriser" },
                    { 10, 7, new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(8668), "OK1" },
                    { 11, 7, new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(8691), "OK2" },
                    { 12, 7, new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(8714), "OK3" },
                    { 53, 35, new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(1275), "DT2" },
                    { 13, 8, new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(8768), "Turmat" },
                    { 15, 9, new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(8888), "Chiron 2" },
                    { 16, 11, new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(8971), "DT1" },
                    { 17, 11, new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(8994), "DT2" },
                    { 18, 12, new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(9051), "Accuriser" },
                    { 19, 13, new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(9126), "OK1" },
                    { 20, 13, new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(9149), "OK2" },
                    { 21, 13, new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(9172), "OK3" },
                    { 22, 14, new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(9225), "Turmat" },
                    { 23, 15, new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(9321), "Chiron 1" },
                    { 24, 15, new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(9346), "Chiron 2" },
                    { 25, 17, new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(9428), "DT1" },
                    { 14, 9, new DateTime(2020, 8, 13, 14, 42, 43, 189, DateTimeKind.Local).AddTicks(8863), "Chiron 1" },
                    { 54, 36, new DateTime(2020, 8, 13, 14, 42, 43, 190, DateTimeKind.Local).AddTicks(1328), "Accuriser" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DeleteData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "DisplayAs",
                keyColumn: "DisplayAsId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 34);

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

            migrationBuilder.DeleteData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "SubMachines",
                keyColumn: "SubMachineId",
                keyValue: 42);

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

            migrationBuilder.DeleteData(
                table: "ControlMethods",
                keyColumn: "ControlMethodId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: 9);
        }
    }
}
