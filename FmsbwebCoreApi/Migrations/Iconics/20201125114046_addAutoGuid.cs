using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FmsbwebCoreApi.Migrations.Iconics
{
    public partial class addAutoGuid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "KepServerTagNameMonitors",
                keyColumn: "Id",
                keyValue: new Guid("16ba0e58-074c-4dac-82cc-3e6f9888b435"));

            migrationBuilder.DeleteData(
                table: "KepServerTagNameMonitors",
                keyColumn: "Id",
                keyValue: new Guid("1df5e880-70e5-45a4-979f-0aa4bb11e0c8"));

            migrationBuilder.DeleteData(
                table: "KepServerTagNameMonitors",
                keyColumn: "Id",
                keyValue: new Guid("2af9989a-bdab-40c6-9f8e-912b60e6bced"));

            migrationBuilder.DeleteData(
                table: "KepServerTagNameMonitors",
                keyColumn: "Id",
                keyValue: new Guid("4f4403aa-154d-4db8-bbfe-0f76d2b895a6"));

            migrationBuilder.DeleteData(
                table: "KepServerTagNameMonitors",
                keyColumn: "Id",
                keyValue: new Guid("81360f87-f965-4525-a7a1-d225929b0288"));

            migrationBuilder.DeleteData(
                table: "KepServerTagNameMonitors",
                keyColumn: "Id",
                keyValue: new Guid("e3f2c2fa-c054-42eb-87a9-385800e8b886"));

            migrationBuilder.DeleteData(
                table: "KepServerTagNameMonitors",
                keyColumn: "Id",
                keyValue: new Guid("f1d141ff-fa86-4d5c-91cb-d7d50dca3762"));

            migrationBuilder.DeleteData(
                table: "KepServerTagNameMonitors",
                keyColumn: "Id",
                keyValue: new Guid("f965ea10-22d3-4ff8-bcc6-1f854a16bc38"));

            migrationBuilder.DeleteData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("13e0013c-5278-4c6b-bdcc-68716e9c47aa"));

            migrationBuilder.DeleteData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("17fb0d78-3b3d-4b1e-890b-1058d4d59d19"));

            migrationBuilder.DeleteData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("2d6af88b-e4b5-40eb-a9b9-25bb044c88cb"));

            migrationBuilder.DeleteData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("32298129-21e4-4469-9ca9-9f9304854ce4"));

            migrationBuilder.DeleteData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("60cde83c-2fee-4594-afd0-2c4f9a2fbbe0"));

            migrationBuilder.DeleteData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("7122a990-09f7-4ac5-b169-66948182e2da"));

            migrationBuilder.DeleteData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("96cd0c8d-52a7-4e01-b38d-021b7910f2ad"));

            migrationBuilder.DeleteData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("d1501b14-2a69-4c03-870d-895fb37236b8"));

            migrationBuilder.InsertData(
                table: "KepServerTagNameGroups",
                columns: new[] { "KepServerTagNameGroupId", "GroupName", "TimeStamp" },
                values: new object[,]
                {
                    { new Guid("9914adfb-beb4-45b8-841e-92a62644cdb9"), "A2", new DateTime(2020, 11, 25, 6, 40, 45, 591, DateTimeKind.Local).AddTicks(7330) },
                    { new Guid("b77a6852-48bb-4737-b311-72f0b89eb1a9"), "A3", new DateTime(2020, 11, 25, 6, 40, 45, 594, DateTimeKind.Local).AddTicks(842) },
                    { new Guid("ab52ed25-e05a-43d2-a5b5-886c9f81016b"), "A4", new DateTime(2020, 11, 25, 6, 40, 45, 594, DateTimeKind.Local).AddTicks(1192) },
                    { new Guid("70f09fe2-69b5-4163-9ba9-ee7dd44392a8"), "A5", new DateTime(2020, 11, 25, 6, 40, 45, 594, DateTimeKind.Local).AddTicks(1288) },
                    { new Guid("a5faa0ae-79a7-4982-b5e6-9f02b6336c78"), "A6", new DateTime(2020, 11, 25, 6, 40, 45, 594, DateTimeKind.Local).AddTicks(1545) },
                    { new Guid("a2a448c1-4395-45c8-b52d-521cef7e0857"), "A7", new DateTime(2020, 11, 25, 6, 40, 45, 594, DateTimeKind.Local).AddTicks(1651) },
                    { new Guid("5acb6ebc-fb7f-435e-b48a-e02e798e6a8b"), "A8", new DateTime(2020, 11, 25, 6, 40, 45, 594, DateTimeKind.Local).AddTicks(1745) },
                    { new Guid("beba32fb-23ee-40e5-8d0d-046c990eb374"), "A9", new DateTime(2020, 11, 25, 6, 40, 45, 594, DateTimeKind.Local).AddTicks(1834) }
                });

            migrationBuilder.InsertData(
                table: "KepServerTagNameMonitors",
                columns: new[] { "Id", "KepServerTagNameGroupId", "TagName", "TimeStamp" },
                values: new object[,]
                {
                    { new Guid("db786411-2031-45f3-8859-ea7e68c7cd7f"), new Guid("9914adfb-beb4-45b8-841e-92a62644cdb9"), "A2_PACKOUT_APC", new DateTime(2020, 11, 25, 6, 40, 45, 593, DateTimeKind.Local).AddTicks(9712) },
                    { new Guid("9b65c9bf-a1c2-418b-9717-84312a93302e"), new Guid("b77a6852-48bb-4737-b311-72f0b89eb1a9"), "A3_APC", new DateTime(2020, 11, 25, 6, 40, 45, 594, DateTimeKind.Local).AddTicks(1110) },
                    { new Guid("8be0315b-85d1-420e-ab08-385069df78d8"), new Guid("ab52ed25-e05a-43d2-a5b5-886c9f81016b"), "A4_M3_APC", new DateTime(2020, 11, 25, 6, 40, 45, 594, DateTimeKind.Local).AddTicks(1241) },
                    { new Guid("fa27bca7-0fdb-4f3c-959d-06a458cdd708"), new Guid("70f09fe2-69b5-4163-9ba9-ee7dd44392a8"), "A5_APC", new DateTime(2020, 11, 25, 6, 40, 45, 594, DateTimeKind.Local).AddTicks(1334) },
                    { new Guid("7ae528bd-ab15-4497-85b5-2cf2165fdd9f"), new Guid("a5faa0ae-79a7-4982-b5e6-9f02b6336c78"), "A6_M2_APC", new DateTime(2020, 11, 25, 6, 40, 45, 594, DateTimeKind.Local).AddTicks(1604) },
                    { new Guid("b5ec7f4d-2978-4e3b-b46f-e69063385a0b"), new Guid("a2a448c1-4395-45c8-b52d-521cef7e0857"), "A7_M3_APC", new DateTime(2020, 11, 25, 6, 40, 45, 594, DateTimeKind.Local).AddTicks(1700) },
                    { new Guid("22bebde8-74dc-46eb-a44d-606ba74127fd"), new Guid("5acb6ebc-fb7f-435e-b48a-e02e798e6a8b"), "A8_APC", new DateTime(2020, 11, 25, 6, 40, 45, 594, DateTimeKind.Local).AddTicks(1794) },
                    { new Guid("7570d19e-b2d3-4fe0-a264-2d1d0b425ac8"), new Guid("beba32fb-23ee-40e5-8d0d-046c990eb374"), "A9_M3_APC", new DateTime(2020, 11, 25, 6, 40, 45, 594, DateTimeKind.Local).AddTicks(1885) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "KepServerTagNameMonitors",
                keyColumn: "Id",
                keyValue: new Guid("22bebde8-74dc-46eb-a44d-606ba74127fd"));

            migrationBuilder.DeleteData(
                table: "KepServerTagNameMonitors",
                keyColumn: "Id",
                keyValue: new Guid("7570d19e-b2d3-4fe0-a264-2d1d0b425ac8"));

            migrationBuilder.DeleteData(
                table: "KepServerTagNameMonitors",
                keyColumn: "Id",
                keyValue: new Guid("7ae528bd-ab15-4497-85b5-2cf2165fdd9f"));

            migrationBuilder.DeleteData(
                table: "KepServerTagNameMonitors",
                keyColumn: "Id",
                keyValue: new Guid("8be0315b-85d1-420e-ab08-385069df78d8"));

            migrationBuilder.DeleteData(
                table: "KepServerTagNameMonitors",
                keyColumn: "Id",
                keyValue: new Guid("9b65c9bf-a1c2-418b-9717-84312a93302e"));

            migrationBuilder.DeleteData(
                table: "KepServerTagNameMonitors",
                keyColumn: "Id",
                keyValue: new Guid("b5ec7f4d-2978-4e3b-b46f-e69063385a0b"));

            migrationBuilder.DeleteData(
                table: "KepServerTagNameMonitors",
                keyColumn: "Id",
                keyValue: new Guid("db786411-2031-45f3-8859-ea7e68c7cd7f"));

            migrationBuilder.DeleteData(
                table: "KepServerTagNameMonitors",
                keyColumn: "Id",
                keyValue: new Guid("fa27bca7-0fdb-4f3c-959d-06a458cdd708"));

            migrationBuilder.DeleteData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("5acb6ebc-fb7f-435e-b48a-e02e798e6a8b"));

            migrationBuilder.DeleteData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("70f09fe2-69b5-4163-9ba9-ee7dd44392a8"));

            migrationBuilder.DeleteData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("9914adfb-beb4-45b8-841e-92a62644cdb9"));

            migrationBuilder.DeleteData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("a2a448c1-4395-45c8-b52d-521cef7e0857"));

            migrationBuilder.DeleteData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("a5faa0ae-79a7-4982-b5e6-9f02b6336c78"));

            migrationBuilder.DeleteData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("ab52ed25-e05a-43d2-a5b5-886c9f81016b"));

            migrationBuilder.DeleteData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("b77a6852-48bb-4737-b311-72f0b89eb1a9"));

            migrationBuilder.DeleteData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("beba32fb-23ee-40e5-8d0d-046c990eb374"));

            migrationBuilder.InsertData(
                table: "KepServerTagNameGroups",
                columns: new[] { "KepServerTagNameGroupId", "GroupName", "TimeStamp" },
                values: new object[,]
                {
                    { new Guid("17fb0d78-3b3d-4b1e-890b-1058d4d59d19"), "A2", new DateTime(2020, 11, 24, 16, 53, 56, 45, DateTimeKind.Local).AddTicks(936) },
                    { new Guid("60cde83c-2fee-4594-afd0-2c4f9a2fbbe0"), "A3", new DateTime(2020, 11, 24, 16, 53, 56, 46, DateTimeKind.Local).AddTicks(9497) },
                    { new Guid("d1501b14-2a69-4c03-870d-895fb37236b8"), "A4", new DateTime(2020, 11, 24, 16, 53, 56, 46, DateTimeKind.Local).AddTicks(9955) },
                    { new Guid("2d6af88b-e4b5-40eb-a9b9-25bb044c88cb"), "A5", new DateTime(2020, 11, 24, 16, 53, 56, 47, DateTimeKind.Local).AddTicks(29) },
                    { new Guid("96cd0c8d-52a7-4e01-b38d-021b7910f2ad"), "A6", new DateTime(2020, 11, 24, 16, 53, 56, 47, DateTimeKind.Local).AddTicks(96) },
                    { new Guid("7122a990-09f7-4ac5-b169-66948182e2da"), "A7", new DateTime(2020, 11, 24, 16, 53, 56, 47, DateTimeKind.Local).AddTicks(166) },
                    { new Guid("13e0013c-5278-4c6b-bdcc-68716e9c47aa"), "A8", new DateTime(2020, 11, 24, 16, 53, 56, 47, DateTimeKind.Local).AddTicks(232) },
                    { new Guid("32298129-21e4-4469-9ca9-9f9304854ce4"), "A9", new DateTime(2020, 11, 24, 16, 53, 56, 47, DateTimeKind.Local).AddTicks(295) }
                });

            migrationBuilder.InsertData(
                table: "KepServerTagNameMonitors",
                columns: new[] { "Id", "KepServerTagNameGroupId", "TagName", "TimeStamp" },
                values: new object[,]
                {
                    { new Guid("2af9989a-bdab-40c6-9f8e-912b60e6bced"), new Guid("17fb0d78-3b3d-4b1e-890b-1058d4d59d19"), "A2_PACKOUT_APC", new DateTime(2020, 11, 24, 16, 53, 56, 46, DateTimeKind.Local).AddTicks(8576) },
                    { new Guid("4f4403aa-154d-4db8-bbfe-0f76d2b895a6"), new Guid("60cde83c-2fee-4594-afd0-2c4f9a2fbbe0"), "A3_APC", new DateTime(2020, 11, 24, 16, 53, 56, 46, DateTimeKind.Local).AddTicks(9879) },
                    { new Guid("f1d141ff-fa86-4d5c-91cb-d7d50dca3762"), new Guid("d1501b14-2a69-4c03-870d-895fb37236b8"), "A4_M3_APC", new DateTime(2020, 11, 24, 16, 53, 56, 46, DateTimeKind.Local).AddTicks(9994) },
                    { new Guid("1df5e880-70e5-45a4-979f-0aa4bb11e0c8"), new Guid("2d6af88b-e4b5-40eb-a9b9-25bb044c88cb"), "A5_APC", new DateTime(2020, 11, 24, 16, 53, 56, 47, DateTimeKind.Local).AddTicks(61) },
                    { new Guid("16ba0e58-074c-4dac-82cc-3e6f9888b435"), new Guid("96cd0c8d-52a7-4e01-b38d-021b7910f2ad"), "A6_M2_APC", new DateTime(2020, 11, 24, 16, 53, 56, 47, DateTimeKind.Local).AddTicks(135) },
                    { new Guid("81360f87-f965-4525-a7a1-d225929b0288"), new Guid("7122a990-09f7-4ac5-b169-66948182e2da"), "A7_M3_APC", new DateTime(2020, 11, 24, 16, 53, 56, 47, DateTimeKind.Local).AddTicks(200) },
                    { new Guid("f965ea10-22d3-4ff8-bcc6-1f854a16bc38"), new Guid("13e0013c-5278-4c6b-bdcc-68716e9c47aa"), "A8_APC", new DateTime(2020, 11, 24, 16, 53, 56, 47, DateTimeKind.Local).AddTicks(266) },
                    { new Guid("e3f2c2fa-c054-42eb-87a9-385800e8b886"), new Guid("32298129-21e4-4469-9ca9-9f9304854ce4"), "A9_M3_APC", new DateTime(2020, 11, 24, 16, 53, 56, 47, DateTimeKind.Local).AddTicks(329) }
                });
        }
    }
}
