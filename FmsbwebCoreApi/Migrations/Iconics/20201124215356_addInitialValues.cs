using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FmsbwebCoreApi.Migrations.Iconics
{
    public partial class addInitialValues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("3a724a2e-bd4f-47f1-a0f5-830c40c770d7"));

            migrationBuilder.DeleteData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("6dfe84ae-7850-44cf-bd90-26685b34bee8"));

            migrationBuilder.DeleteData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("76eef47b-7541-4b52-884c-af130e121c77"));

            migrationBuilder.DeleteData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("7bdff7de-8049-4059-8b9e-c0138af93119"));

            migrationBuilder.DeleteData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("95800b52-3430-4200-a546-000dbd13bb92"));

            migrationBuilder.DeleteData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("baddedd6-2d1c-46e8-bc25-9101ae0c6e87"));

            migrationBuilder.DeleteData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("bfe14929-c580-4c76-b3b0-0f1250208cbb"));

            migrationBuilder.DeleteData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("ffb2e046-ff1a-42e0-8b10-a24e4b17dd11"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("3a724a2e-bd4f-47f1-a0f5-830c40c770d7"), "A2", new DateTime(2020, 11, 24, 16, 42, 2, 978, DateTimeKind.Local).AddTicks(6386) },
                    { new Guid("7bdff7de-8049-4059-8b9e-c0138af93119"), "A3", new DateTime(2020, 11, 24, 16, 42, 2, 980, DateTimeKind.Local).AddTicks(1793) },
                    { new Guid("baddedd6-2d1c-46e8-bc25-9101ae0c6e87"), "A4", new DateTime(2020, 11, 24, 16, 42, 2, 980, DateTimeKind.Local).AddTicks(1978) },
                    { new Guid("bfe14929-c580-4c76-b3b0-0f1250208cbb"), "A5", new DateTime(2020, 11, 24, 16, 42, 2, 980, DateTimeKind.Local).AddTicks(2009) },
                    { new Guid("6dfe84ae-7850-44cf-bd90-26685b34bee8"), "A6", new DateTime(2020, 11, 24, 16, 42, 2, 980, DateTimeKind.Local).AddTicks(2047) },
                    { new Guid("76eef47b-7541-4b52-884c-af130e121c77"), "A7", new DateTime(2020, 11, 24, 16, 42, 2, 980, DateTimeKind.Local).AddTicks(2081) },
                    { new Guid("95800b52-3430-4200-a546-000dbd13bb92"), "A8", new DateTime(2020, 11, 24, 16, 42, 2, 980, DateTimeKind.Local).AddTicks(2107) },
                    { new Guid("ffb2e046-ff1a-42e0-8b10-a24e4b17dd11"), "A9", new DateTime(2020, 11, 24, 16, 42, 2, 980, DateTimeKind.Local).AddTicks(2134) }
                });
        }
    }
}
