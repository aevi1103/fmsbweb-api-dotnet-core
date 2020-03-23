﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.ResourceParameters.FMSB
{
    public class DowntimeResourceParameter
    {
        public DateTime Start { get; set; } = DateTime.Today;
        public DateTime End { get; set; } = DateTime.Today;
        public string Dept { get; set; } = "";
        public string Line { get; set; } = "";
        public string Shift { get; set; } = "";
    }
}