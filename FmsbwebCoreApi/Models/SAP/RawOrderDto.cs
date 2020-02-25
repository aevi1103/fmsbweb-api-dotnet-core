using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Models.SAP
{

    public class OperationSetDto
    {
        public UriDto __deferred { get; set; }
    }

    public class UriDto
    {
        public string uri { get; set; }
    }

    public class RawOrderDto
    {
        public string Aufnr { get; set; } //order
        public string Matnr { get; set; } //material
        public string Maktx { get; set; } //material desc
        public string Gamng { get; set; } //target
        public string Ism01 { get; set; } //actual
        public string Ism01Shift { get; set; } //actual by currrent shift
        public string Arbpl { get; set; } //work center
        public string VornrGr { get; set; } //operation
        public OperationSetDto OperationsSet { get; set; }
    }

    public class OrdersResultsDto
    {
        public List<RawOrderDto> results { get; set; }
    }

    public class OrdersDto
    {
        public OrdersResultsDto d { get; set; }
    }
}
