using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Context.Fmsb2;
using FmsbwebCoreApi.Context.Intranet;
using FmsbwebCoreApi.Repositories;
using FmsbwebCoreApi.Services.Interfaces;

namespace FmsbwebCoreApi.Services
{
    public class KpiTargetService : KpiTargetRepository, IKpiTargetService
    {
        private readonly IntranetContext _context;
        private readonly Fmsb2Context _fmsb2Context;

        public KpiTargetService(IntranetContext context, Fmsb2Context fmsb2Context) : base(context, fmsb2Context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _fmsb2Context = fmsb2Context ?? throw new ArgumentNullException(nameof(fmsb2Context));
        }
    }
}
