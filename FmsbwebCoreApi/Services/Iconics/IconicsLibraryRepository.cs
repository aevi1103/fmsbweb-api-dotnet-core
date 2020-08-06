using FmsbwebCoreApi.Context.Iconics;
using FmsbwebCoreApi.Helpers;
using FmsbwebCoreApi.Models.Iconics;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Services.Iconics
{
    public class IconicsLibraryRepository : IIconicsLibraryRepository, IDisposable
    {
        private readonly IconicsContext _context;

        public IconicsLibraryRepository(IconicsContext context)
        {
            _context = context ??
                throw new ArgumentNullException(nameof(context));
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

        public List<IconicsDowntimeDto> SpreadHours(List<IconicsDowntimeDto> data)
        {
            data = data ?? throw new ArgumentNullException(nameof(data));
            var dh = new DateTimeHelpers();

            var list = new List<IconicsDowntimeDto>();
            if (!data.Any()) return list;

            var dataToSpreadDowntime = data.Where(x => x.StarHour != x.EndHour).ToList();
            var others = data.Where(x => x.StarHour == x.EndHour).ToList();

            foreach (var item in dataToSpreadDowntime)
            {

                var endTime = DateTime.Now;
                if (item.EndStamp == null)
                {
                    item.EndStamp = endTime; //if null get current date time
                }

                var completedDateTime = Convert.ToDateTime(item.EndStamp);
                var tempStart = Convert.ToDateTime(item.StartStamp).Date + new TimeSpan(Convert.ToDateTime(item.StartStamp).Hour, 0, 0);
                var tempEnd = completedDateTime.Date + new TimeSpan(completedDateTime.Hour, 0, 0);

                var tempEndHour = tempEnd.Hour;
                var tempEndDate = tempEnd.Date;

                //defaults
                var timeOfCall = Convert.ToDateTime(item.StartStamp);
                var timeOfCompletion = dh.EndOfHour(timeOfCall);

                while (tempStart <= tempEnd)
                {
                    var hour = tempStart.Hour;
                    var date = tempStart.Date;

                    //create a copy of the original object
                    var itemCopy = FastDeepCloner.DeepCloner.Clone(item);

                    //assign new datetime values
                    itemCopy.StartStamp = timeOfCall;
                    itemCopy.EndStamp = timeOfCompletion;

                    itemCopy.StarHour = timeOfCall.Hour;
                    itemCopy.EndHour = timeOfCompletion.Hour;

                    if (timeOfCall > timeOfCompletion)
                    {
                        itemCopy.Downtime = 0;
                    }

                    itemCopy.Downtime = (decimal)dh.ElapsedTime(timeOfCall, timeOfCompletion);

                    if (hour == tempEndHour && date == tempEndDate)
                    {
                        //if last hour get the original time of completion
                        timeOfCompletion = Convert.ToDateTime(item.EndStamp);

                        //override time of completion.
                        itemCopy.EndHour = timeOfCompletion.Hour;
                        itemCopy.EndStamp = timeOfCompletion;
                        itemCopy.Downtime = (decimal)dh.ElapsedTime(timeOfCall, timeOfCompletion);
                    }
                    else
                    {
                        //for the next iteration we want to change the time of call to the next hour so add 1 seconds from the time of completion
                        timeOfCall = timeOfCompletion.AddSeconds(1);

                        //get the last hour of time of call
                        timeOfCompletion = dh.EndOfHour(timeOfCall);
                    }

                    list.Add(itemCopy);
                    tempStart = dh.EndOfHour(tempStart).AddSeconds(1);

                }
            }

            list.AddRange(others); //add the rest of the data

            return list;
        }
    }
}
