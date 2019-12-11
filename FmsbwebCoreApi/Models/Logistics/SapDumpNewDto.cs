using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using FmsbwebCoreApi.Entity.SAP;

namespace FmsbwebCoreApi.Models.Logistics
{
    public class SapDumpNewDto : SapDumpNew
    {
        public decimal? _4000
        {
            get
            {
                return _4001 + _4002 + _4003 + _4004 + _4005 + _4006 + _4007 + _4008 + _4009 + _4010;
            }
        }

        public decimal? _5000
        {
            get
            {
                return _5001 + _5002 + _5003 + _5004 + _5005 + _5006 + _5007 + _5008 + _5009 + _5010;
            }
        }

        public decimal? Total
        {
            get
            {
                return _0111 + _0115 + _4000 + _5000 + Qc01 + Qc02 + _0130 + _0131 + _0135 + _0160 + _0300 + _0125;
            }
        }
    }
}
