using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FmsbwebCoreApi.Migrations.FmsbOee
{
    public partial class AddNewColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "CycleTime",
                table: "OeeLines",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "ScrapInspectionLocation",
                table: "OeeLines",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "OeeLines",
                keyColumn: "OeeLineId",
                keyValue: new Guid("01b888a3-00ca-4736-96ae-1636dc7ec914"),
                columns: new[] { "CycleTime", "DateModified", "ScrapInspectionLocation" },
                values: new object[] { 5m, new DateTime(2020, 12, 9, 9, 20, 6, 163, DateTimeKind.Local).AddTicks(4117), 2 });

            migrationBuilder.UpdateData(
                table: "OeeLines",
                keyColumn: "OeeLineId",
                keyValue: new Guid("13667af3-8a37-456a-8d65-5e98627af1ad"),
                columns: new[] { "CycleTime", "DateModified", "ScrapInspectionLocation" },
                values: new object[] { 12m, new DateTime(2020, 12, 9, 9, 20, 6, 170, DateTimeKind.Local).AddTicks(8070), 1 });

            migrationBuilder.UpdateData(
                table: "OeeLines",
                keyColumn: "OeeLineId",
                keyValue: new Guid("1ace746f-f44f-47c4-bb9c-6c49fc550488"),
                columns: new[] { "CycleTime", "DateModified", "ScrapInspectionLocation" },
                values: new object[] { 9m, new DateTime(2020, 12, 9, 9, 20, 6, 170, DateTimeKind.Local).AddTicks(8043), 1 });

            migrationBuilder.UpdateData(
                table: "OeeLines",
                keyColumn: "OeeLineId",
                keyValue: new Guid("3ea0d0fe-9c1b-4171-baa1-aa5b6e6422e2"),
                columns: new[] { "CycleTime", "DateModified", "ScrapInspectionLocation" },
                values: new object[] { 8.5m, new DateTime(2020, 12, 9, 9, 20, 6, 170, DateTimeKind.Local).AddTicks(8097), 1 });

            migrationBuilder.UpdateData(
                table: "OeeLines",
                keyColumn: "OeeLineId",
                keyValue: new Guid("77e6d96c-f58d-46ea-a00d-5f962cfaf67b"),
                columns: new[] { "CycleTime", "DateModified", "ScrapInspectionLocation" },
                values: new object[] { 8.4m, new DateTime(2020, 12, 9, 9, 20, 6, 170, DateTimeKind.Local).AddTicks(7949), 1 });

            migrationBuilder.UpdateData(
                table: "OeeLines",
                keyColumn: "OeeLineId",
                keyValue: new Guid("bd9eae20-60c7-44cd-ae2e-96c5f015f82e"),
                columns: new[] { "CycleTime", "DateModified", "ScrapInspectionLocation" },
                values: new object[] { 11m, new DateTime(2020, 12, 9, 9, 20, 6, 170, DateTimeKind.Local).AddTicks(7763), 1 });

            migrationBuilder.UpdateData(
                table: "OeeLines",
                keyColumn: "OeeLineId",
                keyValue: new Guid("c26e4341-8e94-48f8-9eb6-fd2c5061bae3"),
                columns: new[] { "CycleTime", "DateModified", "ScrapInspectionLocation" },
                values: new object[] { 8m, new DateTime(2020, 12, 9, 9, 20, 6, 170, DateTimeKind.Local).AddTicks(7984), 2 });

            migrationBuilder.UpdateData(
                table: "OeeLines",
                keyColumn: "OeeLineId",
                keyValue: new Guid("f5ede641-fb76-40d5-924b-5d28ceea1ac9"),
                columns: new[] { "CycleTime", "DateModified", "ScrapInspectionLocation" },
                values: new object[] { 8m, new DateTime(2020, 12, 9, 9, 20, 6, 170, DateTimeKind.Local).AddTicks(8012), 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CycleTime",
                table: "OeeLines");

            migrationBuilder.DropColumn(
                name: "ScrapInspectionLocation",
                table: "OeeLines");

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
    }
}
