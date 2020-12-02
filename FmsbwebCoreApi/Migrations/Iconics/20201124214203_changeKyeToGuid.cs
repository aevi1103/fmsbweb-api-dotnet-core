using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FmsbwebCoreApi.Migrations.Iconics
{
    public partial class changeKyeToGuid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_KepServerTagNameMonitors",
                table: "KepServerTagNameMonitors");

            migrationBuilder.DeleteData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("0445d260-273d-44fe-af79-46a8a38b7b27"));

            migrationBuilder.DeleteData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("3554f89b-06b6-4c2d-a774-a5ea62197997"));

            migrationBuilder.DeleteData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("4e7f855a-1999-4848-b811-06ac81c2c431"));

            migrationBuilder.DeleteData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("6425df41-847a-4fee-b3d3-0d3935370dcc"));

            migrationBuilder.DeleteData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("72723b26-5652-4d82-9bc3-eac81a74b022"));

            migrationBuilder.DeleteData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("87dde5c2-6177-4831-bd4d-8ad613767b43"));

            migrationBuilder.DeleteData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("c86e18f2-5ce9-401f-aa2d-2a3a35e96efa"));

            migrationBuilder.DeleteData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("e9f14765-bb45-4dd1-adbc-be7cb3d49c8c"));

            migrationBuilder.DropColumn(
                name: "KepServerTagNameMonitorId",
                table: "KepServerTagNameMonitors");

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "KepServerTagNameMonitors",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_KepServerTagNameMonitors",
                table: "KepServerTagNameMonitors",
                column: "Id");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_KepServerTagNameMonitors",
                table: "KepServerTagNameMonitors");

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

            migrationBuilder.DropColumn(
                name: "Id",
                table: "KepServerTagNameMonitors");

            migrationBuilder.AddColumn<int>(
                name: "KepServerTagNameMonitorId",
                table: "KepServerTagNameMonitors",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_KepServerTagNameMonitors",
                table: "KepServerTagNameMonitors",
                column: "KepServerTagNameMonitorId");

            migrationBuilder.InsertData(
                table: "KepServerTagNameGroups",
                columns: new[] { "KepServerTagNameGroupId", "GroupName", "TimeStamp" },
                values: new object[,]
                {
                    { new Guid("3554f89b-06b6-4c2d-a774-a5ea62197997"), "A2", new DateTime(2020, 11, 24, 16, 35, 37, 77, DateTimeKind.Local).AddTicks(2817) },
                    { new Guid("4e7f855a-1999-4848-b811-06ac81c2c431"), "A3", new DateTime(2020, 11, 24, 16, 35, 37, 78, DateTimeKind.Local).AddTicks(5269) },
                    { new Guid("0445d260-273d-44fe-af79-46a8a38b7b27"), "A4", new DateTime(2020, 11, 24, 16, 35, 37, 78, DateTimeKind.Local).AddTicks(5392) },
                    { new Guid("87dde5c2-6177-4831-bd4d-8ad613767b43"), "A5", new DateTime(2020, 11, 24, 16, 35, 37, 78, DateTimeKind.Local).AddTicks(5418) },
                    { new Guid("6425df41-847a-4fee-b3d3-0d3935370dcc"), "A6", new DateTime(2020, 11, 24, 16, 35, 37, 78, DateTimeKind.Local).AddTicks(5451) },
                    { new Guid("c86e18f2-5ce9-401f-aa2d-2a3a35e96efa"), "A7", new DateTime(2020, 11, 24, 16, 35, 37, 78, DateTimeKind.Local).AddTicks(5481) },
                    { new Guid("72723b26-5652-4d82-9bc3-eac81a74b022"), "A8", new DateTime(2020, 11, 24, 16, 35, 37, 78, DateTimeKind.Local).AddTicks(5504) },
                    { new Guid("e9f14765-bb45-4dd1-adbc-be7cb3d49c8c"), "A9", new DateTime(2020, 11, 24, 16, 35, 37, 78, DateTimeKind.Local).AddTicks(5526) }
                });
        }
    }
}
