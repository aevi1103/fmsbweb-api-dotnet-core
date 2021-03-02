using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using FmsbwebCoreApi.Entity.Safety;
using FmsbwebCoreApi.Models;

namespace FmsbwebCoreApi.Profiles
{
    public class SafetyProfile : Profile
    {
        public SafetyProfile()
        {
            CreateMap<SafetyIncidenceDto, Incidence>();
            CreateMap<Incidence, SafetyIncidenceDto>();
        }
    }
}
