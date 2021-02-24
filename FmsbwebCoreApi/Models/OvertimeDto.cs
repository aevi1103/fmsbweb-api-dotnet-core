using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Entity.Overtime;
using FmsbwebCoreApi.Enums;

namespace FmsbwebCoreApi.Models
{
    public class OvertimeDto : Employee
    {
        public int? OvertimeId { get; set; }
        public double Hours { get; set; }
        public string TypeName { get; set; }
        public double YearsOfService { get; set; }
        public DateTime? OvertimeDate { get; set; }
        public DateTime? OvertimeModifiedDate { get; set; }
        public DateTime? ParameterDate { get; set; }
    }
}
