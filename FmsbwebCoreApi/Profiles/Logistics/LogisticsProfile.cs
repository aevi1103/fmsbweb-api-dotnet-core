﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using FmsbwebCoreApi.Entity.SAP;
using FmsbwebCoreApi.Models;
using FmsbwebCoreApi.Models.Logistics;
using FmsbwebCoreApi.ResourceParameters.Logistics;

namespace FmsbwebCoreApi.Profiles.Logistics
{
    public class LogisticsProfile : Profile
    {
        public LogisticsProfile()
        {
            CreateMap<SapDumpWithSafetyStock, SapDumpNewDto>();
            CreateMap<SapDumpNewUnpivotWithUnrestrictedInv, SapDumpUnpivotDto>();
            CreateMap<SapProdOrders, SapProdOrdersDto>();
            CreateMap<InvProgramTargetResourceParameter, InvProgramTargets>();
        }
    }
}
