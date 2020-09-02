using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FmsbwebCoreApi.Migrations.Intranet
{
    public partial class addTimeStamps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EOLVS_EOS_OPERATORS",
                keyColumn: "OperatorId",
                keyValue: 1,
                columns: new[] { "FirstName", "LastName", "TimeStamp" },
                values: new object[] { "Kevin", "Dimmett", new DateTime(2020, 8, 25, 13, 12, 30, 386, DateTimeKind.Local).AddTicks(6574) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EOLVS_EOS_OPERATORS",
                keyColumn: "OperatorId",
                keyValue: 2,
                columns: new[] { "FirstName", "LastName", "TimeStamp" },
                values: new object[] { "Pedro", "Anglero", new DateTime(2020, 8, 25, 13, 12, 30, 386, DateTimeKind.Local).AddTicks(7891) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EOLVS_EOS_OPERATORS",
                keyColumn: "OperatorId",
                keyValue: 3,
                columns: new[] { "FirstName", "LastName", "TimeStamp" },
                values: new object[] { "Joe", "Stroud", new DateTime(2020, 8, 25, 13, 12, 30, 386, DateTimeKind.Local).AddTicks(8061) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EOLVS_EOS_OPERATORS",
                keyColumn: "OperatorId",
                keyValue: 4,
                columns: new[] { "FirstName", "LastName", "TimeStamp" },
                values: new object[] { "Ritchard", "Krouse", new DateTime(2020, 8, 25, 13, 12, 30, 386, DateTimeKind.Local).AddTicks(8182) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EOLVS_EOS_OPERATORS",
                keyColumn: "OperatorId",
                keyValue: 5,
                columns: new[] { "FirstName", "LastName", "TimeStamp" },
                values: new object[] { "Gregory", "Kuzmits", new DateTime(2020, 8, 25, 13, 12, 30, 386, DateTimeKind.Local).AddTicks(8212) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EOLVS_EOS_OPERATORS",
                keyColumn: "OperatorId",
                keyValue: 6,
                columns: new[] { "FirstName", "LastName", "TimeStamp" },
                values: new object[] { "Nick", "Powers", new DateTime(2020, 8, 25, 13, 12, 30, 386, DateTimeKind.Local).AddTicks(8241) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EOLVS_EOS_OPERATORS",
                keyColumn: "OperatorId",
                keyValue: 7,
                columns: new[] { "FirstName", "LastName", "TimeStamp" },
                values: new object[] { "Bryan", "Crowner", new DateTime(2020, 8, 25, 13, 12, 30, 386, DateTimeKind.Local).AddTicks(8263) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EOLVS_EOS_OPERATORS",
                keyColumn: "OperatorId",
                keyValue: 8,
                columns: new[] { "FirstName", "TimeStamp" },
                values: new object[] { "Kenny", new DateTime(2020, 8, 25, 13, 12, 30, 386, DateTimeKind.Local).AddTicks(8284) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EOLVS_EOS_OPERATORS",
                keyColumn: "OperatorId",
                keyValue: 9,
                columns: new[] { "FirstName", "LastName", "TimeStamp" },
                values: new object[] { "Michael", "Plencner", new DateTime(2020, 8, 25, 13, 12, 30, 386, DateTimeKind.Local).AddTicks(8305) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EOLVS_EOS_OPERATORS",
                keyColumn: "OperatorId",
                keyValue: 10,
                columns: new[] { "FirstName", "LastName", "TimeStamp" },
                values: new object[] { "Paula", "Smith", new DateTime(2020, 8, 25, 13, 12, 30, 386, DateTimeKind.Local).AddTicks(8329) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EOLVS_EOS_OPERATORS",
                keyColumn: "OperatorId",
                keyValue: 11,
                columns: new[] { "FirstName", "LastName", "TimeStamp" },
                values: new object[] { "Gary", "Westerhouse", new DateTime(2020, 8, 25, 13, 12, 30, 386, DateTimeKind.Local).AddTicks(8350) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EOLVS_EOS_OPERATORS",
                keyColumn: "OperatorId",
                keyValue: 12,
                columns: new[] { "FirstName", "LastName", "TimeStamp" },
                values: new object[] { "Steve", "Ehardt", new DateTime(2020, 8, 25, 13, 12, 30, 386, DateTimeKind.Local).AddTicks(8371) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EOLVS_EOS_OPERATORS",
                keyColumn: "OperatorId",
                keyValue: 13,
                columns: new[] { "FirstName", "LastName", "TimeStamp" },
                values: new object[] { "Rollie", "Ball", new DateTime(2020, 8, 25, 13, 12, 30, 386, DateTimeKind.Local).AddTicks(8391) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EOLVS_EOS_OPERATORS",
                keyColumn: "OperatorId",
                keyValue: 14,
                columns: new[] { "FirstName", "LastName", "TimeStamp" },
                values: new object[] { "Curt", "Webb", new DateTime(2020, 8, 25, 13, 12, 30, 386, DateTimeKind.Local).AddTicks(8412) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EOLVS_EOS_OPERATORS",
                keyColumn: "OperatorId",
                keyValue: 15,
                columns: new[] { "FirstName", "LastName", "TimeStamp" },
                values: new object[] { "Kevin", "Rossaw", new DateTime(2020, 8, 25, 13, 12, 30, 386, DateTimeKind.Local).AddTicks(8433) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EOLVS_EOS_OPERATORS",
                keyColumn: "OperatorId",
                keyValue: 16,
                columns: new[] { "FirstName", "LastName", "TimeStamp" },
                values: new object[] { "Scott", "Higbee", new DateTime(2020, 8, 25, 13, 12, 30, 386, DateTimeKind.Local).AddTicks(8454) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EOLVS_EOS_OPERATORS",
                keyColumn: "OperatorId",
                keyValue: 17,
                columns: new[] { "FirstName", "LastName", "TimeStamp" },
                values: new object[] { "Joe", "Kil", new DateTime(2020, 8, 25, 13, 12, 30, 386, DateTimeKind.Local).AddTicks(8475) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EOLVS_EOS_OPERATORS",
                keyColumn: "OperatorId",
                keyValue: 18,
                columns: new[] { "FirstName", "LastName", "TimeStamp" },
                values: new object[] { "Tracey", "Smith", new DateTime(2020, 8, 25, 13, 12, 30, 386, DateTimeKind.Local).AddTicks(8497) });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "EOLVS_EOS_OPERATORS",
                columns: new[] { "OperatorId", "FirstName", "LastName", "TimeStamp" },
                values: new object[] { 19, "Dale", "Beghtel", new DateTime(2020, 8, 25, 13, 12, 30, 386, DateTimeKind.Local).AddTicks(8518) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EOLVS_EOS_OPERATOR_JOBS",
                keyColumn: "OperatorJobId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 25, 13, 12, 30, 379, DateTimeKind.Local).AddTicks(3774));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EOLVS_EOS_OPERATOR_JOBS",
                keyColumn: "OperatorJobId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 8, 25, 13, 12, 30, 386, DateTimeKind.Local).AddTicks(2218));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "EOLVS_EOS_OPERATORS",
                keyColumn: "OperatorId",
                keyValue: 19);

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EOLVS_EOS_OPERATORS",
                keyColumn: "OperatorId",
                keyValue: 1,
                columns: new[] { "FirstName", "LastName", "TimeStamp" },
                values: new object[] { "Pedro", "Anglero", new DateTime(2020, 8, 25, 13, 9, 7, 216, DateTimeKind.Local).AddTicks(6159) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EOLVS_EOS_OPERATORS",
                keyColumn: "OperatorId",
                keyValue: 2,
                columns: new[] { "FirstName", "LastName", "TimeStamp" },
                values: new object[] { "Joe", "Stroud", new DateTime(2020, 8, 25, 13, 9, 7, 216, DateTimeKind.Local).AddTicks(6236) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EOLVS_EOS_OPERATORS",
                keyColumn: "OperatorId",
                keyValue: 3,
                columns: new[] { "FirstName", "LastName", "TimeStamp" },
                values: new object[] { "Ritchard", "Krouse", new DateTime(2020, 8, 25, 13, 9, 7, 216, DateTimeKind.Local).AddTicks(6242) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EOLVS_EOS_OPERATORS",
                keyColumn: "OperatorId",
                keyValue: 4,
                columns: new[] { "FirstName", "LastName", "TimeStamp" },
                values: new object[] { "Gregory", "Kuzmits", new DateTime(2020, 8, 25, 13, 9, 7, 216, DateTimeKind.Local).AddTicks(6245) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EOLVS_EOS_OPERATORS",
                keyColumn: "OperatorId",
                keyValue: 5,
                columns: new[] { "FirstName", "LastName", "TimeStamp" },
                values: new object[] { "Nick", "Powers", new DateTime(2020, 8, 25, 13, 9, 7, 216, DateTimeKind.Local).AddTicks(6254) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EOLVS_EOS_OPERATORS",
                keyColumn: "OperatorId",
                keyValue: 6,
                columns: new[] { "FirstName", "LastName", "TimeStamp" },
                values: new object[] { "Bryan", "Crowner", new DateTime(2020, 8, 25, 13, 9, 7, 216, DateTimeKind.Local).AddTicks(6258) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EOLVS_EOS_OPERATORS",
                keyColumn: "OperatorId",
                keyValue: 7,
                columns: new[] { "FirstName", "LastName", "TimeStamp" },
                values: new object[] { "Kenny", "Plencner", new DateTime(2020, 8, 25, 13, 9, 7, 216, DateTimeKind.Local).AddTicks(6262) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EOLVS_EOS_OPERATORS",
                keyColumn: "OperatorId",
                keyValue: 8,
                columns: new[] { "FirstName", "TimeStamp" },
                values: new object[] { "Michael", new DateTime(2020, 8, 25, 13, 9, 7, 216, DateTimeKind.Local).AddTicks(6265) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EOLVS_EOS_OPERATORS",
                keyColumn: "OperatorId",
                keyValue: 9,
                columns: new[] { "FirstName", "LastName", "TimeStamp" },
                values: new object[] { "Paula", "Smith", new DateTime(2020, 8, 25, 13, 9, 7, 216, DateTimeKind.Local).AddTicks(6405) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EOLVS_EOS_OPERATORS",
                keyColumn: "OperatorId",
                keyValue: 10,
                columns: new[] { "FirstName", "LastName", "TimeStamp" },
                values: new object[] { "Gary", "Westerhouse", new DateTime(2020, 8, 25, 13, 9, 7, 216, DateTimeKind.Local).AddTicks(6410) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EOLVS_EOS_OPERATORS",
                keyColumn: "OperatorId",
                keyValue: 11,
                columns: new[] { "FirstName", "LastName", "TimeStamp" },
                values: new object[] { "Steve", "Ehardt", new DateTime(2020, 8, 25, 13, 9, 7, 216, DateTimeKind.Local).AddTicks(6413) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EOLVS_EOS_OPERATORS",
                keyColumn: "OperatorId",
                keyValue: 12,
                columns: new[] { "FirstName", "LastName", "TimeStamp" },
                values: new object[] { "Rollie", "Ball", new DateTime(2020, 8, 25, 13, 9, 7, 216, DateTimeKind.Local).AddTicks(6417) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EOLVS_EOS_OPERATORS",
                keyColumn: "OperatorId",
                keyValue: 13,
                columns: new[] { "FirstName", "LastName", "TimeStamp" },
                values: new object[] { "Curt", "Webb", new DateTime(2020, 8, 25, 13, 9, 7, 216, DateTimeKind.Local).AddTicks(6421) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EOLVS_EOS_OPERATORS",
                keyColumn: "OperatorId",
                keyValue: 14,
                columns: new[] { "FirstName", "LastName", "TimeStamp" },
                values: new object[] { "Kevin", "Rossaw", new DateTime(2020, 8, 25, 13, 9, 7, 216, DateTimeKind.Local).AddTicks(6426) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EOLVS_EOS_OPERATORS",
                keyColumn: "OperatorId",
                keyValue: 15,
                columns: new[] { "FirstName", "LastName", "TimeStamp" },
                values: new object[] { "Scott", "Higbee", new DateTime(2020, 8, 25, 13, 9, 7, 216, DateTimeKind.Local).AddTicks(6431) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EOLVS_EOS_OPERATORS",
                keyColumn: "OperatorId",
                keyValue: 16,
                columns: new[] { "FirstName", "LastName", "TimeStamp" },
                values: new object[] { "Joe", "Kil", new DateTime(2020, 8, 25, 13, 9, 7, 216, DateTimeKind.Local).AddTicks(6435) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EOLVS_EOS_OPERATORS",
                keyColumn: "OperatorId",
                keyValue: 17,
                columns: new[] { "FirstName", "LastName", "TimeStamp" },
                values: new object[] { "Tracey", "Smith", new DateTime(2020, 8, 25, 13, 9, 7, 216, DateTimeKind.Local).AddTicks(6439) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EOLVS_EOS_OPERATORS",
                keyColumn: "OperatorId",
                keyValue: 18,
                columns: new[] { "FirstName", "LastName", "TimeStamp" },
                values: new object[] { "Dale", "Beghtel", new DateTime(2020, 8, 25, 13, 9, 7, 216, DateTimeKind.Local).AddTicks(6443) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EOLVS_EOS_OPERATOR_JOBS",
                keyColumn: "OperatorJobId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EOLVS_EOS_OPERATOR_JOBS",
                keyColumn: "OperatorJobId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
