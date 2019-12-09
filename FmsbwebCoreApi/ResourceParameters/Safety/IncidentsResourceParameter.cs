using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.ResourceParameters.Safety
{
    public class IncidentsResourceParameter
    {
        const int maxPageSize = 100;
        public string Dept { get; set; }
        public DateTime Start { get; set; } = new DateTime(DateTime.Today.Year, 1, 1);
        public DateTime End { get; set; } = DateTime.Now;
        public string SearchQuery { get; set; }
        public int PageNumber { get; set; } = 1;

        private int _pageSize = 10;
        public int PageSize
        {
            get => _pageSize;
            set => _pageSize = (value > maxPageSize) ? maxPageSize : value;
        }

        public string OrderBy { get; set; } = "IncidentDate";
        public string Fields { get; set; }
    }
}
