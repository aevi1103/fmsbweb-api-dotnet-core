using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Models.Safety
{
    public class AttachmentForCreationDto
    {
        public string Filename { get; set; }
        public string ContentType { get; set; }
        public byte?[] Data { get; set; }
        public DateTime Modifieddate { get; set; }
    }
}
