using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public class LogisticCustomerName
    {
        [Key]
        public string LogisticCustomerNameId { get; set; }

        public DateTime DateTime { get; set; }  
    }
}
