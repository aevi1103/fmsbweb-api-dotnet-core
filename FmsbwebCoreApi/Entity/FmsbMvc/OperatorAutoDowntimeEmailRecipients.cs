using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbMvc
{
    public partial class OperatorAutoDowntimeEmailRecipients
    {
        [Key]
        public int OperatorAutoDowntimeEmailRecipientsId { get; set; }
        public string DepartmentName { get; set; }
        public string Email { get; set; }
        public string Shift { get; set; }
    }
}
