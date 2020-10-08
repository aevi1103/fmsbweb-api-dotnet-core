using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.ResourceParameters.FMSB
{
    public class DowntimeResourceParameter
    {
        public DateTime Start { get; set; } = DateTime.Today;
        public DateTime End { get; set; } = DateTime.Today;
        public string Dept { get; set; } = "";
        public string Line { get; set; } = "";
        public string Shift { get; set; } = "";
        public int MinDowntimeEvent { get; set; } = 10;
        public int? MaxDowntimeEvent { get; set; } = null;

        public List<string> Lines { get; set; } = new List<string>();

        //private List<string> GetLinesArr()
        //{
        //    return string.IsNullOrEmpty(Lines)
        //        ? new List<string>()
        //        : Lines.Split(',').Select(x => x.Trim()).ToList();
        //}
    }
}
