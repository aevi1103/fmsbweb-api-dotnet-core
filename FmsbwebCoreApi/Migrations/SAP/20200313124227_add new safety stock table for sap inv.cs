using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FmsbwebCoreApi.Migrations.SAP
{
    public partial class addnewsafetystocktableforsapinv : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SAP_Dump_With_SafetyStock",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Material = table.Column<string>(maxLength: 50, nullable: true),
                    TotalUnrestInv = table.Column<decimal>(name: "Total Unrest. Inv.", type: "decimal(18, 2)", nullable: true),
                    _0111 = table.Column<decimal>(name: "0111", type: "decimal(18, 2)", nullable: true),
                    _0115 = table.Column<decimal>(name: "0115", type: "decimal(18, 2)", nullable: true),
                    _4001 = table.Column<decimal>(name: "4001", type: "decimal(18, 2)", nullable: true),
                    _4002 = table.Column<decimal>(name: "4002", type: "decimal(18, 2)", nullable: true),
                    _4003 = table.Column<decimal>(name: "4003", type: "decimal(18, 2)", nullable: true),
                    _4004 = table.Column<decimal>(name: "4004", type: "decimal(18, 2)", nullable: true),
                    _4005 = table.Column<decimal>(name: "4005", type: "decimal(18, 2)", nullable: true),
                    _4006 = table.Column<decimal>(name: "4006", type: "decimal(18, 2)", nullable: true),
                    _4007 = table.Column<decimal>(name: "4007", type: "decimal(18, 2)", nullable: true),
                    _4008 = table.Column<decimal>(name: "4008", type: "decimal(18, 2)", nullable: true),
                    _4009 = table.Column<decimal>(name: "4009", type: "decimal(18, 2)", nullable: true),
                    _4010 = table.Column<decimal>(name: "4010", type: "decimal(18, 2)", nullable: true),
                    _5001 = table.Column<decimal>(name: "5001", type: "decimal(18, 2)", nullable: true),
                    _5002 = table.Column<decimal>(name: "5002", type: "decimal(18, 2)", nullable: true),
                    _5003 = table.Column<decimal>(name: "5003", type: "decimal(18, 2)", nullable: true),
                    _5004 = table.Column<decimal>(name: "5004", type: "decimal(18, 2)", nullable: true),
                    _5005 = table.Column<decimal>(name: "5005", type: "decimal(18, 2)", nullable: true),
                    _5006 = table.Column<decimal>(name: "5006", type: "decimal(18, 2)", nullable: true),
                    _5007 = table.Column<decimal>(name: "5007", type: "decimal(18, 2)", nullable: true),
                    _5008 = table.Column<decimal>(name: "5008", type: "decimal(18, 2)", nullable: true),
                    _5009 = table.Column<decimal>(name: "5009", type: "decimal(18, 2)", nullable: true),
                    _5010 = table.Column<decimal>(name: "5010", type: "decimal(18, 2)", nullable: true),
                    QC01 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    QC02 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    _0130 = table.Column<decimal>(name: "0130", type: "decimal(18, 2)", nullable: true),
                    _0131 = table.Column<decimal>(name: "0131", type: "decimal(18, 2)", nullable: true),
                    _0135 = table.Column<decimal>(name: "0135", type: "decimal(18, 2)", nullable: true),
                    _0160 = table.Column<decimal>(name: "0160", type: "decimal(18, 2)", nullable: true),
                    _0300 = table.Column<decimal>(name: "0300", type: "decimal(18, 2)", nullable: true),
                    _0125 = table.Column<decimal>(name: "0125", type: "decimal(18, 2)", nullable: true),
                    _0140 = table.Column<decimal>(name: "0140", type: "decimal(18, 2)", nullable: true),
                    Standardprice = table.Column<decimal>(name: "Standard price", type: "decimal(18, 2)", nullable: true),
                    per = table.Column<int>(nullable: true),
                    ValuationClass = table.Column<string>(name: "Valuation Class", maxLength: 100, nullable: true),
                    MaterialDescription = table.Column<string>(name: "Material Description", maxLength: 100, nullable: true),
                    Program = table.Column<string>(maxLength: 100, nullable: true),
                    SafetyStock = table.Column<int>(nullable: false),
                    uploadDateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    date = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SAP_Dump_With_SafetyStock", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SAP_Dump_With_SafetyStock");
        }
    }
}
