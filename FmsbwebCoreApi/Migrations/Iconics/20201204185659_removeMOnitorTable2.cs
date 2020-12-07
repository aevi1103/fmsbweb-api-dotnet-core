using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FmsbwebCoreApi.Migrations.Iconics
{
    public partial class removeMOnitorTable2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("01b888a3-00ca-4736-96ae-1636dc7ec914"),
                columns: new[] { "TagName", "TimeStamp" },
                values: new object[] { "Assembly.A2_PACKOUT.A2_PACKOUT_APC", new DateTime(2020, 12, 4, 13, 56, 58, 848, DateTimeKind.Local).AddTicks(2034) });

            migrationBuilder.UpdateData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("13667af3-8a37-456a-8d65-5e98627af1ad"),
                columns: new[] { "TagName", "TimeStamp" },
                values: new object[] { "Assembly.A8.A8_APC", new DateTime(2020, 12, 4, 13, 56, 58, 849, DateTimeKind.Local).AddTicks(5128) });

            migrationBuilder.UpdateData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("1ace746f-f44f-47c4-bb9c-6c49fc550488"),
                columns: new[] { "TagName", "TimeStamp" },
                values: new object[] { "Assembly.A7_M3.A7_M3_APC", new DateTime(2020, 12, 4, 13, 56, 58, 849, DateTimeKind.Local).AddTicks(5103) });

            migrationBuilder.UpdateData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("3ea0d0fe-9c1b-4171-baa1-aa5b6e6422e2"),
                columns: new[] { "TagName", "TimeStamp" },
                values: new object[] { "Assembly.A9_M3.A9_M3_APC", new DateTime(2020, 12, 4, 13, 56, 58, 849, DateTimeKind.Local).AddTicks(5152) });

            migrationBuilder.UpdateData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("77e6d96c-f58d-46ea-a00d-5f962cfaf67b"),
                columns: new[] { "TagName", "TimeStamp" },
                values: new object[] { "Assembly.A4_M3.A4_M3_APC", new DateTime(2020, 12, 4, 13, 56, 58, 849, DateTimeKind.Local).AddTicks(5012) });

            migrationBuilder.UpdateData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("bd9eae20-60c7-44cd-ae2e-96c5f015f82e"),
                columns: new[] { "TagName", "TimeStamp" },
                values: new object[] { "Assembly.A3.A3_APC", new DateTime(2020, 12, 4, 13, 56, 58, 849, DateTimeKind.Local).AddTicks(4883) });

            migrationBuilder.UpdateData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("c26e4341-8e94-48f8-9eb6-fd2c5061bae3"),
                columns: new[] { "TagName", "TimeStamp" },
                values: new object[] { "Assembly.A5.A5_APC", new DateTime(2020, 12, 4, 13, 56, 58, 849, DateTimeKind.Local).AddTicks(5039) });

            migrationBuilder.UpdateData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("f5ede641-fb76-40d5-924b-5d28ceea1ac9"),
                columns: new[] { "TagName", "TimeStamp" },
                values: new object[] { "Assembly.A6_M2.A6_M2_APC", new DateTime(2020, 12, 4, 13, 56, 58, 849, DateTimeKind.Local).AddTicks(5074) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
