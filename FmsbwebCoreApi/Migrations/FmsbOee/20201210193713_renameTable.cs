using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FmsbwebCoreApi.Migrations.FmsbOee
{
    public partial class renameTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Oee_OeeLines_OeeLineId",
                table: "Oee");

            migrationBuilder.DropTable(
                name: "OeeLines");

            migrationBuilder.CreateTable(
                name: "Lines",
                columns: table => new
                {
                    LineId = table.Column<Guid>(nullable: false),
                    GroupName = table.Column<string>(maxLength: 5, nullable: true),
                    TagName = table.Column<string>(nullable: false),
                    WorkCenter = table.Column<string>(nullable: false),
                    Department = table.Column<string>(nullable: false),
                    CycleTimeSeconds = table.Column<decimal>(nullable: false),
                    ScrapInspectionLocation = table.Column<int>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lines", x => x.LineId);
                });

            migrationBuilder.InsertData(
                table: "Lines",
                columns: new[] { "LineId", "CycleTimeSeconds", "DateModified", "Department", "GroupName", "ScrapInspectionLocation", "TagName", "WorkCenter" },
                values: new object[,]
                {
                    { new Guid("01b888a3-00ca-4736-96ae-1636dc7ec914"), 5m, new DateTime(2020, 12, 10, 14, 37, 12, 608, DateTimeKind.Local).AddTicks(8909), "Assembly", "A2", 2, "Assembly.A2_PACKOUT.A2_PACKOUT_APC", "ASBY0002" },
                    { new Guid("bd9eae20-60c7-44cd-ae2e-96c5f015f82e"), 11m, new DateTime(2020, 12, 10, 14, 37, 12, 619, DateTimeKind.Local).AddTicks(5717), "Assembly", "A3", 1, "Assembly.A3.A3_APC", "ASBY0003" },
                    { new Guid("77e6d96c-f58d-46ea-a00d-5f962cfaf67b"), 8.4m, new DateTime(2020, 12, 10, 14, 37, 12, 619, DateTimeKind.Local).AddTicks(5991), "Assembly", "A4", 1, "Assembly.A4_M3.A4_M3_APC", "ASBY0004" },
                    { new Guid("c26e4341-8e94-48f8-9eb6-fd2c5061bae3"), 8m, new DateTime(2020, 12, 10, 14, 37, 12, 619, DateTimeKind.Local).AddTicks(6035), "Assembly", "A5", 2, "Assembly.A5.A5_APC", "ASBY0005" },
                    { new Guid("f5ede641-fb76-40d5-924b-5d28ceea1ac9"), 8m, new DateTime(2020, 12, 10, 14, 37, 12, 619, DateTimeKind.Local).AddTicks(6156), "Assembly", "A6", 1, "Assembly.A6_M2.A6_M2_APC", "ASBY0006" },
                    { new Guid("1ace746f-f44f-47c4-bb9c-6c49fc550488"), 9m, new DateTime(2020, 12, 10, 14, 37, 12, 619, DateTimeKind.Local).AddTicks(6214), "Assembly", "A7", 1, "Assembly.A7_M3.A7_M3_APC", "ASBY0007" },
                    { new Guid("13667af3-8a37-456a-8d65-5e98627af1ad"), 12m, new DateTime(2020, 12, 10, 14, 37, 12, 619, DateTimeKind.Local).AddTicks(6252), "Assembly", "A8", 1, "Assembly.A8.A8_APC", "ASBY0008" },
                    { new Guid("3ea0d0fe-9c1b-4171-baa1-aa5b6e6422e2"), 8.5m, new DateTime(2020, 12, 10, 14, 37, 12, 619, DateTimeKind.Local).AddTicks(6290), "Assembly", "A9", 1, "Assembly.A9_M3.A9_M3_APC", "ASBY0009" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Oee_Lines_OeeLineId",
                table: "Oee",
                column: "OeeLineId",
                principalTable: "Lines",
                principalColumn: "LineId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Oee_Lines_OeeLineId",
                table: "Oee");

            migrationBuilder.DropTable(
                name: "Lines");

            migrationBuilder.CreateTable(
                name: "OeeLines",
                columns: table => new
                {
                    OeeLineId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CycleTimeSeconds = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GroupName = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    ScrapInspectionLocation = table.Column<int>(type: "int", nullable: false),
                    TagName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkCenter = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OeeLines", x => x.OeeLineId);
                });

            migrationBuilder.InsertData(
                table: "OeeLines",
                columns: new[] { "OeeLineId", "CycleTimeSeconds", "DateModified", "Department", "GroupName", "ScrapInspectionLocation", "TagName", "WorkCenter" },
                values: new object[,]
                {
                    { new Guid("01b888a3-00ca-4736-96ae-1636dc7ec914"), 5m, new DateTime(2020, 12, 9, 14, 9, 23, 916, DateTimeKind.Local).AddTicks(7349), "Assembly", "A2", 2, "Assembly.A2_PACKOUT.A2_PACKOUT_APC", "ASBY0002" },
                    { new Guid("bd9eae20-60c7-44cd-ae2e-96c5f015f82e"), 11m, new DateTime(2020, 12, 9, 14, 9, 23, 924, DateTimeKind.Local).AddTicks(616), "Assembly", "A3", 1, "Assembly.A3.A3_APC", "ASBY0003" },
                    { new Guid("77e6d96c-f58d-46ea-a00d-5f962cfaf67b"), 8.4m, new DateTime(2020, 12, 9, 14, 9, 23, 924, DateTimeKind.Local).AddTicks(791), "Assembly", "A4", 1, "Assembly.A4_M3.A4_M3_APC", "ASBY0004" },
                    { new Guid("c26e4341-8e94-48f8-9eb6-fd2c5061bae3"), 8m, new DateTime(2020, 12, 9, 14, 9, 23, 924, DateTimeKind.Local).AddTicks(824), "Assembly", "A5", 2, "Assembly.A5.A5_APC", "ASBY0005" },
                    { new Guid("f5ede641-fb76-40d5-924b-5d28ceea1ac9"), 8m, new DateTime(2020, 12, 9, 14, 9, 23, 924, DateTimeKind.Local).AddTicks(853), "Assembly", "A6", 1, "Assembly.A6_M2.A6_M2_APC", "ASBY0006" },
                    { new Guid("1ace746f-f44f-47c4-bb9c-6c49fc550488"), 9m, new DateTime(2020, 12, 9, 14, 9, 23, 924, DateTimeKind.Local).AddTicks(886), "Assembly", "A7", 1, "Assembly.A7_M3.A7_M3_APC", "ASBY0007" },
                    { new Guid("13667af3-8a37-456a-8d65-5e98627af1ad"), 12m, new DateTime(2020, 12, 9, 14, 9, 23, 924, DateTimeKind.Local).AddTicks(914), "Assembly", "A8", 1, "Assembly.A8.A8_APC", "ASBY0008" },
                    { new Guid("3ea0d0fe-9c1b-4171-baa1-aa5b6e6422e2"), 8.5m, new DateTime(2020, 12, 9, 14, 9, 23, 924, DateTimeKind.Local).AddTicks(939), "Assembly", "A9", 1, "Assembly.A9_M3.A9_M3_APC", "ASBY0009" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Oee_OeeLines_OeeLineId",
                table: "Oee",
                column: "OeeLineId",
                principalTable: "OeeLines",
                principalColumn: "OeeLineId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
