﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Models.Intranet
{
    public class DailyHxHTargetDto : HxHTargetDto
    {
        public DateTime ShiftDate { get; set; }
    }
}
