using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DateShiftLib.Extensions;
using Nager.Date;
using Nager.Date.Extensions;

namespace FmsbwebCoreApi.Models
{
    public class SapProdOrdersDto
    {
        public int Id { get; set; }
        public long Order { get; set; }
        public string Activity { get; set; }
        public string WorkCenter { get; set; }
        public string OperationsShortText { get; set; }
        public int? OperationQuantity { get; set; }
        public string OperationUnit { get; set; }
        public string ActStartDateExecution { get; set; }
        public string ActFinishTimeExecution { get; set; }
        public string SystemStatus { get; set; }
        public DateTime UploadDateTime { get; set; }
        public DateTime Date { get; set; }

        public DateTime ActStartDateExecutionDate => Convert.ToDateTime(ActStartDateExecution);

        public bool IsWeekEnd => ActStartDateExecutionDate.IsWeekend(CountryCode.US);
        public int WeekNumber => ActStartDateExecutionDate.ToWeekNumber();

    }
}
