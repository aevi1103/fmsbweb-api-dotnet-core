﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Models.SAP
{
    public class GetSapProdAndScrapDto
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int Target { get; set; }
        public int SapProd { get; set; }
        public int SbScrap { get; set; }
        public int PurchasedScrap { get; set; }
        public int SapGross { get; set; }
        public decimal SbScrapRate { get; set; }
        public decimal PurchaseScrapRate { get; set; }
        public decimal SapOae { get; set; }
        public IEnumerable<DailySapProdDto> DailySapProd { get; set; } = new List<DailySapProdDto>();
        public IEnumerable<ScrapByCodeDetailsDto> SbScrapDetail { get; set; } = new List<ScrapByCodeDetailsDto>();
        public IEnumerable<ScrapByCodeDetailsDto> PurchaseScrapDetail { get; set; } = new List<ScrapByCodeDetailsDto>();
    } 
}
