using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Context.Fmsb2;
using FmsbwebCoreApi.Repositories;
using FmsbwebCoreApi.Services.Interfaces;

namespace FmsbwebCoreApi.Services
{
    public class ProjectTrackerService : ProjectTrackerRepository, IProjectTrackerService
    {
        public ProjectTrackerService(Fmsb2Context context) : base(context)
        {
        }
    }
}
