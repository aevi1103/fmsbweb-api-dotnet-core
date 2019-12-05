using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Models.Safety
{
    public class AttachmentDto
    {
        public int Id { get; set; }
        public string Filename { get; set; }
        public string ContentType { get; set; }
        public byte[] Data { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
