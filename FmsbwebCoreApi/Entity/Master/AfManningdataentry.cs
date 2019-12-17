using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    public partial class AfManningdataentry
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Date { get; set; }
        [Required]
        [StringLength(1)]
        public string Shift { get; set; }
        [StringLength(5)]
        public string EnteredBy { get; set; }
        [Column("Fin_ops")]
        public short? FinOps { get; set; }
        [Column("fin_PSO_Inspectors")]
        public int? FinPsoInspectors { get; set; }
        [Column("finTemps")]
        public int? FinTemps { get; set; }
        [Column("Fin_Mat_Handlers")]
        public int? FinMatHandlers { get; set; }
        [Column("Fin_P_techs")]
        public int? FinPTechs { get; set; }
        [Column("Assy_Ops")]
        public short? AssyOps { get; set; }
        [Column("Assy_PSO_Inspectors")]
        public short? AssyPsoInspectors { get; set; }
        public short? AssyTemps { get; set; }
        [Column("Assy_MatHandlers")]
        public short? AssyMatHandlers { get; set; }
        [Column("Assy_P_techs")]
        public int? AssyPTechs { get; set; }
    }
}
