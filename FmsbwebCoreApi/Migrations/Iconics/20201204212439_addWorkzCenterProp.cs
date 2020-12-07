using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FmsbwebCoreApi.Migrations.Iconics
{
    public partial class addWorkzCenterProp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "WorkCenter",
                table: "KepServerTagNameGroups",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("01b888a3-00ca-4736-96ae-1636dc7ec914"),
                columns: new[] { "TimeStamp", "WorkCenter" },
                values: new object[] { new DateTime(2020, 12, 4, 16, 24, 39, 232, DateTimeKind.Local).AddTicks(7628), "ASBY0002" });

            migrationBuilder.UpdateData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("13667af3-8a37-456a-8d65-5e98627af1ad"),
                columns: new[] { "TimeStamp", "WorkCenter" },
                values: new object[] { new DateTime(2020, 12, 4, 16, 24, 39, 234, DateTimeKind.Local).AddTicks(6962), "ASBY0008" });

            migrationBuilder.UpdateData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("1ace746f-f44f-47c4-bb9c-6c49fc550488"),
                columns: new[] { "TimeStamp", "WorkCenter" },
                values: new object[] { new DateTime(2020, 12, 4, 16, 24, 39, 234, DateTimeKind.Local).AddTicks(6916), "ASBY0007" });

            migrationBuilder.UpdateData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("3ea0d0fe-9c1b-4171-baa1-aa5b6e6422e2"),
                columns: new[] { "TimeStamp", "WorkCenter" },
                values: new object[] { new DateTime(2020, 12, 4, 16, 24, 39, 234, DateTimeKind.Local).AddTicks(7008), "ASBY0009" });

            migrationBuilder.UpdateData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("77e6d96c-f58d-46ea-a00d-5f962cfaf67b"),
                columns: new[] { "TimeStamp", "WorkCenter" },
                values: new object[] { new DateTime(2020, 12, 4, 16, 24, 39, 234, DateTimeKind.Local).AddTicks(6708), "ASBY0004" });

            migrationBuilder.UpdateData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("bd9eae20-60c7-44cd-ae2e-96c5f015f82e"),
                columns: new[] { "TimeStamp", "WorkCenter" },
                values: new object[] { new DateTime(2020, 12, 4, 16, 24, 39, 234, DateTimeKind.Local).AddTicks(6473), "ASBY0003" });

            migrationBuilder.UpdateData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("c26e4341-8e94-48f8-9eb6-fd2c5061bae3"),
                columns: new[] { "TimeStamp", "WorkCenter" },
                values: new object[] { new DateTime(2020, 12, 4, 16, 24, 39, 234, DateTimeKind.Local).AddTicks(6771), "ASBY0005" });

            migrationBuilder.UpdateData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("f5ede641-fb76-40d5-924b-5d28ceea1ac9"),
                columns: new[] { "TimeStamp", "WorkCenter" },
                values: new object[] { new DateTime(2020, 12, 4, 16, 24, 39, 234, DateTimeKind.Local).AddTicks(6837), "ASBY0006" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WorkCenter",
                table: "KepServerTagNameGroups");

            migrationBuilder.UpdateData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("01b888a3-00ca-4736-96ae-1636dc7ec914"),
                column: "TimeStamp",
                value: new DateTime(2020, 12, 4, 13, 56, 58, 848, DateTimeKind.Local).AddTicks(2034));

            migrationBuilder.UpdateData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("13667af3-8a37-456a-8d65-5e98627af1ad"),
                column: "TimeStamp",
                value: new DateTime(2020, 12, 4, 13, 56, 58, 849, DateTimeKind.Local).AddTicks(5128));

            migrationBuilder.UpdateData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("1ace746f-f44f-47c4-bb9c-6c49fc550488"),
                column: "TimeStamp",
                value: new DateTime(2020, 12, 4, 13, 56, 58, 849, DateTimeKind.Local).AddTicks(5103));

            migrationBuilder.UpdateData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("3ea0d0fe-9c1b-4171-baa1-aa5b6e6422e2"),
                column: "TimeStamp",
                value: new DateTime(2020, 12, 4, 13, 56, 58, 849, DateTimeKind.Local).AddTicks(5152));

            migrationBuilder.UpdateData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("77e6d96c-f58d-46ea-a00d-5f962cfaf67b"),
                column: "TimeStamp",
                value: new DateTime(2020, 12, 4, 13, 56, 58, 849, DateTimeKind.Local).AddTicks(5012));

            migrationBuilder.UpdateData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("bd9eae20-60c7-44cd-ae2e-96c5f015f82e"),
                column: "TimeStamp",
                value: new DateTime(2020, 12, 4, 13, 56, 58, 849, DateTimeKind.Local).AddTicks(4883));

            migrationBuilder.UpdateData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("c26e4341-8e94-48f8-9eb6-fd2c5061bae3"),
                column: "TimeStamp",
                value: new DateTime(2020, 12, 4, 13, 56, 58, 849, DateTimeKind.Local).AddTicks(5039));

            migrationBuilder.UpdateData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("f5ede641-fb76-40d5-924b-5d28ceea1ac9"),
                column: "TimeStamp",
                value: new DateTime(2020, 12, 4, 13, 56, 58, 849, DateTimeKind.Local).AddTicks(5074));
        }
    }
}
