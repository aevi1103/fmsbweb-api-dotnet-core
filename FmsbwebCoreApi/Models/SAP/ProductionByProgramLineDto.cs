﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Models.SAP
{
    public class ProductionByProgramLineDto : ProductionDetailsDto
    { 
        public string Program { get; set; }
        public string Line { get; set; }
    }
}
