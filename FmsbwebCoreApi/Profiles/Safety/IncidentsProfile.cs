using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using FmsbwebCoreApi.Entity.Safety;
using FmsbwebCoreApi.Models.Safety.Incident;

namespace FmsbwebCoreApi.Profiles.Safety
{
    public class IncidentsProfile : Profile
    {
        public IncidentsProfile()
        {
            CreateMap<Incidence, IncidentDto>()
                    .ForMember(
                        dest => dest.Name,
                        opt => opt.MapFrom(src => $"{src.Fname} {src.Lname}"))
                    .ForMember(
                        dest => dest.IncidentDate,
                        opt => opt.MapFrom(src => src.AccidentDate)
                    )
                    .ForMember(
                        dest => dest.Injury,
                        opt => opt.MapFrom(src => src.Injury.InjuryName)
                    )
                    .ForMember(
                        dest => dest.BodyPart,
                        opt => opt.MapFrom(src => src.BodyPart.BodyPart1)
                    )
                    .ForMember(
                        dest => dest.InjuryStatus,
                        opt => opt.MapFrom(src => src.InjuryStatId)
                    )
                    .ForMember(
                        dest => dest.NumberOfAttachments,
                        opt => opt.MapFrom(src => src.Attachments.Count)
                    );

            CreateMap<Incidence, IncidentFullDto>()
                   .ForMember(
                       dest => dest.FirstName,
                       opt => opt.MapFrom(src => src.Fname))
                   .ForMember(
                       dest => dest.LastName,
                       opt => opt.MapFrom(src => src.Lname))
                   .ForMember(
                       dest => dest.IncidentDate,
                       opt => opt.MapFrom(src => src.AccidentDate)
                   )
                   .ForMember(
                       dest => dest.Injury,
                       opt => opt.MapFrom(src => src.Injury.InjuryName)
                   )
                   .ForMember(
                       dest => dest.BodyPart,
                       opt => opt.MapFrom(src => src.BodyPart.BodyPart1)
                   )
                   .ForMember(
                       dest => dest.InjuryStatus,
                       opt => opt.MapFrom(src => src.InjuryStatId)
                   )
                   .ForMember(
                       dest => dest.NumberOfAttachments,
                       opt => opt.MapFrom(src => src.Attachments.Count)
                   );

            CreateMap<IncidentForCreationDto, Incidence>();
            CreateMap<IncidentForUpdateDto, Incidence>();
            CreateMap<Incidence, IncidentForUpdateDto>();
        }
    }
}
