﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Models.FMSB2
{
    public class ProductionLaborHoursDto
    {
        public decimal? Regular { get; set; }
        public decimal? Overtime { get; set; }
        public decimal? DoubleTime { get; set; }
        public decimal? Orientation { get; set; }
        public decimal? OverAll { get; set; }

        public decimal? PPMH { get; set; }
        public int? SAPGross { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string LaborTitle { get; set; }

        public LabourHoursDetails InspectorDetails { get; set; }
        public LabourHoursDetails PSODetails { get; set; }
        public LabourHoursDetails OtherDetails { get; set; }

        public IEnumerable<LaborHoursDetailsByType> Details { get; set; }

    }
}
