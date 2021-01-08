using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FmsbwebCoreApi.Migrations.FmsbOee
{
    public partial class addmachinenameinline : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MachineName",
                table: "Lines",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("01b888a3-00ca-4736-96ae-1636dc7ec914"),
                columns: new[] { "DateModified", "MachineName" },
                values: new object[] { new DateTime(2021, 1, 6, 8, 48, 45, 258, DateTimeKind.Local).AddTicks(6573), "Assembly 2" });

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("13667af3-8a37-456a-8d65-5e98627af1ad"),
                columns: new[] { "DateModified", "MachineName" },
                values: new object[] { new DateTime(2021, 1, 6, 8, 48, 45, 267, DateTimeKind.Local).AddTicks(9859), "Assembly 8" });

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("1ace746f-f44f-47c4-bb9c-6c49fc550488"),
                columns: new[] { "DateModified", "MachineName" },
                values: new object[] { new DateTime(2021, 1, 6, 8, 48, 45, 267, DateTimeKind.Local).AddTicks(9770), "Assembly 7" });

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("3ea0d0fe-9c1b-4171-baa1-aa5b6e6422e2"),
                columns: new[] { "DateModified", "MachineName" },
                values: new object[] { new DateTime(2021, 1, 6, 8, 48, 45, 267, DateTimeKind.Local).AddTicks(9891), "Assembly 9" });

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("77e6d96c-f58d-46ea-a00d-5f962cfaf67b"),
                columns: new[] { "DateModified", "MachineName" },
                values: new object[] { new DateTime(2021, 1, 6, 8, 48, 45, 267, DateTimeKind.Local).AddTicks(9676), "Assembly 4" });

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("bd9eae20-60c7-44cd-ae2e-96c5f015f82e"),
                columns: new[] { "DateModified", "MachineName" },
                values: new object[] { new DateTime(2021, 1, 6, 8, 48, 45, 267, DateTimeKind.Local).AddTicks(9474), "Assembly 3" });

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("c26e4341-8e94-48f8-9eb6-fd2c5061bae3"),
                columns: new[] { "DateModified", "MachineName" },
                values: new object[] { new DateTime(2021, 1, 6, 8, 48, 45, 267, DateTimeKind.Local).AddTicks(9709), "Assembly 5" });

            migrationBuilder.UpdateData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("f5ede641-fb76-40d5-924b-5d28ceea1ac9"),
                columns: new[] { "DateModified", "MachineName" },
                values: new object[] { new DateTime(2021, 1, 6, 8, 48, 45, 267, DateTimeKind.Local).AddTicks(9736), "Assembly 6" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MachineName",
                table: "Lines");

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
        }
    }
}
