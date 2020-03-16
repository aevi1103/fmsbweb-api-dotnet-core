using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbMvc
{
    [Table("SP_GetClockNumbers_Result")]
    public partial class SpGetClockNumbersResult
    {
        [Key]
        public int Id { get; set; }
        public int Clock { get; set; }
        [Column("FName")]
        public string Fname { get; set; }
        [Column("LName")]
        public string Lname { get; set; }
        public string Dept { get; set; }
        public string Shift { get; set; }
        public string Job { get; set; }
    }
}
