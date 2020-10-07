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
        public string Department { get; set; }
        public string Line { get; set; } = "";
        public string Shift { get; set; } = "";
        public List<string> WorkCenters { get; set; } = new List<string>(); // ASBY0002
        public List<string> MachinesHxh { get; set; } = new List<string>(); // A2
        public List<string> Lines { get; set; } = new List<string>(); // Assembly 2
    }
}
