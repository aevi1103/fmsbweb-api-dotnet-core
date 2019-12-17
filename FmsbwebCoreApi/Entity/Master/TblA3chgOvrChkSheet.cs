using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblA3ChgOvrChkSheet")]
    public partial class TblA3chgOvrChkSheet
    {
        [Key]
        [Column("VDate", TypeName = "datetime")]
        public DateTime Vdate { get; set; }
        [Key]
        [StringLength(1)]
        public string Shift { get; set; }
        [Key]
        [Column("DepartmentID")]
        [StringLength(2)]
        public string DepartmentId { get; set; }
        [Key]
        [StringLength(1)]
        public string Run { get; set; }
        [Key]
        [StringLength(1)]
        public string RunNr { get; set; }
        [Key]
        [Column("PartID")]
        [StringLength(6)]
        public string PartId { get; set; }
        [StringLength(50)]
        public string EnteredBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TimeStamp { get; set; }
        [Column("D1_PL_1")]
        public bool D1Pl1 { get; set; }
        [Column("D1_PL_2")]
        public bool D1Pl2 { get; set; }
        [Column("D1_PL_3")]
        public bool D1Pl3 { get; set; }
        [Column("D1_PL_4")]
        public bool D1Pl4 { get; set; }
        [Column("D1_PL_5")]
        public bool D1Pl5 { get; set; }
        [Column("D1_PL_6")]
        public bool D1Pl6 { get; set; }
        [Column("D1_PL_7")]
        public bool D1Pl7 { get; set; }
        [Column("D1_PL_8")]
        public bool D1Pl8 { get; set; }
        [Column("D1_LS_1")]
        public bool D1Ls1 { get; set; }
        [Column("D1_LS_2")]
        public bool D1Ls2 { get; set; }
        [Column("D1_LS_3")]
        public bool D1Ls3 { get; set; }
        [Column("D1_LS_4")]
        public bool D1Ls4 { get; set; }
        [Column("D1_LS_5")]
        public bool D1Ls5 { get; set; }
        [Column("D1_LS_6")]
        public bool D1Ls6 { get; set; }
        [Column("D1_S1_1")]
        public bool D1S11 { get; set; }
        [Column("D1_S1_2")]
        public bool D1S12 { get; set; }
        [Column("D1_S1_3")]
        public bool D1S13 { get; set; }
        [Column("D1_S1_4")]
        public bool D1S14 { get; set; }
        [Column("D1_S1_5")]
        public bool D1S15 { get; set; }
        [Column("D1_S1_6")]
        public bool D1S16 { get; set; }
        [Column("D1_S1_7")]
        public bool D1S17 { get; set; }
        [Column("D1_S1_8")]
        public bool D1S18 { get; set; }
        [Column("D1_S1_9")]
        public bool D1S19 { get; set; }
        [Column("D1_S2_1")]
        public bool D1S21 { get; set; }
        [Column("D1_S2_2")]
        public bool D1S22 { get; set; }
        [Column("D1_S2_3")]
        public bool D1S23 { get; set; }
        [Column("D1_S2_4")]
        public bool D1S24 { get; set; }
        [Column("D1_S2_5")]
        public bool D1S25 { get; set; }
        [Column("D1_S2_6")]
        public bool D1S26 { get; set; }
        [Column("D1_S2_7")]
        public bool D1S27 { get; set; }
        [Column("D1_S2_8")]
        public bool D1S28 { get; set; }
        [Column("D1_S2_9")]
        public bool D1S29 { get; set; }
        [Column("D1_S4_1")]
        public bool D1S41 { get; set; }
        [Column("D1_S4_2")]
        public bool D1S42 { get; set; }
        [Column("D1_S4_3")]
        public bool D1S43 { get; set; }
        [Column("D1_S4_4")]
        public bool D1S44 { get; set; }
        [Column("D1_S4_5")]
        public bool D1S45 { get; set; }
        [Column("D1_S4_6")]
        public bool D1S46 { get; set; }
        [Column("D1_S4_7")]
        public bool D1S47 { get; set; }
        [Column("D1_S5_1")]
        public bool D1S51 { get; set; }
        [Column("D1_S5_2")]
        public bool D1S52 { get; set; }
        [Column("D1_S5_3")]
        public bool D1S53 { get; set; }
        [Column("D1_S5_4")]
        public bool D1S54 { get; set; }
        [Column("D1_S5_5")]
        public bool D1S55 { get; set; }
        [Column("D1_S5_6")]
        public bool D1S56 { get; set; }
        [Column("D2_TS1")]
        public bool D2Ts1 { get; set; }
        [Column("D2_IJ_1")]
        public bool D2Ij1 { get; set; }
        [Column("D2_IJ_2")]
        public bool D2Ij2 { get; set; }
        [Column("D2_IJ_A1")]
        public bool D2IjA1 { get; set; }
        [Column("D2_IJ_A2")]
        public bool D2IjA2 { get; set; }
        [Column("D2_IJ_A3")]
        public bool D2IjA3 { get; set; }
        [Column("D2_IJ_A4")]
        public bool D2IjA4 { get; set; }
        [Column("D2_IJ_D1")]
        public bool D2IjD1 { get; set; }
        [Column("D2_RP_1")]
        public bool D2Rp1 { get; set; }
        [Column("D2_RP_2")]
        public bool D2Rp2 { get; set; }
        [Column("D2_RP_3")]
        public bool D2Rp3 { get; set; }
        [Column("D2_RP_4")]
        public bool D2Rp4 { get; set; }
        [Column("D2_RP_5")]
        public bool D2Rp5 { get; set; }
        [Column("D2_PD_1")]
        public bool D2Pd1 { get; set; }
        [Column("D2_PD_A1")]
        public bool D2PdA1 { get; set; }
        [Column("D2_PD_A2")]
        public bool D2PdA2 { get; set; }
        [Column("D2_PD_D1")]
        public bool D2PdD1 { get; set; }
        [Column("D2_TS2")]
        public bool D2Ts2 { get; set; }
        [Column("D3_RS_1")]
        public bool D3Rs1 { get; set; }
        [Column("D3_RS_2")]
        public bool D3Rs2 { get; set; }
        [Column("D3_RS_3")]
        public bool D3Rs3 { get; set; }
        [Column("D3_RI_1")]
        public bool D3Ri1 { get; set; }
        [Column("D3_RI_2")]
        public bool D3Ri2 { get; set; }
        [Column("D3_RI_3")]
        public bool D3Ri3 { get; set; }
        [Column("D3_RI_4")]
        public bool D3Ri4 { get; set; }
        [Column("D3_RI_5")]
        public bool D3Ri5 { get; set; }
        [Column("D3_RI_6")]
        public bool D3Ri6 { get; set; }
        [Column("D3_RI_7")]
        public bool D3Ri7 { get; set; }
        [Column("D3_RI_8")]
        public bool D3Ri8 { get; set; }
        [Column("D3_RI_9")]
        public bool D3Ri9 { get; set; }
        [Column("D3_PS_1")]
        public bool D3Ps1 { get; set; }
        [Column("D3_PS_2")]
        public bool D3Ps2 { get; set; }
        [Column("D3_PS_3")]
        public bool D3Ps3 { get; set; }
        [Column("D3_PS_4")]
        public bool D3Ps4 { get; set; }
        [Column("D3_PS_5")]
        public bool D3Ps5 { get; set; }
        [Column("D3_PS_6")]
        public bool D3Ps6 { get; set; }
        [Column("D3_PI_1")]
        public bool D3Pi1 { get; set; }
        [Column("D3_PI_2")]
        public bool D3Pi2 { get; set; }
        [Column("D3_PI_3")]
        public bool D3Pi3 { get; set; }
        [Column("D3_C1_1")]
        public bool D3C11 { get; set; }
        [Column("D3_C1_2")]
        public bool D3C12 { get; set; }
        [Column("D3_C1_3")]
        public bool D3C13 { get; set; }
        [Column("D3_C1_4")]
        public bool D3C14 { get; set; }
        [Column("D3_C1_5")]
        public bool D3C15 { get; set; }
        [Column("D3_C2_1")]
        public bool D3C21 { get; set; }
        [Column("D3_C2_2")]
        public bool D3C22 { get; set; }
        [Column("D3_C2_3")]
        public bool D3C23 { get; set; }
        [Column("D3_C2_4")]
        public bool D3C24 { get; set; }
        [Column("D3_CS_1")]
        public bool D3Cs1 { get; set; }
        [Column("D3_CS_2")]
        public bool D3Cs2 { get; set; }
        [Column("D3_CG_1")]
        public bool D3Cg1 { get; set; }
        [Column("D3_CG_2")]
        public bool D3Cg2 { get; set; }
        [Column("D3_CG_3")]
        public bool D3Cg3 { get; set; }
        [Column("D3_RJ_1")]
        public bool D3Rj1 { get; set; }
        [Column("D3_RJ_A1")]
        public bool D3RjA1 { get; set; }
        [Column("D3_RJ_A2")]
        public bool D3RjA2 { get; set; }
        [Column("D3_RJ_D1")]
        public bool D3RjD1 { get; set; }
        [Column("D3_US_1")]
        public bool D3Us1 { get; set; }
        [Column("D3_ST_1")]
        public bool D3St1 { get; set; }
        [StringLength(254)]
        public string Comments { get; set; }
    }
}
