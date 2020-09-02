using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Entity.Intranet
{
    [Table("EOLVS_EOS_OPERATOR_JOBS", Schema = "dbo")]
    public class OperatorJob
    {
        public int OperatorJobId { get; set; }
        public string Job { get; set; }
        public DateTime TimeStamp { get; set; } = DateTime.Now;
    }
}
