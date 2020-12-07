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
        public bool IsDownBool => !string.IsNullOrEmpty(IsDown)
                                  && Convert.ToBoolean(IsDown.ToLower(new CultureInfo("en-US")),
                                      new CultureInfo("en-US"));

        public string GroupName => TagName.Split('.')[2];
    }
}
