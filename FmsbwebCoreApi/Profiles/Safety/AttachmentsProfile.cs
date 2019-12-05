using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using FmsbwebCoreApi.Entity.Safety;
using FmsbwebCoreApi.Models.Safety;
using FmsbwebCoreApi.Models.Safety.Attachment;

namespace FmsbwebCoreApi.Profiles.Safety
{
    public class AttachmentsProfile : Profile
    {
        public AttachmentsProfile()
        {
            CreateMap<Attachments, AttachmentDto>()
                    .ForMember(
                        dest => dest.ModifiedDate,
                        opt => opt.MapFrom(src => src.Modifieddate)
                    );

            CreateMap<AttachmentForCreationDto, Attachments>();
        }
    }
}
