using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Context.Intranet;
using FmsbwebCoreApi.Context.SAP;
using FmsbwebCoreApi.Repositories;
using FmsbwebCoreApi.Services.Interfaces;

namespace FmsbwebCoreApi.Services
{
    public class ProductionService : ProductionRepository, IProductionService
    {
        private readonly SapContext _context;
        private readonly IntranetContext _intranetContext;


        public ProductionService(SapContext context, IntranetContext intranetContext) : base(context, intranetContext)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _intranetContext = intranetContext ?? throw new ArgumentNullException(nameof(intranetContext));
        }
    }
}
