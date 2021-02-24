using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Entity.Overtime
{
    public class Type
    {
        [Key]
        public string TypeName { get; set; }
    }
}
