using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FmsbwebCoreApi.Migrations.Fmsb2
{
    public partial class AddProjectTackerTable2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProjectTracker",
                columns: table => new
                {
                    ProjectTrackerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HourByHourId = table.Column<int>(nullable: false),
                    DateTimeRequested = table.Column<DateTime>(nullable: false),
                    ProjectName = table.Column<string>(nullable: true),
                    ProjectDescription = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: true),
                    CompletionDate = table.Column<DateTime>(nullable: true),
                    Comments = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectTracker", x => x.ProjectTrackerId);
                    table.ForeignKey(
                        name: "FK_ProjectTracker_CreateHxH_HourByHourId",
                        column: x => x.HourByHourId,
                        principalTable: "CreateHxH",
                        principalColumn: "hrId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectTracker_HourByHourId",
                table: "ProjectTracker",
                column: "HourByHourId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectTracker");
        }
    }
}
