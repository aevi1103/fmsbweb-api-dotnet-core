using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.ResourceParameters
{
    public class ProjectTrackerResourceParameter
    {
        private string _searchKeyword = "";
        public DateTime StartDateTime { get; set; } = DateTime.Now.Date;
        public DateTime EndDateTime { get; set; } = DateTime.Now.Date;

        public string SearchKeyword
        {
            get => _searchKeyword.ToLower(new CultureInfo("en-US")).Trim();
            set => _searchKeyword = value;
        }
    }
}
