using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblCompanyInfo")]
    public partial class TblCompanyInfo
    {
        [Key]
        [StringLength(35)]
        public string CompanyName { get; set; }
        [StringLength(35)]
        public string Address1 { get; set; }
        [StringLength(35)]
        public string Address2 { get; set; }
        [StringLength(25)]
        public string City { get; set; }
        [StringLength(2)]
        public string State { get; set; }
        [StringLength(10)]
        public string ZipCode { get; set; }
        [StringLength(14)]
        public string Phone { get; set; }
        [StringLength(14)]
        public string Fax { get; set; }
        [StringLength(14)]
        public string TollFree { get; set; }
        [Column("FedIDNr")]
        [StringLength(15)]
        public string FedIdnr { get; set; }
        [Column("StateIDNr")]
        [StringLength(15)]
        public string StateIdnr { get; set; }
        [Required]
        public bool? Secure { get; set; }
        [Column(TypeName = "image")]
        public byte[] CompanyLogo { get; set; }
    }
}
