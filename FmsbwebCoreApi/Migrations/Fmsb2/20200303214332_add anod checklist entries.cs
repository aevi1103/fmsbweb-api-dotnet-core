using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FmsbwebCoreApi.Migrations.Fmsb2
{
    public partial class addanodchecklistentries : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AnodizeChecklistEntries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnodizeChecklistId = table.Column<int>(nullable: false),
                    Value = table.Column<string>(nullable: true),
                    CreateHxHHrId = table.Column<int>(nullable: true),
                    HrId = table.Column<int>(nullable: false),
                    Stamp = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnodizeChecklistEntries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnodizeChecklistEntries_AnodizeChecklist_AnodizeChecklistId",
                        column: x => x.AnodizeChecklistId,
                        principalTable: "AnodizeChecklist",
                        principalColumn: "AnodizeChecklistId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnodizeChecklistEntries_CreateHxH_CreateHxHHrId",
                        column: x => x.CreateHxHHrId,
                        principalTable: "CreateHxH",
                        principalColumn: "hrId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnodizeChecklistEntries_AnodizeChecklistId",
                table: "AnodizeChecklistEntries",
                column: "AnodizeChecklistId");

            migrationBuilder.CreateIndex(
                name: "IX_AnodizeChecklistEntries_CreateHxHHrId",
                table: "AnodizeChecklistEntries",
                column: "CreateHxHHrId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnodizeChecklistEntries");
        }
    }
}
