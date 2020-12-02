using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FmsbwebCoreApi.Migrations.Iconics
{
    public partial class addConstantGuids : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "KepServerTagNameMonitors",
                keyColumn: "Id",
                keyValue: new Guid("22bebde8-74dc-46eb-a44d-606ba74127fd"));

            migrationBuilder.DeleteData(
                table: "KepServerTagNameMonitors",
                keyColumn: "Id",
                keyValue: new Guid("7570d19e-b2d3-4fe0-a264-2d1d0b425ac8"));

            migrationBuilder.DeleteData(
                table: "KepServerTagNameMonitors",
                keyColumn: "Id",
                keyValue: new Guid("7ae528bd-ab15-4497-85b5-2cf2165fdd9f"));

            migrationBuilder.DeleteData(
                table: "KepServerTagNameMonitors",
                keyColumn: "Id",
                keyValue: new Guid("8be0315b-85d1-420e-ab08-385069df78d8"));

            migrationBuilder.DeleteData(
                table: "KepServerTagNameMonitors",
                keyColumn: "Id",
                keyValue: new Guid("9b65c9bf-a1c2-418b-9717-84312a93302e"));

            migrationBuilder.DeleteData(
                table: "KepServerTagNameMonitors",
                keyColumn: "Id",
                keyValue: new Guid("b5ec7f4d-2978-4e3b-b46f-e69063385a0b"));

            migrationBuilder.DeleteData(
                table: "KepServerTagNameMonitors",
                keyColumn: "Id",
                keyValue: new Guid("db786411-2031-45f3-8859-ea7e68c7cd7f"));

            migrationBuilder.DeleteData(
                table: "KepServerTagNameMonitors",
                keyColumn: "Id",
                keyValue: new Guid("fa27bca7-0fdb-4f3c-959d-06a458cdd708"));

            migrationBuilder.DeleteData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("5acb6ebc-fb7f-435e-b48a-e02e798e6a8b"));

            migrationBuilder.DeleteData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("70f09fe2-69b5-4163-9ba9-ee7dd44392a8"));

            migrationBuilder.DeleteData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("9914adfb-beb4-45b8-841e-92a62644cdb9"));

            migrationBuilder.DeleteData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("a2a448c1-4395-45c8-b52d-521cef7e0857"));

            migrationBuilder.DeleteData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("a5faa0ae-79a7-4982-b5e6-9f02b6336c78"));

            migrationBuilder.DeleteData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("ab52ed25-e05a-43d2-a5b5-886c9f81016b"));

            migrationBuilder.DeleteData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("b77a6852-48bb-4737-b311-72f0b89eb1a9"));

            migrationBuilder.DeleteData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("beba32fb-23ee-40e5-8d0d-046c990eb374"));

            migrationBuilder.InsertData(
                table: "KepServerTagNameGroups",
                columns: new[] { "KepServerTagNameGroupId", "GroupName", "TimeStamp" },
                values: new object[,]
                {
                    { new Guid("01b888a3-00ca-4736-96ae-1636dc7ec914"), "A2", new DateTime(2020, 11, 25, 7, 5, 16, 988, DateTimeKind.Local).AddTicks(9518) },
                    { new Guid("bd9eae20-60c7-44cd-ae2e-96c5f015f82e"), "A3", new DateTime(2020, 11, 25, 7, 5, 16, 991, DateTimeKind.Local).AddTicks(9475) },
                    { new Guid("77e6d96c-f58d-46ea-a00d-5f962cfaf67b"), "A4", new DateTime(2020, 11, 25, 7, 5, 16, 991, DateTimeKind.Local).AddTicks(9704) },
                    { new Guid("c26e4341-8e94-48f8-9eb6-fd2c5061bae3"), "A5", new DateTime(2020, 11, 25, 7, 5, 16, 991, DateTimeKind.Local).AddTicks(9759) },
                    { new Guid("f5ede641-fb76-40d5-924b-5d28ceea1ac9"), "A6", new DateTime(2020, 11, 25, 7, 5, 16, 991, DateTimeKind.Local).AddTicks(9809) },
                    { new Guid("1ace746f-f44f-47c4-bb9c-6c49fc550488"), "A7", new DateTime(2020, 11, 25, 7, 5, 16, 991, DateTimeKind.Local).AddTicks(9872) },
                    { new Guid("13667af3-8a37-456a-8d65-5e98627af1ad"), "A8", new DateTime(2020, 11, 25, 7, 5, 16, 991, DateTimeKind.Local).AddTicks(9923) },
                    { new Guid("3ea0d0fe-9c1b-4171-baa1-aa5b6e6422e2"), "A9", new DateTime(2020, 11, 25, 7, 5, 16, 991, DateTimeKind.Local).AddTicks(9973) }
                });

            migrationBuilder.InsertData(
                table: "KepServerTagNameMonitors",
                columns: new[] { "Id", "KepServerTagNameGroupId", "TagName", "TimeStamp" },
                values: new object[,]
                {
                    { new Guid("b37a8885-7889-407f-a44a-3cbcf3ee1a14"), new Guid("01b888a3-00ca-4736-96ae-1636dc7ec914"), "A2_PACKOUT_APC", new DateTime(2020, 11, 25, 7, 5, 16, 991, DateTimeKind.Local).AddTicks(8481) },
                    { new Guid("9f1aabaf-fc1e-437e-8af3-2e3e17aa4192"), new Guid("bd9eae20-60c7-44cd-ae2e-96c5f015f82e"), "A3_APC", new DateTime(2020, 11, 25, 7, 5, 16, 991, DateTimeKind.Local).AddTicks(9663) },
                    { new Guid("d81f4aca-b172-4e2d-b138-85fca35fdb48"), new Guid("77e6d96c-f58d-46ea-a00d-5f962cfaf67b"), "A4_M3_APC", new DateTime(2020, 11, 25, 7, 5, 16, 991, DateTimeKind.Local).AddTicks(9735) },
                    { new Guid("978337b6-98c6-4f65-97da-bed63b415e4a"), new Guid("c26e4341-8e94-48f8-9eb6-fd2c5061bae3"), "A5_APC", new DateTime(2020, 11, 25, 7, 5, 16, 991, DateTimeKind.Local).AddTicks(9785) },
                    { new Guid("bb1862ce-201c-40b1-be25-c6f13f8ec6b1"), new Guid("f5ede641-fb76-40d5-924b-5d28ceea1ac9"), "A6_M2_APC", new DateTime(2020, 11, 25, 7, 5, 16, 991, DateTimeKind.Local).AddTicks(9847) },
                    { new Guid("e6273b83-641d-4669-8003-be5bdd928093"), new Guid("1ace746f-f44f-47c4-bb9c-6c49fc550488"), "A7_M3_APC", new DateTime(2020, 11, 25, 7, 5, 16, 991, DateTimeKind.Local).AddTicks(9899) },
                    { new Guid("d43a0be0-32cc-4e28-9f74-88d10c04b6a8"), new Guid("13667af3-8a37-456a-8d65-5e98627af1ad"), "A8_APC", new DateTime(2020, 11, 25, 7, 5, 16, 991, DateTimeKind.Local).AddTicks(9949) },
                    { new Guid("61a26041-c823-427b-be03-9a10f37e344a"), new Guid("3ea0d0fe-9c1b-4171-baa1-aa5b6e6422e2"), "A9_M3_APC", new DateTime(2020, 11, 25, 7, 5, 16, 991, DateTimeKind.Local).AddTicks(9999) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "KepServerTagNameMonitors",
                keyColumn: "Id",
                keyValue: new Guid("61a26041-c823-427b-be03-9a10f37e344a"));

            migrationBuilder.DeleteData(
                table: "KepServerTagNameMonitors",
                keyColumn: "Id",
                keyValue: new Guid("978337b6-98c6-4f65-97da-bed63b415e4a"));

            migrationBuilder.DeleteData(
                table: "KepServerTagNameMonitors",
                keyColumn: "Id",
                keyValue: new Guid("9f1aabaf-fc1e-437e-8af3-2e3e17aa4192"));

            migrationBuilder.DeleteData(
                table: "KepServerTagNameMonitors",
                keyColumn: "Id",
                keyValue: new Guid("b37a8885-7889-407f-a44a-3cbcf3ee1a14"));

            migrationBuilder.DeleteData(
                table: "KepServerTagNameMonitors",
                keyColumn: "Id",
                keyValue: new Guid("bb1862ce-201c-40b1-be25-c6f13f8ec6b1"));

            migrationBuilder.DeleteData(
                table: "KepServerTagNameMonitors",
                keyColumn: "Id",
                keyValue: new Guid("d43a0be0-32cc-4e28-9f74-88d10c04b6a8"));

            migrationBuilder.DeleteData(
                table: "KepServerTagNameMonitors",
                keyColumn: "Id",
                keyValue: new Guid("d81f4aca-b172-4e2d-b138-85fca35fdb48"));

            migrationBuilder.DeleteData(
                table: "KepServerTagNameMonitors",
                keyColumn: "Id",
                keyValue: new Guid("e6273b83-641d-4669-8003-be5bdd928093"));

            migrationBuilder.DeleteData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("01b888a3-00ca-4736-96ae-1636dc7ec914"));

            migrationBuilder.DeleteData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("13667af3-8a37-456a-8d65-5e98627af1ad"));

            migrationBuilder.DeleteData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("1ace746f-f44f-47c4-bb9c-6c49fc550488"));

            migrationBuilder.DeleteData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("3ea0d0fe-9c1b-4171-baa1-aa5b6e6422e2"));

            migrationBuilder.DeleteData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("77e6d96c-f58d-46ea-a00d-5f962cfaf67b"));

            migrationBuilder.DeleteData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("bd9eae20-60c7-44cd-ae2e-96c5f015f82e"));

            migrationBuilder.DeleteData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("c26e4341-8e94-48f8-9eb6-fd2c5061bae3"));

            migrationBuilder.DeleteData(
                table: "KepServerTagNameGroups",
                keyColumn: "KepServerTagNameGroupId",
                keyValue: new Guid("f5ede641-fb76-40d5-924b-5d28ceea1ac9"));

            migrationBuilder.InsertData(
                table: "KepServerTagNameGroups",
                columns: new[] { "KepServerTagNameGroupId", "GroupName", "TimeStamp" },
                values: new object[,]
                {
                    { new Guid("9914adfb-beb4-45b8-841e-92a62644cdb9"), "A2", new DateTime(2020, 11, 25, 6, 40, 45, 591, DateTimeKind.Local).AddTicks(7330) },
                    { new Guid("b77a6852-48bb-4737-b311-72f0b89eb1a9"), "A3", new DateTime(2020, 11, 25, 6, 40, 45, 594, DateTimeKind.Local).AddTicks(842) },
                    { new Guid("ab52ed25-e05a-43d2-a5b5-886c9f81016b"), "A4", new DateTime(2020, 11, 25, 6, 40, 45, 594, DateTimeKind.Local).AddTicks(1192) },
                    { new Guid("70f09fe2-69b5-4163-9ba9-ee7dd44392a8"), "A5", new DateTime(2020, 11, 25, 6, 40, 45, 594, DateTimeKind.Local).AddTicks(1288) },
                    { new Guid("a5faa0ae-79a7-4982-b5e6-9f02b6336c78"), "A6", new DateTime(2020, 11, 25, 6, 40, 45, 594, DateTimeKind.Local).AddTicks(1545) },
                    { new Guid("a2a448c1-4395-45c8-b52d-521cef7e0857"), "A7", new DateTime(2020, 11, 25, 6, 40, 45, 594, DateTimeKind.Local).AddTicks(1651) },
                    { new Guid("5acb6ebc-fb7f-435e-b48a-e02e798e6a8b"), "A8", new DateTime(2020, 11, 25, 6, 40, 45, 594, DateTimeKind.Local).AddTicks(1745) },
                    { new Guid("beba32fb-23ee-40e5-8d0d-046c990eb374"), "A9", new DateTime(2020, 11, 25, 6, 40, 45, 594, DateTimeKind.Local).AddTicks(1834) }
                });

            migrationBuilder.InsertData(
                table: "KepServerTagNameMonitors",
                columns: new[] { "Id", "KepServerTagNameGroupId", "TagName", "TimeStamp" },
                values: new object[,]
                {
                    { new Guid("db786411-2031-45f3-8859-ea7e68c7cd7f"), new Guid("9914adfb-beb4-45b8-841e-92a62644cdb9"), "A2_PACKOUT_APC", new DateTime(2020, 11, 25, 6, 40, 45, 593, DateTimeKind.Local).AddTicks(9712) },
                    { new Guid("9b65c9bf-a1c2-418b-9717-84312a93302e"), new Guid("b77a6852-48bb-4737-b311-72f0b89eb1a9"), "A3_APC", new DateTime(2020, 11, 25, 6, 40, 45, 594, DateTimeKind.Local).AddTicks(1110) },
                    { new Guid("8be0315b-85d1-420e-ab08-385069df78d8"), new Guid("ab52ed25-e05a-43d2-a5b5-886c9f81016b"), "A4_M3_APC", new DateTime(2020, 11, 25, 6, 40, 45, 594, DateTimeKind.Local).AddTicks(1241) },
                    { new Guid("fa27bca7-0fdb-4f3c-959d-06a458cdd708"), new Guid("70f09fe2-69b5-4163-9ba9-ee7dd44392a8"), "A5_APC", new DateTime(2020, 11, 25, 6, 40, 45, 594, DateTimeKind.Local).AddTicks(1334) },
                    { new Guid("7ae528bd-ab15-4497-85b5-2cf2165fdd9f"), new Guid("a5faa0ae-79a7-4982-b5e6-9f02b6336c78"), "A6_M2_APC", new DateTime(2020, 11, 25, 6, 40, 45, 594, DateTimeKind.Local).AddTicks(1604) },
                    { new Guid("b5ec7f4d-2978-4e3b-b46f-e69063385a0b"), new Guid("a2a448c1-4395-45c8-b52d-521cef7e0857"), "A7_M3_APC", new DateTime(2020, 11, 25, 6, 40, 45, 594, DateTimeKind.Local).AddTicks(1700) },
                    { new Guid("22bebde8-74dc-46eb-a44d-606ba74127fd"), new Guid("5acb6ebc-fb7f-435e-b48a-e02e798e6a8b"), "A8_APC", new DateTime(2020, 11, 25, 6, 40, 45, 594, DateTimeKind.Local).AddTicks(1794) },
                    { new Guid("7570d19e-b2d3-4fe0-a264-2d1d0b425ac8"), new Guid("beba32fb-23ee-40e5-8d0d-046c990eb374"), "A9_M3_APC", new DateTime(2020, 11, 25, 6, 40, 45, 594, DateTimeKind.Local).AddTicks(1885) }
                });
        }
    }
}
