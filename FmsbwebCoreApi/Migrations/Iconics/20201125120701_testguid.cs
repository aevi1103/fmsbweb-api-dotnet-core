using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FmsbwebCoreApi.Migrations.Iconics
{
    public partial class testguid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("01b888a3-00ca-4736-96ae-1636dc7ec914"),
                column: "TimeStamp",
                value: new DateTime(2020, 11, 25, 7, 7, 0, 774, DateTimeKind.Local).AddTicks(3944));

            migrationBuilder.UpdateData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("13667af3-8a37-456a-8d65-5e98627af1ad"),
                column: "TimeStamp",
                value: new DateTime(2020, 11, 25, 7, 7, 0, 777, DateTimeKind.Local).AddTicks(4311));

            migrationBuilder.UpdateData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("1ace746f-f44f-47c4-bb9c-6c49fc550488"),
                column: "TimeStamp",
                value: new DateTime(2020, 11, 25, 7, 7, 0, 777, DateTimeKind.Local).AddTicks(4260));

            migrationBuilder.UpdateData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("3ea0d0fe-9c1b-4171-baa1-aa5b6e6422e2"),
                column: "TimeStamp",
                value: new DateTime(2020, 11, 25, 7, 7, 0, 777, DateTimeKind.Local).AddTicks(4361));

            migrationBuilder.UpdateData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("77e6d96c-f58d-46ea-a00d-5f962cfaf67b"),
                column: "TimeStamp",
                value: new DateTime(2020, 11, 25, 7, 7, 0, 777, DateTimeKind.Local).AddTicks(4087));

            migrationBuilder.UpdateData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("bd9eae20-60c7-44cd-ae2e-96c5f015f82e"),
                column: "TimeStamp",
                value: new DateTime(2020, 11, 25, 7, 7, 0, 777, DateTimeKind.Local).AddTicks(3871));

            migrationBuilder.UpdateData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("c26e4341-8e94-48f8-9eb6-fd2c5061bae3"),
                column: "TimeStamp",
                value: new DateTime(2020, 11, 25, 7, 7, 0, 777, DateTimeKind.Local).AddTicks(4142));

            migrationBuilder.UpdateData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("f5ede641-fb76-40d5-924b-5d28ceea1ac9"),
                column: "TimeStamp",
                value: new DateTime(2020, 11, 25, 7, 7, 0, 777, DateTimeKind.Local).AddTicks(4205));

            migrationBuilder.UpdateData(
                table: "KepServerTagNameMonitors",
                keyColumn: "Id",
                keyValue: new Guid("61a26041-c823-427b-be03-9a10f37e344a"),
                column: "TimeStamp",
                value: new DateTime(2020, 11, 25, 7, 7, 0, 777, DateTimeKind.Local).AddTicks(4390));

            migrationBuilder.UpdateData(
                table: "KepServerTagNameMonitors",
                keyColumn: "Id",
                keyValue: new Guid("978337b6-98c6-4f65-97da-bed63b415e4a"),
                column: "TimeStamp",
                value: new DateTime(2020, 11, 25, 7, 7, 0, 777, DateTimeKind.Local).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "KepServerTagNameMonitors",
                keyColumn: "Id",
                keyValue: new Guid("9f1aabaf-fc1e-437e-8af3-2e3e17aa4192"),
                column: "TimeStamp",
                value: new DateTime(2020, 11, 25, 7, 7, 0, 777, DateTimeKind.Local).AddTicks(4048));

            migrationBuilder.UpdateData(
                table: "KepServerTagNameMonitors",
                keyColumn: "Id",
                keyValue: new Guid("b37a8885-7889-407f-a44a-3cbcf3ee1a14"),
                column: "TimeStamp",
                value: new DateTime(2020, 11, 25, 7, 7, 0, 777, DateTimeKind.Local).AddTicks(2901));

            migrationBuilder.UpdateData(
                table: "KepServerTagNameMonitors",
                keyColumn: "Id",
                keyValue: new Guid("bb1862ce-201c-40b1-be25-c6f13f8ec6b1"),
                column: "TimeStamp",
                value: new DateTime(2020, 11, 25, 7, 7, 0, 777, DateTimeKind.Local).AddTicks(4234));

            migrationBuilder.UpdateData(
                table: "KepServerTagNameMonitors",
                keyColumn: "Id",
                keyValue: new Guid("d43a0be0-32cc-4e28-9f74-88d10c04b6a8"),
                column: "TimeStamp",
                value: new DateTime(2020, 11, 25, 7, 7, 0, 777, DateTimeKind.Local).AddTicks(4337));

            migrationBuilder.UpdateData(
                table: "KepServerTagNameMonitors",
                keyColumn: "Id",
                keyValue: new Guid("d81f4aca-b172-4e2d-b138-85fca35fdb48"),
                column: "TimeStamp",
                value: new DateTime(2020, 11, 25, 7, 7, 0, 777, DateTimeKind.Local).AddTicks(4116));

            migrationBuilder.UpdateData(
                table: "KepServerTagNameMonitors",
                keyColumn: "Id",
                keyValue: new Guid("e6273b83-641d-4669-8003-be5bdd928093"),
                column: "TimeStamp",
                value: new DateTime(2020, 11, 25, 7, 7, 0, 777, DateTimeKind.Local).AddTicks(4286));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("01b888a3-00ca-4736-96ae-1636dc7ec914"),
                column: "TimeStamp",
                value: new DateTime(2020, 11, 25, 7, 5, 16, 988, DateTimeKind.Local).AddTicks(9518));

            migrationBuilder.UpdateData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("13667af3-8a37-456a-8d65-5e98627af1ad"),
                column: "TimeStamp",
                value: new DateTime(2020, 11, 25, 7, 5, 16, 991, DateTimeKind.Local).AddTicks(9923));

            migrationBuilder.UpdateData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("1ace746f-f44f-47c4-bb9c-6c49fc550488"),
                column: "TimeStamp",
                value: new DateTime(2020, 11, 25, 7, 5, 16, 991, DateTimeKind.Local).AddTicks(9872));

            migrationBuilder.UpdateData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("3ea0d0fe-9c1b-4171-baa1-aa5b6e6422e2"),
                column: "TimeStamp",
                value: new DateTime(2020, 11, 25, 7, 5, 16, 991, DateTimeKind.Local).AddTicks(9973));

            migrationBuilder.UpdateData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("77e6d96c-f58d-46ea-a00d-5f962cfaf67b"),
                column: "TimeStamp",
                value: new DateTime(2020, 11, 25, 7, 5, 16, 991, DateTimeKind.Local).AddTicks(9704));

            migrationBuilder.UpdateData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("bd9eae20-60c7-44cd-ae2e-96c5f015f82e"),
                column: "TimeStamp",
                value: new DateTime(2020, 11, 25, 7, 5, 16, 991, DateTimeKind.Local).AddTicks(9475));

            migrationBuilder.UpdateData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("c26e4341-8e94-48f8-9eb6-fd2c5061bae3"),
                column: "TimeStamp",
                value: new DateTime(2020, 11, 25, 7, 5, 16, 991, DateTimeKind.Local).AddTicks(9759));

            migrationBuilder.UpdateData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("f5ede641-fb76-40d5-924b-5d28ceea1ac9"),
                column: "TimeStamp",
                value: new DateTime(2020, 11, 25, 7, 5, 16, 991, DateTimeKind.Local).AddTicks(9809));

            migrationBuilder.UpdateData(
                table: "KepServerTagNameMonitors",
                keyColumn: "Id",
                keyValue: new Guid("61a26041-c823-427b-be03-9a10f37e344a"),
                column: "TimeStamp",
                value: new DateTime(2020, 11, 25, 7, 5, 16, 991, DateTimeKind.Local).AddTicks(9999));

            migrationBuilder.UpdateData(
                table: "KepServerTagNameMonitors",
                keyColumn: "Id",
                keyValue: new Guid("978337b6-98c6-4f65-97da-bed63b415e4a"),
                column: "TimeStamp",
                value: new DateTime(2020, 11, 25, 7, 5, 16, 991, DateTimeKind.Local).AddTicks(9785));

            migrationBuilder.UpdateData(
                table: "KepServerTagNameMonitors",
                keyColumn: "Id",
                keyValue: new Guid("9f1aabaf-fc1e-437e-8af3-2e3e17aa4192"),
                column: "TimeStamp",
                value: new DateTime(2020, 11, 25, 7, 5, 16, 991, DateTimeKind.Local).AddTicks(9663));

            migrationBuilder.UpdateData(
                table: "KepServerTagNameMonitors",
                keyColumn: "Id",
                keyValue: new Guid("b37a8885-7889-407f-a44a-3cbcf3ee1a14"),
                column: "TimeStamp",
                value: new DateTime(2020, 11, 25, 7, 5, 16, 991, DateTimeKind.Local).AddTicks(8481));

            migrationBuilder.UpdateData(
                table: "KepServerTagNameMonitors",
                keyColumn: "Id",
                keyValue: new Guid("bb1862ce-201c-40b1-be25-c6f13f8ec6b1"),
                column: "TimeStamp",
                value: new DateTime(2020, 11, 25, 7, 5, 16, 991, DateTimeKind.Local).AddTicks(9847));

            migrationBuilder.UpdateData(
                table: "KepServerTagNameMonitors",
                keyColumn: "Id",
                keyValue: new Guid("d43a0be0-32cc-4e28-9f74-88d10c04b6a8"),
                column: "TimeStamp",
                value: new DateTime(2020, 11, 25, 7, 5, 16, 991, DateTimeKind.Local).AddTicks(9949));

            migrationBuilder.UpdateData(
                table: "KepServerTagNameMonitors",
                keyColumn: "Id",
                keyValue: new Guid("d81f4aca-b172-4e2d-b138-85fca35fdb48"),
                column: "TimeStamp",
                value: new DateTime(2020, 11, 25, 7, 5, 16, 991, DateTimeKind.Local).AddTicks(9735));

            migrationBuilder.UpdateData(
                table: "KepServerTagNameMonitors",
                keyColumn: "Id",
                keyValue: new Guid("e6273b83-641d-4669-8003-be5bdd928093"),
                column: "TimeStamp",
                value: new DateTime(2020, 11, 25, 7, 5, 16, 991, DateTimeKind.Local).AddTicks(9899));
        }
    }
}
