using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Hubs.Counter
{
    public class CounterModel
    {
        public string TagName { get; set; }
        public long Counter { get; set; }
        public int Quality { get; set; }
        public DateTime LastUpdate { get; set; }
        public bool IsInitialSave { get; set; }
        public string Department => TagName.Split('.')[0];
    }
}
