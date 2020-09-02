using Microsoft.EntityFrameworkCore.Migrations;

namespace FmsbwebCoreApi.Migrations.Intranet
{
    public partial class renameTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EOLVS_EOS_MANNING_Operators_OperatorId",
                schema: "dbo",
                table: "EOLVS_EOS_MANNING");

            migrationBuilder.DropForeignKey(
                name: "FK_EOLVS_EOS_MANNING_OperatorJobs_OperatorJobId",
                schema: "dbo",
                table: "EOLVS_EOS_MANNING");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Operators",
                schema: "db_owner",
                table: "Operators");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OperatorJobs",
                schema: "db_owner",
                table: "OperatorJobs");

            migrationBuilder.RenameTable(
                name: "Operators",
                schema: "db_owner",
                newName: "EOLVS_EOS_OPERATORS",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "OperatorJobs",
                schema: "db_owner",
                newName: "EOLVS_EOS_OPERATOR_JOBS",
                newSchema: "dbo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EOLVS_EOS_OPERATORS",
                schema: "dbo",
                table: "EOLVS_EOS_OPERATORS",
                column: "OperatorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EOLVS_EOS_OPERATOR_JOBS",
                schema: "dbo",
                table: "EOLVS_EOS_OPERATOR_JOBS",
                column: "OperatorJobId");

            migrationBuilder.AddForeignKey(
                name: "FK_EOLVS_EOS_MANNING_EOLVS_EOS_OPERATORS_OperatorId",
                schema: "dbo",
                table: "EOLVS_EOS_MANNING",
                column: "OperatorId",
                principalSchema: "dbo",
                principalTable: "EOLVS_EOS_OPERATORS",
                principalColumn: "OperatorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EOLVS_EOS_MANNING_EOLVS_EOS_OPERATOR_JOBS_OperatorJobId",
                schema: "dbo",
                table: "EOLVS_EOS_MANNING",
                column: "OperatorJobId",
                principalSchema: "dbo",
                principalTable: "EOLVS_EOS_OPERATOR_JOBS",
                principalColumn: "OperatorJobId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EOLVS_EOS_MANNING_EOLVS_EOS_OPERATORS_OperatorId",
                schema: "dbo",
                table: "EOLVS_EOS_MANNING");

            migrationBuilder.DropForeignKey(
                name: "FK_EOLVS_EOS_MANNING_EOLVS_EOS_OPERATOR_JOBS_OperatorJobId",
                schema: "dbo",
                table: "EOLVS_EOS_MANNING");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EOLVS_EOS_OPERATORS",
                schema: "dbo",
                table: "EOLVS_EOS_OPERATORS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EOLVS_EOS_OPERATOR_JOBS",
                schema: "dbo",
                table: "EOLVS_EOS_OPERATOR_JOBS");

            migrationBuilder.EnsureSchema(
                name: "db_owner");

            migrationBuilder.RenameTable(
                name: "EOLVS_EOS_OPERATORS",
                schema: "dbo",
                newName: "Operators",
                newSchema: "db_owner");

            migrationBuilder.RenameTable(
                name: "EOLVS_EOS_OPERATOR_JOBS",
                schema: "dbo",
                newName: "OperatorJobs",
                newSchema: "db_owner");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Operators",
                schema: "db_owner",
                table: "Operators",
                column: "OperatorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OperatorJobs",
                schema: "db_owner",
                table: "OperatorJobs",
                column: "OperatorJobId");

            migrationBuilder.AddForeignKey(
                name: "FK_EOLVS_EOS_MANNING_Operators_OperatorId",
                schema: "dbo",
                table: "EOLVS_EOS_MANNING",
                column: "OperatorId",
                principalSchema: "db_owner",
                principalTable: "Operators",
                principalColumn: "OperatorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EOLVS_EOS_MANNING_OperatorJobs_OperatorJobId",
                schema: "dbo",
                table: "EOLVS_EOS_MANNING",
                column: "OperatorJobId",
                principalSchema: "db_owner",
                principalTable: "OperatorJobs",
                principalColumn: "OperatorJobId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
