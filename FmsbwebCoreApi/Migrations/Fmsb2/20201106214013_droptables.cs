using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FmsbwebCoreApi.Migrations.Fmsb2
{
    public partial class droptables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActionImprovementList");

            migrationBuilder.DropTable(
                name: "CheckSheet");

            migrationBuilder.DropTable(
                name: "ChecksheetResult");

            migrationBuilder.DropTable(
                name: "DashBoardPlannedDown");

            migrationBuilder.DropTable(
                name: "DefectEscalation");

            migrationBuilder.DropTable(
                name: "DefectGroup");

            migrationBuilder.DropTable(
                name: "EnableDisableEscalation");

            migrationBuilder.DropTable(
                name: "FoundryCellCounter");

            migrationBuilder.DropTable(
                name: "HeatMapValues");

            migrationBuilder.DropTable(
                name: "Inspectors");

            migrationBuilder.DropTable(
                name: "MonitorScale");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ActionImprovementList",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    actionImprovements = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    modifieddate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActionImprovementList", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CheckSheet",
                columns: table => new
                {
                    checksheetId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    checksheet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    deptId = table.Column<int>(type: "int", nullable: false),
                    modifieddate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckSheet", x => x.checksheetId);
                });

            migrationBuilder.CreateTable(
                name: "ChecksheetResult",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    checkId = table.Column<int>(type: "int", nullable: false),
                    checksheetId = table.Column<int>(type: "int", nullable: false),
                    hourId = table.Column<int>(type: "int", nullable: false),
                    modifieddate = table.Column<DateTime>(type: "datetime", nullable: false),
                    status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChecksheetResult", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "DashBoardPlannedDown",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    datemodified = table.Column<DateTime>(type: "datetime", nullable: false),
                    machineId = table.Column<int>(type: "int", nullable: false),
                    planedDown = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DashBoardPlannedDown", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "DefectEscalation",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    alarmLevel = table.Column<int>(type: "int", nullable: false),
                    defectId = table.Column<int>(type: "int", nullable: false),
                    deptId = table.Column<int>(type: "int", nullable: false),
                    escalationMsgId = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    machineId = table.Column<int>(type: "int", nullable: false),
                    modifieddate = table.Column<DateTime>(type: "datetime", nullable: false),
                    triggerQty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DefectEscalation", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "DefectGroup",
                columns: table => new
                {
                    defectGroupId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    modifieddate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DefectGroup", x => x.defectGroupId);
                });

            migrationBuilder.CreateTable(
                name: "EnableDisableEscalation",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    enable = table.Column<bool>(type: "bit", nullable: false),
                    machineId = table.Column<int>(type: "int", nullable: false),
                    modifieddate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnableDisableEscalation", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "FoundryCellCounter",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    endCount = table.Column<long>(type: "bigint", nullable: false),
                    hourId = table.Column<int>(type: "int", nullable: false),
                    stamp = table.Column<DateTime>(type: "datetime", nullable: false),
                    startCount = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoundryCellCounter", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "HeatMapValues",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    heatMapLoginId = table.Column<int>(type: "int", nullable: false),
                    modifiedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    radius = table.Column<int>(type: "int", nullable: false),
                    value = table.Column<int>(type: "int", nullable: false),
                    x_value = table.Column<int>(type: "int", nullable: false),
                    y_value = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeatMapValues", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Inspectors",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    clock = table.Column<int>(type: "int", nullable: false),
                    modifieddate = table.Column<DateTime>(type: "datetime", nullable: false),
                    prodid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inspectors", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "MonitorScale",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    height = table.Column<int>(type: "int", nullable: false),
                    machId = table.Column<int>(type: "int", nullable: false),
                    modifieddate = table.Column<DateTime>(type: "datetime", nullable: false),
                    width = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonitorScale", x => x.id);
                });
        }
    }
}
