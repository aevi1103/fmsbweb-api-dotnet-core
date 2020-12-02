using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FmsbwebCoreApi.Migrations.Iconics
{
    public partial class addDefaultGuid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
