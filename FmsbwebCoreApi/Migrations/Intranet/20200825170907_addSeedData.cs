using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FmsbwebCoreApi.Migrations.Intranet
{
    public partial class addSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "dbo",
                table: "EOLVS_EOS_OPERATORS",
                columns: new[] { "OperatorId", "FirstName", "LastName", "TimeStamp" },
                values: new object[,]
                {
                    { 1, "Pedro", "Anglero", new DateTime(2020, 8, 25, 13, 9, 7, 216, DateTimeKind.Local).AddTicks(6159) },
                    { 18, "Dale", "Beghtel", new DateTime(2020, 8, 25, 13, 9, 7, 216, DateTimeKind.Local).AddTicks(6443) },
                    { 17, "Tracey", "Smith", new DateTime(2020, 8, 25, 13, 9, 7, 216, DateTimeKind.Local).AddTicks(6439) },
                    { 16, "Joe", "Kil", new DateTime(2020, 8, 25, 13, 9, 7, 216, DateTimeKind.Local).AddTicks(6435) },
                    { 15, "Scott", "Higbee", new DateTime(2020, 8, 25, 13, 9, 7, 216, DateTimeKind.Local).AddTicks(6431) },
                    { 14, "Kevin", "Rossaw", new DateTime(2020, 8, 25, 13, 9, 7, 216, DateTimeKind.Local).AddTicks(6426) },
                    { 13, "Curt", "Webb", new DateTime(2020, 8, 25, 13, 9, 7, 216, DateTimeKind.Local).AddTicks(6421) },
                    { 12, "Rollie", "Ball", new DateTime(2020, 8, 25, 13, 9, 7, 216, DateTimeKind.Local).AddTicks(6417) },
                    { 11, "Steve", "Ehardt", new DateTime(2020, 8, 25, 13, 9, 7, 216, DateTimeKind.Local).AddTicks(6413) },
                    { 10, "Gary", "Westerhouse", new DateTime(2020, 8, 25, 13, 9, 7, 216, DateTimeKind.Local).AddTicks(6410) },
                    { 9, "Paula", "Smith", new DateTime(2020, 8, 25, 13, 9, 7, 216, DateTimeKind.Local).AddTicks(6405) },
                    { 8, "Michael", "Plencner", new DateTime(2020, 8, 25, 13, 9, 7, 216, DateTimeKind.Local).AddTicks(6265) },
                    { 7, "Kenny", "Plencner", new DateTime(2020, 8, 25, 13, 9, 7, 216, DateTimeKind.Local).AddTicks(6262) },
                    { 6, "Bryan", "Crowner", new DateTime(2020, 8, 25, 13, 9, 7, 216, DateTimeKind.Local).AddTicks(6258) },
                    { 5, "Nick", "Powers", new DateTime(2020, 8, 25, 13, 9, 7, 216, DateTimeKind.Local).AddTicks(6254) },
                    { 4, "Gregory", "Kuzmits", new DateTime(2020, 8, 25, 13, 9, 7, 216, DateTimeKind.Local).AddTicks(6245) },
                    { 3, "Ritchard", "Krouse", new DateTime(2020, 8, 25, 13, 9, 7, 216, DateTimeKind.Local).AddTicks(6242) },
                    { 2, "Joe", "Stroud", new DateTime(2020, 8, 25, 13, 9, 7, 216, DateTimeKind.Local).AddTicks(6236) }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "EOLVS_EOS_OPERATOR_JOBS",
                columns: new[] { "OperatorJobId", "Job", "TimeStamp" },
                values: new object[,]
                {
                    { 1, "Okuma Operator", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Diamond Turn Operator", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "EOLVS_EOS_OPERATORS",
                keyColumn: "OperatorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "EOLVS_EOS_OPERATORS",
                keyColumn: "OperatorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "EOLVS_EOS_OPERATORS",
                keyColumn: "OperatorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "EOLVS_EOS_OPERATORS",
                keyColumn: "OperatorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "EOLVS_EOS_OPERATORS",
                keyColumn: "OperatorId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "EOLVS_EOS_OPERATORS",
                keyColumn: "OperatorId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "EOLVS_EOS_OPERATORS",
                keyColumn: "OperatorId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "EOLVS_EOS_OPERATORS",
                keyColumn: "OperatorId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "EOLVS_EOS_OPERATORS",
                keyColumn: "OperatorId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "EOLVS_EOS_OPERATORS",
                keyColumn: "OperatorId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "EOLVS_EOS_OPERATORS",
                keyColumn: "OperatorId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "EOLVS_EOS_OPERATORS",
                keyColumn: "OperatorId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "EOLVS_EOS_OPERATORS",
                keyColumn: "OperatorId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "EOLVS_EOS_OPERATORS",
                keyColumn: "OperatorId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "EOLVS_EOS_OPERATORS",
                keyColumn: "OperatorId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "EOLVS_EOS_OPERATORS",
                keyColumn: "OperatorId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "EOLVS_EOS_OPERATORS",
                keyColumn: "OperatorId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "EOLVS_EOS_OPERATORS",
                keyColumn: "OperatorId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "EOLVS_EOS_OPERATOR_JOBS",
                keyColumn: "OperatorJobId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "EOLVS_EOS_OPERATOR_JOBS",
                keyColumn: "OperatorJobId",
                keyValue: 2);
        }
    }
}
