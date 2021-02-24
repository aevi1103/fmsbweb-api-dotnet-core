using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework.Constraints;

namespace FmsbwebCoreApi.Entity.Overtime
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
    }
}
