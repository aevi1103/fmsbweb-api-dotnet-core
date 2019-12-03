using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FmsbwebCoreApi.Migrations.Fmsb2
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "24Hours",
            //    columns: table => new
            //    {
            //        shift = table.Column<int>(nullable: true),
            //        hour = table.Column<int>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ActionImprovementList",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        actionImprovements = table.Column<string>(maxLength: 500, nullable: false),
            //        modifieddate = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ActionImprovementList", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ActualCycles",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        hourid = table.Column<int>(nullable: false),
            //        actualcycle = table.Column<decimal>(type: "decimal(18, 5)", nullable: true),
            //        modifieddate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        hourNum = table.Column<int>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ActualCycles", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "AssemblyChangeover",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        hourId = table.Column<int>(nullable: false),
            //        question = table.Column<string>(unicode: false, maxLength: 500, nullable: false),
            //        yesNo = table.Column<bool>(nullable: false),
            //        mnodifiedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        fromPart = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        toPart = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        hourNum = table.Column<int>(nullable: false),
            //        order = table.Column<int>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AssemblyChangeover", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Attachments",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        filename = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        contentType = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
            //        data = table.Column<byte[]>(nullable: true),
            //        deptComId = table.Column<int>(nullable: false),
            //        modifieddate = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Attachments", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "AuthorizeClocks",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        clocknum = table.Column<int>(nullable: false),
            //        machineId = table.Column<int>(nullable: false),
            //        modifieddate = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AuthorizeClocks", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "CellCavities",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        machineId = table.Column<int>(nullable: false),
            //        cavities = table.Column<int>(nullable: false),
            //        modifieddate = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_CellCavities", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ChecksExist",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        hourId = table.Column<int>(nullable: false),
            //        modifieddate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        fromPart = table.Column<string>(maxLength: 50, nullable: false),
            //        toPart = table.Column<string>(maxLength: 50, nullable: false),
            //        Page = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ChecksExist", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "CheckSheet",
            //    columns: table => new
            //    {
            //        checksheetId = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        deptId = table.Column<int>(nullable: false),
            //        checksheet = table.Column<string>(nullable: false),
            //        modifieddate = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_CheckSheet", x => x.checksheetId);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ChecksheetResult",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        hourId = table.Column<int>(nullable: false),
            //        checksheetId = table.Column<int>(nullable: false),
            //        status = table.Column<bool>(nullable: false),
            //        modifieddate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        checkId = table.Column<int>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ChecksheetResult", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ComponentGroup",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        componentCategory = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        modifieddate = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ComponentGroup", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ComponentRecords",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        componentTypeId = table.Column<int>(nullable: false),
            //        qty = table.Column<int>(nullable: false),
            //        comments = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
            //        modifieddate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        hourNum = table.Column<int>(nullable: false),
            //        prodId = table.Column<int>(nullable: false),
            //        RodReclaimId = table.Column<int>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ComponentRecords", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ComponentReference",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        defectid = table.Column<int>(nullable: false),
            //        machineid = table.Column<int>(nullable: false),
            //        component = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        multiplier = table.Column<int>(nullable: false),
            //        modifieddate = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ComponentReference", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ComponentTraceability",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        hourId = table.Column<int>(nullable: false),
            //        hour = table.Column<int>(nullable: false),
            //        pistonPartOverride = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        componentPart = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        lotNumber = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        modifiedate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        julianDateCode = table.Column<string>(unicode: false, maxLength: 100, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ComponentTraceability", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ComponentTypeReference",
            //    columns: table => new
            //    {
            //        ComponentId = table.Column<string>(unicode: false, maxLength: 3, nullable: false),
            //        ComponentName = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ComponentTypeReference", x => x.ComponentId);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "componentTypes",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        componentGroupId = table.Column<int>(nullable: false),
            //        component = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        modifieddate = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_componentTypes", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "CostCenter_SAP",
            //    columns: table => new
            //    {
            //        CostCenter = table.Column<int>(nullable: false),
            //        Dept = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_CostCenter_SAP", x => x.CostCenter);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "CreateHxH",
            //    columns: table => new
            //    {
            //        hrId = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        shiftdate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        shift = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        deptid = table.Column<int>(nullable: false),
            //        machineid = table.Column<int>(nullable: false),
            //        modifieddate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        CellSide = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
            //        RowVersion = table.Column<byte[]>(rowVersion: true, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_CreateHxH", x => x.hrId);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "CycleTime",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        machineId = table.Column<int>(nullable: false),
            //        cycletime_sec = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
            //        modifieddate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        part = table.Column<string>(maxLength: 50, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_CycleTime", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "DashBoardPlannedDown",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        machineId = table.Column<int>(nullable: false),
            //        planedDown = table.Column<bool>(nullable: false),
            //        datemodified = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_DashBoardPlannedDown", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "DefectArea",
            //    columns: table => new
            //    {
            //        defectAreaId = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        defectArea = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        modifieddate = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_DefectArea", x => x.defectAreaId);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "DefectEscalation",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        deptId = table.Column<int>(nullable: false),
            //        defectId = table.Column<int>(nullable: false),
            //        alarmLevel = table.Column<int>(nullable: false),
            //        triggerQty = table.Column<int>(nullable: false),
            //        escalationMsgId = table.Column<string>(maxLength: 500, nullable: true),
            //        modifieddate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        machineId = table.Column<int>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_DefectEscalation", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "DefectGroup",
            //    columns: table => new
            //    {
            //        defectGroupId = table.Column<string>(maxLength: 50, nullable: false),
            //        modifieddate = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_DefectGroup", x => x.defectGroupId);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Department",
            //    columns: table => new
            //    {
            //        deptId = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        deptName = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        modifieddate = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Department", x => x.deptId);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "DepartmentalComments",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        dept = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        date = table.Column<DateTime>(type: "datetime", nullable: false),
            //        manager = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        category = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        comments = table.Column<string>(unicode: false, nullable: false),
            //        modifieddate = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_DepartmentalComments", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "DeptReferences",
            //    columns: table => new
            //    {
            //        Dept = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        DeptRef = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //    });

            //migrationBuilder.CreateTable(
            //    name: "DeptReferences2",
            //    columns: table => new
            //    {
            //        Dept = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        DeptLinkOldDb = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_DeptReferences2", x => x.Dept);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Downtime",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        hxhId = table.Column<int>(nullable: false),
            //        reason1Id = table.Column<int>(nullable: false),
            //        reason2Id = table.Column<int>(nullable: true),
            //        Comments = table.Column<string>(nullable: true),
            //        modifieddate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        downtimeloss = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
            //        machineGroupId = table.Column<int>(nullable: true),
            //        machineNumberId = table.Column<int>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Downtime", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "DowntimeDataList2_Copy",
            //    columns: table => new
            //    {
            //        HourId = table.Column<int>(nullable: false),
            //        downtimeId = table.Column<int>(nullable: false),
            //        deptName = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        machineName = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        cellSide_foundry = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
            //        shiftdate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        shift = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        hour = table.Column<int>(nullable: false),
            //        pn = table.Column<string>(maxLength: 50, nullable: true),
            //        machineGroup = table.Column<string>(maxLength: 500, nullable: true),
            //        machineNumber = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        reason1 = table.Column<string>(nullable: true),
            //        reason2 = table.Column<string>(maxLength: 500, nullable: false),
            //        Comments = table.Column<string>(nullable: true),
            //        downtimeloss = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
            //        modifieddate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        machineGroupId = table.Column<int>(nullable: true),
            //        machineNumberId = table.Column<int>(nullable: true),
            //        reason1Id = table.Column<int>(nullable: true),
            //        reason2Id = table.Column<int>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //    });

            //migrationBuilder.CreateTable(
            //    name: "DowntimeReportRecipient",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        email = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        dept = table.Column<string>(maxLength: 50, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_DowntimeReportRecipient", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "DowntimeReportRecipients",
            //    columns: table => new
            //    {
            //        email = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
            //        deptName = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_DowntimeReportRecipients", x => x.email);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "EmailNotification",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        email = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        dept = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        modifieddate = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_EmailNotification", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "EnableDisableEscalation",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        machineId = table.Column<int>(nullable: false),
            //        enable = table.Column<bool>(nullable: false),
            //        modifieddate = table.Column<DateTime>(type: "datetime", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_EnableDisableEscalation", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "EOS_Comments",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        shiftDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        shift = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
            //        machine = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        side = table.Column<string>(unicode: false, maxLength: 5, nullable: true),
            //        comment = table.Column<string>(unicode: false, nullable: false),
            //        modifiedDate = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_EOS_Comments", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "EscalationEmailsNoti",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        email = table.Column<string>(maxLength: 100, nullable: false),
            //        dept = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        alarmLevel = table.Column<int>(nullable: false),
            //        modifieddate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        alarmType = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_EscalationEmailsNoti", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "EscalationLog",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        deptId = table.Column<int>(nullable: false),
            //        date = table.Column<DateTime>(type: "datetime", nullable: false),
            //        shift = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        line = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        part = table.Column<string>(maxLength: 50, nullable: false),
            //        gross = table.Column<int>(nullable: false),
            //        scrapcode = table.Column<int>(nullable: false),
            //        defectName = table.Column<string>(maxLength: 100, nullable: false),
            //        scrapQty = table.Column<int>(nullable: false),
            //        scrapRate = table.Column<decimal>(type: "decimal(18, 5)", nullable: false),
            //        mean = table.Column<decimal>(type: "decimal(18, 5)", nullable: false),
            //        std = table.Column<decimal>(type: "decimal(18, 5)", nullable: false),
            //        std1 = table.Column<decimal>(type: "decimal(18, 5)", nullable: false),
            //        std2 = table.Column<decimal>(type: "decimal(18, 5)", nullable: false),
            //        modifieddate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        alarmLevel = table.Column<int>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_EscalationLog", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "EscalationLog2",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        deptId = table.Column<int>(nullable: false),
            //        shiftDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        shift = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        machineId = table.Column<int>(nullable: false),
            //        defectId = table.Column<int>(nullable: false),
            //        scrapQty = table.Column<int>(nullable: false),
            //        alarmLevel = table.Column<int>(nullable: false),
            //        modifieddate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        page = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_EscalationLog2", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "EscalationMsg",
            //    columns: table => new
            //    {
            //        escalationMsgTitle = table.Column<string>(maxLength: 100, nullable: false),
            //        type = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        htmlEscalationMsg = table.Column<string>(nullable: false),
            //        modifieddate = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_EscalationMsg", x => x.escalationMsgTitle);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "EscalationReactions",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        escalationId = table.Column<int>(nullable: false),
            //        name = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        reactionComment = table.Column<string>(unicode: false, nullable: false),
            //        modifieddate = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_EscalationReactions", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Finance_DailyInput",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        date = table.Column<DateTime>(type: "datetime", nullable: false),
            //        pistonScrapDollars_mtd = table.Column<decimal>(type: "decimal(18, 5)", nullable: false),
            //        pisonScrapDollars_dailyAvg = table.Column<decimal>(type: "decimal(18, 5)", nullable: false),
            //        mroDollars_mtd = table.Column<decimal>(type: "decimal(18, 5)", nullable: false),
            //        mroDollars_dailyAvg = table.Column<decimal>(type: "decimal(18, 5)", nullable: false),
            //        foundry_units_mtd = table.Column<int>(nullable: false),
            //        mach_units_mtd = table.Column<int>(nullable: false),
            //        assy_units_mtd = table.Column<int>(nullable: false),
            //        DL_hoursWorked_mtd = table.Column<decimal>(type: "decimal(18, 5)", nullable: true),
            //        DL_hoursEarned_mtd = table.Column<decimal>(type: "decimal(18, 5)", nullable: true),
            //        comments = table.Column<string>(unicode: false, nullable: true),
            //        stamp = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Finance_DailyInput", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Finance_DailyKPI",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        date = table.Column<DateTime>(type: "datetime", nullable: false),
            //        type = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        mtd_cost = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
            //        daily_avg_cost = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
            //        unitsProduced = table.Column<int>(nullable: false),
            //        actual_cost_absorption = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
            //        target_cost_absorption = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
            //        reach_percent_absorption = table.Column<decimal>(type: "decimal(18, 5)", nullable: false),
            //        stamp = table.Column<DateTime>(type: "datetime", nullable: true),
            //        comment = table.Column<string>(unicode: false, maxLength: 500, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Finance_DailyKPI", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Finance_DeptFcst",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        year = table.Column<int>(nullable: false),
            //        monthNum = table.Column<int>(nullable: false),
            //        dept = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        totalUnitFcst = table.Column<int>(nullable: false),
            //        oaeFcst = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
            //        datetime = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Finance_DeptFcst", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Finance_Figures",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        year = table.Column<int>(nullable: false),
            //        sales_1000 = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
            //        ebitda_1000 = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
            //        stamp = table.Column<DateTime>(type: "datetime", nullable: false),
            //        monthNum = table.Column<int>(nullable: false),
            //        type = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Finance_Figures", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Finance_FlashProjections",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        year = table.Column<int>(nullable: false),
            //        monthNum = table.Column<int>(nullable: false),
            //        sales_1000 = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
            //        ebitda_1000 = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
            //        capitalFcst = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
            //        pistonScrapFcst_cost = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
            //        mroFcst_cost = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
            //        stamp = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Finance_FlashProjections", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Finance_LaborHours",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Name = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
            //        ID_ = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        Dept = table.Column<int>(nullable: true),
            //        GLAccount = table.Column<int>(nullable: true),
            //        Shift = table.Column<int>(nullable: true),
            //        DateIn = table.Column<DateTime>(type: "datetime", nullable: true),
            //        TimeIn = table.Column<TimeSpan>(nullable: true),
            //        DateOut = table.Column<DateTime>(type: "datetime", nullable: true),
            //        TimeOut = table.Column<TimeSpan>(nullable: true),
            //        Regular = table.Column<decimal>(type: "decimal(18, 5)", nullable: true),
            //        OtHalfTime = table.Column<decimal>(type: "decimal(18, 5)", nullable: true),
            //        Ot7d = table.Column<decimal>(type: "decimal(18, 5)", nullable: true),
            //        Overtime = table.Column<decimal>(type: "decimal(18, 5)", nullable: true),
            //        DoubleTime = table.Column<decimal>(type: "decimal(18, 5)", nullable: true),
            //        Orientation = table.Column<decimal>(type: "decimal(18, 5)", nullable: true),
            //        UploadTime = table.Column<DateTime>(type: "datetime", nullable: false),
            //        Type = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Finance_LaborHours", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Finance_PPMH",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        dept = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        month = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        target = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
            //        actual = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
            //        DLE = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
            //        stamp = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Finance_PPMH", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "FinVerification",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        hourId = table.Column<int>(nullable: false),
            //        value = table.Column<bool>(nullable: false),
            //        modifiedDate = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_FinVerification", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "FoundryCastingParamAccess",
            //    columns: table => new
            //    {
            //        UserName = table.Column<string>(maxLength: 50, nullable: false),
            //        Password = table.Column<string>(maxLength: 50, nullable: true),
            //        access = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_FoundryCastingParamAccess", x => x.UserName);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "FoundryCellCounter",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        hourId = table.Column<int>(nullable: false),
            //        startCount = table.Column<long>(nullable: false),
            //        endCount = table.Column<long>(nullable: false),
            //        stamp = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_FoundryCellCounter", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "FoundryParamAttachments_temp",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        fileName = table.Column<string>(unicode: false, maxLength: 500, nullable: false),
            //        contentType = table.Column<string>(unicode: false, maxLength: 500, nullable: false),
            //        data = table.Column<byte[]>(nullable: false),
            //        imageType = table.Column<string>(unicode: false, maxLength: 500, nullable: false),
            //        fndryParamId = table.Column<int>(nullable: false),
            //        modifiedData = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //    });

            //migrationBuilder.CreateTable(
            //    name: "FoundryParamAttachments_temp2",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        fileName = table.Column<string>(unicode: false, maxLength: 500, nullable: false),
            //        contentType = table.Column<string>(unicode: false, maxLength: 500, nullable: false),
            //        data = table.Column<byte[]>(nullable: false),
            //        imageType = table.Column<string>(unicode: false, maxLength: 500, nullable: false),
            //        fndryParamId = table.Column<int>(nullable: false),
            //        modifiedData = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //    });

            //migrationBuilder.CreateTable(
            //    name: "FoundryParamGroups",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        groupName = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        modifieddate = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_FoundryParamGroups", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "FoundryParamSheetIds",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        fmsbPart = table.Column<string>(maxLength: 50, nullable: false),
            //        customer = table.Column<string>(maxLength: 50, nullable: false),
            //        modifieddate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        revisionNumber = table.Column<int>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_FoundryParamSheetIds", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "FurnaceReplacementExt",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        furnaceReplacementId = table.Column<int>(nullable: false),
            //        machineId = table.Column<int>(nullable: false),
            //        side = table.Column<string>(unicode: false, maxLength: 1, nullable: false),
            //        shift = table.Column<string>(unicode: false, maxLength: 1, nullable: false),
            //        clockNum = table.Column<int>(nullable: false),
            //        isPreHeated = table.Column<bool>(nullable: false),
            //        comments = table.Column<string>(unicode: false, nullable: false),
            //        modifieddate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        dateReplaced = table.Column<DateTime>(type: "datetime", nullable: false),
            //        dateRemoved = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_FurnaceReplacementExt", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "FurnaceShellNumbers",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        shellNumber = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        mosToReplace = table.Column<int>(nullable: false),
            //        modifiedDate = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_FurnaceShellNumbers", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "HeatMapLoginRec",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        date = table.Column<DateTime>(type: "datetime", nullable: false),
            //        shift = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        part = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        defectName = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        clock = table.Column<int>(nullable: false),
            //        modifieddate = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_HeatMapLoginRec", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "HeatMapValues",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        heatMapLoginId = table.Column<int>(nullable: false),
            //        x_value = table.Column<int>(nullable: false),
            //        y_value = table.Column<int>(nullable: false),
            //        modifiedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        radius = table.Column<int>(nullable: false),
            //        value = table.Column<int>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_HeatMapValues", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "HourByHourEscalationActions",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        hourId = table.Column<int>(nullable: false),
            //        hour = table.Column<int>(nullable: false),
            //        action = table.Column<string>(unicode: false, nullable: true),
            //        owner = table.Column<string>(unicode: false, nullable: true),
            //        duedate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        modifieddate = table.Column<DateTime>(type: "datetime", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_HourByHourEscalationActions", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "HourReference",
            //    columns: table => new
            //    {
            //        HrNumber = table.Column<int>(nullable: false),
            //        time = table.Column<TimeSpan>(nullable: false),
            //        Shift = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Inspectors",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        clock = table.Column<int>(nullable: false),
            //        prodid = table.Column<int>(nullable: false),
            //        modifieddate = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Inspectors", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "logistics_customer",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        customer = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        comment = table.Column<string>(unicode: false, nullable: true),
            //        modifiedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        logisticsId = table.Column<int>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_logistics_customer", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "logistics_dollars",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        logisticsId = table.Column<int>(nullable: false),
            //        category = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
            //        actual = table.Column<decimal>(type: "decimal(18, 5)", nullable: true),
            //        target = table.Column<decimal>(type: "decimal(18, 5)", nullable: true),
            //        modifieDate = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_logistics_dollars", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "logistics_inventory",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        logisticsId = table.Column<int>(nullable: false),
            //        category = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
            //        qty = table.Column<int>(nullable: false),
            //        avg_days = table.Column<decimal>(type: "decimal(18, 5)", nullable: false),
            //        comments = table.Column<string>(unicode: false, nullable: true),
            //        modifiedDate = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_logistics_inventory", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "logistics_mm",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        date = table.Column<DateTime>(type: "datetime", nullable: true),
            //        modifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_logistics_mm", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "logistics_part_inv",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        partId = table.Column<int>(nullable: false),
            //        qty = table.Column<int>(nullable: true),
            //        daysOnHand = table.Column<decimal>(type: "decimal(18, 5)", nullable: true),
            //        modifiedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        logisticsId = table.Column<int>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_logistics_part_inv", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "logistics_scrap",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        inventoryScrapQty = table.Column<int>(nullable: true),
            //        inventoryScrapCost = table.Column<decimal>(type: "decimal(18, 5)", nullable: true),
            //        processScrapQty = table.Column<int>(nullable: true),
            //        processScrapCost = table.Column<decimal>(type: "decimal(18, 5)", nullable: true),
            //        modifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        costCenter = table.Column<int>(nullable: true),
            //        logisticsId = table.Column<int>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_logistics_scrap", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "logisticsParts",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        program = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        part = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        sort = table.Column<int>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_logisticsParts", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Mach_ToolBreakage",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        hourId = table.Column<int>(nullable: false),
            //        reason = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        supervisorClock = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        isGood = table.Column<bool>(nullable: false),
            //        stamp = table.Column<DateTime>(type: "datetime", nullable: false),
            //        machineNumber = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Mach_ToolBreakage", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Mach_ToolBreakageEmailRecipients",
            //    columns: table => new
            //    {
            //        email = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ToolBreakageEmailsRecipients", x => x.email);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "MachineCycleTimeMasterEntries",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        hourId = table.Column<int>(nullable: false),
            //        machineCycleTimeId = table.Column<int>(nullable: false),
            //        cycleTime = table.Column<decimal>(type: "decimal(18, 5)", nullable: true),
            //        stamp = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_MachineCycleTimeMasterEntries", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "MachineCycleTimeMasterRefs",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        machineName = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        machineId = table.Column<int>(nullable: false),
            //        target = table.Column<int>(nullable: true),
            //        cycle = table.Column<int>(nullable: false),
            //        stamp = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_MachineCycleTimeMasterRefs", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "MachineGroup",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        machineId = table.Column<int>(nullable: false),
            //        machineGroup = table.Column<string>(maxLength: 500, nullable: false),
            //        modifiedate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        isActive = table.Column<bool>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_MachineGroup", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "MachineGroupNumber",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        machineGroupId = table.Column<int>(nullable: false),
            //        machineNumber = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        modifieddate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        isActive = table.Column<bool>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_MachineGroupNumber", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "MachineLookup",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        mainMachineId = table.Column<int>(nullable: false),
            //        refMachineId = table.Column<int>(nullable: false),
            //        modifieddate = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_MachineLookup", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "MachiningDieNumber",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        hourId = table.Column<int>(nullable: false),
            //        hour = table.Column<int>(nullable: false),
            //        dieNumber = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        stamp = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_MachiningDieNumber", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "MachLineLoadLog",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        scrapId = table.Column<int>(nullable: false),
            //        bCode = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        modifieddate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        clorindo = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
            //        gsa = table.Column<bool>(nullable: true, defaultValueSql: "((0))")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_MachLineLoadLog", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "MM_Comments",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        dept = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        name = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
            //        issue = table.Column<string>(unicode: false, nullable: false),
            //        action = table.Column<string>(unicode: false, nullable: true),
            //        date = table.Column<DateTime>(type: "datetime", nullable: false),
            //        timeStamp = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_MM_Comments", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "MonitorScale",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        machId = table.Column<int>(nullable: false),
            //        width = table.Column<int>(nullable: false),
            //        height = table.Column<int>(nullable: false),
            //        modifieddate = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_MonitorScale", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "MorningMeetingCom",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        name = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        issue = table.Column<string>(unicode: false, nullable: true),
            //        action = table.Column<string>(unicode: false, nullable: true),
            //        timeStamp = table.Column<DateTime>(type: "datetime", nullable: false),
            //        date = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_MorningMeetingCom", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "OaeBootStrapClass",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        machineId = table.Column<int>(nullable: false),
            //        stat = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        percentage = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
            //        modifieddate = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_OaeBootStrapClass", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "OaeEmailRecipients",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        deptId = table.Column<int>(nullable: false),
            //        shift = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        alarmLevel = table.Column<int>(nullable: false),
            //        emailAddress = table.Column<string>(maxLength: 50, nullable: false),
            //        modifieddate = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_OaeEmailRecipients", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "OaeEscalationActions",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        oaeLogId = table.Column<int>(nullable: false),
            //        name = table.Column<string>(maxLength: 50, nullable: false),
            //        action = table.Column<string>(nullable: false),
            //        modifieddate = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_OaeEscalationActions", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "OaeEscalationLog",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        prodId = table.Column<int>(nullable: false),
            //        hour = table.Column<int>(nullable: false),
            //        alarmLevel = table.Column<int>(nullable: false),
            //        modifieddate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        occurence = table.Column<int>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_OaeEscalationLog", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "OaeEscalationSetting",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        machineId = table.Column<int>(nullable: false),
            //        alarmLevel = table.Column<int>(nullable: false),
            //        redStatusCount = table.Column<int>(nullable: false),
            //        yellowStatusCount = table.Column<int>(nullable: false),
            //        modifieddate = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_OaeEscalationSetting", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "OaeMachineOwners",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        machineId = table.Column<int>(nullable: false),
            //        owners = table.Column<string>(maxLength: 50, nullable: true),
            //        modifiedate = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_OaeMachineOwners", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ParallelMachines_Mach",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        machineId = table.Column<int>(nullable: false),
            //        divisor = table.Column<int>(nullable: false),
            //        modifieddate = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ParallelMachines_Mach", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "PartRefs",
            //    columns: table => new
            //    {
            //        part = table.Column<string>(maxLength: 50, nullable: true),
            //        correctPart = table.Column<string>(maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ProductionIssuesActions",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        date = table.Column<DateTime>(type: "datetime", nullable: false),
            //        shift = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        deptId = table.Column<int>(nullable: false),
            //        machineid = table.Column<int>(nullable: false),
            //        name = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        issue = table.Column<string>(unicode: false, nullable: false),
            //        actions = table.Column<string>(unicode: false, nullable: true),
            //        modifieddate = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ProductionIssuesActions", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ProgramRefs",
            //    columns: table => new
            //    {
            //        part = table.Column<string>(maxLength: 50, nullable: false),
            //        program = table.Column<string>(maxLength: 100, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ProgramRefs", x => x.part);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "PSO",
            //    columns: table => new
            //    {
            //        Id = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        name = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_PSO", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "RemoveGradeReference",
            //    columns: table => new
            //    {
            //        partwithsuffix = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        part = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_RemoveGradeReference", x => x.partwithsuffix);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "RodReclaim",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        date = table.Column<DateTime>(type: "datetime", nullable: false),
            //        shift = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        clockNum = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        partNum = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        qtyToReclaim = table.Column<int>(nullable: false),
            //        modifieddate = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_RodReclaim", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "RouteMachineId",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        deptId = table.Column<int>(nullable: true),
            //        machineId = table.Column<int>(nullable: true),
            //        machineIdRoute = table.Column<int>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_RouteMachineId", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "SapCompParts",
            //    columns: table => new
            //    {
            //        sapCompPart = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        description = table.Column<string>(unicode: false, maxLength: 100, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_SapCompParts", x => x.sapCompPart);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "SapCompPartsBom",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        sap_part = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        fm_part = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        sad_desc = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
            //        p1a = table.Column<string>(unicode: false, maxLength: 500, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_SapCompPartsBom", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "SapCostCenter",
            //    columns: table => new
            //    {
            //        Dept = table.Column<string>(maxLength: 50, nullable: false),
            //        CostCenter = table.Column<int>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_SapCostCenter", x => x.Dept);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ScrapRatesbyDefect_Foundry_copy",
            //    columns: table => new
            //    {
            //        deptName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        shiftdate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        shift = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        defectName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        Gross = table.Column<int>(nullable: true),
            //        qty = table.Column<int>(nullable: true),
            //        scrapRate = table.Column<decimal>(type: "decimal(18, 5)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ScrapRatesParts_Foundry_copy",
            //    columns: table => new
            //    {
            //        deptName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        shiftdate = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        shift = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        pn = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        Gross = table.Column<int>(nullable: true),
            //        qty = table.Column<int>(nullable: true),
            //        scrapRate = table.Column<decimal>(type: "decimal(18, 5)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ScrapViewName",
            //    columns: table => new
            //    {
            //        ScrapViewName = table.Column<string>(maxLength: 100, nullable: false),
            //        modifieddate = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ScrapViewName", x => x.ScrapViewName);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Shift",
            //    columns: table => new
            //    {
            //        Shift = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Shift", x => x.Shift);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "SkirtCoatScreenLife",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        hourId = table.Column<int>(nullable: false),
            //        hourNum = table.Column<int>(nullable: false),
            //        screenPartNum = table.Column<string>(unicode: false, maxLength: 500, nullable: false),
            //        meshNumber = table.Column<string>(unicode: false, maxLength: 500, nullable: false),
            //        meshColor = table.Column<string>(unicode: false, maxLength: 500, nullable: false),
            //        revDate = table.Column<string>(unicode: false, maxLength: 500, nullable: false),
            //        julianDate = table.Column<string>(unicode: false, maxLength: 500, nullable: false),
            //        startCount = table.Column<int>(nullable: true),
            //        endCount = table.Column<int>(nullable: true),
            //        dateTimeScanned = table.Column<DateTime>(type: "datetime", nullable: false),
            //        removalReason = table.Column<string>(unicode: false, nullable: true),
            //        scrapReason = table.Column<string>(unicode: false, nullable: true),
            //        status = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_SkirtCoatScreenLife", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "SWOT_NetTargetEscalation",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        swotTargetId = table.Column<int>(nullable: false),
            //        type = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        emailRecipients = table.Column<string>(unicode: false, maxLength: 1000, nullable: false),
            //        message = table.Column<string>(unicode: false, nullable: false),
            //        stamp = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_SWOT_NetTargetEscalation", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "SWOT_Profile",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        dept = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        profile = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        lines = table.Column<string>(unicode: false, maxLength: 500, nullable: false),
            //        stamp = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_SWOT_Profile", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "SWOT_Targets",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        machineId = table.Column<int>(nullable: false),
            //        oaeTarget = table.Column<decimal>(type: "decimal(18, 5)", nullable: false),
            //        targetPartsPerHour = table.Column<int>(nullable: false),
            //        stamp = table.Column<DateTime>(type: "datetime", nullable: false),
            //        foundryScrapTarget = table.Column<decimal>(type: "decimal(18, 5)", nullable: false),
            //        machineScrapTarget = table.Column<decimal>(type: "decimal(18, 5)", nullable: false),
            //        afScrapTarget = table.Column<decimal>(type: "decimal(18, 5)", nullable: false),
            //        isPriority = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
            //        component_count = table.Column<int>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_SWOT_Targets", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "TemporaryLevelGetterOae",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        prodId = table.Column<int>(nullable: true),
            //        alarmLevel = table.Column<int>(nullable: true),
            //        modifieddate = table.Column<DateTime>(type: "datetime", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_TemporaryLevelGetterOae", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Users",
            //    columns: table => new
            //    {
            //        fmid = table.Column<string>(maxLength: 50, nullable: false),
            //        fname = table.Column<string>(maxLength: 50, nullable: false),
            //        lname = table.Column<string>(maxLength: 50, nullable: false),
            //        deptid = table.Column<int>(nullable: false),
            //        shift = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        password = table.Column<string>(nullable: false),
            //        modifieddate = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Users", x => x.fmid);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "HourByHour",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        hour = table.Column<int>(nullable: false),
            //        pn = table.Column<string>(maxLength: 50, nullable: true),
            //        production = table.Column<int>(nullable: true),
            //        modifieddate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        cellSide_foundry = table.Column<string>(maxLength: 50, nullable: true),
            //        cavities_foundry = table.Column<int>(nullable: true),
            //        HourId = table.Column<int>(nullable: false),
            //        runningTotal = table.Column<int>(nullable: true),
            //        grossWithWarmers = table.Column<int>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_HourByHour", x => x.id);
            //        table.ForeignKey(
            //            name: "FK_HourByHour_CreateHxH",
            //            column: x => x.HourId,
            //            principalTable: "CreateHxH",
            //            principalColumn: "hrId",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "HxhOpsClockNum",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        clock = table.Column<int>(nullable: false),
            //        hxhid = table.Column<int>(nullable: false),
            //        modifieddate = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_HxhOpsClockNum", x => x.id);
            //        table.ForeignKey(
            //            name: "FK_HxhOpsClockNum_CreateHxH",
            //            column: x => x.hxhid,
            //            principalTable: "CreateHxH",
            //            principalColumn: "hrId",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ScrapHxh",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        hxhid = table.Column<int>(nullable: false),
            //        defectid = table.Column<int>(nullable: false),
            //        qty = table.Column<int>(nullable: false),
            //        comments = table.Column<string>(nullable: true),
            //        modifieddate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        hourNum = table.Column<int>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ScrapHxh", x => x.id);
            //        table.ForeignKey(
            //            name: "FK_ScrapHxh_CreateHxH",
            //            column: x => x.hxhid,
            //            principalTable: "CreateHxH",
            //            principalColumn: "hrId",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Defects",
            //    columns: table => new
            //    {
            //        defectId = table.Column<int>(nullable: false),
            //        defectName = table.Column<string>(unicode: false, maxLength: 500, nullable: false),
            //        defectDescription = table.Column<string>(nullable: true),
            //        modifieddate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        defectAreaId = table.Column<int>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Defects", x => x.defectId);
            //        table.ForeignKey(
            //            name: "FK_Defects_DefectArea",
            //            column: x => x.defectAreaId,
            //            principalTable: "DefectArea",
            //            principalColumn: "defectAreaId",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "DowntimeReason1",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        modifieddate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        deptId = table.Column<int>(nullable: false),
            //        reason1 = table.Column<string>(nullable: true),
            //        isActive = table.Column<bool>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_DowntimeReason1", x => x.id);
            //        table.ForeignKey(
            //            name: "FK_DowntimeReason1_Department",
            //            column: x => x.deptId,
            //            principalTable: "Department",
            //            principalColumn: "deptId",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "DowntimeReason2",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        reason2 = table.Column<string>(nullable: false),
            //        modifieddate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        deptId = table.Column<int>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_DowntimeReason2", x => x.id);
            //        table.ForeignKey(
            //            name: "FK_DowntimeReason2_Department",
            //            column: x => x.deptId,
            //            principalTable: "Department",
            //            principalColumn: "deptId",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Machines",
            //    columns: table => new
            //    {
            //        machineId = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        machineName = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        machineDesc = table.Column<string>(maxLength: 500, nullable: true),
            //        modifieddate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        deptId = table.Column<int>(nullable: false),
            //        MachineMapper = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
            //        lineNumber = table.Column<int>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Machines", x => x.machineId);
            //        table.ForeignKey(
            //            name: "FK_Machines_Department",
            //            column: x => x.deptId,
            //            principalTable: "Department",
            //            principalColumn: "deptId",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "FoundryParamCharacteristics",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        groupId = table.Column<int>(nullable: false),
            //        characteristics = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        modifieddate = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_FoundryParamCharacteristics", x => x.id);
            //        table.ForeignKey(
            //            name: "FK_FoundryParamCharacteristics_FoundryParamGroups",
            //            column: x => x.groupId,
            //            principalTable: "FoundryParamGroups",
            //            principalColumn: "id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "FoundryParamAttachments",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        fileName = table.Column<string>(unicode: false, maxLength: 500, nullable: false),
            //        contentType = table.Column<string>(unicode: false, maxLength: 500, nullable: false),
            //        data = table.Column<byte[]>(nullable: false),
            //        imageType = table.Column<string>(unicode: false, maxLength: 500, nullable: false),
            //        fndryParamId = table.Column<int>(nullable: false),
            //        modifiedData = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_FoundryParamAttachments", x => x.id);
            //        table.ForeignKey(
            //            name: "FK_FoundryParamAttachments_FoundryParamSheetIds",
            //            column: x => x.fndryParamId,
            //            principalTable: "FoundryParamSheetIds",
            //            principalColumn: "id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "FurnaceRebuild",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        furnaceShellid = table.Column<int>(nullable: false),
            //        isFurnaceReady = table.Column<bool>(nullable: false),
            //        date = table.Column<DateTime>(type: "datetime", nullable: false),
            //        clockNum = table.Column<int>(nullable: false),
            //        comment = table.Column<string>(unicode: false, nullable: false),
            //        thingsToLookFor = table.Column<string>(unicode: false, nullable: true),
            //        timeStamp = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_FurnaceRebuild", x => x.id);
            //        table.ForeignKey(
            //            name: "FK_FurnaceRebuild_FurnaceShellNumbers",
            //            column: x => x.furnaceShellid,
            //            principalTable: "FurnaceShellNumbers",
            //            principalColumn: "id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "DowntimeReason2.1",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        deptid = table.Column<int>(nullable: false),
            //        reason1id = table.Column<int>(nullable: false),
            //        reason2 = table.Column<string>(maxLength: 500, nullable: false),
            //        modifieddate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        isActive = table.Column<bool>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_DowntimeReason2.1", x => x.id);
            //        table.ForeignKey(
            //            name: "FK_DowntimeReason2.1_Department",
            //            column: x => x.deptid,
            //            principalTable: "Department",
            //            principalColumn: "deptId",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_DowntimeReason2.1_DowntimeReason1",
            //            column: x => x.reason1id,
            //            principalTable: "DowntimeReason1",
            //            principalColumn: "id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "FurnaceReplacement",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        shiftDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        furnaceShellId = table.Column<int>(nullable: false),
            //        machineId = table.Column<int>(nullable: false),
            //        side = table.Column<string>(unicode: false, maxLength: 1, nullable: false),
            //        isPreHeated = table.Column<bool>(nullable: false),
            //        shift = table.Column<string>(unicode: false, maxLength: 2, nullable: false),
            //        clockNum = table.Column<int>(nullable: false),
            //        comments = table.Column<string>(unicode: false, nullable: true),
            //        modifiedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        status = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        usedDays = table.Column<int>(nullable: true, defaultValueSql: "((0))")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_FurnaceReplacement", x => x.id);
            //        table.ForeignKey(
            //            name: "FK_FurnaceReplacement_FurnaceShellNumbers",
            //            column: x => x.furnaceShellId,
            //            principalTable: "FurnaceShellNumbers",
            //            principalColumn: "id",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_FurnaceReplacement_Machines",
            //            column: x => x.machineId,
            //            principalTable: "Machines",
            //            principalColumn: "machineId",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Prod",
            //    columns: table => new
            //    {
            //        prodId = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        deptId = table.Column<int>(nullable: false),
            //        machineId = table.Column<int>(nullable: false),
            //        shiftDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        shift = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        gross = table.Column<int>(nullable: true),
            //        approved = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
            //        comments = table.Column<string>(nullable: true),
            //        modifieddate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        part = table.Column<string>(nullable: false),
            //        clockNumber = table.Column<int>(nullable: false),
            //        runtime = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
            //        cell = table.Column<string>(maxLength: 50, nullable: true),
            //        die = table.Column<string>(maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Prod", x => x.prodId);
            //        table.ForeignKey(
            //            name: "FK_Prod_Department",
            //            column: x => x.deptId,
            //            principalTable: "Department",
            //            principalColumn: "deptId",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_Prod_Machines",
            //            column: x => x.machineId,
            //            principalTable: "Machines",
            //            principalColumn: "machineId",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_Prod_Shift",
            //            column: x => x.shift,
            //            principalTable: "Shift",
            //            principalColumn: "Shift",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ProdScrap",
            //    columns: table => new
            //    {
            //        prodScrapId = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        deptId = table.Column<int>(nullable: false),
            //        machineId = table.Column<int>(nullable: false),
            //        defectId = table.Column<int>(nullable: false),
            //        shiftDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        shift = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        qty = table.Column<int>(nullable: true),
            //        comments = table.Column<string>(nullable: true),
            //        prodId = table.Column<int>(nullable: true),
            //        modifieddate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        part = table.Column<string>(nullable: false),
            //        defectAreaId = table.Column<int>(nullable: false),
            //        cellNumber = table.Column<string>(maxLength: 50, nullable: true),
            //        dieNumber = table.Column<string>(maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ProdScrap", x => x.prodScrapId);
            //        table.ForeignKey(
            //            name: "FK_ProdScrap_DefectArea",
            //            column: x => x.defectAreaId,
            //            principalTable: "DefectArea",
            //            principalColumn: "defectAreaId",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_ProdScrap_Defects",
            //            column: x => x.defectId,
            //            principalTable: "Defects",
            //            principalColumn: "defectId",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_ProdScrap_Department",
            //            column: x => x.deptId,
            //            principalTable: "Department",
            //            principalColumn: "deptId",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_ProdScrap_Machines",
            //            column: x => x.machineId,
            //            principalTable: "Machines",
            //            principalColumn: "machineId",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_ProdScrap_Shift",
            //            column: x => x.shift,
            //            principalTable: "Shift",
            //            principalColumn: "Shift",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ScrapView",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        deptId = table.Column<int>(nullable: false),
            //        defectAreaId = table.Column<int>(nullable: false),
            //        defectId = table.Column<int>(nullable: false),
            //        modifieddate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        machineId = table.Column<int>(nullable: false),
            //        viewName = table.Column<string>(maxLength: 100, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ScrapView", x => x.id);
            //        table.ForeignKey(
            //            name: "FK_ScrapView_DefectArea",
            //            column: x => x.defectAreaId,
            //            principalTable: "DefectArea",
            //            principalColumn: "defectAreaId",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_ScrapView_Defects",
            //            column: x => x.defectId,
            //            principalTable: "Defects",
            //            principalColumn: "defectId",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_ScrapView_Department",
            //            column: x => x.deptId,
            //            principalTable: "Department",
            //            principalColumn: "deptId",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_ScrapView_Machines",
            //            column: x => x.machineId,
            //            principalTable: "Machines",
            //            principalColumn: "machineId",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_ScrapView_ScrapViewName",
            //            column: x => x.viewName,
            //            principalTable: "ScrapViewName",
            //            principalColumn: "ScrapViewName",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "FoundryParamSheets",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        characteristicId = table.Column<int>(nullable: false),
            //        value = table.Column<string>(unicode: false, maxLength: 500, nullable: false),
            //        notes = table.Column<string>(unicode: false, nullable: true),
            //        modifieddate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        paramId = table.Column<int>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_FoundryParamSheets", x => x.id);
            //        table.ForeignKey(
            //            name: "FK_FoundryParamSheets_FoundryParamCharacteristics",
            //            column: x => x.characteristicId,
            //            principalTable: "FoundryParamCharacteristics",
            //            principalColumn: "id",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_FoundryParamSheets_FoundryParamSheetIds",
            //            column: x => x.paramId,
            //            principalTable: "FoundryParamSheetIds",
            //            principalColumn: "id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "NonClusteredIndex-20171108-154232",
            //    table: "ActualCycles",
            //    columns: new[] { "hourid", "hourNum" });

            //migrationBuilder.CreateIndex(
            //    name: "NonClusteredIndex-20171108-154214",
            //    table: "AuthorizeClocks",
            //    columns: new[] { "clocknum", "machineId" });

            //migrationBuilder.CreateIndex(
            //    name: "NonClusteredIndex-20171108-154302",
            //    table: "ComponentReference",
            //    columns: new[] { "defectid", "machineid" });

            //migrationBuilder.CreateIndex(
            //    name: "NonClusteredIndex-20171108-153906",
            //    table: "CreateHxH",
            //    columns: new[] { "deptid", "machineid" });

            //migrationBuilder.CreateIndex(
            //    name: "NonClusteredIndex-20171108-154323",
            //    table: "CycleTime",
            //    columns: new[] { "machineId", "part" });

            //migrationBuilder.CreateIndex(
            //    name: "NonClusteredIndex-20171108-154151",
            //    table: "DefectArea",
            //    column: "defectArea");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Defects_defectAreaId",
            //    table: "Defects",
            //    column: "defectAreaId");

            //migrationBuilder.CreateIndex(
            //    name: "NonClusteredIndex-20171108-154131",
            //    table: "Defects",
            //    columns: new[] { "defectName", "defectAreaId" });

            //migrationBuilder.CreateIndex(
            //    name: "NonClusteredIndex-20171108-154106",
            //    table: "Department",
            //    column: "deptName");

            //migrationBuilder.CreateIndex(
            //    name: "NonClusteredIndex-20171108-154431",
            //    table: "Downtime",
            //    columns: new[] { "hxhId", "reason1Id", "reason2Id", "machineGroupId", "machineNumberId" });

            //migrationBuilder.CreateIndex(
            //    name: "NonClusteredIndex-20171108-154512",
            //    table: "DowntimeReason1",
            //    column: "deptId");

            //migrationBuilder.CreateIndex(
            //    name: "NonClusteredIndex-20171108-154528",
            //    table: "DowntimeReason2",
            //    column: "deptId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_DowntimeReason2.1_reason1id",
            //    table: "DowntimeReason2.1",
            //    column: "reason1id");

            //migrationBuilder.CreateIndex(
            //    name: "NonClusteredIndex-20171111-132126",
            //    table: "DowntimeReason2.1",
            //    columns: new[] { "deptid", "reason1id", "reason2" });

            //migrationBuilder.CreateIndex(
            //    name: "IX_FoundryParamAttachments_fndryParamId",
            //    table: "FoundryParamAttachments",
            //    column: "fndryParamId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_FoundryParamCharacteristics_groupId",
            //    table: "FoundryParamCharacteristics",
            //    column: "groupId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_FoundryParamSheets_characteristicId",
            //    table: "FoundryParamSheets",
            //    column: "characteristicId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_FoundryParamSheets_paramId",
            //    table: "FoundryParamSheets",
            //    column: "paramId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_FurnaceRebuild_furnaceShellid",
            //    table: "FurnaceRebuild",
            //    column: "furnaceShellid");

            //migrationBuilder.CreateIndex(
            //    name: "IX_FurnaceReplacement_furnaceShellId",
            //    table: "FurnaceReplacement",
            //    column: "furnaceShellId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_FurnaceReplacement_machineId",
            //    table: "FurnaceReplacement",
            //    column: "machineId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_HourByHour_HourId",
            //    table: "HourByHour",
            //    column: "HourId");

            //migrationBuilder.CreateIndex(
            //    name: "NonClusteredIndex-20171108-154610",
            //    table: "HourByHour",
            //    columns: new[] { "hour", "pn", "HourId" });

            //migrationBuilder.CreateIndex(
            //    name: "IX_HxhOpsClockNum_hxhid",
            //    table: "HxhOpsClockNum",
            //    column: "hxhid");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Machines_deptId",
            //    table: "Machines",
            //    column: "deptId");

            //migrationBuilder.CreateIndex(
            //    name: "NonClusteredIndex-20171108-153956",
            //    table: "Machines",
            //    columns: new[] { "machineName", "deptId" });

            //migrationBuilder.CreateIndex(
            //    name: "IX_Prod_deptId",
            //    table: "Prod",
            //    column: "deptId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Prod_machineId",
            //    table: "Prod",
            //    column: "machineId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Prod_shift",
            //    table: "Prod",
            //    column: "shift");

            //migrationBuilder.CreateIndex(
            //    name: "IX_ProdScrap_defectAreaId",
            //    table: "ProdScrap",
            //    column: "defectAreaId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_ProdScrap_defectId",
            //    table: "ProdScrap",
            //    column: "defectId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_ProdScrap_deptId",
            //    table: "ProdScrap",
            //    column: "deptId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_ProdScrap_machineId",
            //    table: "ProdScrap",
            //    column: "machineId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_ProdScrap_shift",
            //    table: "ProdScrap",
            //    column: "shift");

            //migrationBuilder.CreateIndex(
            //    name: "NonClusteredIndex-20171108-153825",
            //    table: "ScrapHxh",
            //    columns: new[] { "hxhid", "defectid", "hourNum" });

            //migrationBuilder.CreateIndex(
            //    name: "IX_ScrapView_defectAreaId",
            //    table: "ScrapView",
            //    column: "defectAreaId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_ScrapView_defectId",
            //    table: "ScrapView",
            //    column: "defectId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_ScrapView_machineId",
            //    table: "ScrapView",
            //    column: "machineId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_ScrapView_viewName",
            //    table: "ScrapView",
            //    column: "viewName");

            //migrationBuilder.CreateIndex(
            //    name: "NonClusteredIndex-20171108-154704",
            //    table: "ScrapView",
            //    columns: new[] { "deptId", "defectAreaId", "defectId", "machineId", "viewName" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "24Hours");

            migrationBuilder.DropTable(
                name: "ActionImprovementList");

            migrationBuilder.DropTable(
                name: "ActualCycles");

            migrationBuilder.DropTable(
                name: "AssemblyChangeover");

            migrationBuilder.DropTable(
                name: "Attachments");

            migrationBuilder.DropTable(
                name: "AuthorizeClocks");

            migrationBuilder.DropTable(
                name: "CellCavities");

            migrationBuilder.DropTable(
                name: "ChecksExist");

            migrationBuilder.DropTable(
                name: "CheckSheet");

            migrationBuilder.DropTable(
                name: "ChecksheetResult");

            migrationBuilder.DropTable(
                name: "ComponentGroup");

            migrationBuilder.DropTable(
                name: "ComponentRecords");

            migrationBuilder.DropTable(
                name: "ComponentReference");

            migrationBuilder.DropTable(
                name: "ComponentTraceability");

            migrationBuilder.DropTable(
                name: "ComponentTypeReference");

            migrationBuilder.DropTable(
                name: "componentTypes");

            migrationBuilder.DropTable(
                name: "CostCenter_SAP");

            migrationBuilder.DropTable(
                name: "CycleTime");

            migrationBuilder.DropTable(
                name: "DashBoardPlannedDown");

            migrationBuilder.DropTable(
                name: "DefectEscalation");

            migrationBuilder.DropTable(
                name: "DefectGroup");

            migrationBuilder.DropTable(
                name: "DepartmentalComments");

            migrationBuilder.DropTable(
                name: "DeptReferences");

            migrationBuilder.DropTable(
                name: "DeptReferences2");

            migrationBuilder.DropTable(
                name: "Downtime");

            migrationBuilder.DropTable(
                name: "DowntimeDataList2_Copy");

            migrationBuilder.DropTable(
                name: "DowntimeReason2");

            migrationBuilder.DropTable(
                name: "DowntimeReason2.1");

            migrationBuilder.DropTable(
                name: "DowntimeReportRecipient");

            migrationBuilder.DropTable(
                name: "DowntimeReportRecipients");

            migrationBuilder.DropTable(
                name: "EmailNotification");

            migrationBuilder.DropTable(
                name: "EnableDisableEscalation");

            migrationBuilder.DropTable(
                name: "EOS_Comments");

            migrationBuilder.DropTable(
                name: "EscalationEmailsNoti");

            migrationBuilder.DropTable(
                name: "EscalationLog");

            migrationBuilder.DropTable(
                name: "EscalationLog2");

            migrationBuilder.DropTable(
                name: "EscalationMsg");

            migrationBuilder.DropTable(
                name: "EscalationReactions");

            migrationBuilder.DropTable(
                name: "Finance_DailyInput");

            migrationBuilder.DropTable(
                name: "Finance_DailyKPI");

            migrationBuilder.DropTable(
                name: "Finance_DeptFcst");

            migrationBuilder.DropTable(
                name: "Finance_Figures");

            migrationBuilder.DropTable(
                name: "Finance_FlashProjections");

            migrationBuilder.DropTable(
                name: "Finance_LaborHours");

            migrationBuilder.DropTable(
                name: "Finance_PPMH");

            migrationBuilder.DropTable(
                name: "FinVerification");

            migrationBuilder.DropTable(
                name: "FoundryCastingParamAccess");

            migrationBuilder.DropTable(
                name: "FoundryCellCounter");

            migrationBuilder.DropTable(
                name: "FoundryParamAttachments");

            migrationBuilder.DropTable(
                name: "FoundryParamAttachments_temp");

            migrationBuilder.DropTable(
                name: "FoundryParamAttachments_temp2");

            migrationBuilder.DropTable(
                name: "FoundryParamSheets");

            migrationBuilder.DropTable(
                name: "FurnaceRebuild");

            migrationBuilder.DropTable(
                name: "FurnaceReplacement");

            migrationBuilder.DropTable(
                name: "FurnaceReplacementExt");

            migrationBuilder.DropTable(
                name: "HeatMapLoginRec");

            migrationBuilder.DropTable(
                name: "HeatMapValues");

            migrationBuilder.DropTable(
                name: "HourByHour");

            migrationBuilder.DropTable(
                name: "HourByHourEscalationActions");

            migrationBuilder.DropTable(
                name: "HourReference");

            migrationBuilder.DropTable(
                name: "HxhOpsClockNum");

            migrationBuilder.DropTable(
                name: "Inspectors");

            migrationBuilder.DropTable(
                name: "logistics_customer");

            migrationBuilder.DropTable(
                name: "logistics_dollars");

            migrationBuilder.DropTable(
                name: "logistics_inventory");

            migrationBuilder.DropTable(
                name: "logistics_mm");

            migrationBuilder.DropTable(
                name: "logistics_part_inv");

            migrationBuilder.DropTable(
                name: "logistics_scrap");

            migrationBuilder.DropTable(
                name: "logisticsParts");

            migrationBuilder.DropTable(
                name: "Mach_ToolBreakage");

            migrationBuilder.DropTable(
                name: "Mach_ToolBreakageEmailRecipients");

            migrationBuilder.DropTable(
                name: "MachineCycleTimeMasterEntries");

            migrationBuilder.DropTable(
                name: "MachineCycleTimeMasterRefs");

            migrationBuilder.DropTable(
                name: "MachineGroup");

            migrationBuilder.DropTable(
                name: "MachineGroupNumber");

            migrationBuilder.DropTable(
                name: "MachineLookup");

            migrationBuilder.DropTable(
                name: "MachiningDieNumber");

            migrationBuilder.DropTable(
                name: "MachLineLoadLog");

            migrationBuilder.DropTable(
                name: "MM_Comments");

            migrationBuilder.DropTable(
                name: "MonitorScale");

            migrationBuilder.DropTable(
                name: "MorningMeetingCom");

            migrationBuilder.DropTable(
                name: "OaeBootStrapClass");

            migrationBuilder.DropTable(
                name: "OaeEmailRecipients");

            migrationBuilder.DropTable(
                name: "OaeEscalationActions");

            migrationBuilder.DropTable(
                name: "OaeEscalationLog");

            migrationBuilder.DropTable(
                name: "OaeEscalationSetting");

            migrationBuilder.DropTable(
                name: "OaeMachineOwners");

            migrationBuilder.DropTable(
                name: "ParallelMachines_Mach");

            migrationBuilder.DropTable(
                name: "PartRefs");

            migrationBuilder.DropTable(
                name: "Prod");

            migrationBuilder.DropTable(
                name: "ProdScrap");

            migrationBuilder.DropTable(
                name: "ProductionIssuesActions");

            migrationBuilder.DropTable(
                name: "ProgramRefs");

            migrationBuilder.DropTable(
                name: "PSO");

            migrationBuilder.DropTable(
                name: "RemoveGradeReference");

            migrationBuilder.DropTable(
                name: "RodReclaim");

            migrationBuilder.DropTable(
                name: "RouteMachineId");

            migrationBuilder.DropTable(
                name: "SapCompParts");

            migrationBuilder.DropTable(
                name: "SapCompPartsBom");

            migrationBuilder.DropTable(
                name: "SapCostCenter");

            migrationBuilder.DropTable(
                name: "ScrapHxh");

            migrationBuilder.DropTable(
                name: "ScrapRatesbyDefect_Foundry_copy");

            migrationBuilder.DropTable(
                name: "ScrapRatesParts_Foundry_copy");

            migrationBuilder.DropTable(
                name: "ScrapView");

            migrationBuilder.DropTable(
                name: "SkirtCoatScreenLife");

            migrationBuilder.DropTable(
                name: "SWOT_NetTargetEscalation");

            migrationBuilder.DropTable(
                name: "SWOT_Profile");

            migrationBuilder.DropTable(
                name: "SWOT_Targets");

            migrationBuilder.DropTable(
                name: "TemporaryLevelGetterOae");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "DowntimeReason1");

            migrationBuilder.DropTable(
                name: "FoundryParamCharacteristics");

            migrationBuilder.DropTable(
                name: "FoundryParamSheetIds");

            migrationBuilder.DropTable(
                name: "FurnaceShellNumbers");

            migrationBuilder.DropTable(
                name: "Shift");

            migrationBuilder.DropTable(
                name: "CreateHxH");

            migrationBuilder.DropTable(
                name: "Defects");

            migrationBuilder.DropTable(
                name: "Machines");

            migrationBuilder.DropTable(
                name: "ScrapViewName");

            migrationBuilder.DropTable(
                name: "FoundryParamGroups");

            migrationBuilder.DropTable(
                name: "DefectArea");

            migrationBuilder.DropTable(
                name: "Department");
        }
    }
}
