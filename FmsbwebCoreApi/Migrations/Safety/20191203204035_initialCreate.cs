using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FmsbwebCoreApi.Migrations.Safety
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "audit_incidence_deleted",
            //    columns: table => new
            //    {
            //        ID = table.Column<int>(nullable: true),
            //        dept = table.Column<string>(maxLength: 50, nullable: true),
            //        fname = table.Column<string>(maxLength: 50, nullable: true),
            //        lname = table.Column<string>(maxLength: 50, nullable: true),
            //        shift = table.Column<string>(maxLength: 50, nullable: true),
            //        accidentdate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        injuryid = table.Column<string>(maxLength: 50, nullable: true),
            //        bodyid = table.Column<string>(maxLength: 50, nullable: true),
            //        supervisor = table.Column<string>(maxLength: 50, nullable: true),
            //        injurystatid = table.Column<string>(maxLength: 50, nullable: true),
            //        description = table.Column<string>(nullable: true),
            //        iat = table.Column<string>(nullable: true),
            //        final = table.Column<string>(nullable: true),
            //        reason = table.Column<string>(nullable: true),
            //        triggerdate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        triggerStatus = table.Column<string>(maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //    });

            //migrationBuilder.CreateTable(
            //    name: "BodyPart",
            //    columns: table => new
            //    {
            //        ID = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        BodyPart = table.Column<string>(maxLength: 50, nullable: false),
            //        Description = table.Column<string>(maxLength: 500, nullable: true),
            //        modifieddate = table.Column<DateTime>(type: "datetime", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_BodyPart", x => x.ID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Dept",
            //    columns: table => new
            //    {
            //        Dept = table.Column<string>(maxLength: 50, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Dept", x => x.Dept);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "EmailNotificationLog",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        email = table.Column<string>(maxLength: 50, nullable: true),
            //        status = table.Column<string>(maxLength: 50, nullable: true),
            //        errorMsg = table.Column<string>(nullable: true),
            //        datemodified = table.Column<DateTime>(type: "datetime", nullable: true),
            //        incidentId = table.Column<int>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_EmailNotificationLog", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "EmailsNotiRecipients",
            //    columns: table => new
            //    {
            //        email = table.Column<string>(maxLength: 50, nullable: false),
            //        modifieddate = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_EmailsNotificationRecipients", x => x.email);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Injuries",
            //    columns: table => new
            //    {
            //        ID = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        InjuryName = table.Column<string>(maxLength: 50, nullable: false),
            //        Description = table.Column<string>(maxLength: 500, nullable: true),
            //        Modifieddate = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Injuries", x => x.ID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "InjuryStat",
            //    columns: table => new
            //    {
            //        InjuryStat = table.Column<string>(maxLength: 50, nullable: false),
            //        color = table.Column<string>(unicode: false, maxLength: 10, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_InjuryStat", x => x.InjuryStat);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ManHours",
            //    columns: table => new
            //    {
            //        ID = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        mos_dte = table.Column<DateTime>(type: "datetime", nullable: false),
            //        manhrs = table.Column<decimal>(type: "decimal(18, 5)", nullable: false),
            //        modifieddate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        comments = table.Column<string>(maxLength: 500, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ManHours", x => x.ID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Months_Reference",
            //    columns: table => new
            //    {
            //        mos = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        mos_num = table.Column<int>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //    });

            //migrationBuilder.CreateTable(
            //    name: "RecordableRecipients",
            //    columns: table => new
            //    {
            //        email = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_RecordableRecipients", x => x.email);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "SafetyStatusRecords",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        dateOpen = table.Column<DateTime>(type: "datetime", nullable: false),
            //        status = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        dept = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        description = table.Column<string>(unicode: false, nullable: false),
            //        correctiveAction = table.Column<string>(unicode: false, nullable: true),
            //        dateClose = table.Column<DateTime>(type: "datetime", nullable: true),
            //        stamp = table.Column<DateTime>(type: "datetime", nullable: false),
            //        responsiblePerson = table.Column<string>(unicode: false, maxLength: 100, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_SafetyStatusRecords", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "temp_stacked",
            //    columns: table => new
            //    {
            //        yr = table.Column<int>(nullable: true),
            //        mos = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        stat = table.Column<string>(maxLength: 50, nullable: true),
            //        monum = table.Column<int>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tempStacked_NoDate",
            //    columns: table => new
            //    {
            //        Label = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        Series = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Incidence",
            //    columns: table => new
            //    {
            //        ID = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Dept = table.Column<string>(maxLength: 50, nullable: false),
            //        Fname = table.Column<string>(maxLength: 50, nullable: false),
            //        LName = table.Column<string>(maxLength: 50, nullable: false),
            //        Shift = table.Column<string>(maxLength: 50, nullable: true),
            //        AccidentDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        InjuryID = table.Column<int>(nullable: false),
            //        BodyPartID = table.Column<int>(nullable: false),
            //        Supervisor = table.Column<string>(maxLength: 50, nullable: true),
            //        InjuryStatID = table.Column<string>(maxLength: 50, nullable: false),
            //        Description = table.Column<string>(nullable: true),
            //        InterimActionTaken = table.Column<string>(nullable: true),
            //        FinalCorrectiveAction = table.Column<string>(nullable: true),
            //        ReasonSupportingORIRStat = table.Column<string>(nullable: true),
            //        Modifieddate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        isClosed = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
            //        isFmTipsCompleted = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
            //        fmTipsNumber = table.Column<string>(unicode: false, maxLength: 5000, nullable: true),
            //        deletedFlag = table.Column<bool>(nullable: false),
            //        deletedFlagComment = table.Column<string>(unicode: false, maxLength: 5000, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Incidence", x => x.ID);
            //        table.ForeignKey(
            //            name: "FK_Incidence_BodyPart",
            //            column: x => x.BodyPartID,
            //            principalTable: "BodyPart",
            //            principalColumn: "ID",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_Incidence_Dept",
            //            column: x => x.Dept,
            //            principalTable: "Dept",
            //            principalColumn: "Dept",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_Incidence_Injuries",
            //            column: x => x.InjuryID,
            //            principalTable: "Injuries",
            //            principalColumn: "ID",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "attachments",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        filename = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        contentType = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
            //        data = table.Column<byte[]>(nullable: true),
            //        incidentid = table.Column<int>(nullable: false),
            //        modifieddate = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_attachments", x => x.id);
            //        table.ForeignKey(
            //            name: "FK_attachments_Incidence",
            //            column: x => x.incidentid,
            //            principalTable: "Incidence",
            //            principalColumn: "ID",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_attachments_incidentid",
            //    table: "attachments",
            //    column: "incidentid");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Incidence_BodyPartID",
            //    table: "Incidence",
            //    column: "BodyPartID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Incidence_Dept",
            //    table: "Incidence",
            //    column: "Dept");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Incidence_InjuryID",
            //    table: "Incidence",
            //    column: "InjuryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "attachments");

            migrationBuilder.DropTable(
                name: "audit_incidence_deleted");

            migrationBuilder.DropTable(
                name: "EmailNotificationLog");

            migrationBuilder.DropTable(
                name: "EmailsNotiRecipients");

            migrationBuilder.DropTable(
                name: "InjuryStat");

            migrationBuilder.DropTable(
                name: "ManHours");

            migrationBuilder.DropTable(
                name: "Months_Reference");

            migrationBuilder.DropTable(
                name: "RecordableRecipients");

            migrationBuilder.DropTable(
                name: "SafetyStatusRecords");

            migrationBuilder.DropTable(
                name: "temp_stacked");

            migrationBuilder.DropTable(
                name: "tempStacked_NoDate");

            migrationBuilder.DropTable(
                name: "Incidence");

            migrationBuilder.DropTable(
                name: "BodyPart");

            migrationBuilder.DropTable(
                name: "Dept");

            migrationBuilder.DropTable(
                name: "Injuries");
        }
    }
}
