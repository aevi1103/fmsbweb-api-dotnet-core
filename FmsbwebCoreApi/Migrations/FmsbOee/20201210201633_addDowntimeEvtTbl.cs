using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FmsbwebCoreApi.Migrations.FmsbOee
{
    public partial class addDowntimeEvtTbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DowntimeEvents",
                columns: table => new
                {
                    DowntimeEventId = table.Column<Guid>(nullable: false),
                    DowntimeEventType = table.Column<int>(nullable: false),
                    MachineId = table.Column<Guid>(nullable: false),
                    SecondaryReasonId = table.Column<Guid>(nullable: false),
                    Downtime = table.Column<int>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DowntimeEvents", x => x.DowntimeEventId);
                    table.ForeignKey(
                        name: "FK_DowntimeEvents_Machines_MachineId",
                        column: x => x.MachineId,
                        principalTable: "Machines",
                        principalColumn: "MachineId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DowntimeEvents_SecondaryReasons_SecondaryReasonId",
                        column: x => x.SecondaryReasonId,
                        principalTable: "SecondaryReasons",
                        principalColumn: "SecondaryReasonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("01b888a3-00ca-4736-96ae-1636dc7ec914"),
                column: "DateModified",
                value: new DateTime(2020, 12, 10, 15, 16, 33, 201, DateTimeKind.Local).AddTicks(3693));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("13667af3-8a37-456a-8d65-5e98627af1ad"),
                column: "DateModified",
                value: new DateTime(2020, 12, 10, 15, 16, 33, 208, DateTimeKind.Local).AddTicks(7597));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("1ace746f-f44f-47c4-bb9c-6c49fc550488"),
                column: "DateModified",
                value: new DateTime(2020, 12, 10, 15, 16, 33, 208, DateTimeKind.Local).AddTicks(7571));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("3ea0d0fe-9c1b-4171-baa1-aa5b6e6422e2"),
                column: "DateModified",
                value: new DateTime(2020, 12, 10, 15, 16, 33, 208, DateTimeKind.Local).AddTicks(7635));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("77e6d96c-f58d-46ea-a00d-5f962cfaf67b"),
                column: "DateModified",
                value: new DateTime(2020, 12, 10, 15, 16, 33, 208, DateTimeKind.Local).AddTicks(7476));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("bd9eae20-60c7-44cd-ae2e-96c5f015f82e"),
                column: "DateModified",
                value: new DateTime(2020, 12, 10, 15, 16, 33, 208, DateTimeKind.Local).AddTicks(7136));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("c26e4341-8e94-48f8-9eb6-fd2c5061bae3"),
                column: "DateModified",
                value: new DateTime(2020, 12, 10, 15, 16, 33, 208, DateTimeKind.Local).AddTicks(7510));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("f5ede641-fb76-40d5-924b-5d28ceea1ac9"),
                column: "DateModified",
                value: new DateTime(2020, 12, 10, 15, 16, 33, 208, DateTimeKind.Local).AddTicks(7537));

            migrationBuilder.CreateIndex(
                name: "IX_DowntimeEvents_MachineId",
                table: "DowntimeEvents",
                column: "MachineId");

            migrationBuilder.CreateIndex(
                name: "IX_DowntimeEvents_SecondaryReasonId",
                table: "DowntimeEvents",
                column: "SecondaryReasonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DowntimeEvents");

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("01b888a3-00ca-4736-96ae-1636dc7ec914"),
                column: "DateModified",
                value: new DateTime(2020, 12, 10, 15, 14, 20, 757, DateTimeKind.Local).AddTicks(2045));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("13667af3-8a37-456a-8d65-5e98627af1ad"),
                column: "DateModified",
                value: new DateTime(2020, 12, 10, 15, 14, 20, 764, DateTimeKind.Local).AddTicks(2284));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("1ace746f-f44f-47c4-bb9c-6c49fc550488"),
                column: "DateModified",
                value: new DateTime(2020, 12, 10, 15, 14, 20, 764, DateTimeKind.Local).AddTicks(2259));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("3ea0d0fe-9c1b-4171-baa1-aa5b6e6422e2"),
                column: "DateModified",
                value: new DateTime(2020, 12, 10, 15, 14, 20, 764, DateTimeKind.Local).AddTicks(2308));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("77e6d96c-f58d-46ea-a00d-5f962cfaf67b"),
                column: "DateModified",
                value: new DateTime(2020, 12, 10, 15, 14, 20, 764, DateTimeKind.Local).AddTicks(2112));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("bd9eae20-60c7-44cd-ae2e-96c5f015f82e"),
                column: "DateModified",
                value: new DateTime(2020, 12, 10, 15, 14, 20, 764, DateTimeKind.Local).AddTicks(1937));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("c26e4341-8e94-48f8-9eb6-fd2c5061bae3"),
                column: "DateModified",
                value: new DateTime(2020, 12, 10, 15, 14, 20, 764, DateTimeKind.Local).AddTicks(2200));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("f5ede641-fb76-40d5-924b-5d28ceea1ac9"),
                column: "DateModified",
                value: new DateTime(2020, 12, 10, 15, 14, 20, 764, DateTimeKind.Local).AddTicks(2230));
        }
    }
}
