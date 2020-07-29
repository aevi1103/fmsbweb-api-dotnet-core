﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.ResourceParameters
{
    public class ProductionResourceParameter
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Area { get; set; } = "";
        public string Line { get; set; } = "";
        public string Shift { get; set; } = "";
        public List<string> WorkCenters { get; set; } = new List<string>();
        public List<string> MachinesHxh { get; set; } = new List<string>();
    }
}
