using FmsbwebCoreApi.Models.Iconics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Services.Iconics
{
    public interface IIconicsLibraryRepository
    {
        Task<IEnumerable<IconicsDowntimeDto>> GetDowntimeIconics(
            DateTime startDate,
            DateTime endDate,
            string dept = "",
            int minDowntimeEvent = 10,
            int? maxDowntimeEvent = null);

        List<IconicsDowntimeDto> SpreadHours(List<IconicsDowntimeDto> data);
    }
}
