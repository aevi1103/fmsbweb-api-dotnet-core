using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Helpers
{
    public class MapArea
    {
        public string RanameAreaToDepartment(string area)
        {
            if (area == null) throw new ArgumentNullException(nameof(area));
            var dept = area;
            return (area.ToLower().Trim()) switch
            {
                "foundry cell" => "foundry",
                "machine line" => "machining",
                _ => dept,
            };
        }
    }
}
