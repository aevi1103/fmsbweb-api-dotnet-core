using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FmsbwebCoreApi.Migrations.Iconics
{
    public partial class removeMOnitorTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KepServerTagNameMonitors");

            migrationBuilder.AddColumn<string>(
                name: "TagName",
                table: "KepServerTagNameGroups",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("01b888a3-00ca-4736-96ae-1636dc7ec914"),
                columns: new[] { "TagName", "TimeStamp" },
                values: new object[] { "A2_PACKOUT_APC", new DateTime(2020, 12, 4, 13, 48, 10, 934, DateTimeKind.Local).AddTicks(9609) });

            migrationBuilder.UpdateData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("13667af3-8a37-456a-8d65-5e98627af1ad"),
                columns: new[] { "TagName", "TimeStamp" },
                values: new object[] { "A8_APC", new DateTime(2020, 12, 4, 13, 48, 10, 936, DateTimeKind.Local).AddTicks(8666) });

            migrationBuilder.UpdateData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("1ace746f-f44f-47c4-bb9c-6c49fc550488"),
                columns: new[] { "TagName", "TimeStamp" },
                values: new object[] { "A7_M3_APC", new DateTime(2020, 12, 4, 13, 48, 10, 936, DateTimeKind.Local).AddTicks(8641) });

            migrationBuilder.UpdateData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("3ea0d0fe-9c1b-4171-baa1-aa5b6e6422e2"),
                columns: new[] { "TagName", "TimeStamp" },
                values: new object[] { "A9_M3_APC", new DateTime(2020, 12, 4, 13, 48, 10, 936, DateTimeKind.Local).AddTicks(8784) });

            migrationBuilder.UpdateData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("77e6d96c-f58d-46ea-a00d-5f962cfaf67b"),
                columns: new[] { "TagName", "TimeStamp" },
                values: new object[] { "A4_M3_APC", new DateTime(2020, 12, 4, 13, 48, 10, 936, DateTimeKind.Local).AddTicks(8550) });

            migrationBuilder.UpdateData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("bd9eae20-60c7-44cd-ae2e-96c5f015f82e"),
                columns: new[] { "TagName", "TimeStamp" },
                values: new object[] { "A3_APC", new DateTime(2020, 12, 4, 13, 48, 10, 936, DateTimeKind.Local).AddTicks(8418) });

            migrationBuilder.UpdateData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("c26e4341-8e94-48f8-9eb6-fd2c5061bae3"),
                columns: new[] { "TagName", "TimeStamp" },
                values: new object[] { "A5_APC", new DateTime(2020, 12, 4, 13, 48, 10, 936, DateTimeKind.Local).AddTicks(8576) });

            migrationBuilder.UpdateData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("f5ede641-fb76-40d5-924b-5d28ceea1ac9"),
                columns: new[] { "TagName", "TimeStamp" },
                values: new object[] { "A6_M2_APC", new DateTime(2020, 12, 4, 13, 48, 10, 936, DateTimeKind.Local).AddTicks(8600) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TagName",
                table: "KepServerTagNameGroups");

            migrationBuilder.CreateTable(
                name: "KepServerTagNameMonitors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    KepServerTagNameGroupId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TagName = table.Column<string>(type: "varchar(100)", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KepServerTagNameMonitors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KepServerTagNameMonitors_KepServerTagNameGroups_KepServerTagNameGroupId",
                        column: x => x.KepServerTagNameGroupId,
                        principalTable: "KepServerTagNameGroups",
                        principalColumn: "KepServerTagNameGroupId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KepServerTagNameMonitors_KEPserverTagNames_TagName",
                        column: x => x.TagName,
                        principalTable: "KEPserverTagNames",
                        principalColumn: "TagName",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("01b888a3-00ca-4736-96ae-1636dc7ec914"),
                column: "TimeStamp",
                value: new DateTime(2020, 11, 25, 9, 46, 35, 576, DateTimeKind.Local).AddTicks(3515));

            migrationBuilder.UpdateData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("13667af3-8a37-456a-8d65-5e98627af1ad"),
                column: "TimeStamp",
                value: new DateTime(2020, 11, 25, 9, 46, 35, 579, DateTimeKind.Local).AddTicks(8254));

            migrationBuilder.UpdateData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("1ace746f-f44f-47c4-bb9c-6c49fc550488"),
                column: "TimeStamp",
                value: new DateTime(2020, 11, 25, 9, 46, 35, 579, DateTimeKind.Local).AddTicks(8200));

            migrationBuilder.UpdateData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("3ea0d0fe-9c1b-4171-baa1-aa5b6e6422e2"),
                column: "TimeStamp",
                value: new DateTime(2020, 11, 25, 9, 46, 35, 579, DateTimeKind.Local).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("77e6d96c-f58d-46ea-a00d-5f962cfaf67b"),
                column: "TimeStamp",
                value: new DateTime(2020, 11, 25, 9, 46, 35, 579, DateTimeKind.Local).AddTicks(8015));

            migrationBuilder.UpdateData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("bd9eae20-60c7-44cd-ae2e-96c5f015f82e"),
                column: "TimeStamp",
                value: new DateTime(2020, 11, 25, 9, 46, 35, 579, DateTimeKind.Local).AddTicks(7760));

            migrationBuilder.UpdateData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("c26e4341-8e94-48f8-9eb6-fd2c5061bae3"),
                column: "TimeStamp",
                value: new DateTime(2020, 11, 25, 9, 46, 35, 579, DateTimeKind.Local).AddTicks(8084));

            migrationBuilder.UpdateData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("f5ede641-fb76-40d5-924b-5d28ceea1ac9"),
                column: "TimeStamp",
                value: new DateTime(2020, 11, 25, 9, 46, 35, 579, DateTimeKind.Local).AddTicks(8141));

            migrationBuilder.InsertData(
                table: "KepServerTagNameMonitors",
                columns: new[] { "Id", "KepServerTagNameGroupId", "TagName", "TimeStamp" },
                values: new object[,]
                {
                    { new Guid("b37a8885-7889-407f-a44a-3cbcf3ee1a14"), new Guid("01b888a3-00ca-4736-96ae-1636dc7ec914"), "A2_PACKOUT_APC", new DateTime(2020, 11, 25, 9, 46, 35, 579, DateTimeKind.Local).AddTicks(6620) },
                    { new Guid("9f1aabaf-fc1e-437e-8af3-2e3e17aa4192"), new Guid("bd9eae20-60c7-44cd-ae2e-96c5f015f82e"), "A3_APC", new DateTime(2020, 11, 25, 9, 46, 35, 579, DateTimeKind.Local).AddTicks(7974) },
                    { new Guid("d81f4aca-b172-4e2d-b138-85fca35fdb48"), new Guid("77e6d96c-f58d-46ea-a00d-5f962cfaf67b"), "A4_M3_APC", new DateTime(2020, 11, 25, 9, 46, 35, 579, DateTimeKind.Local).AddTicks(8048) },
                    { new Guid("978337b6-98c6-4f65-97da-bed63b415e4a"), new Guid("c26e4341-8e94-48f8-9eb6-fd2c5061bae3"), "A5_APC", new DateTime(2020, 11, 25, 9, 46, 35, 579, DateTimeKind.Local).AddTicks(8114) },
                    { new Guid("bb1862ce-201c-40b1-be25-c6f13f8ec6b1"), new Guid("f5ede641-fb76-40d5-924b-5d28ceea1ac9"), "A6_M2_APC", new DateTime(2020, 11, 25, 9, 46, 35, 579, DateTimeKind.Local).AddTicks(8173) },
                    { new Guid("e6273b83-641d-4669-8003-be5bdd928093"), new Guid("1ace746f-f44f-47c4-bb9c-6c49fc550488"), "A7_M3_APC", new DateTime(2020, 11, 25, 9, 46, 35, 579, DateTimeKind.Local).AddTicks(8229) },
                    { new Guid("d43a0be0-32cc-4e28-9f74-88d10c04b6a8"), new Guid("13667af3-8a37-456a-8d65-5e98627af1ad"), "A8_APC", new DateTime(2020, 11, 25, 9, 46, 35, 579, DateTimeKind.Local).AddTicks(8282) },
                    { new Guid("61a26041-c823-427b-be03-9a10f37e344a"), new Guid("3ea0d0fe-9c1b-4171-baa1-aa5b6e6422e2"), "A9_M3_APC", new DateTime(2020, 11, 25, 9, 46, 35, 579, DateTimeKind.Local).AddTicks(8338) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_KepServerTagNameMonitors_KepServerTagNameGroupId",
                table: "KepServerTagNameMonitors",
                column: "KepServerTagNameGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_KepServerTagNameMonitors_TagName",
                table: "KepServerTagNameMonitors",
                column: "TagName");
        }
    }
}
