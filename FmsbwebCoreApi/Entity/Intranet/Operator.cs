using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Entity.Intranet
{
    [Table("EOLVS_EOS_OPERATORS", Schema = "dbo")]
    public class Operator
    {
        public int OperatorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime TimeStamp { get; set; } = DateTime.Now;
    }
}
