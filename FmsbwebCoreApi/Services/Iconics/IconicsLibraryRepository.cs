using FmsbwebCoreApi.Context.Iconics;
using FmsbwebCoreApi.Helpers;
using FmsbwebCoreApi.Models.Iconics;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DateShiftMethods.Helpers;

namespace FmsbwebCoreApi.Services.Iconics
{
    public class IconicsLibraryRepository : IIconicsLibraryRepository, IDisposable
    {
        private readonly IconicsContext _context;
        private readonly DateShift _dateShift;

        public IconicsLibraryRepository(IconicsContext context, DateShift dateShift)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _dateShift = dateShift ?? throw new ArgumentNullException(nameof(dateShift));
        }

        public async Task<IEnumerable<IconicsDowntimeDto>> GetDowntimeIconics(DateTime startDate, DateTime endDate, string dept = "",
                int minDowntimeEvent = 10, int? maxDowntimeEvent = null)
        {
            try
            {
                minDowntimeEvent = minDowntimeEvent < 0 ? 0 : minDowntimeEvent;
                maxDowntimeEvent = maxDowntimeEvent < 0 ? 0 : maxDowntimeEvent;

                var dataQry = from machineDowntime in _context.KepserverMachineDowntime
                              join tagNames in _context.KepserverTagNamesView on machineDowntime.TagName equals tagNames.TagId into dv
                              from tagNames in dv.DefaultIfEmpty()
                              where machineDowntime.StartStamp >= startDate &&
                                    machineDowntime.StartStamp <= endDate && tagNames.Dept.ToLower().Contains(dept.ToLower().Trim()) &&
                                    machineDowntime.DowntimeMinutes >= minDowntimeEvent
                              select new { machineDowntime, tagNames };

                if (maxDowntimeEvent != null)
                {
                    dataQry = dataQry.Where(x => x.machineDowntime.DowntimeMinutes <= maxDowntimeEvent);
                }

                var res = await dataQry.Select(x => new IconicsDowntimeDto
                {
                    TagName =  x.machineDowntime.TagName,
                    Dept = x.tagNames.Dept,
                    Line = x.tagNames.Line,
                    MachineName = x.tagNames.MachineName2 ?? x.tagNames.Line,
                    StartStamp = (DateTime)x.machineDowntime.StartStamp,
                    EndStamp = (DateTime)x.machineDowntime.EndStamp,
                    StarHour = ((DateTime)x.machineDowntime.StartStamp).Hour,
                    EndHour = ((DateTime)x.machineDowntime.EndStamp).Hour,
                    Downtime = (decimal)x.machineDowntime.DowntimeMinutes
                })
                .ToListAsync()
                .ConfigureAwait(false);

                var sum = res.Sum(x => x.Downtime);

                return res.Where(x => x.Downtime > 0);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        public List<IconicsDowntimeDto> SpreadHours(List<IconicsDowntimeDto> data)
        {
            data = data ?? throw new ArgumentNullException(nameof(data));

            var list = new List<IconicsDowntimeDto>();
            if (!data.Any()) return list;

            var dataToSpreadDowntime = data.Where(x => x.StarHour != x.EndHour).ToList();
            var others = data.Where(x => x.StarHour == x.EndHour).ToList();

            foreach (var item in dataToSpreadDowntime)
            {
                var start = item.StartStamp;
                var endStamp = item.EndStamp;
                while (start <= endStamp)
                {
                    var endTime = _dateShift.EndOfHour(start);
                    var itemCopy = FastDeepCloner.DeepCloner.Clone(item);

                    itemCopy.StartStamp = start;
                    itemCopy.EndStamp = endTime;

                    itemCopy.StarHour = start.Hour;
                    itemCopy.EndHour = endTime.Hour;

                    if (start.Date != endStamp.Date)
                    {
                        list.Add(itemCopy);
                        start = endTime.AddMinutes(1);
                        continue;
                    }

                    if (start.Hour != endStamp.Hour)
                    {
                        list.Add(itemCopy);
                        start = endTime.AddMinutes(1);
                    }
                    else
                    {
                        itemCopy.EndStamp = endStamp;
                        itemCopy.EndHour = endStamp.Hour;
                        list.Add(itemCopy);
                        break;
                    }

                }
            }

            list.AddRange(others); //add the rest of the data

            return list;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // dispose resources when needed
            }
        }
    }
}
