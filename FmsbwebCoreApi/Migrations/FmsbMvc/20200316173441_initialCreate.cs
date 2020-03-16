using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FmsbwebCoreApi.Migrations.FmsbMvc
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "FmsbWeb");

            migrationBuilder.EnsureSchema(
                name: "DieStatus");

            migrationBuilder.EnsureSchema(
                name: "Alert");

            migrationBuilder.EnsureSchema(
                name: "Overtime");

            migrationBuilder.EnsureSchema(
                name: "Discipline");

            migrationBuilder.EnsureSchema(
                name: "Iconics");

            migrationBuilder.EnsureSchema(
                name: "Maintenance");

            migrationBuilder.EnsureSchema(
                name: "Gauge");

            migrationBuilder.EnsureSchema(
                name: "HxH");

            migrationBuilder.EnsureSchema(
                name: "ProcessTechs");

            migrationBuilder.CreateTable(
                name: "__MigrationHistory",
                columns: table => new
                {
                    MigrationId = table.Column<string>(maxLength: 150, nullable: false),
                    ContextKey = table.Column<string>(maxLength: 300, nullable: false),
                    Model = table.Column<byte[]>(nullable: false),
                    ProductVersion = table.Column<string>(maxLength: 32, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.__MigrationHistory", x => new { x.MigrationId, x.ContextKey });
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 128, nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEndDateUtc = table.Column<DateTime>(type: "datetime", nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeFeedbacks",
                columns: table => new
                {
                    EmployeeFeedbackId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Feedback = table.Column<string>(unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.EmployeeFeedbacks", x => x.EmployeeFeedbackId);
                });

            migrationBuilder.CreateTable(
                name: "OperatorAutoDowntimeEmailRecipients",
                columns: table => new
                {
                    OperatorAutoDowntimeEmailRecipientsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Shift = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperatorAutoDowntimeEmailRecipients", x => x.OperatorAutoDowntimeEmailRecipientsId);
                });

            migrationBuilder.CreateTable(
                name: "ShiftNames",
                columns: table => new
                {
                    ShiftNameId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Shift = table.Column<string>(unicode: false, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.ShiftNames", x => x.ShiftNameId);
                });

            migrationBuilder.CreateTable(
                name: "SP_GetClockNumbers_Result",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Clock = table.Column<int>(nullable: false),
                    FName = table.Column<string>(nullable: true),
                    LName = table.Column<string>(nullable: true),
                    Dept = table.Column<string>(nullable: true),
                    Shift = table.Column<string>(nullable: true),
                    Job = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SP_GetClockNumbers_Result", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GaugeCallType",
                schema: "Gauge",
                columns: table => new
                {
                    GaugeCallTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GaugeCall = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GaugeCallType", x => x.GaugeCallTypeId);
                });

            migrationBuilder.CreateTable(
                name: "GaugeStation",
                schema: "Gauge",
                columns: table => new
                {
                    GaugeStationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Station = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GaugeStation", x => x.GaugeStationId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(maxLength: 128, nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    UserId = table.Column<string>(maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey, x.UserId });
                    table.ForeignKey(
                        name: "FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(maxLength: 128, nullable: false),
                    RoleId = table.Column<string>(maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Stamp = table.Column<DateTime>(type: "datetime", nullable: false),
                    ApplicationUserId = table.Column<string>(maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.Departments", x => x.DepartmentId);
                    table.ForeignKey(
                        name: "FK_dbo.Departments_dbo.AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Topics",
                columns: table => new
                {
                    TopicsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TopicName = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    Stamp = table.Column<DateTime>(type: "datetime", nullable: false),
                    ApplicationUserId = table.Column<string>(maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topics", x => x.TopicsId);
                    table.ForeignKey(
                        name: "FK_dbo.Topics_dbo.AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CastingCell",
                schema: "DieStatus",
                columns: table => new
                {
                    CastingCellName = table.Column<int>(nullable: false),
                    IsDualCavity = table.Column<bool>(nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime", nullable: false),
                    ApplicationUserId = table.Column<string>(maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DieStatus.CastingCell", x => x.CastingCellName);
                    table.ForeignKey(
                        name: "FK_DieStatus.CastingCell_dbo.AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PartNumber",
                schema: "DieStatus",
                columns: table => new
                {
                    PartNumberId = table.Column<string>(maxLength: 128, nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime", nullable: false),
                    ApplicationUserId = table.Column<string>(maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartNumber", x => x.PartNumberId);
                    table.ForeignKey(
                        name: "FK_DieStatus.PartNumber_dbo.AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DisciplineLevels",
                schema: "Discipline",
                columns: table => new
                {
                    DisciplineLevelsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Levels = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    Stamp = table.Column<DateTime>(type: "datetime", nullable: false),
                    ApplicationUserId = table.Column<string>(maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DisciplineLevels", x => x.DisciplineLevelsId);
                    table.ForeignKey(
                        name: "FK_Discipline.DisciplineLevels_dbo.AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DisciplineTopic",
                schema: "Discipline",
                columns: table => new
                {
                    DisciplineTopicId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Topic = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    Stamp = table.Column<DateTime>(type: "datetime", nullable: false),
                    ApplicationUserId = table.Column<string>(maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DisciplineTopic", x => x.DisciplineTopicId);
                    table.ForeignKey(
                        name: "FK_Discipline.DisciplineTopic_dbo.AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Area",
                schema: "FmsbWeb",
                columns: table => new
                {
                    AreaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AreaName = table.Column<string>(unicode: false, maxLength: 25, nullable: false),
                    Stamp = table.Column<DateTime>(type: "datetime", nullable: false),
                    ApplicationUserId = table.Column<string>(maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Area", x => x.AreaId);
                    table.ForeignKey(
                        name: "FK_FmsbWeb.Area_dbo.AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KPI",
                schema: "FmsbWeb",
                columns: table => new
                {
                    KPIId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KPIName = table.Column<string>(unicode: false, maxLength: 25, nullable: false),
                    Stamp = table.Column<DateTime>(type: "datetime", nullable: false),
                    ApplicationUserId = table.Column<string>(maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KPI", x => x.KPIId);
                    table.ForeignKey(
                        name: "FK_FmsbWeb.KPI_dbo.AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Program",
                schema: "FmsbWeb",
                columns: table => new
                {
                    ProgramId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProgramName = table.Column<string>(maxLength: 50, nullable: false),
                    Stamp = table.Column<DateTime>(type: "datetime", nullable: false),
                    ApplicationUserId = table.Column<string>(maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Program", x => x.ProgramId);
                    table.ForeignKey(
                        name: "FK_FmsbWeb.Program_dbo.AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HxHPushAlerts",
                schema: "HxH",
                columns: table => new
                {
                    HxHPushAlertsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HxHPushEnum = table.Column<int>(nullable: false),
                    Enable = table.Column<bool>(nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime", nullable: false),
                    ApplicationUserId = table.Column<string>(maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HxHPushAlerts", x => x.HxHPushAlertsId);
                    table.ForeignKey(
                        name: "FK_HxH.HxHPushAlerts_dbo.AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DowntimeTriggerThreshold",
                schema: "Iconics",
                columns: table => new
                {
                    DowntimeTriggerThresholdId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeptName = table.Column<string>(nullable: true),
                    Threshold = table.Column<int>(nullable: false),
                    ApplicationUserId = table.Column<string>(maxLength: 128, nullable: true),
                    IsLive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DowntimeTriggerThreshold", x => x.DowntimeTriggerThresholdId);
                    table.ForeignKey(
                        name: "FK_Iconics.DowntimeTriggerThreshold_dbo.AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClockNumber",
                schema: "Overtime",
                columns: table => new
                {
                    ClockNumberId = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    LastName = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    DateHired = table.Column<DateTime>(type: "datetime", nullable: false),
                    Stamp = table.Column<DateTime>(type: "datetime", nullable: false),
                    ApplicationUserId = table.Column<string>(maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClockNumber", x => x.ClockNumberId);
                    table.ForeignKey(
                        name: "FK_Overtime.ClockNumber_dbo.AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OvertimeCategory",
                schema: "Overtime",
                columns: table => new
                {
                    OvertimeCategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Stamp = table.Column<DateTime>(type: "datetime", nullable: false),
                    ApplicationUserId = table.Column<string>(maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OvertimeCategory", x => x.OvertimeCategoryId);
                    table.ForeignKey(
                        name: "FK_Overtime.OvertimeCategory_dbo.AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MaintenanceTech",
                schema: "Maintenance",
                columns: table => new
                {
                    ClockNumber = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    ShiftNameId = table.Column<int>(nullable: false),
                    Stamp = table.Column<DateTime>(type: "datetime", nullable: false),
                    ApplicationUserId = table.Column<string>(maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maintenance.MaintenanceTech", x => x.ClockNumber);
                    table.ForeignKey(
                        name: "FK_Maintenance.MaintenanceTech_dbo.AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Maintenance.MaintenanceTech_dbo.ShiftNames_ShiftNameId",
                        column: x => x.ShiftNameId,
                        principalTable: "ShiftNames",
                        principalColumn: "ShiftNameId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmailNotificationRecipients",
                columns: table => new
                {
                    Email = table.Column<string>(maxLength: 500, nullable: false),
                    DepartmentId = table.Column<int>(nullable: false),
                    ShiftNameId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.EmailNotificationRecipients", x => x.Email);
                    table.ForeignKey(
                        name: "FK_dbo.EmailNotificationRecipients_dbo.Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dbo.EmailNotificationRecipients_dbo.ShiftNames_ShiftNameId",
                        column: x => x.ShiftNameId,
                        principalTable: "ShiftNames",
                        principalColumn: "ShiftNameId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserDepartments",
                columns: table => new
                {
                    UserDepartmentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentId = table.Column<int>(nullable: false),
                    ApplicationUserId = table.Column<string>(maxLength: 128, nullable: true),
                    Stamp = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.UserDepartments", x => x.UserDepartmentId);
                    table.ForeignKey(
                        name: "FK_dbo.UserDepartments_dbo.AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dbo.UserDepartments_dbo.Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ForkliftTask",
                schema: "Alert",
                columns: table => new
                {
                    ForkliftTaskId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentId = table.Column<int>(nullable: false),
                    TaskName = table.Column<string>(nullable: false),
                    IsObsolete = table.Column<bool>(nullable: false),
                    Stamp = table.Column<DateTime>(type: "datetime", nullable: false),
                    ApplicationUserId = table.Column<string>(maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForkliftTask", x => x.ForkliftTaskId);
                    table.ForeignKey(
                        name: "FK_Alert.ForkliftTask_dbo.AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Alert.ForkliftTask_dbo.Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MaintenanceBreakDownReason",
                schema: "Alert",
                columns: table => new
                {
                    MaintenanceBreakDownReasonId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BreakDown = table.Column<string>(nullable: false),
                    Stamp = table.Column<DateTime>(type: "datetime", nullable: false),
                    ApplicationUserId = table.Column<string>(maxLength: 128, nullable: true),
                    DepartmentId = table.Column<int>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaintenanceBreakDownReason", x => x.MaintenanceBreakDownReasonId);
                    table.ForeignKey(
                        name: "FK_Alert.MaintenanceBreakDownReason_dbo.AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Alert.MaintenanceBreakDownReason_dbo.Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Machine",
                schema: "Maintenance",
                columns: table => new
                {
                    MachineId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentId = table.Column<int>(nullable: false),
                    MachineName = table.Column<string>(unicode: false, maxLength: 500, nullable: false),
                    Stamp = table.Column<DateTime>(type: "datetime", nullable: false),
                    ApplicationUserId = table.Column<string>(maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Machine", x => x.MachineId);
                    table.ForeignKey(
                        name: "FK_Maintenance.Machine_dbo.AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Maintenance.Machine_dbo.Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "JobTitle",
                schema: "Overtime",
                columns: table => new
                {
                    JobTitleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Description = table.Column<string>(unicode: false, maxLength: 8000, nullable: true),
                    Stamp = table.Column<DateTime>(type: "datetime", nullable: false),
                    ApplicationUserId = table.Column<string>(maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobTitle", x => x.JobTitleId);
                    table.ForeignKey(
                        name: "FK_Overtime.JobTitle_dbo.AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Overtime.JobTitle_dbo.Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProcessTechName",
                schema: "ProcessTechs",
                columns: table => new
                {
                    ClockNumber = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    DepartmentId = table.Column<int>(nullable: false),
                    ShiftNameId = table.Column<int>(nullable: false),
                    Stamp = table.Column<DateTime>(type: "datetime", nullable: false),
                    ApplicationUserId = table.Column<string>(maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcessTechs.ProcessTechName", x => x.ClockNumber);
                    table.ForeignKey(
                        name: "FK_ProcessTechs.ProcessTechName_dbo.AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProcessTechs.ProcessTechName_dbo.Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProcessTechs.ProcessTechName_dbo.ShiftNames_ShiftNameId",
                        column: x => x.ShiftNameId,
                        principalTable: "ShiftNames",
                        principalColumn: "ShiftNameId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Assignments",
                columns: table => new
                {
                    AssignmentsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    NumOfConversation = table.Column<int>(nullable: false),
                    DepartmentId = table.Column<int>(nullable: false),
                    TopicsId = table.Column<int>(nullable: false),
                    Comments = table.Column<string>(nullable: false),
                    Stamp = table.Column<DateTime>(type: "datetime", nullable: false),
                    ApplicationUserId = table.Column<string>(maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assignments", x => x.AssignmentsId);
                    table.ForeignKey(
                        name: "FK_dbo.Assignments_dbo.AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dbo.Assignments_dbo.Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dbo.Assignments_dbo.Topics_TopicsId",
                        column: x => x.TopicsId,
                        principalTable: "Topics",
                        principalColumn: "TopicsId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Block",
                schema: "DieStatus",
                columns: table => new
                {
                    BlockId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlockName = table.Column<int>(nullable: false),
                    PartNumberId = table.Column<string>(maxLength: 128, nullable: true),
                    Comments = table.Column<string>(nullable: true),
                    Warning = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime", nullable: false),
                    ApplicationUserId = table.Column<string>(maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Block", x => x.BlockId);
                    table.ForeignKey(
                        name: "FK_DieStatus.Block_dbo.AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DieStatus.Block_DieStatus.PartNumber_PartNumberId",
                        column: x => x.PartNumberId,
                        principalSchema: "DieStatus",
                        principalTable: "PartNumber",
                        principalColumn: "PartNumberId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Discipline",
                schema: "Discipline",
                columns: table => new
                {
                    DisciplineLogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentId = table.Column<int>(nullable: false),
                    SupervisorClockNumber = table.Column<int>(nullable: false),
                    SupervisorName = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    ShiftNameId = table.Column<int>(nullable: false),
                    ClockNumber = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(unicode: false, maxLength: 25, nullable: false),
                    LastName = table.Column<string>(unicode: false, maxLength: 25, nullable: false),
                    Comments = table.Column<string>(unicode: false, maxLength: 1000, nullable: false),
                    DisciplineTopicId = table.Column<int>(nullable: false),
                    DisciplineLevelsId = table.Column<int>(nullable: false),
                    Stamp = table.Column<DateTime>(type: "datetime", nullable: false),
                    ApplicationUserId = table.Column<string>(maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discipline.Discipline", x => x.DisciplineLogId);
                    table.ForeignKey(
                        name: "FK_Discipline.Discipline_dbo.AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Discipline.Discipline_dbo.Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Discipline.Discipline_Discipline.DisciplineLevels_DisciplineLevelsId",
                        column: x => x.DisciplineLevelsId,
                        principalSchema: "Discipline",
                        principalTable: "DisciplineLevels",
                        principalColumn: "DisciplineLevelsId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Discipline.Discipline_Discipline.DisciplineTopic_DisciplineTopicId",
                        column: x => x.DisciplineTopicId,
                        principalSchema: "Discipline",
                        principalTable: "DisciplineTopic",
                        principalColumn: "DisciplineTopicId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Discipline.Discipline_dbo.ShiftNames_ShiftNameId",
                        column: x => x.ShiftNameId,
                        principalTable: "ShiftNames",
                        principalColumn: "ShiftNameId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KPITarget",
                schema: "FmsbWeb",
                columns: table => new
                {
                    KPITargetId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AreaId = table.Column<int>(nullable: false),
                    KPIId = table.Column<int>(nullable: false),
                    Min = table.Column<decimal>(type: "decimal(18, 5)", nullable: false),
                    Max = table.Column<decimal>(type: "decimal(18, 5)", nullable: false),
                    Stamp = table.Column<DateTime>(type: "datetime", nullable: false),
                    ApplicationUserId = table.Column<string>(maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FmsbWeb.KPITarget", x => x.KPITargetId);
                    table.ForeignKey(
                        name: "FK_FmsbWeb.KPITarget_dbo.AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FmsbWeb.KPITarget_FmsbWeb.Area_AreaId",
                        column: x => x.AreaId,
                        principalSchema: "FmsbWeb",
                        principalTable: "Area",
                        principalColumn: "AreaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FmsbWeb.KPITarget_FmsbWeb.KPI_KPIId",
                        column: x => x.KPIId,
                        principalSchema: "FmsbWeb",
                        principalTable: "KPI",
                        principalColumn: "KPIId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KpiByProgram",
                schema: "FmsbWeb",
                columns: table => new
                {
                    KpiByProgramId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AreaId = table.Column<int>(nullable: false),
                    KPIId = table.Column<int>(nullable: false),
                    ProgramId = table.Column<int>(nullable: false),
                    Target = table.Column<decimal>(type: "decimal(18, 5)", nullable: false),
                    Stamp = table.Column<DateTime>(type: "datetime", nullable: false),
                    ApplicationUserId = table.Column<string>(maxLength: 128, nullable: true),
                    MonthNumber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FmsbWeb.KpiByProgram", x => x.KpiByProgramId);
                    table.ForeignKey(
                        name: "FK_FmsbWeb.KpiByProgram_dbo.AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FmsbWeb.KpiByProgram_FmsbWeb.Area_AreaId",
                        column: x => x.AreaId,
                        principalSchema: "FmsbWeb",
                        principalTable: "Area",
                        principalColumn: "AreaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FmsbWeb.KpiByProgram_FmsbWeb.KPI_KPIId",
                        column: x => x.KPIId,
                        principalSchema: "FmsbWeb",
                        principalTable: "KPI",
                        principalColumn: "KPIId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FmsbWeb.KpiByProgram_FmsbWeb.Program_ProgramId",
                        column: x => x.ProgramId,
                        principalSchema: "FmsbWeb",
                        principalTable: "Program",
                        principalColumn: "ProgramId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OvertimeLog",
                schema: "Overtime",
                columns: table => new
                {
                    OvertimeLogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentId = table.Column<int>(nullable: false),
                    ClockNumberId = table.Column<int>(nullable: false),
                    DateOffered = table.Column<DateTime>(type: "datetime", nullable: false),
                    OvertimeShift = table.Column<string>(nullable: false),
                    Hours = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    OvertimeCategoryId = table.Column<int>(nullable: false),
                    Comments = table.Column<string>(unicode: false, maxLength: 8000, nullable: true),
                    Supervisor = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Stamp = table.Column<DateTime>(type: "datetime", nullable: false),
                    ApplicationUserId = table.Column<string>(maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OvertimeLog", x => x.OvertimeLogId);
                    table.ForeignKey(
                        name: "FK_Overtime.OvertimeLog_dbo.AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Overtime.OvertimeLog_Overtime.ClockNumber_ClockNumberId",
                        column: x => x.ClockNumberId,
                        principalSchema: "Overtime",
                        principalTable: "ClockNumber",
                        principalColumn: "ClockNumberId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Overtime.OvertimeLog_dbo.Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Overtime.OvertimeLog_Overtime.OvertimeCategory_OvertimeCategoryId",
                        column: x => x.OvertimeCategoryId,
                        principalSchema: "Overtime",
                        principalTable: "OvertimeCategory",
                        principalColumn: "OvertimeCategoryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BreakdownReason2",
                schema: "Alert",
                columns: table => new
                {
                    BreakdownReason2Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BreakDown = table.Column<string>(nullable: false),
                    Stamp = table.Column<DateTime>(type: "datetime", nullable: false),
                    MaintenanceBreakDownReasonId = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    ApplicationUserId = table.Column<string>(maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BreakdownReason2", x => x.BreakdownReason2Id);
                    table.ForeignKey(
                        name: "FK_Alert.BreakdownReason2_dbo.AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Alert.BreakdownReason2_Alert.MaintenanceBreakDownReason_MaintenanceBreakDownReasonId",
                        column: x => x.MaintenanceBreakDownReasonId,
                        principalSchema: "Alert",
                        principalTable: "MaintenanceBreakDownReason",
                        principalColumn: "MaintenanceBreakDownReasonId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Forklift",
                schema: "Alert",
                columns: table => new
                {
                    ForkliftId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MachineId = table.Column<int>(nullable: false),
                    ForkliftTaskId = table.Column<int>(nullable: false),
                    RequestDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    WorkingDateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    CompletedDateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsWorking = table.Column<bool>(nullable: false),
                    IsComplete = table.Column<bool>(nullable: false),
                    ApplicationUserId = table.Column<string>(maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Forklift", x => x.ForkliftId);
                    table.ForeignKey(
                        name: "FK_Alert.Forklift_dbo.AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Alert.Forklift_Alert.ForkliftTask_ForkliftTaskId",
                        column: x => x.ForkliftTaskId,
                        principalSchema: "Alert",
                        principalTable: "ForkliftTask",
                        principalColumn: "ForkliftTaskId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Alert.Forklift_Maintenance.Machine_MachineId",
                        column: x => x.MachineId,
                        principalSchema: "Maintenance",
                        principalTable: "Machine",
                        principalColumn: "MachineId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EstimatedPM",
                schema: "Maintenance",
                columns: table => new
                {
                    EstimatedPMId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MachineId = table.Column<int>(nullable: false),
                    DaysBeforePM = table.Column<int>(nullable: false),
                    Stamp = table.Column<DateTime>(type: "datetime", nullable: false),
                    ApplicationUserId = table.Column<string>(maxLength: 128, nullable: true),
                    MinDaysBeforePM = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstimatedPM", x => x.EstimatedPMId);
                    table.ForeignKey(
                        name: "FK_Maintenance.EstimatedPM_dbo.AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Maintenance.EstimatedPM_Maintenance.Machine_MachineId",
                        column: x => x.MachineId,
                        principalSchema: "Maintenance",
                        principalTable: "Machine",
                        principalColumn: "MachineId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PreventiveMaintenance",
                schema: "Maintenance",
                columns: table => new
                {
                    PreventiveMaintenanceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MachineId = table.Column<int>(nullable: false),
                    LastCompletedPM = table.Column<DateTime>(type: "datetime", nullable: false),
                    Comments = table.Column<string>(nullable: true),
                    Stamp = table.Column<DateTime>(type: "datetime", nullable: false),
                    ApplicationUserId = table.Column<string>(maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreventiveMaintenance", x => x.PreventiveMaintenanceId);
                    table.ForeignKey(
                        name: "FK_Maintenance.PreventiveMaintenance_dbo.AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Maintenance.PreventiveMaintenance_Maintenance.Machine_MachineId",
                        column: x => x.MachineId,
                        principalSchema: "Maintenance",
                        principalTable: "Machine",
                        principalColumn: "MachineId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SubMachine",
                schema: "Maintenance",
                columns: table => new
                {
                    SubMachineId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MachineId = table.Column<int>(nullable: false),
                    SubMachineName = table.Column<string>(unicode: false, maxLength: 500, nullable: false),
                    Stamp = table.Column<DateTime>(type: "datetime", nullable: false),
                    ApplicationUserId = table.Column<string>(maxLength: 128, nullable: true),
                    IsObsolete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubMachine", x => x.SubMachineId);
                    table.ForeignKey(
                        name: "FK_Maintenance.SubMachine_dbo.AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Maintenance.SubMachine_Maintenance.Machine_MachineId",
                        column: x => x.MachineId,
                        principalSchema: "Maintenance",
                        principalTable: "Machine",
                        principalColumn: "MachineId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeJob",
                schema: "Overtime",
                columns: table => new
                {
                    EmployeeJobId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClockNumberId = table.Column<int>(nullable: false),
                    DepartmentId = table.Column<int>(nullable: false),
                    ShiftNameId = table.Column<int>(nullable: false),
                    JobTitleId = table.Column<int>(nullable: false),
                    Stamp = table.Column<DateTime>(type: "datetime", nullable: false),
                    ApplicationUserId = table.Column<string>(maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeJob", x => x.EmployeeJobId);
                    table.ForeignKey(
                        name: "FK_Overtime.EmployeeJob_dbo.AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Overtime.EmployeeJob_Overtime.ClockNumber_ClockNumberId",
                        column: x => x.ClockNumberId,
                        principalSchema: "Overtime",
                        principalTable: "ClockNumber",
                        principalColumn: "ClockNumberId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Overtime.EmployeeJob_dbo.Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Overtime.EmployeeJob_Overtime.JobTitle_JobTitleId",
                        column: x => x.JobTitleId,
                        principalSchema: "Overtime",
                        principalTable: "JobTitle",
                        principalColumn: "JobTitleId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Overtime.EmployeeJob_dbo.ShiftNames_ShiftNameId",
                        column: x => x.ShiftNameId,
                        principalTable: "ShiftNames",
                        principalColumn: "ShiftNameId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SupervisorConversations",
                columns: table => new
                {
                    SupervisorConversationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentId = table.Column<int>(nullable: false),
                    SupervisorClockNumber = table.Column<int>(nullable: false),
                    SupervisorName = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    ShiftNameId = table.Column<int>(nullable: false),
                    ClockNumber = table.Column<int>(nullable: true),
                    FirstName = table.Column<string>(unicode: false, maxLength: 25, nullable: true),
                    LastName = table.Column<string>(unicode: false, maxLength: 25, nullable: true),
                    AssignmentsId = table.Column<int>(nullable: false),
                    EmployeeFeedbackId = table.Column<int>(nullable: false),
                    Comments = table.Column<string>(unicode: false, maxLength: 1000, nullable: false),
                    Stamp = table.Column<DateTime>(type: "datetime", nullable: false),
                    ApplicationUserId = table.Column<string>(maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.SupervisorConversations", x => x.SupervisorConversationId);
                    table.ForeignKey(
                        name: "FK_dbo.SupervisorConversations_dbo.AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dbo.SupervisorConversations_dbo.Assignments_AssignmentsId",
                        column: x => x.AssignmentsId,
                        principalTable: "Assignments",
                        principalColumn: "AssignmentsId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dbo.SupervisorConversations_dbo.Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dbo.SupervisorConversations_dbo.EmployeeFeedbacks_EmployeeFeedbackId",
                        column: x => x.EmployeeFeedbackId,
                        principalTable: "EmployeeFeedbacks",
                        principalColumn: "EmployeeFeedbackId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dbo.SupervisorConversations_dbo.ShiftNames_ShiftNameId",
                        column: x => x.ShiftNameId,
                        principalTable: "ShiftNames",
                        principalColumn: "ShiftNameId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Die",
                schema: "DieStatus",
                columns: table => new
                {
                    DieId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DieName = table.Column<string>(nullable: true),
                    BlockId = table.Column<int>(nullable: false),
                    DieCoatingLife = table.Column<int>(nullable: false),
                    Warning = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime", nullable: false),
                    ApplicationUserId = table.Column<string>(maxLength: 128, nullable: true),
                    DieComment = table.Column<string>(nullable: true),
                    BlockComment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Die", x => x.DieId);
                    table.ForeignKey(
                        name: "FK_DieStatus.Die_dbo.AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DieStatus.Die_DieStatus.Block_BlockId",
                        column: x => x.BlockId,
                        principalSchema: "DieStatus",
                        principalTable: "Block",
                        principalColumn: "BlockId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MaintenanceAlertLog",
                schema: "Alert",
                columns: table => new
                {
                    MaintenanceAlertLogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeStamp = table.Column<DateTime>(type: "datetime", nullable: false),
                    Status = table.Column<int>(nullable: false),
                    ApplicationUserId = table.Column<string>(maxLength: 128, nullable: true),
                    MaintenanceAlertId = table.Column<int>(nullable: false),
                    MachineId = table.Column<int>(nullable: false),
                    SubMachineId = table.Column<int>(nullable: false),
                    MaintenanceBreakDownReasonId = table.Column<int>(nullable: false),
                    BreakdownComments = table.Column<string>(nullable: true),
                    RequestDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    WorkingDateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    CompletedDateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsWorking = table.Column<bool>(nullable: false),
                    IsComplete = table.Column<bool>(nullable: false),
                    IsFollowUp = table.Column<bool>(nullable: false),
                    MaintenanceTechClockNumbers = table.Column<string>(nullable: true),
                    ResponseComment = table.Column<string>(nullable: true),
                    InitialUserId = table.Column<string>(nullable: true),
                    SupervisorId = table.Column<string>(nullable: true),
                    ClockNumberStr = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    StartedFrom = table.Column<string>(nullable: true),
                    EndedFrom = table.Column<string>(nullable: true),
                    DeleteComment = table.Column<string>(nullable: true),
                    BreakdownReason2Id = table.Column<int>(nullable: true),
                    HourId = table.Column<int>(nullable: true),
                    HxHId = table.Column<int>(nullable: true),
                    OperatorDowntimeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaintenanceAlertLog", x => x.MaintenanceAlertLogId);
                    table.ForeignKey(
                        name: "FK_Alert.MaintenanceAlertLog_dbo.AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Alert.MaintenanceAlertLog_Alert.BreakdownReason2_BreakdownReason2Id",
                        column: x => x.BreakdownReason2Id,
                        principalSchema: "Alert",
                        principalTable: "BreakdownReason2",
                        principalColumn: "BreakdownReason2Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Alert.MaintenanceAlertLog_Maintenance.Machine_MachineId",
                        column: x => x.MachineId,
                        principalSchema: "Maintenance",
                        principalTable: "Machine",
                        principalColumn: "MachineId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Alert.MaintenanceAlertLog_Alert.MaintenanceBreakDownReason_MaintenanceBreakDownReasonId",
                        column: x => x.MaintenanceBreakDownReasonId,
                        principalSchema: "Alert",
                        principalTable: "MaintenanceBreakDownReason",
                        principalColumn: "MaintenanceBreakDownReasonId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Alert.MaintenanceAlertLog_Maintenance.SubMachine_SubMachineId",
                        column: x => x.SubMachineId,
                        principalSchema: "Maintenance",
                        principalTable: "SubMachine",
                        principalColumn: "SubMachineId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OperatorDowntime",
                schema: "Iconics",
                columns: table => new
                {
                    OperatorDowntimeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TagId = table.Column<string>(nullable: true),
                    MachineName = table.Column<string>(nullable: true),
                    HourId = table.Column<int>(nullable: false),
                    DowntimeAutoId = table.Column<int>(nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    MachineId = table.Column<int>(nullable: true),
                    SubMachineId = table.Column<int>(nullable: true),
                    MaintenanceBreakDownReasonId = table.Column<int>(nullable: true),
                    BreakdownReason2Id = table.Column<int>(nullable: true),
                    DowntimeComment = table.Column<string>(nullable: true),
                    StatusText = table.Column<string>(nullable: true),
                    TimeStamp = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsManualTrigger = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperatorDowntime", x => x.OperatorDowntimeId);
                    table.ForeignKey(
                        name: "FK_Iconics.OperatorDowntime_Alert.BreakdownReason2_BreakdownReason2Id",
                        column: x => x.BreakdownReason2Id,
                        principalSchema: "Alert",
                        principalTable: "BreakdownReason2",
                        principalColumn: "BreakdownReason2Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Iconics.OperatorDowntime_Maintenance.Machine_MachineId",
                        column: x => x.MachineId,
                        principalSchema: "Maintenance",
                        principalTable: "Machine",
                        principalColumn: "MachineId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Iconics.OperatorDowntime_Alert.MaintenanceBreakDownReason_MaintenanceBreakDownReasonId",
                        column: x => x.MaintenanceBreakDownReasonId,
                        principalSchema: "Alert",
                        principalTable: "MaintenanceBreakDownReason",
                        principalColumn: "MaintenanceBreakDownReasonId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Iconics.OperatorDowntime_Maintenance.SubMachine_SubMachineId",
                        column: x => x.SubMachineId,
                        principalSchema: "Maintenance",
                        principalTable: "SubMachine",
                        principalColumn: "SubMachineId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SubMachinePM",
                schema: "Maintenance",
                columns: table => new
                {
                    SubMachinePMId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubMachineId = table.Column<int>(nullable: false),
                    PreventiveMaintenanceId = table.Column<int>(nullable: false),
                    DateCompleted = table.Column<DateTime>(type: "datetime", nullable: true),
                    Comments = table.Column<string>(nullable: true),
                    Stamp = table.Column<DateTime>(type: "datetime", nullable: false),
                    ApplicationUserId = table.Column<string>(maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubMachinePM", x => x.SubMachinePMId);
                    table.ForeignKey(
                        name: "FK_Maintenance.SubMachinePM_dbo.AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Maintenance.SubMachinePM_Maintenance.PreventiveMaintenance_PreventiveMaintenanceId",
                        column: x => x.PreventiveMaintenanceId,
                        principalSchema: "Maintenance",
                        principalTable: "PreventiveMaintenance",
                        principalColumn: "PreventiveMaintenanceId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Maintenance.SubMachinePM_Maintenance.SubMachine_SubMachineId",
                        column: x => x.SubMachineId,
                        principalSchema: "Maintenance",
                        principalTable: "SubMachine",
                        principalColumn: "SubMachineId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DieTracker",
                schema: "DieStatus",
                columns: table => new
                {
                    DieTrackerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CastingCellName = table.Column<int>(nullable: false),
                    CellSideEnum = table.Column<int>(nullable: false),
                    DieLocationEnum = table.Column<int>(nullable: false),
                    OddEvenEnum = table.Column<int>(nullable: false),
                    Comments = table.Column<string>(nullable: true),
                    DieId = table.Column<int>(nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime", nullable: false),
                    ApplicationUserId = table.Column<string>(maxLength: 128, nullable: true),
                    PartNumberId = table.Column<string>(maxLength: 128, nullable: true),
                    BlockChangeDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DieChangeDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DieTracker", x => x.DieTrackerId);
                    table.ForeignKey(
                        name: "FK_DieStatus.DieTracker_dbo.AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DieStatus.DieTracker_DieStatus.CastingCell_CastingCellName",
                        column: x => x.CastingCellName,
                        principalSchema: "DieStatus",
                        principalTable: "CastingCell",
                        principalColumn: "CastingCellName",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DieStatus.DieTracker_DieStatus.Die_DieId",
                        column: x => x.DieId,
                        principalSchema: "DieStatus",
                        principalTable: "Die",
                        principalColumn: "DieId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DieStatus.DieTracker_DieStatus.PartNumber_PartNumberId",
                        column: x => x.PartNumberId,
                        principalSchema: "DieStatus",
                        principalTable: "PartNumber",
                        principalColumn: "PartNumberId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GageCall",
                schema: "Alert",
                columns: table => new
                {
                    GageCallId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MachineId = table.Column<int>(nullable: false),
                    QualityTechName = table.Column<string>(nullable: true),
                    Characteristics = table.Column<string>(nullable: true),
                    ApplicationUserId = table.Column<string>(maxLength: 128, nullable: true),
                    TieIn = table.Column<bool>(nullable: false),
                    Containment = table.Column<bool>(nullable: false),
                    RequestTimeStamp = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsTurnOver = table.Column<bool>(nullable: false),
                    GaugeCallTypeId = table.Column<int>(nullable: false),
                    GaugeStationId = table.Column<int>(nullable: false),
                    OperatorComment = table.Column<string>(nullable: true),
                    TechComment = table.Column<string>(nullable: true),
                    StartTimeStamp = table.Column<DateTime>(type: "datetime", nullable: true),
                    EndTimeStamp = table.Column<DateTime>(type: "datetime", nullable: true),
                    RequestedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    HourId = table.Column<int>(nullable: true),
                    HxHId = table.Column<int>(nullable: true),
                    OperatorDowntimeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GageCall", x => x.GageCallId);
                    table.ForeignKey(
                        name: "FK_Alert.GageCall_dbo.AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Alert.GageCall_Gauge.GaugeCallType_GaugeCallTypeId",
                        column: x => x.GaugeCallTypeId,
                        principalSchema: "Gauge",
                        principalTable: "GaugeCallType",
                        principalColumn: "GaugeCallTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Alert.GageCall_Gauge.GaugeStation_GaugeStationId",
                        column: x => x.GaugeStationId,
                        principalSchema: "Gauge",
                        principalTable: "GaugeStation",
                        principalColumn: "GaugeStationId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Alert.GageCall_Maintenance.Machine_MachineId",
                        column: x => x.MachineId,
                        principalSchema: "Maintenance",
                        principalTable: "Machine",
                        principalColumn: "MachineId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Alert.GageCall_Iconics.OperatorDowntime_OperatorDowntimeId",
                        column: x => x.OperatorDowntimeId,
                        principalSchema: "Iconics",
                        principalTable: "OperatorDowntime",
                        principalColumn: "OperatorDowntimeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MaintenanceAlert",
                schema: "Alert",
                columns: table => new
                {
                    MaintenanceAlertId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MachineId = table.Column<int>(nullable: false),
                    SubMachineId = table.Column<int>(nullable: false),
                    RequestDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    WorkingDateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    CompletedDateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsWorking = table.Column<bool>(nullable: false),
                    IsComplete = table.Column<bool>(nullable: false),
                    ResponseComment = table.Column<string>(nullable: true),
                    ApplicationUserId = table.Column<string>(maxLength: 128, nullable: true),
                    MaintenanceBreakDownReasonId = table.Column<int>(nullable: false),
                    BreakdownComments = table.Column<string>(nullable: true),
                    MaintenanceTechClockNumbers = table.Column<string>(nullable: true),
                    SupervisorId = table.Column<string>(nullable: true),
                    ClockNumberStr = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    IsFollowUp = table.Column<bool>(nullable: false),
                    StartedFrom = table.Column<string>(nullable: true),
                    EndedFrom = table.Column<string>(nullable: true),
                    BreakdownReason2Id = table.Column<int>(nullable: true),
                    HourId = table.Column<int>(nullable: true),
                    HxHId = table.Column<int>(nullable: true),
                    OperatorDowntimeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaintenanceAlert", x => x.MaintenanceAlertId);
                    table.ForeignKey(
                        name: "FK_Alert.MaintenanceAlert_dbo.AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Alert.MaintenanceAlert_Alert.BreakdownReason2_BreakdownReason2Id",
                        column: x => x.BreakdownReason2Id,
                        principalSchema: "Alert",
                        principalTable: "BreakdownReason2",
                        principalColumn: "BreakdownReason2Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Alert.MaintenanceAlert_Maintenance.Machine_MachineId",
                        column: x => x.MachineId,
                        principalSchema: "Maintenance",
                        principalTable: "Machine",
                        principalColumn: "MachineId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Alert.MaintenanceAlert_Alert.MaintenanceBreakDownReason_MaintenanceBreakDownReasonId",
                        column: x => x.MaintenanceBreakDownReasonId,
                        principalSchema: "Alert",
                        principalTable: "MaintenanceBreakDownReason",
                        principalColumn: "MaintenanceBreakDownReasonId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Alert.MaintenanceAlert_Iconics.OperatorDowntime_OperatorDowntimeId",
                        column: x => x.OperatorDowntimeId,
                        principalSchema: "Iconics",
                        principalTable: "OperatorDowntime",
                        principalColumn: "OperatorDowntimeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Alert.MaintenanceAlert_Maintenance.SubMachine_SubMachineId",
                        column: x => x.SubMachineId,
                        principalSchema: "Maintenance",
                        principalTable: "SubMachine",
                        principalColumn: "SubMachineId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProcessTech",
                schema: "Alert",
                columns: table => new
                {
                    ProcessTechId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MachineId = table.Column<int>(nullable: false),
                    SubMachineId = table.Column<int>(nullable: false),
                    MaintenanceBreakDownReasonId = table.Column<int>(nullable: false),
                    BreakdownComments = table.Column<string>(nullable: true),
                    RequestDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    WorkingDateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    CompletedDateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsWorking = table.Column<bool>(nullable: false),
                    IsComplete = table.Column<bool>(nullable: false),
                    IsFollowUp = table.Column<bool>(nullable: false),
                    ApplicationUserId = table.Column<string>(maxLength: 128, nullable: true),
                    ProcessTechClockNumbers = table.Column<string>(nullable: true),
                    ClockNumberStr = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    ResponseComment = table.Column<string>(nullable: true),
                    SupervisorId = table.Column<string>(nullable: true),
                    IsVisionTech = table.Column<bool>(nullable: false),
                    BreakdownReason2Id = table.Column<int>(nullable: true),
                    HourId = table.Column<int>(nullable: true),
                    HxHId = table.Column<int>(nullable: true),
                    OperatorDowntimeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcessTech", x => x.ProcessTechId);
                    table.ForeignKey(
                        name: "FK_Alert.ProcessTech_dbo.AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Alert.ProcessTech_Alert.BreakdownReason2_BreakdownReason2Id",
                        column: x => x.BreakdownReason2Id,
                        principalSchema: "Alert",
                        principalTable: "BreakdownReason2",
                        principalColumn: "BreakdownReason2Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Alert.ProcessTech_Maintenance.Machine_MachineId",
                        column: x => x.MachineId,
                        principalSchema: "Maintenance",
                        principalTable: "Machine",
                        principalColumn: "MachineId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Alert.ProcessTech_Alert.MaintenanceBreakDownReason_MaintenanceBreakDownReasonId",
                        column: x => x.MaintenanceBreakDownReasonId,
                        principalSchema: "Alert",
                        principalTable: "MaintenanceBreakDownReason",
                        principalColumn: "MaintenanceBreakDownReasonId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Alert.ProcessTech_Iconics.OperatorDowntime_OperatorDowntimeId",
                        column: x => x.OperatorDowntimeId,
                        principalSchema: "Iconics",
                        principalTable: "OperatorDowntime",
                        principalColumn: "OperatorDowntimeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Alert.ProcessTech_Maintenance.SubMachine_SubMachineId",
                        column: x => x.SubMachineId,
                        principalSchema: "Maintenance",
                        principalTable: "SubMachine",
                        principalColumn: "SubMachineId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserId",
                table: "AspNetUserRoles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "UserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserId",
                table: "Assignments",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentId",
                table: "Assignments",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_TopicsId",
                table: "Assignments",
                column: "TopicsId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserId",
                table: "Departments",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentId",
                table: "EmailNotificationRecipients",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_ShiftNameId",
                table: "EmailNotificationRecipients",
                column: "ShiftNameId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserId",
                table: "SupervisorConversations",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AssignmentsId",
                table: "SupervisorConversations",
                column: "AssignmentsId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentId",
                table: "SupervisorConversations",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeFeedbackId",
                table: "SupervisorConversations",
                column: "EmployeeFeedbackId");

            migrationBuilder.CreateIndex(
                name: "IX_ShiftNameId",
                table: "SupervisorConversations",
                column: "ShiftNameId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserId",
                table: "Topics",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserId",
                table: "UserDepartments",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentId",
                table: "UserDepartments",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserId",
                schema: "Alert",
                table: "BreakdownReason2",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MaintenanceBreakDownReasonId",
                schema: "Alert",
                table: "BreakdownReason2",
                column: "MaintenanceBreakDownReasonId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserId",
                schema: "Alert",
                table: "Forklift",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ForkliftTaskId",
                schema: "Alert",
                table: "Forklift",
                column: "ForkliftTaskId");

            migrationBuilder.CreateIndex(
                name: "IX_MachineId",
                schema: "Alert",
                table: "Forklift",
                column: "MachineId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserId",
                schema: "Alert",
                table: "ForkliftTask",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentId",
                schema: "Alert",
                table: "ForkliftTask",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserId",
                schema: "Alert",
                table: "GageCall",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GaugeCallTypeId",
                schema: "Alert",
                table: "GageCall",
                column: "GaugeCallTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_GaugeStationId",
                schema: "Alert",
                table: "GageCall",
                column: "GaugeStationId");

            migrationBuilder.CreateIndex(
                name: "IX_MachineId",
                schema: "Alert",
                table: "GageCall",
                column: "MachineId");

            migrationBuilder.CreateIndex(
                name: "IX_OperatorDowntimeId",
                schema: "Alert",
                table: "GageCall",
                column: "OperatorDowntimeId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserId",
                schema: "Alert",
                table: "MaintenanceAlert",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_BreakdownReason2Id",
                schema: "Alert",
                table: "MaintenanceAlert",
                column: "BreakdownReason2Id");

            migrationBuilder.CreateIndex(
                name: "IX_MachineId",
                schema: "Alert",
                table: "MaintenanceAlert",
                column: "MachineId");

            migrationBuilder.CreateIndex(
                name: "IX_MaintenanceBreakDownReasonId",
                schema: "Alert",
                table: "MaintenanceAlert",
                column: "MaintenanceBreakDownReasonId");

            migrationBuilder.CreateIndex(
                name: "IX_OperatorDowntimeId",
                schema: "Alert",
                table: "MaintenanceAlert",
                column: "OperatorDowntimeId");

            migrationBuilder.CreateIndex(
                name: "IX_SubMachineId",
                schema: "Alert",
                table: "MaintenanceAlert",
                column: "SubMachineId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserId",
                schema: "Alert",
                table: "MaintenanceAlertLog",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_BreakdownReason2Id",
                schema: "Alert",
                table: "MaintenanceAlertLog",
                column: "BreakdownReason2Id");

            migrationBuilder.CreateIndex(
                name: "IX_MachineId",
                schema: "Alert",
                table: "MaintenanceAlertLog",
                column: "MachineId");

            migrationBuilder.CreateIndex(
                name: "IX_MaintenanceBreakDownReasonId",
                schema: "Alert",
                table: "MaintenanceAlertLog",
                column: "MaintenanceBreakDownReasonId");

            migrationBuilder.CreateIndex(
                name: "IX_SubMachineId",
                schema: "Alert",
                table: "MaintenanceAlertLog",
                column: "SubMachineId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserId",
                schema: "Alert",
                table: "MaintenanceBreakDownReason",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentId",
                schema: "Alert",
                table: "MaintenanceBreakDownReason",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserId",
                schema: "Alert",
                table: "ProcessTech",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_BreakdownReason2Id",
                schema: "Alert",
                table: "ProcessTech",
                column: "BreakdownReason2Id");

            migrationBuilder.CreateIndex(
                name: "IX_MachineId",
                schema: "Alert",
                table: "ProcessTech",
                column: "MachineId");

            migrationBuilder.CreateIndex(
                name: "IX_MaintenanceBreakDownReasonId",
                schema: "Alert",
                table: "ProcessTech",
                column: "MaintenanceBreakDownReasonId");

            migrationBuilder.CreateIndex(
                name: "IX_OperatorDowntimeId",
                schema: "Alert",
                table: "ProcessTech",
                column: "OperatorDowntimeId");

            migrationBuilder.CreateIndex(
                name: "IX_SubMachineId",
                schema: "Alert",
                table: "ProcessTech",
                column: "SubMachineId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserId",
                schema: "DieStatus",
                table: "Block",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PartNumberId",
                schema: "DieStatus",
                table: "Block",
                column: "PartNumberId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserId",
                schema: "DieStatus",
                table: "CastingCell",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserId",
                schema: "DieStatus",
                table: "Die",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_BlockId",
                schema: "DieStatus",
                table: "Die",
                column: "BlockId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserId",
                schema: "DieStatus",
                table: "DieTracker",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_CastingCellName",
                schema: "DieStatus",
                table: "DieTracker",
                column: "CastingCellName");

            migrationBuilder.CreateIndex(
                name: "IX_DieId",
                schema: "DieStatus",
                table: "DieTracker",
                column: "DieId");

            migrationBuilder.CreateIndex(
                name: "IX_PartNumberId",
                schema: "DieStatus",
                table: "DieTracker",
                column: "PartNumberId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserId",
                schema: "DieStatus",
                table: "PartNumber",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserId",
                schema: "Discipline",
                table: "Discipline",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentId",
                schema: "Discipline",
                table: "Discipline",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_DisciplineLevelsId",
                schema: "Discipline",
                table: "Discipline",
                column: "DisciplineLevelsId");

            migrationBuilder.CreateIndex(
                name: "IX_DisciplineTopicId",
                schema: "Discipline",
                table: "Discipline",
                column: "DisciplineTopicId");

            migrationBuilder.CreateIndex(
                name: "IX_ShiftNameId",
                schema: "Discipline",
                table: "Discipline",
                column: "ShiftNameId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserId",
                schema: "Discipline",
                table: "DisciplineLevels",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserId",
                schema: "Discipline",
                table: "DisciplineTopic",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserId",
                schema: "FmsbWeb",
                table: "Area",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserId",
                schema: "FmsbWeb",
                table: "KPI",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserId",
                schema: "FmsbWeb",
                table: "KpiByProgram",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AreaId",
                schema: "FmsbWeb",
                table: "KpiByProgram",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_KPIId",
                schema: "FmsbWeb",
                table: "KpiByProgram",
                column: "KPIId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgramId",
                schema: "FmsbWeb",
                table: "KpiByProgram",
                column: "ProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserId",
                schema: "FmsbWeb",
                table: "KPITarget",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AreaId",
                schema: "FmsbWeb",
                table: "KPITarget",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_KPIId",
                schema: "FmsbWeb",
                table: "KPITarget",
                column: "KPIId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserId",
                schema: "FmsbWeb",
                table: "Program",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserId",
                schema: "HxH",
                table: "HxHPushAlerts",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserId",
                schema: "Iconics",
                table: "DowntimeTriggerThreshold",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_BreakdownReason2Id",
                schema: "Iconics",
                table: "OperatorDowntime",
                column: "BreakdownReason2Id");

            migrationBuilder.CreateIndex(
                name: "IX_MachineId",
                schema: "Iconics",
                table: "OperatorDowntime",
                column: "MachineId");

            migrationBuilder.CreateIndex(
                name: "IX_MaintenanceBreakDownReasonId",
                schema: "Iconics",
                table: "OperatorDowntime",
                column: "MaintenanceBreakDownReasonId");

            migrationBuilder.CreateIndex(
                name: "IX_SubMachineId",
                schema: "Iconics",
                table: "OperatorDowntime",
                column: "SubMachineId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserId",
                schema: "Maintenance",
                table: "EstimatedPM",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MachineId",
                schema: "Maintenance",
                table: "EstimatedPM",
                column: "MachineId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserId",
                schema: "Maintenance",
                table: "Machine",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentId",
                schema: "Maintenance",
                table: "Machine",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserId",
                schema: "Maintenance",
                table: "MaintenanceTech",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ShiftNameId",
                schema: "Maintenance",
                table: "MaintenanceTech",
                column: "ShiftNameId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserId",
                schema: "Maintenance",
                table: "PreventiveMaintenance",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MachineId",
                schema: "Maintenance",
                table: "PreventiveMaintenance",
                column: "MachineId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserId",
                schema: "Maintenance",
                table: "SubMachine",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MachineId",
                schema: "Maintenance",
                table: "SubMachine",
                column: "MachineId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserId",
                schema: "Maintenance",
                table: "SubMachinePM",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PreventiveMaintenanceId",
                schema: "Maintenance",
                table: "SubMachinePM",
                column: "PreventiveMaintenanceId");

            migrationBuilder.CreateIndex(
                name: "IX_SubMachineId",
                schema: "Maintenance",
                table: "SubMachinePM",
                column: "SubMachineId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserId",
                schema: "Overtime",
                table: "ClockNumber",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserId",
                schema: "Overtime",
                table: "EmployeeJob",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ClockNumberId",
                schema: "Overtime",
                table: "EmployeeJob",
                column: "ClockNumberId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentId",
                schema: "Overtime",
                table: "EmployeeJob",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_JobTitleId",
                schema: "Overtime",
                table: "EmployeeJob",
                column: "JobTitleId");

            migrationBuilder.CreateIndex(
                name: "IX_ShiftNameId",
                schema: "Overtime",
                table: "EmployeeJob",
                column: "ShiftNameId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserId",
                schema: "Overtime",
                table: "JobTitle",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentId",
                schema: "Overtime",
                table: "JobTitle",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserId",
                schema: "Overtime",
                table: "OvertimeCategory",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserId",
                schema: "Overtime",
                table: "OvertimeLog",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ClockNumberId",
                schema: "Overtime",
                table: "OvertimeLog",
                column: "ClockNumberId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentId",
                schema: "Overtime",
                table: "OvertimeLog",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_OvertimeCategoryId",
                schema: "Overtime",
                table: "OvertimeLog",
                column: "OvertimeCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserId",
                schema: "ProcessTechs",
                table: "ProcessTechName",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentId",
                schema: "ProcessTechs",
                table: "ProcessTechName",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_ShiftNameId",
                schema: "ProcessTechs",
                table: "ProcessTechName",
                column: "ShiftNameId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "__MigrationHistory");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "EmailNotificationRecipients");

            migrationBuilder.DropTable(
                name: "OperatorAutoDowntimeEmailRecipients");

            migrationBuilder.DropTable(
                name: "SP_GetClockNumbers_Result");

            migrationBuilder.DropTable(
                name: "SupervisorConversations");

            migrationBuilder.DropTable(
                name: "UserDepartments");

            migrationBuilder.DropTable(
                name: "Forklift",
                schema: "Alert");

            migrationBuilder.DropTable(
                name: "GageCall",
                schema: "Alert");

            migrationBuilder.DropTable(
                name: "MaintenanceAlert",
                schema: "Alert");

            migrationBuilder.DropTable(
                name: "MaintenanceAlertLog",
                schema: "Alert");

            migrationBuilder.DropTable(
                name: "ProcessTech",
                schema: "Alert");

            migrationBuilder.DropTable(
                name: "DieTracker",
                schema: "DieStatus");

            migrationBuilder.DropTable(
                name: "Discipline",
                schema: "Discipline");

            migrationBuilder.DropTable(
                name: "KpiByProgram",
                schema: "FmsbWeb");

            migrationBuilder.DropTable(
                name: "KPITarget",
                schema: "FmsbWeb");

            migrationBuilder.DropTable(
                name: "HxHPushAlerts",
                schema: "HxH");

            migrationBuilder.DropTable(
                name: "DowntimeTriggerThreshold",
                schema: "Iconics");

            migrationBuilder.DropTable(
                name: "EstimatedPM",
                schema: "Maintenance");

            migrationBuilder.DropTable(
                name: "MaintenanceTech",
                schema: "Maintenance");

            migrationBuilder.DropTable(
                name: "SubMachinePM",
                schema: "Maintenance");

            migrationBuilder.DropTable(
                name: "EmployeeJob",
                schema: "Overtime");

            migrationBuilder.DropTable(
                name: "OvertimeLog",
                schema: "Overtime");

            migrationBuilder.DropTable(
                name: "ProcessTechName",
                schema: "ProcessTechs");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Assignments");

            migrationBuilder.DropTable(
                name: "EmployeeFeedbacks");

            migrationBuilder.DropTable(
                name: "ForkliftTask",
                schema: "Alert");

            migrationBuilder.DropTable(
                name: "GaugeCallType",
                schema: "Gauge");

            migrationBuilder.DropTable(
                name: "GaugeStation",
                schema: "Gauge");

            migrationBuilder.DropTable(
                name: "OperatorDowntime",
                schema: "Iconics");

            migrationBuilder.DropTable(
                name: "CastingCell",
                schema: "DieStatus");

            migrationBuilder.DropTable(
                name: "Die",
                schema: "DieStatus");

            migrationBuilder.DropTable(
                name: "DisciplineLevels",
                schema: "Discipline");

            migrationBuilder.DropTable(
                name: "DisciplineTopic",
                schema: "Discipline");

            migrationBuilder.DropTable(
                name: "Program",
                schema: "FmsbWeb");

            migrationBuilder.DropTable(
                name: "Area",
                schema: "FmsbWeb");

            migrationBuilder.DropTable(
                name: "KPI",
                schema: "FmsbWeb");

            migrationBuilder.DropTable(
                name: "PreventiveMaintenance",
                schema: "Maintenance");

            migrationBuilder.DropTable(
                name: "JobTitle",
                schema: "Overtime");

            migrationBuilder.DropTable(
                name: "ClockNumber",
                schema: "Overtime");

            migrationBuilder.DropTable(
                name: "OvertimeCategory",
                schema: "Overtime");

            migrationBuilder.DropTable(
                name: "ShiftNames");

            migrationBuilder.DropTable(
                name: "Topics");

            migrationBuilder.DropTable(
                name: "BreakdownReason2",
                schema: "Alert");

            migrationBuilder.DropTable(
                name: "SubMachine",
                schema: "Maintenance");

            migrationBuilder.DropTable(
                name: "Block",
                schema: "DieStatus");

            migrationBuilder.DropTable(
                name: "MaintenanceBreakDownReason",
                schema: "Alert");

            migrationBuilder.DropTable(
                name: "Machine",
                schema: "Maintenance");

            migrationBuilder.DropTable(
                name: "PartNumber",
                schema: "DieStatus");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
