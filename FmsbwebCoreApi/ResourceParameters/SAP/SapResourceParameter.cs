using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.ResourceParameters.SAP
{
    public class SapResourceParameter
    {
        private string _area;
        private string _shift;
        public DateTime Start { get; set; } = DateTime.Today.AddDays(-1);
        public DateTime End { get; set; } = DateTime.Today.AddDays(-1);

        public string Area
        {
            get => _area != null ? _area.Trim() : _area;
            set => _area = value;
        }

        public string Shift
        {
            get => _shift != null ? _shift.Trim() : _shift;
            set => _shift = value;
        }

        public bool IsPurchasedScrap { get; set; }
        public bool IsPlantTotal { get; set; }
        public DateTime MonthStart { get; set; } = DateTime.Today.AddDays(-1);
        public DateTime MonthEnd { get; set; } = DateTime.Today.AddDays(-1);

    }
}
