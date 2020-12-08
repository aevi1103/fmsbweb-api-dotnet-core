using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FmsbwebCoreApi.Migrations.FmsbOee
{
    public partial class addRowVersion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Timestamp",
                table: "Oee",
                rowVersion: true,
                nullable: false);

            migrationBuilder.UpdateData(
                table: "OeeLines",
                keyColumn: "OeeLineId",
                keyValue: new Guid("01b888a3-00ca-4736-96ae-1636dc7ec914"),
                column: "DateModified",
                value: new DateTime(2020, 12, 7, 10, 8, 10, 183, DateTimeKind.Local).AddTicks(6120));

            migrationBuilder.UpdateData(
                table: "OeeLines",
                keyColumn: "OeeLineId",
                keyValue: new Guid("13667af3-8a37-456a-8d65-5e98627af1ad"),
                column: "DateModified",
                value: new DateTime(2020, 12, 7, 10, 8, 10, 185, DateTimeKind.Local).AddTicks(7397));

            migrationBuilder.UpdateData(
                table: "OeeLines",
                keyColumn: "OeeLineId",
                keyValue: new Guid("1ace746f-f44f-47c4-bb9c-6c49fc550488"),
                column: "DateModified",
                value: new DateTime(2020, 12, 7, 10, 8, 10, 185, DateTimeKind.Local).AddTicks(7339));

            migrationBuilder.UpdateData(
                table: "OeeLines",
                keyColumn: "OeeLineId",
                keyValue: new Guid("3ea0d0fe-9c1b-4171-baa1-aa5b6e6422e2"),
                column: "DateModified",
                value: new DateTime(2020, 12, 7, 10, 8, 10, 185, DateTimeKind.Local).AddTicks(7455));

            migrationBuilder.UpdateData(
                table: "OeeLines",
                keyColumn: "OeeLineId",
                keyValue: new Guid("77e6d96c-f58d-46ea-a00d-5f962cfaf67b"),
                column: "DateModified",
                value: new DateTime(2020, 12, 7, 10, 8, 10, 185, DateTimeKind.Local).AddTicks(7136));

            migrationBuilder.UpdateData(
                table: "OeeLines",
                keyColumn: "OeeLineId",
                keyValue: new Guid("bd9eae20-60c7-44cd-ae2e-96c5f015f82e"),
                column: "DateModified",
                value: new DateTime(2020, 12, 7, 10, 8, 10, 185, DateTimeKind.Local).AddTicks(6858));

            migrationBuilder.UpdateData(
                table: "OeeLines",
                keyColumn: "OeeLineId",
                keyValue: new Guid("c26e4341-8e94-48f8-9eb6-fd2c5061bae3"),
                column: "DateModified",
                value: new DateTime(2020, 12, 7, 10, 8, 10, 185, DateTimeKind.Local).AddTicks(7200));

            migrationBuilder.UpdateData(
                table: "OeeLines",
                keyColumn: "OeeLineId",
                keyValue: new Guid("f5ede641-fb76-40d5-924b-5d28ceea1ac9"),
                column: "DateModified",
                value: new DateTime(2020, 12, 7, 10, 8, 10, 185, DateTimeKind.Local).AddTicks(7267));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "Oee");

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
    }
}
