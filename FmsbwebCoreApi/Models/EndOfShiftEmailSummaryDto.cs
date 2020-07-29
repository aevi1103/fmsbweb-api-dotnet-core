using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Models
{
    public class EndOfShiftEmailSummaryDto
    {
        public string Department { get; set; }
        public string Shift_Date { get; set; }
        public string Shift { get; set; }
        public string Target { get; set; }
        public string OAE_Target { get; set; }
        public string AF_Scrap_Target { get; set; }
        public string Overall_Scrap_Target { get; set; }
        public string HxH_Gross { get; set; }
        public string HxH_OAE { get; set; }
        public string SAP_OAE { get; set; }
        public string SB_Scrap { get; set; }
        public string Purchased_Scrap { get; set; }
        public string AF_Scrap { get; set; }
        public string Overall_Scrap { get; set; }
        public int? Manning { get; set; }
        public decimal PPMH { get; set; }
    }
}
