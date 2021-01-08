using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FmsbwebCoreApi.Migrations.FmsbOee
{
    public partial class addmachinegroupcollection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "LineId",
                table: "MachineGroups",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("01b888a3-00ca-4736-96ae-1636dc7ec914"),
                column: "DateModified",
                value: new DateTime(2021, 1, 6, 8, 14, 45, 433, DateTimeKind.Local).AddTicks(8758));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("13667af3-8a37-456a-8d65-5e98627af1ad"),
                column: "DateModified",
                value: new DateTime(2021, 1, 6, 8, 14, 45, 446, DateTimeKind.Local).AddTicks(7314));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("1ace746f-f44f-47c4-bb9c-6c49fc550488"),
                column: "DateModified",
                value: new DateTime(2021, 1, 6, 8, 14, 45, 446, DateTimeKind.Local).AddTicks(7286));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("3ea0d0fe-9c1b-4171-baa1-aa5b6e6422e2"),
                column: "DateModified",
                value: new DateTime(2021, 1, 6, 8, 14, 45, 446, DateTimeKind.Local).AddTicks(7342));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("77e6d96c-f58d-46ea-a00d-5f962cfaf67b"),
                column: "DateModified",
                value: new DateTime(2021, 1, 6, 8, 14, 45, 446, DateTimeKind.Local).AddTicks(7054));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("bd9eae20-60c7-44cd-ae2e-96c5f015f82e"),
                column: "DateModified",
                value: new DateTime(2021, 1, 6, 8, 14, 45, 446, DateTimeKind.Local).AddTicks(6593));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("c26e4341-8e94-48f8-9eb6-fd2c5061bae3"),
                column: "DateModified",
                value: new DateTime(2021, 1, 6, 8, 14, 45, 446, DateTimeKind.Local).AddTicks(7201));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("f5ede641-fb76-40d5-924b-5d28ceea1ac9"),
                column: "DateModified",
                value: new DateTime(2021, 1, 6, 8, 14, 45, 446, DateTimeKind.Local).AddTicks(7243));

            migrationBuilder.CreateIndex(
                name: "IX_MachineGroups_LineId",
                table: "MachineGroups",
                column: "LineId");

            migrationBuilder.AddForeignKey(
                name: "FK_MachineGroups_Lines_LineId",
                table: "MachineGroups",
                column: "LineId",
                principalTable: "Lines",
                principalColumn: "LineId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MachineGroups_Lines_LineId",
                table: "MachineGroups");

            migrationBuilder.DropIndex(
                name: "IX_MachineGroups_LineId",
                table: "MachineGroups");

            migrationBuilder.DropColumn(
                name: "LineId",
                table: "MachineGroups");

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("01b888a3-00ca-4736-96ae-1636dc7ec914"),
                column: "DateModified",
                value: new DateTime(2021, 1, 6, 6, 57, 39, 767, DateTimeKind.Local).AddTicks(736));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("13667af3-8a37-456a-8d65-5e98627af1ad"),
                column: "DateModified",
                value: new DateTime(2021, 1, 6, 6, 57, 39, 783, DateTimeKind.Local).AddTicks(2163));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("1ace746f-f44f-47c4-bb9c-6c49fc550488"),
                column: "DateModified",
                value: new DateTime(2021, 1, 6, 6, 57, 39, 783, DateTimeKind.Local).AddTicks(2050));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("3ea0d0fe-9c1b-4171-baa1-aa5b6e6422e2"),
                column: "DateModified",
                value: new DateTime(2021, 1, 6, 6, 57, 39, 783, DateTimeKind.Local).AddTicks(2233));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("77e6d96c-f58d-46ea-a00d-5f962cfaf67b"),
                column: "DateModified",
                value: new DateTime(2021, 1, 6, 6, 57, 39, 783, DateTimeKind.Local).AddTicks(1275));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("bd9eae20-60c7-44cd-ae2e-96c5f015f82e"),
                column: "DateModified",
                value: new DateTime(2021, 1, 6, 6, 57, 39, 783, DateTimeKind.Local).AddTicks(792));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("c26e4341-8e94-48f8-9eb6-fd2c5061bae3"),
                column: "DateModified",
                value: new DateTime(2021, 1, 6, 6, 57, 39, 783, DateTimeKind.Local).AddTicks(1366));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("f5ede641-fb76-40d5-924b-5d28ceea1ac9"),
                column: "DateModified",
                value: new DateTime(2021, 1, 6, 6, 57, 39, 783, DateTimeKind.Local).AddTicks(1440));
        }
    }
}
