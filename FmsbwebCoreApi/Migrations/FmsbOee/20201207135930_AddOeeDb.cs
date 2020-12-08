using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FmsbwebCoreApi.Migrations.FmsbOee
{
    public partial class AddOeeDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OeeLines",
                columns: table => new
                {
                    OeeLineId = table.Column<Guid>(nullable: false),
                    GroupName = table.Column<string>(maxLength: 5, nullable: true),
                    TagName = table.Column<string>(nullable: false),
                    WorkCenter = table.Column<string>(nullable: false),
                    Department = table.Column<string>(nullable: false),
                    TimeStamp = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OeeLines", x => x.OeeLineId);
                });

            migrationBuilder.CreateTable(
                name: "Oee",
                columns: table => new
                {
                    OeeId = table.Column<Guid>(nullable: false),
                    OeeLineId = table.Column<Guid>(nullable: false),
                    StartDateTime = table.Column<DateTime>(nullable: false),
                    EndDateTime = table.Column<DateTime>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oee", x => x.OeeId);
                    table.ForeignKey(
                        name: "FK_Oee_OeeLines_OeeLineId",
                        column: x => x.OeeLineId,
                        principalTable: "OeeLines",
                        principalColumn: "OeeLineId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "OeeLines",
                columns: new[] { "OeeLineId", "Department", "GroupName", "TagName", "TimeStamp", "WorkCenter" },
                values: new object[,]
                {
                    { new Guid("01b888a3-00ca-4736-96ae-1636dc7ec914"), "Assembly", "A2", "Assembly.A2_PACKOUT.A2_PACKOUT_APC", new DateTime(2020, 12, 7, 8, 59, 29, 760, DateTimeKind.Local).AddTicks(9759), "ASBY0002" },
                    { new Guid("bd9eae20-60c7-44cd-ae2e-96c5f015f82e"), "Assembly", "A3", "Assembly.A3.A3_APC", new DateTime(2020, 12, 7, 8, 59, 29, 762, DateTimeKind.Local).AddTicks(3562), "ASBY0003" },
                    { new Guid("77e6d96c-f58d-46ea-a00d-5f962cfaf67b"), "Assembly", "A4", "Assembly.A4_M3.A4_M3_APC", new DateTime(2020, 12, 7, 8, 59, 29, 762, DateTimeKind.Local).AddTicks(3710), "ASBY0004" },
                    { new Guid("c26e4341-8e94-48f8-9eb6-fd2c5061bae3"), "Assembly", "A5", "Assembly.A5.A5_APC", new DateTime(2020, 12, 7, 8, 59, 29, 762, DateTimeKind.Local).AddTicks(3741), "ASBY0005" },
                    { new Guid("f5ede641-fb76-40d5-924b-5d28ceea1ac9"), "Assembly", "A6", "Assembly.A6_M2.A6_M2_APC", new DateTime(2020, 12, 7, 8, 59, 29, 762, DateTimeKind.Local).AddTicks(3767), "ASBY0006" },
                    { new Guid("1ace746f-f44f-47c4-bb9c-6c49fc550488"), "Assembly", "A7", "Assembly.A7_M3.A7_M3_APC", new DateTime(2020, 12, 7, 8, 59, 29, 762, DateTimeKind.Local).AddTicks(3800), "ASBY0007" },
                    { new Guid("13667af3-8a37-456a-8d65-5e98627af1ad"), "Assembly", "A8", "Assembly.A8.A8_APC", new DateTime(2020, 12, 7, 8, 59, 29, 762, DateTimeKind.Local).AddTicks(3825), "ASBY0008" },
                    { new Guid("3ea0d0fe-9c1b-4171-baa1-aa5b6e6422e2"), "Assembly", "A9", "Assembly.A9_M3.A9_M3_APC", new DateTime(2020, 12, 7, 8, 59, 29, 762, DateTimeKind.Local).AddTicks(3862), "ASBY0009" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Oee_OeeLineId",
                table: "Oee",
                column: "OeeLineId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Oee");

            migrationBuilder.DropTable(
                name: "OeeLines");
        }
    }
}
