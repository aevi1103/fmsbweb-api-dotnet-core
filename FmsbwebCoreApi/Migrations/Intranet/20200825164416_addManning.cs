using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FmsbwebCoreApi.Migrations.Intranet
{
    public partial class addManning : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.EnsureSchema(
                name: "db_owner");

            migrationBuilder.CreateTable(
                name: "OperatorJobs",
                schema: "db_owner",
                columns: table => new
                {
                    OperatorJobId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Job = table.Column<string>(nullable: true),
                    TimeStamp = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperatorJobs", x => x.OperatorJobId);
                });

            migrationBuilder.CreateTable(
                name: "Operators",
                schema: "db_owner",
                columns: table => new
                {
                    OperatorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    TimeStamp = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operators", x => x.OperatorId);
                });

            //migrationBuilder.CreateTable(
            //    name: "EOLVS_EOS",
            //    schema: "dbo",
            //    columns: table => new
            //    {
            //        ID = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        shiftDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        supervisor = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        line = table.Column<int>(nullable: false),
            //        gross = table.Column<int>(nullable: false),
            //        ms = table.Column<int>(nullable: false),
            //        fs = table.Column<int>(nullable: true),
            //        machDef_25 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        quality_com = table.Column<string>(unicode: false, nullable: true),
            //        downtime_com = table.Column<string>(unicode: false, nullable: true),
            //        com = table.Column<string>(unicode: false, nullable: true),
            //        attachment = table.Column<byte[]>(nullable: true),
            //        shiftname = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
            //        modifieddate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        num_people = table.Column<decimal>(type: "decimal(18, 3)", nullable: false),
            //        manual_target = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
            //        pn = table.Column<string>(maxLength: 100, nullable: true),
            //        Target_Runtime = table.Column<decimal>(type: "decimal(18, 5)", nullable: true),
            //        Non_schedRuntime = table.Column<decimal>(type: "decimal(18, 5)", nullable: true),
            //        Actual_Runtime = table.Column<decimal>(type: "decimal(18, 5)", nullable: true),
            //        Non_schedReason = table.Column<string>(maxLength: 50, nullable: true),
            //        changeoverHrs = table.Column<decimal>(type: "decimal(18, 3)", nullable: true),
            //        co_type = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        ToolChanged = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
            //        offLoads = table.Column<int>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_EOLVS_EOS", x => x.ID);
            //    });

            migrationBuilder.CreateTable(
                name: "EOLVS_EOS_MANNING",
                schema: "dbo",
                columns: table => new
                {
                    EolManningId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EolvsEosId = table.Column<int>(nullable: false),
                    OperatorJobId = table.Column<int>(nullable: false),
                    OperatorId = table.Column<int>(nullable: false),
                    TimeStamp = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EOLVS_EOS_MANNING", x => x.EolManningId);
                    table.ForeignKey(
                        name: "FK_EOLVS_EOS_MANNING_EOLVS_EOS_EolvsEosId",
                        column: x => x.EolvsEosId,
                        principalSchema: "dbo",
                        principalTable: "EOLVS_EOS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EOLVS_EOS_MANNING_Operators_OperatorId",
                        column: x => x.OperatorId,
                        principalSchema: "db_owner",
                        principalTable: "Operators",
                        principalColumn: "OperatorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EOLVS_EOS_MANNING_OperatorJobs_OperatorJobId",
                        column: x => x.OperatorJobId,
                        principalSchema: "db_owner",
                        principalTable: "OperatorJobs",
                        principalColumn: "OperatorJobId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EOLVS_EOS_MANNING_EolvsEosId",
                schema: "dbo",
                table: "EOLVS_EOS_MANNING",
                column: "EolvsEosId");

            migrationBuilder.CreateIndex(
                name: "IX_EOLVS_EOS_MANNING_OperatorId",
                schema: "dbo",
                table: "EOLVS_EOS_MANNING",
                column: "OperatorId");

            migrationBuilder.CreateIndex(
                name: "IX_EOLVS_EOS_MANNING_OperatorJobId",
                schema: "dbo",
                table: "EOLVS_EOS_MANNING",
                column: "OperatorJobId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EOLVS_EOS_MANNING",
                schema: "dbo");

            //migrationBuilder.DropTable(
            //    name: "EOLVS_EOS",
            //    schema: "dbo");

            migrationBuilder.DropTable(
                name: "Operators",
                schema: "db_owner");

            migrationBuilder.DropTable(
                name: "OperatorJobs",
                schema: "db_owner");
        }
    }
}
