using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Models.Logistics
{
    public class SapDumpUnpivotDto
    {
        public int Id { get; set; }
        public string Material { get; set; }
        public string Program { get; set; }
        public string ValuationClass { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public decimal Qty { get; set; }
        public decimal SafetyStock { get; set; }
        public decimal StandardPrice { get; set; }
        public int Per { get; set; }
        public string Type { get; set; }
        public decimal StandardPricePerPc { get; set; }
        public decimal PricePerQty { get; set; }
        public int SlocOrder { get; set; }

        public string Sloc => GetSloc();
        public bool IsRawMaterial => Type.Contains("7", StringComparison.CurrentCultureIgnoreCase);
        public bool IsDmax => Program.ToLower(new CultureInfo("en-US")) == "dmax";
        public string CostType => GetCostType();

        private string GetSloc()
        {
            if (Type == "P1A" && Program == "DMAX")
                return "SBT – Finish Goods";

            return Type switch
            {
                "P5C" => "Foundry Casting (0115, 0125)",
                "P3M" => "Machine WIP (0130)",
                "P2F" => "Finishing (P2F)",
                "P1A" => "SB – Finish Goods",
                _ => ""
            };
        }

        private string GetCostType()
        {
            if (!IsDmax && IsRawMaterial) return "SB – Raw Material";
            if (!IsDmax && !IsRawMaterial) return "SB – WIP";
            if (!IsDmax && !IsRawMaterial && Type == "P1A") return "SB – Finish Goods";

            if (IsDmax && IsRawMaterial) return "SBT – Raw Material";
            if (IsDmax && !IsRawMaterial) return "SB – WIP";
            if (IsDmax && !IsRawMaterial && Type == "P1A") return "SB – Finish Goods";

            return null;
        }
    }
}
