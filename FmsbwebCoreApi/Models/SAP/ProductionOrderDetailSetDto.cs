using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Models.SAP
{
    public class RawProductionOrderDetailDto
    {
        public string Aufnr { get; set; } //order
        public string Vornr { get; set; } //operation
        public string Arbpl { get; set; } //work center
        public string Ism01 { get; set; } //actual
    }

    public class ProductionOrderDetailDto
    {
        public string OrderNumber { get; set; } //order
        public string OperationNumber { get; set; } //operation
        public string WorkCenter { get; set; } //work center
        public int Actual { get; set; } //actual
    }

    public class ProductionOrderDetailResultsDto
    {
        public List<RawProductionOrderDetailDto> results { get; set; }
    }

    public class ProductionOrderDetailsDto
    {
        public ProductionOrderDetailResultsDto d { get; set; }
    }
}
