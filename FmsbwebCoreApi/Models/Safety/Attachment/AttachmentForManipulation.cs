using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Models.Safety.Attachment
{
    public abstract class AttachmentForManipulation
    {
        [Required]
        public string Filename { get; set; }

        [Required]
        public string ContentType { get; set; }
        public byte?[] Data { get; set; }
        public DateTime Modifieddate { get; set; } = DateTime.Now;
    }
}
