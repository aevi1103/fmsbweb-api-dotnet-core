﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace FmsbwebCoreApi.Entity.Safety
{
    [Table("Dept")]
    public partial class Dept
    {
        public Dept()
        {
            Incidences = new HashSet<Incidence>();
        }

        [Key]
        [Column("Dept")]
        [StringLength(50)]
        public string Dept1 { get; set; }

        [InverseProperty(nameof(Incidence.DeptNavigation))]
        public virtual ICollection<Incidence> Incidences { get; set; }
    }
}