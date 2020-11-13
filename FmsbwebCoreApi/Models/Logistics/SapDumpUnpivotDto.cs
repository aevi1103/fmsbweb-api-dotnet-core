using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Models.Logistics
{
    public class SapDumpUnpivotDto
    {
        //todo: just do a p4,p5,p3,p2,p1
        public IReadOnlyCollection<string> NonRawMaterialParts => new List<string>() { "P5C", "P4H", "P3M", "P2F", "P2A", "P1A" };

        public long Id { get; set; }
        public string Material { get; set; }
        public string Program { get; set; }
        public string ValuationClass { get; set; }
        public DateTime? Date { get; set; }
        public string Location { get; set; }
        public decimal? Qty { get; set; }
        public decimal? SafetyStock { get; set; }
        public decimal? StandardPrice { get; set; }
        public int? Per { get; set; }
        public string Type { get; set; }
        public decimal? StandardPricePerPc { get; set; }
        public decimal? PricePerQty { get; set; }
        public int SlocOrder { get; set; }

        public string Sloc => GetSloc();
        public bool IsRawMaterial => Type.Contains("7", StringComparison.CurrentCultureIgnoreCase);
        public bool IsDmax => Program.ToLower(new CultureInfo("en-US")) == "dmax";
        public string CostType => GetCostType();

        private string GetSloc()
        {
            return Type switch
            {
                "P1A" when Program == "DMAX" && Location.Trim() == "0300" => "SBT – Finish Goods",
                "P1A" when Program != "DMAX" && Location.Trim() == "0300" => "SB – Finish Goods",
                _ => Type switch
                {
                    "P5C" => "Foundry Casting (0115, 0125)",
                    "P3M" => "Machine WIP (0130)",
                    "P2F" => "Finishing (P2F)",
                    _ => ""
                }
            };
        }

        private string GetCostType()
        {

            if (Program != "DMAX" && !IsRawMaterial && NonRawMaterialParts.Contains(Type) && Location == "NotIn0300")
            {
                return "SB – WIP"; //not in 0300
            }

            if (Program == "DMAX" && !IsRawMaterial && NonRawMaterialParts.Contains(Type) && Location == "NotIn0300")
            {
                return "SBT – WIP";
            }

            if (!IsDmax && !IsRawMaterial && Type == "P1A" && Location == "0300")
            {
                return "SB – Finish Goods"; // in 0300
            }

            if (IsDmax && !IsRawMaterial && Type == "P1A" && Location == "0300")
            {
                return "SBT – Finish Goods";
            }

            if (!IsDmax && IsRawMaterial)
            {
                return "SB – Raw Material"; //get unrestricted 
            }

            if (IsDmax && IsRawMaterial)
            {
                return "SBT – Raw Material";
            }

            return null;
        }
    }
}
