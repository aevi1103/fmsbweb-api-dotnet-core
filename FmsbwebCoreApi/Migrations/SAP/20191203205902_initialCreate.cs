using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FmsbwebCoreApi.Migrations.SAP
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "AvgShipDayPart",
            //    columns: table => new
            //    {
            //        material = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
            //        avg_ship_day = table.Column<int>(nullable: true, defaultValueSql: "((0))"),
            //        show = table.Column<bool>(nullable: true, defaultValueSql: "((1))"),
            //        skidQty = table.Column<int>(nullable: true, defaultValueSql: "((0))")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AvgShipDayPart", x => x.material);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "DmaxParts",
            //    columns: table => new
            //    {
            //        material_dmax = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_DmaxParts", x => x.material_dmax);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Escalation_Message",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Name = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        Message = table.Column<string>(unicode: false, nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Escalation_Message", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Escalation_Recipients",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        DeptName = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        Name = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        Shift = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        EmailRecipients = table.Column<string>(unicode: false, nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Escalation_Recipients", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ExcludedProgram",
            //    columns: table => new
            //    {
            //        Program = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        Stamp = table.Column<byte[]>(rowVersion: true, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ExcludedProgram", x => x.Program);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "InvProgramTargets",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        program = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        SLOC = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        min = table.Column<int>(nullable: false),
            //        max = table.Column<int>(nullable: false),
            //        stamp = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_InvProgramTargets", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "KPI_Targets",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false),
            //        deptId = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        kpi = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        min = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
            //        max = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
            //        modifiedDate = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_KPI_Targets", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "MachineMapping",
            //    columns: table => new
            //    {
            //        machine = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
            //        machine_hxh = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
            //        side = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        Department = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        Area = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        line = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        deptid = table.Column<int>(nullable: true),
            //        machineId = table.Column<int>(nullable: true),
            //        MachineMapping = table.Column<string>(unicode: false, maxLength: 20, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_MachineMapping", x => x.machine);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Production",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        WorkCenter = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
            //        OrderNumber = table.Column<long>(nullable: false),
            //        EnteredDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        EnteredTime = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        Material = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
            //        EnteredUser = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
            //        Yield = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
            //        UoM = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        UK_DateTime = table.Column<DateTime>(type: "datetime", nullable: true),
            //        LocalDateTime = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ShiftDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Shift = table.Column<string>(unicode: false, maxLength: 5, nullable: true),
            //        shiftDate_8 = table.Column<DateTime>(type: "datetime", nullable: true),
            //        shift_8 = table.Column<int>(nullable: true),
            //        isFiveDayShift = table.Column<bool>(nullable: true),
            //        ExportFileName = table.Column<string>(unicode: false, maxLength: 200, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Production", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Production_Temp",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        WorkCenter = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
            //        OrderNumber = table.Column<long>(nullable: false),
            //        EnteredDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        EnteredTime = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        Material = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
            //        EnteredUser = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
            //        Yield = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
            //        UoM = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        UK_DateTime = table.Column<DateTime>(type: "datetime", nullable: true),
            //        LocalDateTime = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ShiftDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Shift = table.Column<string>(unicode: false, maxLength: 5, nullable: true),
            //        shiftDate_8 = table.Column<DateTime>(type: "datetime", nullable: true),
            //        shift_8 = table.Column<int>(nullable: true),
            //        isFiveDayShift = table.Column<bool>(nullable: true),
            //        ExportFileName = table.Column<string>(unicode: false, maxLength: 200, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Production_Temp", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "SAP_Dump_New",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Material = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        TotalUnrestInv = table.Column<decimal>(name: "Total Unrest. Inv.", type: "decimal(18, 2)", nullable: true),
            //        _0111 = table.Column<decimal>(name: "0111", type: "decimal(18, 2)", nullable: true),
            //        _0115 = table.Column<decimal>(name: "0115", type: "decimal(18, 2)", nullable: true),
            //        _4001 = table.Column<decimal>(name: "4001", type: "decimal(18, 2)", nullable: true),
            //        _4002 = table.Column<decimal>(name: "4002", type: "decimal(18, 2)", nullable: true),
            //        _4003 = table.Column<decimal>(name: "4003", type: "decimal(18, 2)", nullable: true),
            //        _4004 = table.Column<decimal>(name: "4004", type: "decimal(18, 2)", nullable: true),
            //        _4005 = table.Column<decimal>(name: "4005", type: "decimal(18, 2)", nullable: true),
            //        _4006 = table.Column<decimal>(name: "4006", type: "decimal(18, 2)", nullable: true),
            //        _4007 = table.Column<decimal>(name: "4007", type: "decimal(18, 2)", nullable: true),
            //        _4008 = table.Column<decimal>(name: "4008", type: "decimal(18, 2)", nullable: true),
            //        _4009 = table.Column<decimal>(name: "4009", type: "decimal(18, 2)", nullable: true),
            //        _4010 = table.Column<decimal>(name: "4010", type: "decimal(18, 2)", nullable: true),
            //        _5001 = table.Column<decimal>(name: "5001", type: "decimal(18, 2)", nullable: true),
            //        _5002 = table.Column<decimal>(name: "5002", type: "decimal(18, 2)", nullable: true),
            //        _5003 = table.Column<decimal>(name: "5003", type: "decimal(18, 2)", nullable: true),
            //        _5004 = table.Column<decimal>(name: "5004", type: "decimal(18, 2)", nullable: true),
            //        _5005 = table.Column<decimal>(name: "5005", type: "decimal(18, 2)", nullable: true),
            //        _5006 = table.Column<decimal>(name: "5006", type: "decimal(18, 2)", nullable: true),
            //        _5007 = table.Column<decimal>(name: "5007", type: "decimal(18, 2)", nullable: true),
            //        _5008 = table.Column<decimal>(name: "5008", type: "decimal(18, 2)", nullable: true),
            //        _5009 = table.Column<decimal>(name: "5009", type: "decimal(18, 2)", nullable: true),
            //        _5010 = table.Column<decimal>(name: "5010", type: "decimal(18, 2)", nullable: true),
            //        QC01 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
            //        QC02 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
            //        _0130 = table.Column<decimal>(name: "0130", type: "decimal(18, 2)", nullable: true),
            //        _0131 = table.Column<decimal>(name: "0131", type: "decimal(18, 2)", nullable: true),
            //        _0135 = table.Column<decimal>(name: "0135", type: "decimal(18, 2)", nullable: true),
            //        _0160 = table.Column<decimal>(name: "0160", type: "decimal(18, 2)", nullable: true),
            //        _0300 = table.Column<decimal>(name: "0300", type: "decimal(18, 2)", nullable: true),
            //        _0125 = table.Column<decimal>(name: "0125", type: "decimal(18, 2)", nullable: true),
            //        _0140 = table.Column<decimal>(name: "0140", type: "decimal(18, 2)", nullable: true),
            //        Standardprice = table.Column<decimal>(name: "Standard price", type: "decimal(18, 2)", nullable: true),
            //        per = table.Column<int>(nullable: true),
            //        ValuationClass = table.Column<string>(name: "Valuation Class", unicode: false, maxLength: 100, nullable: true),
            //        MaterialDescription = table.Column<string>(name: "Material Description", unicode: false, maxLength: 100, nullable: true),
            //        Program = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
            //        uploadDateTime = table.Column<DateTime>(type: "datetime", nullable: true),
            //        date = table.Column<DateTime>(type: "datetime", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_SAP_Dump_New", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "SAP_Dump2",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Material = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
            //        TotalUnrestInv = table.Column<decimal>(name: "Total Unrest. Inv.", type: "decimal(18, 2)", nullable: true),
            //        _0100RawPistonsP7s = table.Column<decimal>(name: "0100 Raw Pistons (P7's)", type: "decimal(18, 2)", nullable: true),
            //        _0105AssyComponents = table.Column<decimal>(name: "0105 Assy Components", type: "decimal(18, 2)", nullable: true),
            //        _0108Protocompts = table.Column<decimal>(name: "0108  Proto compts", type: "decimal(18, 2)", nullable: true),
            //        _0109SBTrcomponents = table.Column<decimal>(name: "0109 SB Tr components", type: "decimal(18, 2)", nullable: true),
            //        _01150120 = table.Column<decimal>(name: "01150120", type: "decimal(18, 2)", nullable: true),
            //        _0125Machlineside = table.Column<decimal>(name: "0125 Mach lineside", type: "decimal(18, 2)", nullable: true),
            //        _0128Protolineside = table.Column<decimal>(name: "0128 Proto line side", type: "decimal(18, 2)", nullable: true),
            //        _0130machinedpistonsP3M = table.Column<decimal>(name: "0130 machined pistons (P3M)", type: "decimal(18, 2)", nullable: true),
            //        _0135completednotinshipping = table.Column<decimal>(name: "0135 completed not in shipping", type: "decimal(18, 2)", nullable: true),
            //        _0136AFoverflow = table.Column<decimal>(name: "0136 A & F overflow", type: "decimal(18, 2)", nullable: true),
            //        _0137MBpistonsP2F = table.Column<decimal>(name: "0137 MB pistons P2F", type: "decimal(18, 2)", nullable: true),
            //        _0140Componentsassy = table.Column<decimal>(name: "0140 Components assy", type: "decimal(18, 2)", nullable: true),
            //        _0149SBtrcomponentsassy = table.Column<decimal>(name: "0149 SB tr components assy", type: "decimal(18, 2)", nullable: true),
            //        _0160QCBusstop = table.Column<decimal>(name: "0160 QC Bus stop", type: "decimal(18, 2)", nullable: true),
            //        _0161QCSuspectHold = table.Column<decimal>(name: "0161 QC Suspect Hold", type: "decimal(18, 2)", nullable: true),
            //        _0162QCPPAPHold = table.Column<decimal>(name: "0162 QC PPAP Hold", type: "decimal(18, 2)", nullable: true),
            //        _0163GP12 = table.Column<decimal>(name: "0163 GP12", type: "decimal(18, 2)", nullable: true),
            //        _0164MBHoldarea = table.Column<decimal>(name: "0164 MB Hold area", type: "decimal(18, 2)", nullable: true),
            //        _0165scrap = table.Column<decimal>(name: "0165 scrap", type: "decimal(18, 2)", nullable: true),
            //        _0169SBTrHold = table.Column<decimal>(name: "0169 SB Tr Hold", type: "decimal(18, 2)", nullable: true),
            //        _0300FingdsSB = table.Column<decimal>(name: "0300 Fin gds SB", type: "decimal(18, 2)", nullable: true),
            //        _0303FGMB = table.Column<decimal>(name: "0303 FG MB", type: "decimal(18, 2)", nullable: true),
            //        _0305HodgeFG = table.Column<decimal>(name: "0305 Hodge FG", type: "decimal(18, 2)", nullable: true),
            //        _0309FGSBTr = table.Column<decimal>(name: "0309 FG SB Tr", type: "decimal(18, 2)", nullable: true),
            //        _0400Intransit = table.Column<decimal>(name: "0400 In transit", type: "decimal(18, 2)", nullable: true),
            //        _0403MBWIP = table.Column<decimal>(name: "0403 MB WIP", type: "decimal(18, 2)", nullable: true),
            //        UnrstSLOC7000 = table.Column<decimal>(name: "Unrst. SLOC 7000", type: "decimal(18, 2)", nullable: true),
            //        Standardprice = table.Column<decimal>(name: "Standard price", type: "decimal(18, 2)", nullable: true),
            //        per = table.Column<int>(nullable: true),
            //        ValuationClass = table.Column<string>(name: "Valuation Class", unicode: false, maxLength: 100, nullable: true),
            //        MaterialDescription = table.Column<string>(name: "Material Description", unicode: false, nullable: true),
            //        uploadDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
            //        date = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_SAP_Dump2", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "SAP_ProdOrders",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Order = table.Column<long>(nullable: true),
            //        Activity = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        WorkCenter = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        OperationsShortText = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
            //        OperationQuantity = table.Column<int>(nullable: true),
            //        OperationUnit = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        ActStartDateExecution = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        ActFinishTimeExecutn = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
            //        SystemStatus = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
            //        uploadDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
            //        date = table.Column<DateTime>(type: "datetime", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_SAP_ProdOrders", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Scrap",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        workCenter = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
            //        prodOrderNumber = table.Column<long>(nullable: false),
            //        eteredDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        enteredTime = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        materialNumber = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
            //        enteredUser = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        qty = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
            //        uom = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        scrapCode = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
            //        scrapDesc = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
            //        scrapGroup = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
            //        UK_DateTime = table.Column<DateTime>(type: "datetime", nullable: true),
            //        LocalDateTime = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ShiftDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Shift = table.Column<string>(unicode: false, maxLength: 5, nullable: true),
            //        hour_hxh = table.Column<int>(nullable: true),
            //        shiftDate_8 = table.Column<DateTime>(type: "datetime", nullable: true),
            //        shift_8 = table.Column<int>(nullable: true),
            //        isFiveDayShift = table.Column<bool>(nullable: true),
            //        operationNumber = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
            //        inputMaterialNumber = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        operationNumberLoc = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
            //        IsAutoGaugeScrap = table.Column<bool>(nullable: true),
            //        IsPurchashed = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
            //        IsPurchashedExclude = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
            //        ExportFileName = table.Column<string>(unicode: false, maxLength: 200, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Scrap", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Scrap_temp",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        workCenter = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
            //        prodOrderNumber = table.Column<long>(nullable: false),
            //        eteredDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        enteredTime = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        materialNumber = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
            //        enteredUser = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        qty = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
            //        uom = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        scrapCode = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
            //        scrapDesc = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
            //        scrapGroup = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
            //        UK_DateTime = table.Column<DateTime>(type: "datetime", nullable: true),
            //        LocalDateTime = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ShiftDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Shift = table.Column<string>(unicode: false, maxLength: 5, nullable: true),
            //        hour_hxh = table.Column<int>(nullable: true),
            //        shiftDate_8 = table.Column<DateTime>(type: "datetime", nullable: true),
            //        shift_8 = table.Column<int>(nullable: true),
            //        isFiveDayShift = table.Column<bool>(nullable: true),
            //        operationNumber = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
            //        inputMaterialNumber = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        operationNumberLoc = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
            //        IsAutoGaugeScrap = table.Column<bool>(nullable: true),
            //        IsPurchashed = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
            //        IsPurchashedExclude = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
            //        ExportFileName = table.Column<string>(unicode: false, maxLength: 200, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Scrap_temp", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ScrapAreaCode",
            //    columns: table => new
            //    {
            //        scrapAreaCode = table.Column<int>(nullable: false),
            //        scrapAreaName = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        colorCode = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ScrapAreaCode", x => x.scrapAreaCode);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "SLOC_Order",
            //    columns: table => new
            //    {
            //        SLOC = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        Sort = table.Column<int>(nullable: false),
            //        SLOCName = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_SLOC_Order", x => x.SLOC);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Scrap_Escalation",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        machine = table.Column<string>(unicode: false, maxLength: 5000, nullable: false),
            //        scrapCode = table.Column<string>(unicode: false, maxLength: 5000, nullable: false),
            //        alert_level = table.Column<int>(nullable: false),
            //        qty = table.Column<int>(nullable: false),
            //        modifiedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        escalationRecipientId = table.Column<int>(nullable: false),
            //        escalationMsgId = table.Column<int>(nullable: false),
            //        shift = table.Column<string>(unicode: false, maxLength: 5, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Scrap_Escalation", x => x.id);
            //        table.ForeignKey(
            //            name: "FK_ScrapEscalations_EscalationMessage",
            //            column: x => x.escalationMsgId,
            //            principalTable: "Escalation_Message",
            //            principalColumn: "id",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_ScrapEscalations_EscalationRecipients",
            //            column: x => x.escalationRecipientId,
            //            principalTable: "Escalation_Recipients",
            //            principalColumn: "id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ScrapEscalationLog",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        workCenter = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        scrapCode = table.Column<int>(nullable: false),
            //        alertLevel = table.Column<int>(nullable: false),
            //        shiftDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        shift = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
            //        qty = table.Column<int>(nullable: false),
            //        scrapEscalationId = table.Column<int>(nullable: false),
            //        isAcknowledged = table.Column<bool>(nullable: false),
            //        acknowledgeComment = table.Column<string>(unicode: false, nullable: true),
            //        acknowledgeStamp = table.Column<DateTime>(type: "datetime", nullable: true),
            //        stamp = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ScrapEscalationLog", x => x.id);
            //        table.ForeignKey(
            //            name: "FK_ScrapEscalationLog_Scrap_Escalation",
            //            column: x => x.scrapEscalationId,
            //            principalTable: "Scrap_Escalation",
            //            principalColumn: "id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_Scrap_Escalation_escalationMsgId",
            //    table: "Scrap_Escalation",
            //    column: "escalationMsgId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Scrap_Escalation_escalationRecipientId",
            //    table: "Scrap_Escalation",
            //    column: "escalationRecipientId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_ScrapEscalationLog_scrapEscalationId",
            //    table: "ScrapEscalationLog",
            //    column: "scrapEscalationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AvgShipDayPart");

            migrationBuilder.DropTable(
                name: "DmaxParts");

            migrationBuilder.DropTable(
                name: "ExcludedProgram");

            migrationBuilder.DropTable(
                name: "InvProgramTargets");

            migrationBuilder.DropTable(
                name: "KPI_Targets");

            migrationBuilder.DropTable(
                name: "MachineMapping");

            migrationBuilder.DropTable(
                name: "Production");

            migrationBuilder.DropTable(
                name: "Production_Temp");

            migrationBuilder.DropTable(
                name: "SAP_Dump_New");

            migrationBuilder.DropTable(
                name: "SAP_Dump2");

            migrationBuilder.DropTable(
                name: "SAP_ProdOrders");

            migrationBuilder.DropTable(
                name: "Scrap");

            migrationBuilder.DropTable(
                name: "Scrap_temp");

            migrationBuilder.DropTable(
                name: "ScrapAreaCode");

            migrationBuilder.DropTable(
                name: "ScrapEscalationLog");

            migrationBuilder.DropTable(
                name: "SLOC_Order");

            migrationBuilder.DropTable(
                name: "Scrap_Escalation");

            migrationBuilder.DropTable(
                name: "Escalation_Message");

            migrationBuilder.DropTable(
                name: "Escalation_Recipients");
        }
    }
}
