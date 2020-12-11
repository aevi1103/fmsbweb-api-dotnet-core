using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FmsbwebCoreApi.Migrations.FmsbOee
{
    public partial class addDowntimeTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Machines",
                columns: table => new
                {
                    MachineId = table.Column<Guid>(nullable: false),
                    MachineName = table.Column<string>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Machines", x => x.MachineId);
                });

            migrationBuilder.CreateTable(
                name: "PrimaryReasons",
                columns: table => new
                {
                    PrimaryReasonId = table.Column<Guid>(nullable: false),
                    Reason = table.Column<string>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrimaryReasons", x => x.PrimaryReasonId);
                });

            migrationBuilder.CreateTable(
                name: "SecondaryReasons",
                columns: table => new
                {
                    SecondaryReasonId = table.Column<Guid>(nullable: false),
                    PrimaryReasonId = table.Column<Guid>(nullable: false),
                    Reason = table.Column<string>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecondaryReasons", x => x.SecondaryReasonId);
                    table.ForeignKey(
                        name: "FK_SecondaryReasons_PrimaryReasons_PrimaryReasonId",
                        column: x => x.PrimaryReasonId,
                        principalTable: "PrimaryReasons",
                        principalColumn: "PrimaryReasonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("01b888a3-00ca-4736-96ae-1636dc7ec914"),
                column: "DateModified",
                value: new DateTime(2020, 12, 10, 15, 11, 38, 422, DateTimeKind.Local).AddTicks(7112));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("13667af3-8a37-456a-8d65-5e98627af1ad"),
                column: "DateModified",
                value: new DateTime(2020, 12, 10, 15, 11, 38, 432, DateTimeKind.Local).AddTicks(6740));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("1ace746f-f44f-47c4-bb9c-6c49fc550488"),
                column: "DateModified",
                value: new DateTime(2020, 12, 10, 15, 11, 38, 432, DateTimeKind.Local).AddTicks(6668));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("3ea0d0fe-9c1b-4171-baa1-aa5b6e6422e2"),
                column: "DateModified",
                value: new DateTime(2020, 12, 10, 15, 11, 38, 432, DateTimeKind.Local).AddTicks(6859));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("77e6d96c-f58d-46ea-a00d-5f962cfaf67b"),
                column: "DateModified",
                value: new DateTime(2020, 12, 10, 15, 11, 38, 432, DateTimeKind.Local).AddTicks(6533));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("bd9eae20-60c7-44cd-ae2e-96c5f015f82e"),
                column: "DateModified",
                value: new DateTime(2020, 12, 10, 15, 11, 38, 432, DateTimeKind.Local).AddTicks(6229));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("c26e4341-8e94-48f8-9eb6-fd2c5061bae3"),
                column: "DateModified",
                value: new DateTime(2020, 12, 10, 15, 11, 38, 432, DateTimeKind.Local).AddTicks(6580));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("f5ede641-fb76-40d5-924b-5d28ceea1ac9"),
                column: "DateModified",
                value: new DateTime(2020, 12, 10, 15, 11, 38, 432, DateTimeKind.Local).AddTicks(6620));

            migrationBuilder.CreateIndex(
                name: "IX_SecondaryReasons_PrimaryReasonId",
                table: "SecondaryReasons",
                column: "PrimaryReasonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Machines");

            migrationBuilder.DropTable(
                name: "SecondaryReasons");

            migrationBuilder.DropTable(
                name: "PrimaryReasons");

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("01b888a3-00ca-4736-96ae-1636dc7ec914"),
                column: "DateModified",
                value: new DateTime(2020, 12, 10, 14, 37, 12, 608, DateTimeKind.Local).AddTicks(8909));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("13667af3-8a37-456a-8d65-5e98627af1ad"),
                column: "DateModified",
                value: new DateTime(2020, 12, 10, 14, 37, 12, 619, DateTimeKind.Local).AddTicks(6252));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("1ace746f-f44f-47c4-bb9c-6c49fc550488"),
                column: "DateModified",
                value: new DateTime(2020, 12, 10, 14, 37, 12, 619, DateTimeKind.Local).AddTicks(6214));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("3ea0d0fe-9c1b-4171-baa1-aa5b6e6422e2"),
                column: "DateModified",
                value: new DateTime(2020, 12, 10, 14, 37, 12, 619, DateTimeKind.Local).AddTicks(6290));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("77e6d96c-f58d-46ea-a00d-5f962cfaf67b"),
                column: "DateModified",
                value: new DateTime(2020, 12, 10, 14, 37, 12, 619, DateTimeKind.Local).AddTicks(5991));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("bd9eae20-60c7-44cd-ae2e-96c5f015f82e"),
                column: "DateModified",
                value: new DateTime(2020, 12, 10, 14, 37, 12, 619, DateTimeKind.Local).AddTicks(5717));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("c26e4341-8e94-48f8-9eb6-fd2c5061bae3"),
                column: "DateModified",
                value: new DateTime(2020, 12, 10, 14, 37, 12, 619, DateTimeKind.Local).AddTicks(6035));

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("f5ede641-fb76-40d5-924b-5d28ceea1ac9"),
                column: "DateModified",
                value: new DateTime(2020, 12, 10, 14, 37, 12, 619, DateTimeKind.Local).AddTicks(6156));
        }
    }
}
