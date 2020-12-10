using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FmsbwebCoreApi.Migrations.Iconics
{
    public partial class removeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KepServerTagNameGroups");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KepServerTagNameGroups",
                columns: table => new
                {
                    KepServerTagNameGroupId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GroupName = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    TagName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WorkCenter = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KepServerTagNameGroups", x => x.KepServerTagNameGroupId);
                });

            migrationBuilder.InsertData(
                table: "KepServerTagNameGroups",
                columns: new[] { "KepServerTagNameGroupId", "Department", "GroupName", "TagName", "TimeStamp", "WorkCenter" },
                values: new object[,]
                {
                    { new Guid("01b888a3-00ca-4736-96ae-1636dc7ec914"), "Assembly", "A2", "Assembly.A2_PACKOUT.A2_PACKOUT_APC", new DateTime(2020, 12, 4, 16, 24, 39, 232, DateTimeKind.Local).AddTicks(7628), "ASBY0002" },
                    { new Guid("bd9eae20-60c7-44cd-ae2e-96c5f015f82e"), "Assembly", "A3", "Assembly.A3.A3_APC", new DateTime(2020, 12, 4, 16, 24, 39, 234, DateTimeKind.Local).AddTicks(6473), "ASBY0003" },
                    { new Guid("77e6d96c-f58d-46ea-a00d-5f962cfaf67b"), "Assembly", "A4", "Assembly.A4_M3.A4_M3_APC", new DateTime(2020, 12, 4, 16, 24, 39, 234, DateTimeKind.Local).AddTicks(6708), "ASBY0004" },
                    { new Guid("c26e4341-8e94-48f8-9eb6-fd2c5061bae3"), "Assembly", "A5", "Assembly.A5.A5_APC", new DateTime(2020, 12, 4, 16, 24, 39, 234, DateTimeKind.Local).AddTicks(6771), "ASBY0005" },
                    { new Guid("f5ede641-fb76-40d5-924b-5d28ceea1ac9"), "Assembly", "A6", "Assembly.A6_M2.A6_M2_APC", new DateTime(2020, 12, 4, 16, 24, 39, 234, DateTimeKind.Local).AddTicks(6837), "ASBY0006" },
                    { new Guid("1ace746f-f44f-47c4-bb9c-6c49fc550488"), "Assembly", "A7", "Assembly.A7_M3.A7_M3_APC", new DateTime(2020, 12, 4, 16, 24, 39, 234, DateTimeKind.Local).AddTicks(6916), "ASBY0007" },
                    { new Guid("13667af3-8a37-456a-8d65-5e98627af1ad"), "Assembly", "A8", "Assembly.A8.A8_APC", new DateTime(2020, 12, 4, 16, 24, 39, 234, DateTimeKind.Local).AddTicks(6962), "ASBY0008" },
                    { new Guid("3ea0d0fe-9c1b-4171-baa1-aa5b6e6422e2"), "Assembly", "A9", "Assembly.A9_M3.A9_M3_APC", new DateTime(2020, 12, 4, 16, 24, 39, 234, DateTimeKind.Local).AddTicks(7008), "ASBY0009" }
                });
        }
    }
}
