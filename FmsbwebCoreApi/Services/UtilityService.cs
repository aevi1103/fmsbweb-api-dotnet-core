using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Services.Interfaces;

namespace FmsbwebCoreApi.Services
{
    public class UtilityService : IUtilityService
    {
        public int MapShiftToShiftOrder(string shift)
        {
            return shift switch
            {
                "A" => 1,
                "C" => 2,
                "B" => 1,
                "D" => 2,
                "3" => 1,
                "1" => 2,
                "2" => 3,
                _ => 0
            };
        }

        public string MapAreaToDepartment(string area)
        {
            if (area == null) throw new ArgumentNullException(nameof(area));
            return (area.ToLower().Trim()) switch
            {
                "foundry cell" => "foundry",
                "machine line" => "machining",
                _ => area,
            };
        }

        public List<string> GetAssemblyFinishingScrapAreaNames()
        {
            return new List<string>
            {
                "Anodize",
                "Skirt Coat",
                "Assembly"
            };
        }
    }
}
