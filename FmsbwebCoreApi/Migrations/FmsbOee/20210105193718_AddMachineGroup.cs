using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FmsbwebCoreApi.Migrations.FmsbOee
{
    public partial class AddMachineGroup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "MachineGroupId",
                table: "Machines",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "MachineGroups",
                columns: table => new
                {
                    MachineGroupId = table.Column<Guid>(nullable: false),
                    GroupName = table.Column<string>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MachineGroups", x => x.MachineGroupId);
                });

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("01b888a3-00ca-4736-96ae-1636dc7ec914"),
                column: "DateModified",
                value: new DateTime(2021, 1, 5, 14, 37, 17, 881, DateTimeKind.Local).AddTicks(4994));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("13667af3-8a37-456a-8d65-5e98627af1ad"),
                column: "DateModified",
                value: new DateTime(2021, 1, 5, 14, 37, 17, 894, DateTimeKind.Local).AddTicks(1833));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("1ace746f-f44f-47c4-bb9c-6c49fc550488"),
                column: "DateModified",
                value: new DateTime(2021, 1, 5, 14, 37, 17, 894, DateTimeKind.Local).AddTicks(1786));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("3ea0d0fe-9c1b-4171-baa1-aa5b6e6422e2"),
                column: "DateModified",
                value: new DateTime(2021, 1, 5, 14, 37, 17, 894, DateTimeKind.Local).AddTicks(1881));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("77e6d96c-f58d-46ea-a00d-5f962cfaf67b"),
                column: "DateModified",
                value: new DateTime(2021, 1, 5, 14, 37, 17, 894, DateTimeKind.Local).AddTicks(1625));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("bd9eae20-60c7-44cd-ae2e-96c5f015f82e"),
                column: "DateModified",
                value: new DateTime(2021, 1, 5, 14, 37, 17, 894, DateTimeKind.Local).AddTicks(1359));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("c26e4341-8e94-48f8-9eb6-fd2c5061bae3"),
                column: "DateModified",
                value: new DateTime(2021, 1, 5, 14, 37, 17, 894, DateTimeKind.Local).AddTicks(1682));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("f5ede641-fb76-40d5-924b-5d28ceea1ac9"),
                column: "DateModified",
                value: new DateTime(2021, 1, 5, 14, 37, 17, 894, DateTimeKind.Local).AddTicks(1732));

            migrationBuilder.CreateIndex(
                name: "IX_Machines_MachineGroupId",
                table: "Machines",
                column: "MachineGroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Machines_MachineGroups_MachineGroupId",
                table: "Machines",
                column: "MachineGroupId",
                principalTable: "MachineGroups",
                principalColumn: "MachineGroupId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Machines_MachineGroups_MachineGroupId",
                table: "Machines");

            migrationBuilder.DropTable(
                name: "MachineGroups");

            migrationBuilder.DropIndex(
                name: "IX_Machines_MachineGroupId",
                table: "Machines");

            migrationBuilder.DropColumn(
                name: "MachineGroupId",
                table: "Machines");

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
        }
    }
}
