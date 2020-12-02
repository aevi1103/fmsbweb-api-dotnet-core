using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FmsbwebCoreApi.Migrations.Iconics
{
    public partial class AddTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KepServerTagNameGroups",
                columns: table => new
                {
                    KepServerTagNameGroupId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Group = table.Column<string>(nullable: false),
                    TimeStamp = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KepServerTagNameGroups", x => x.KepServerTagNameGroupId);
                });

            //migrationBuilder.CreateTable(
            //    name: "KEPserverTagNames",
            //    columns: table => new
            //    {
            //        TagName = table.Column<string>(type: "varchar(100)", nullable: false),
            //        Address = table.Column<string>(nullable: false),
            //        DataType = table.Column<string>(nullable: false),
            //        Description = table.Column<string>(nullable: false),
            //        Stamp = table.Column<DateTime>(nullable: true),
            //        TagId = table.Column<string>(nullable: false),
            //        line = table.Column<string>(nullable: true),
            //        dept = table.Column<string>(nullable: true),
            //        isLastCounter = table.Column<bool>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_KEPserverTagNames", x => x.TagName);
            //    });

            migrationBuilder.CreateTable(
                name: "KepServerTagNameMonitors",
                columns: table => new
                {
                    KepServerTagNameMonitorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TagName = table.Column<string>(type: "varchar(100)", nullable: false),
                    KepServerTagNameGroupId = table.Column<int>(nullable: false),
                    TimeStamp = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KepServerTagNameMonitors", x => x.KepServerTagNameMonitorId);
                    table.ForeignKey(
                        name: "FK_KepServerTagNameMonitors_KepServerTagNameGroups_KepServerTagNameGroupId",
                        column: x => x.KepServerTagNameGroupId,
                        principalTable: "KepServerTagNameGroups",
                        principalColumn: "KepServerTagNameGroupId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KepServerTagNameMonitors_KEPserverTagNames_TagName",
                        column: x => x.TagName,
                        principalTable: "KEPserverTagNames",
                        principalColumn: "TagName",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_KepServerTagNameMonitors_KepServerTagNameGroupId",
                table: "KepServerTagNameMonitors",
                column: "KepServerTagNameGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_KepServerTagNameMonitors_TagName",
                table: "KepServerTagNameMonitors",
                column: "TagName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KepServerTagNameMonitors");

            migrationBuilder.DropTable(
                name: "KepServerTagNameGroups");

            //migrationBuilder.DropTable(
            //    name: "KEPserverTagNames");
        }
    }
}
