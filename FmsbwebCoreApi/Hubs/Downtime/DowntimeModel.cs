using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Hubs.Downtime
{
    public class DowntimeModel
    {
        public string TagName { get; set; }
        public DateTime LastUpdate { get; set; }
        public string IsDown { get; set; }
        public bool IsDownBool =>
            !string.IsNullOrEmpty(IsDown)
            && Convert.ToBoolean(IsDown.ToLower(new CultureInfo("en-US")),
                new CultureInfo("en-US"));

        public string GroupName => GetGroupName();

        private string GetGroupName()
        {
            var departments = new List<string> {"machining", "finishing", "assembly" };
            var department = TagName.Split('.')[0];
            var mid = TagName.Split('.')[1];

            return departments.Contains(department.ToLower()) 
                ? mid.Substring(0, 2) 
                : mid;
        }
    }
}
