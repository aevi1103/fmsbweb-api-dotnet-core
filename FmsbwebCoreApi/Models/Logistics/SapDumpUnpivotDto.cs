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
        public int SlocOrder2 => GetSlocOrder();
        public bool IsRawMaterial => Type.Contains("7", StringComparison.CurrentCultureIgnoreCase);
        public bool IsDmax => Program.ToLower(new CultureInfo("en-US")) == "dmax";
        public string CostType => GetCostType();
        public int CostTypeOrder => GetCostTypeOrder();

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

        private int GetSlocOrder()
        {
            return Type switch
            {
                "P1A" when Program == "DMAX" && Location.Trim() == "0300" => 5,
                "P1A" when Program != "DMAX" && Location.Trim() == "0300" => 4,
                _ => Type switch
                {
                    "P5C" => 1,
                    "P3M" => 2,
                    "P2F" => 3,
                    _ => 9999
                }
            };
        }

        private string GetCostType()
        {

            if (Program != "DMAX" && !IsRawMaterial && NonRawMaterialParts.Contains(Type) && Location == "NotIn0300")
                return "SB – WIP"; //not in 0300

            if (Program == "DMAX" && !IsRawMaterial && NonRawMaterialParts.Contains(Type) && Location == "NotIn0300")
                return "SBT – WIP";

            if (!IsDmax && !IsRawMaterial && Type == "P1A" && Location == "0300")
                return "SB – Finish Goods"; // in 0300

            if (IsDmax && !IsRawMaterial && Type == "P1A" && Location == "0300")
                return "SBT – Finish Goods";

            if (!IsDmax && IsRawMaterial)
                return "SB – Raw Material"; //get unrestricted 

            if (IsDmax && IsRawMaterial)
                return "SBT – Raw Material";

            return null;
        }

        private int GetCostTypeOrder()
        {
            if (!IsDmax && IsRawMaterial)
                return 1;

            if (Program != "DMAX" && !IsRawMaterial && NonRawMaterialParts.Contains(Type) && Location == "NotIn0300")
                return 2;

            if (!IsDmax && !IsRawMaterial && Type == "P1A" && Location == "0300")
                return 3;

            if (IsDmax && IsRawMaterial)
                return 4;

            if (Program == "DMAX" && !IsRawMaterial && NonRawMaterialParts.Contains(Type) && Location == "NotIn0300")
                return 5;

            if (IsDmax && !IsRawMaterial && Type == "P1A" && Location == "0300")
                return 6;

            return 9999;
        }
    }
}
