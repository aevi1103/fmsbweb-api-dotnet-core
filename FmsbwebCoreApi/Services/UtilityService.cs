using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using FmsbwebCoreApi.Entity.Fmsb2;
using FmsbwebCoreApi.Entity.SAP;
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

        public string MapDepartmentToArea(string dept)
        {
            if (dept == null) throw new ArgumentNullException(nameof(dept));
            return (dept.ToLower().Trim()) switch
            {
                "foundry" => "foundry cell",
                "machining" => "machine line",
                _ => dept,
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

        public string CreateHourByHourUrl(CreateHxHview hxh, Machines machine)
        {
            if (hxh == null || machine == null) return "";
            return $"http://10.129.224.149/FMSBHXH/HxH?h=1&id={hxh.HrId}&shift={hxh.Shift}&machine={machine.MachineName}&machineId={machine.MachineId}&dept={hxh.DeptName}&machineMapper={machine.MachineMapper}&threshold=-1&shiftDate={hxh.Shiftdate.ToShortDateString()}&side={hxh.CellSide}&deptId={hxh.Deptid}&e=1";
        }

        public string CreateHourByHourUrl(CreateHxHview hxh, MachineMapping machine)
        {
            if (hxh == null || machine == null) return "";
            return $"http://10.129.224.149/FMSBHXH/HxH?h=1&id={hxh.HrId}&shift={hxh.Shift}&machine={machine.Line}&machineId={machine.MachineId}&dept={hxh.DeptName}&machineMapper={machine.MachineMapping1}&threshold=-1&shiftDate={hxh.Shiftdate.ToShortDateString()}&side={hxh.CellSide}&deptId={hxh.Deptid}&e=1";
        }

        public decimal CalculatePpmh(int gross, int? manning)
        {
            var ppl = manning ?? 0;
            var hours = ppl * 8; //8 is hours
            var ppmh = hours == 0 ? 0 : gross / (decimal) hours;
            return Math.Round(ppmh, 2);
        }
    }
}
