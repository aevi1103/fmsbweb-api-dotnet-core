using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FmsbwebCoreApi.Migrations.Fmsb2
{
    public partial class adddowntimeownertable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AddColumn<int>(
            //    name: "DeptId",
            //    table: "DowntimeDataList2_Copy",
            //    nullable: true);

            //migrationBuilder.AddColumn<Guid>(
            //    name: "Id",
            //    table: "DowntimeDataList2_Copy",
            //    nullable: false,
            //    defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "DowntimeOwner",
                columns: table => new
                {
                    Owner = table.Column<string>(nullable: false),
                    Color = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DowntimeOwner", x => x.Owner);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DowntimeOwner");

            //migrationBuilder.DropColumn(
            //    name: "DeptId",
            //    table: "DowntimeDataList2_Copy");

            //migrationBuilder.DropColumn(
            //    name: "Id",
            //    table: "DowntimeDataList2_Copy");
        }
    }
}
