using Microsoft.EntityFrameworkCore.Migrations;

namespace FmsbwebCoreApi.Migrations.Iconics
{
    public partial class updateGroupName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Group",
                table: "KepServerTagNameGroups");

            migrationBuilder.AddColumn<string>(
                name: "GroupName",
                table: "KepServerTagNameMonitors",
                maxLength: 5,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GroupName",
                table: "KepServerTagNameGroups",
                maxLength: 5,
                nullable: false,
                defaultValue: "");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "GroupName",
                table: "KepServerTagNameGroups");

            migrationBuilder.AddColumn<int>(
                name: "KepServerTagNameGroupId",
                table: "KepServerTagNameMonitors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KepServerTagNameGroupId",
                table: "KepServerTagNameGroups",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Group",
                table: "KepServerTagNameGroups",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
    }
}
