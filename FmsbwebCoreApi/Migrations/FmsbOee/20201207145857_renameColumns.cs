using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FmsbwebCoreApi.Migrations.FmsbOee
{
    public partial class renameColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TimeStamp",
                table: "OeeLines");

            migrationBuilder.DropColumn(
                name: "TimeStamp",
                table: "Oee");

            migrationBuilder.DropColumn(
                name: "TimeStamp",
                table: "ClockNumbers");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateModified",
                table: "OeeLines",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateModified",
                table: "Oee",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateModified",
                table: "ClockNumbers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "OeeLines",
                keyColumn: "OeeLineId",
                keyValue: new Guid("01b888a3-00ca-4736-96ae-1636dc7ec914"),
                column: "DateModified",
                value: new DateTime(2020, 12, 7, 9, 58, 56, 728, DateTimeKind.Local).AddTicks(510));

            migrationBuilder.UpdateData(
                table: "OeeLines",
                keyColumn: "OeeLineId",
                keyValue: new Guid("13667af3-8a37-456a-8d65-5e98627af1ad"),
                column: "DateModified",
                value: new DateTime(2020, 12, 7, 9, 58, 56, 729, DateTimeKind.Local).AddTicks(4421));

            migrationBuilder.UpdateData(
                table: "OeeLines",
                keyColumn: "OeeLineId",
                keyValue: new Guid("1ace746f-f44f-47c4-bb9c-6c49fc550488"),
                column: "DateModified",
                value: new DateTime(2020, 12, 7, 9, 58, 56, 729, DateTimeKind.Local).AddTicks(4388));

            migrationBuilder.UpdateData(
                table: "OeeLines",
                keyColumn: "OeeLineId",
                keyValue: new Guid("3ea0d0fe-9c1b-4171-baa1-aa5b6e6422e2"),
                column: "DateModified",
                value: new DateTime(2020, 12, 7, 9, 58, 56, 729, DateTimeKind.Local).AddTicks(4447));

            migrationBuilder.UpdateData(
                table: "OeeLines",
                keyColumn: "OeeLineId",
                keyValue: new Guid("77e6d96c-f58d-46ea-a00d-5f962cfaf67b"),
                column: "DateModified",
                value: new DateTime(2020, 12, 7, 9, 58, 56, 729, DateTimeKind.Local).AddTicks(4305));

            migrationBuilder.UpdateData(
                table: "OeeLines",
                keyColumn: "OeeLineId",
                keyValue: new Guid("bd9eae20-60c7-44cd-ae2e-96c5f015f82e"),
                column: "DateModified",
                value: new DateTime(2020, 12, 7, 9, 58, 56, 729, DateTimeKind.Local).AddTicks(4177));

            migrationBuilder.UpdateData(
                table: "OeeLines",
                keyColumn: "OeeLineId",
                keyValue: new Guid("c26e4341-8e94-48f8-9eb6-fd2c5061bae3"),
                column: "DateModified",
                value: new DateTime(2020, 12, 7, 9, 58, 56, 729, DateTimeKind.Local).AddTicks(4335));

            migrationBuilder.UpdateData(
                table: "OeeLines",
                keyColumn: "OeeLineId",
                keyValue: new Guid("f5ede641-fb76-40d5-924b-5d28ceea1ac9"),
                column: "DateModified",
                value: new DateTime(2020, 12, 7, 9, 58, 56, 729, DateTimeKind.Local).AddTicks(4359));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateModified",
                table: "OeeLines");

            migrationBuilder.DropColumn(
                name: "DateModified",
                table: "Oee");

            migrationBuilder.DropColumn(
                name: "DateModified",
                table: "ClockNumbers");

            migrationBuilder.AddColumn<DateTime>(
                name: "TimeStamp",
                table: "OeeLines",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "TimeStamp",
                table: "Oee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "TimeStamp",
                table: "ClockNumbers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "OeeLines",
                keyColumn: "OeeLineId",
                keyValue: new Guid("01b888a3-00ca-4736-96ae-1636dc7ec914"),
                column: "TimeStamp",
                value: new DateTime(2020, 12, 7, 9, 27, 13, 533, DateTimeKind.Local).AddTicks(7427));

            migrationBuilder.UpdateData(
                table: "OeeLines",
                keyColumn: "OeeLineId",
                keyValue: new Guid("13667af3-8a37-456a-8d65-5e98627af1ad"),
                column: "TimeStamp",
                value: new DateTime(2020, 12, 7, 9, 27, 13, 535, DateTimeKind.Local).AddTicks(3400));

            migrationBuilder.UpdateData(
                table: "OeeLines",
                keyColumn: "OeeLineId",
                keyValue: new Guid("1ace746f-f44f-47c4-bb9c-6c49fc550488"),
                column: "TimeStamp",
                value: new DateTime(2020, 12, 7, 9, 27, 13, 535, DateTimeKind.Local).AddTicks(3372));

            migrationBuilder.UpdateData(
                table: "OeeLines",
                keyColumn: "OeeLineId",
                keyValue: new Guid("3ea0d0fe-9c1b-4171-baa1-aa5b6e6422e2"),
                column: "TimeStamp",
                value: new DateTime(2020, 12, 7, 9, 27, 13, 535, DateTimeKind.Local).AddTicks(3428));

            migrationBuilder.UpdateData(
                table: "OeeLines",
                keyColumn: "OeeLineId",
                keyValue: new Guid("77e6d96c-f58d-46ea-a00d-5f962cfaf67b"),
                column: "TimeStamp",
                value: new DateTime(2020, 12, 7, 9, 27, 13, 535, DateTimeKind.Local).AddTicks(3272));

            migrationBuilder.UpdateData(
                table: "OeeLines",
                keyColumn: "OeeLineId",
                keyValue: new Guid("bd9eae20-60c7-44cd-ae2e-96c5f015f82e"),
                column: "TimeStamp",
                value: new DateTime(2020, 12, 7, 9, 27, 13, 535, DateTimeKind.Local).AddTicks(3118));

            migrationBuilder.UpdateData(
                table: "OeeLines",
                keyColumn: "OeeLineId",
                keyValue: new Guid("c26e4341-8e94-48f8-9eb6-fd2c5061bae3"),
                column: "TimeStamp",
                value: new DateTime(2020, 12, 7, 9, 27, 13, 535, DateTimeKind.Local).AddTicks(3305));

            migrationBuilder.UpdateData(
                table: "OeeLines",
                keyColumn: "OeeLineId",
                keyValue: new Guid("f5ede641-fb76-40d5-924b-5d28ceea1ac9"),
                column: "TimeStamp",
                value: new DateTime(2020, 12, 7, 9, 27, 13, 535, DateTimeKind.Local).AddTicks(3334));
        }
    }
}
