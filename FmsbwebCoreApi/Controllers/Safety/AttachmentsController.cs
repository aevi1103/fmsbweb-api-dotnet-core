using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using FmsbwebCoreApi.Services.Safety;
using FmsbwebCoreApi.Models.Safety;
using AutoMapper;
using FmsbwebCoreApi.Entity.Safety;
using System.Text;
using FmsbwebCoreApi.Models.Safety.Attachment;
using Microsoft.AspNetCore.Cors;

namespace FmsbwebCoreApi.Controllers.Safety
{
    [ApiController]
    [EnableCors]
    [Route("api/safety/incidents/{id}/attachments")]
    public class AttachmentsController : ControllerBase
    {
        private readonly ISafetyLibraryRepository _safetyLibraryRepository;
        private readonly IMapper _mapper;

        public AttachmentsController(ISafetyLibraryRepository safetyLibraryRepository,
            IMapper mapper)
        {
            _safetyLibraryRepository = safetyLibraryRepository ??
                throw new ArgumentNullException(nameof(safetyLibraryRepository));

            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet(Name = "GetAtachmentsForIncident")]
        public ActionResult<IEnumerable<AttachmentDto>> GetAtachmentsForIncident(int id)
        {
            if (!_safetyLibraryRepository.IncidentExists(id))
            {
                return NotFound();
            }

            var attachmentsFromRepo = _safetyLibraryRepository.GetAttachments(id);
            return Ok(_mapper.Map<IEnumerable<AttachmentDto>>(attachmentsFromRepo));
        }

        [HttpGet("{attachmentId}", Name = "GetAtachmentForIncident")]
        public ActionResult<AttachmentDto> GetAtachmentForIncident(int id, int attachmentId)
        {
            if (!_safetyLibraryRepository.IncidentExists(id))
            {
                return NotFound();
            }

            var attachmentFromRepo = _safetyLibraryRepository.GetAttachment(id, attachmentId);

            if (attachmentFromRepo == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<AttachmentDto>(attachmentFromRepo));
        }

        [HttpPost(Name = "CreateAttachmentForIncident")]
        public ActionResult<AttachmentDto> CreateAttachmentForIncident(int id, AttachmentForCreationDto attachment)
        {
            if (!_safetyLibraryRepository.IncidentExists(id))
            {
                return NotFound();
            }

            var attachmentEntity = _mapper.Map<Attachments>(attachment);
            _safetyLibraryRepository.AddAttachment(id, attachmentEntity);
            _safetyLibraryRepository.Save();

            var attachmentToReturn = _mapper.Map<AttachmentDto>(attachmentEntity);
            return CreatedAtRoute("GetAtachmentForIncident", 
                new { 
                    id,
                    attachmentId = attachmentToReturn.Id
                }, attachmentToReturn);
        }
    }
}