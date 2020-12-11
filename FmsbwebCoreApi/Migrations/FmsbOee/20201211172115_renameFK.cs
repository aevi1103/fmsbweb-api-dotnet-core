using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FmsbwebCoreApi.Migrations.FmsbOee
{
    public partial class renameFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Oee_Lines_OeeLineId",
                table: "Oee");

            migrationBuilder.DropIndex(
                name: "IX_Oee_OeeLineId",
                table: "Oee");

            migrationBuilder.DropColumn(
                name: "OeeLineId",
                table: "Oee");

            migrationBuilder.AddColumn<Guid>(
                name: "LineId",
                table: "Oee",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("01b888a3-00ca-4736-96ae-1636dc7ec914"),
                column: "DateModified",
                value: new DateTime(2020, 12, 11, 12, 21, 15, 539, DateTimeKind.Local).AddTicks(535));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("13667af3-8a37-456a-8d65-5e98627af1ad"),
                column: "DateModified",
                value: new DateTime(2020, 12, 11, 12, 21, 15, 546, DateTimeKind.Local).AddTicks(1930));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("1ace746f-f44f-47c4-bb9c-6c49fc550488"),
                column: "DateModified",
                value: new DateTime(2020, 12, 11, 12, 21, 15, 546, DateTimeKind.Local).AddTicks(1809));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("3ea0d0fe-9c1b-4171-baa1-aa5b6e6422e2"),
                column: "DateModified",
                value: new DateTime(2020, 12, 11, 12, 21, 15, 546, DateTimeKind.Local).AddTicks(1962));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("77e6d96c-f58d-46ea-a00d-5f962cfaf67b"),
                column: "DateModified",
                value: new DateTime(2020, 12, 11, 12, 21, 15, 546, DateTimeKind.Local).AddTicks(1427));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("bd9eae20-60c7-44cd-ae2e-96c5f015f82e"),
                column: "DateModified",
                value: new DateTime(2020, 12, 11, 12, 21, 15, 546, DateTimeKind.Local).AddTicks(1074));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("c26e4341-8e94-48f8-9eb6-fd2c5061bae3"),
                column: "DateModified",
                value: new DateTime(2020, 12, 11, 12, 21, 15, 546, DateTimeKind.Local).AddTicks(1572));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("f5ede641-fb76-40d5-924b-5d28ceea1ac9"),
                column: "DateModified",
                value: new DateTime(2020, 12, 11, 12, 21, 15, 546, DateTimeKind.Local).AddTicks(1700));

            migrationBuilder.CreateIndex(
                name: "IX_Oee_LineId",
                table: "Oee",
                column: "LineId");

            migrationBuilder.AddForeignKey(
                name: "FK_Oee_Lines_LineId",
                table: "Oee",
                column: "LineId",
                principalTable: "Lines",
                principalColumn: "LineId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Oee_Lines_LineId",
                table: "Oee");

            migrationBuilder.DropIndex(
                name: "IX_Oee_LineId",
                table: "Oee");

            migrationBuilder.DropColumn(
                name: "LineId",
                table: "Oee");

            migrationBuilder.AddColumn<Guid>(
                name: "OeeLineId",
                table: "Oee",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("01b888a3-00ca-4736-96ae-1636dc7ec914"),
                column: "DateModified",
                value: new DateTime(2020, 12, 11, 8, 20, 59, 617, DateTimeKind.Local).AddTicks(1698));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("13667af3-8a37-456a-8d65-5e98627af1ad"),
                column: "DateModified",
                value: new DateTime(2020, 12, 11, 8, 20, 59, 626, DateTimeKind.Local).AddTicks(4726));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("1ace746f-f44f-47c4-bb9c-6c49fc550488"),
                column: "DateModified",
                value: new DateTime(2020, 12, 11, 8, 20, 59, 626, DateTimeKind.Local).AddTicks(4699));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("3ea0d0fe-9c1b-4171-baa1-aa5b6e6422e2"),
                column: "DateModified",
                value: new DateTime(2020, 12, 11, 8, 20, 59, 626, DateTimeKind.Local).AddTicks(4830));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("77e6d96c-f58d-46ea-a00d-5f962cfaf67b"),
                column: "DateModified",
                value: new DateTime(2020, 12, 11, 8, 20, 59, 626, DateTimeKind.Local).AddTicks(4607));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("bd9eae20-60c7-44cd-ae2e-96c5f015f82e"),
                column: "DateModified",
                value: new DateTime(2020, 12, 11, 8, 20, 59, 626, DateTimeKind.Local).AddTicks(4420));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("c26e4341-8e94-48f8-9eb6-fd2c5061bae3"),
                column: "DateModified",
                value: new DateTime(2020, 12, 11, 8, 20, 59, 626, DateTimeKind.Local).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("f5ede641-fb76-40d5-924b-5d28ceea1ac9"),
                column: "DateModified",
                value: new DateTime(2020, 12, 11, 8, 20, 59, 626, DateTimeKind.Local).AddTicks(4667));

            migrationBuilder.CreateIndex(
                name: "IX_Oee_OeeLineId",
                table: "Oee",
                column: "OeeLineId");

            migrationBuilder.AddForeignKey(
                name: "FK_Oee_Lines_OeeLineId",
                table: "Oee",
                column: "OeeLineId",
                principalTable: "Lines",
                principalColumn: "LineId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
