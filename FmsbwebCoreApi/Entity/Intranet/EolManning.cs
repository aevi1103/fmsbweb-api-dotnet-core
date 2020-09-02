using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Entity.Intranet
{
    [Table("EOLVS_EOS_MANNING", Schema = "dbo")]
    public class EolManning
    {
        public int EolManningId { get; set; }
        public int EolvsEosId { get; set; }
        public EolvsEos EolvsEos { get; set; }
        public int OperatorJobId { get; set; }
        public OperatorJob OperatorJob { get; set; }
        public int OperatorId { get; set; }
        public Operator Operator { get; set; }
        public DateTime TimeStamp { get; set; } = DateTime.Now;
    }
}
