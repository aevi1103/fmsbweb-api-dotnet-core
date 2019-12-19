using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.ResourceParameters.Quality
{
    public class QualityRespourceParameter
    {
        public DateTime Start { get; set; } = DateTime.Today;
        public DateTime End { get; set; } = DateTime.Today;
    }
}
