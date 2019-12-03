using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.SAP
{
    [Table("SAP_ProdOrders")]
    public partial class SapProdOrders
    {
        public long? Order { get; set; }
        [StringLength(50)]
        public string Activity { get; set; }
        [StringLength(50)]
        public string WorkCenter { get; set; }
        [StringLength(500)]
        public string OperationsShortText { get; set; }
        public int? OperationQuantity { get; set; }
        [StringLength(50)]
        public string OperationUnit { get; set; }
        [StringLength(50)]
        public string ActStartDateExecution { get; set; }
        [StringLength(100)]
        public string ActFinishTimeExecutn { get; set; }
        [StringLength(500)]
        public string SystemStatus { get; set; }
        [Column("uploadDateTime", TypeName = "datetime")]
        public DateTime UploadDateTime { get; set; }
        [Column("date", TypeName = "datetime")]
        public DateTime? Date { get; set; }
        [Key]
        [Column("id")]
        public int Id { get; set; }
    }
}
