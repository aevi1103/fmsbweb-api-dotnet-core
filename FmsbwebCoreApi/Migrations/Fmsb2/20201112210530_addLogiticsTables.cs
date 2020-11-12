using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FmsbwebCoreApi.Migrations.Fmsb2
{
    public partial class addLogiticsTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LogisticCustomerNames",
                columns: table => new
                {
                    LogisticCustomerNameId = table.Column<string>(nullable: false),
                    DateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogisticCustomerNames", x => x.LogisticCustomerNameId);
                });

            migrationBuilder.CreateTable(
                name: "LogisticsInventoryCostTypes",
                columns: table => new
                {
                    LogisticsInventoryCostTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(nullable: true),
                    TimeStamp = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogisticsInventoryCostTypes", x => x.LogisticsInventoryCostTypeId);
                });

            migrationBuilder.CreateTable(
                name: "LogisticsInventoryCostTargets",
                columns: table => new
                {
                    LogisticsInventoryCostTargetId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogisticsInventoryCostTypeId = table.Column<int>(nullable: false),
                    Target = table.Column<decimal>(nullable: false),
                    TimeStamp = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogisticsInventoryCostTargets", x => x.LogisticsInventoryCostTargetId);
                    table.ForeignKey(
                        name: "FK_LogisticsInventoryCostTargets_LogisticsInventoryCostTypes_LogisticsInventoryCostTypeId",
                        column: x => x.LogisticsInventoryCostTypeId,
                        principalTable: "LogisticsInventoryCostTypes",
                        principalColumn: "LogisticsInventoryCostTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LogisticsInventoryCostTargets_LogisticsInventoryCostTypeId",
                table: "LogisticsInventoryCostTargets",
                column: "LogisticsInventoryCostTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LogisticCustomerNames");

            migrationBuilder.DropTable(
                name: "LogisticsInventoryCostTargets");

            migrationBuilder.DropTable(
                name: "LogisticsInventoryCostTypes");
        }
    }
}
