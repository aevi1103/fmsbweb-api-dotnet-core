using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FmsbwebCoreApi.Migrations.Iconics
{
    public partial class changeGroupsToguidKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KepServerTagNameMonitors_KepServerTagNameGroups_GroupName",
                table: "KepServerTagNameMonitors");

            migrationBuilder.DropIndex(
                name: "IX_KepServerTagNameMonitors_GroupName",
                table: "KepServerTagNameMonitors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_KepServerTagNameGroups",
                table: "KepServerTagNameGroups");

            migrationBuilder.DropColumn(
                name: "GroupName",
                table: "KepServerTagNameMonitors");

            migrationBuilder.AddColumn<Guid>(
                name: "KepServerTagNameGroupId",
                table: "KepServerTagNameMonitors",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<string>(
                name: "GroupName",
                table: "KepServerTagNameGroups",
                maxLength: 5,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5);

            migrationBuilder.AddColumn<Guid>(
                name: "KepServerTagNameGroupId",
                table: "KepServerTagNameGroups",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_KepServerTagNameGroups",
                table: "KepServerTagNameGroups",
                column: "KepServerTagNameGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_KepServerTagNameMonitors_KepServerTagNameGroupId",
                table: "KepServerTagNameMonitors",
                column: "KepServerTagNameGroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_KepServerTagNameMonitors_KepServerTagNameGroups_KepServerTagNameGroupId",
                table: "KepServerTagNameMonitors",
                column: "KepServerTagNameGroupId",
                principalTable: "KepServerTagNameGroups",
                principalColumn: "KepServerTagNameGroupId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KepServerTagNameMonitors_KepServerTagNameGroups_KepServerTagNameGroupId",
                table: "KepServerTagNameMonitors");

            migrationBuilder.DropIndex(
                name: "IX_KepServerTagNameMonitors_KepServerTagNameGroupId",
                table: "KepServerTagNameMonitors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_KepServerTagNameGroups",
                table: "KepServerTagNameGroups");

            migrationBuilder.DropColumn(
                name: "KepServerTagNameGroupId",
                table: "KepServerTagNameMonitors");

            migrationBuilder.DropColumn(
                name: "KepServerTagNameGroupId",
                table: "KepServerTagNameGroups");

            migrationBuilder.AddColumn<string>(
                name: "GroupName",
                table: "KepServerTagNameMonitors",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "GroupName",
                table: "KepServerTagNameGroups",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 5,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_KepServerTagNameGroups",
                table: "KepServerTagNameGroups",
                column: "GroupName");

            migrationBuilder.CreateIndex(
                name: "IX_KepServerTagNameMonitors_GroupName",
                table: "KepServerTagNameMonitors",
                column: "GroupName");

            migrationBuilder.AddForeignKey(
                name: "FK_KepServerTagNameMonitors_KepServerTagNameGroups_GroupName",
                table: "KepServerTagNameMonitors",
                column: "GroupName",
                principalTable: "KepServerTagNameGroups",
                principalColumn: "GroupName",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
