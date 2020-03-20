using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FmsbwebCoreApi.Migrations.Fmsb2
{
    public partial class addyearforkpitargettable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropColumn(
            //    name: "DeptId",
            //    table: "DowntimeDataList2_Copy");

            //migrationBuilder.DropColumn(
            //    name: "Id",
            //    table: "DowntimeDataList2_Copy");

            migrationBuilder.AddColumn<int>(
                name: "Year",
                table: "KpiTarget",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Year",
                table: "KpiTarget");

            //migrationBuilder.AddColumn<int>(
            //    name: "DeptId",
            //    table: "DowntimeDataList2_Copy",
            //    type: "int",
            //    nullable: true);

            //migrationBuilder.AddColumn<Guid>(
            //    name: "Id",
            //    table: "DowntimeDataList2_Copy",
            //    type: "uniqueidentifier",
            //    nullable: false,
            //    defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }
    }
}
