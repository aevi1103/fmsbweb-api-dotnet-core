using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FmsbwebCoreApi.Migrations.Iconics
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KEPServer_MachineDowntime",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tagName = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    isInitialSave = table.Column<bool>(nullable: true),
                    start_stamp = table.Column<DateTime>(type: "datetime", nullable: true),
                    end_stamp = table.Column<DateTime>(type: "datetime", nullable: true),
                    downtime_minutes = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    time_stamp = table.Column<DateTime>(type: "datetime", nullable: false),
                    currentVal = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    original_start_stamp = table.Column<DateTime>(type: "datetime", nullable: true),
                    original_end_stamp = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KEPServer_MachineDowntime", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KEPServer_MachineDowntime");
        }
    }
}
