using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Context.FmsbMvc;
using FmsbwebCoreApi.Entity.FmsbMvc;
using FmsbwebCoreApi.ResourceParameters.FMSB;
using Microsoft.EntityFrameworkCore;
using FmsbwebCoreApi.Helpers;
using FmsbwebCoreApi.Models.FMSB2;
using FmsbwebCoreApi.Context.Fmsb2;

namespace FmsbwebCoreApi.Services.FmsbMvc
{
    public class FmsbMvcLibraryRepository : IFmsbMvcLibraryRepository, IDisposable
    {
        private readonly FmsbMvcContext _context;
        private readonly Fmsb2Context _fmsbContext;

        public FmsbMvcLibraryRepository(FmsbMvcContext context, Fmsb2Context fmsb2Context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _fmsbContext = fmsb2Context ?? throw new ArgumentNullException(nameof(fmsb2Context));
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

        public async Task<List<DowntimeDto>> GetDowntime(DowntimeResourceParameter parameter)
        {
            var start = parameter.Start.AddMonths(-1);
            var end = parameter.End.AddDays(1).Date; //to get end of that day

            var machines = await _fmsbContext.MachineList.Where(x => x.MachineMapper != null).ToListAsync();

            var machineMapper = "";

            if (parameter.Line != "")
            {
                machineMapper = machines.Where(x => x.MachineName.ToLower() == parameter.Line.ToLower().Trim()).FirstOrDefault().MachineMapper;
            }

            var tasks = new List<Task>();
            var callboxTask = _context.OverallCallbox
                        .Where(x => x.RequestDateTime >= start && x.RequestDateTime <= end)
                        .Where(x => x.Department.ToLower().Contains(parameter.Dept.ToLower()))
                        .Where(x => x.Line.ToLower().Contains(machineMapper.ToLower()))
                        .ToListAsync();

            var manualDowntimeEntryTask = _fmsbContext.DowntimeDataList2
                                        .Where(x => x.Shiftdate >= parameter.Start && x.Shiftdate <= parameter.End)
                                        .Where(x => x.MachineName.ToLower().Contains(parameter.Line))
                                        .Where(x => x.Shift.ToLower().Contains(parameter.Shift))
                                        .ToListAsync();

            tasks.Add(callboxTask);
            tasks.Add(manualDowntimeEntryTask);

            await Task.WhenAll(tasks);
            var callbox = callboxTask.Result;
            var manualDowntimeEntry = manualDowntimeEntryTask.Result;

            var dh = new DateTimeHelpers();

            var spreadCallboxData = SpreadHours(callbox)
            .Select(x => new DowntimeDto
            {
                Dept = machines.Any(m => m.MachineMapper.ToLower() == x.Line.ToLower()) 
                        ? machines.Where(m => m.MachineMapper.ToLower() == x.Line.ToLower()).First().DeptName 
                        : x.Department,

                Line = machines.Any(m => m.MachineMapper.ToLower() == x.Line.ToLower())
                        ? machines.Where(m => m.MachineMapper.ToLower() == x.Line.ToLower()).First().MachineName
                        : x.Line,

                Machine = x.Machine,
                Reason1 = x.PrimaryReason,
                Reason2 = x.SecondaryReason,
                Comments = $"<b>Operator Comment:</b> {x.OperatorComment} <br> <b>Maintenance Comment:</b> {x.CompletionComment}",
                DowntimeLoss = (decimal)dh.ElapsedTime(x.RequestDateTime, x.CompletedDateTime),
                ShifDate = dh.GetDateShiftEightHours((x.CompletedDateTime == null ? DateTime.Now : (DateTime)x.CompletedDateTime)).ShiftDate,
                Shift = dh.GetDateShiftEightHours((x.CompletedDateTime == null ? DateTime.Now : (DateTime)x.CompletedDateTime)).Shift,
                ModifiedDate = x.RequestDateTime,
                Hour = dh.MapHourToHxHHoursForEightHourShift(x.RequestDateTime),
                Type = x.Type
            })
            .Where(x => x.ShifDate >= parameter.Start && x.ShifDate <= parameter.End)
            .Where(x => x.Shift.ToLower().Contains(parameter.Shift.ToLower()))
            .ToList();

            var manualDowntime = manualDowntimeEntry.Select(x => new DowntimeDto
            {
                Dept = x.DeptName,
                Line = x.MachineName,
                Machine = x.MachineNumber,
                Reason1 = x.Reason1,
                Reason2 = x.Reason2,
                Comments = x.Comments,
                DowntimeLoss = x.Downtimeloss,
                ShifDate = x.Shiftdate,
                Shift = x.Shift,
                ModifiedDate = x.Modifieddate,
                Hour = x.Hour,
                Type = "Operator (Manual)"
            })
            .ToList();

            spreadCallboxData.AddRange(manualDowntime);
                            
            return spreadCallboxData
                        .OrderBy(x => x.ShifDate)
                        .ThenBy(x => x.Shift)
                        .ThenBy(x => x.Hour)
                        .ToList();
        }

        public List<OverallCallbox> SpreadHours(List<OverallCallbox> data)
        {
            try
            {
                var dh = new DateTimeHelpers();
                var list = new List<OverallCallbox>();
                if (data.Count() == 0) return list;

                var dataToSpreadDowntime = data.Where(x => x.RequestDateTime.Hour != Convert.ToDateTime((x.CompletedDateTime == null ? DateTime.Now : x.CompletedDateTime)).Hour).ToList();
                var others = data.Where(x => x.RequestDateTime.Hour == Convert.ToDateTime((x.CompletedDateTime == null ? DateTime.Now : x.CompletedDateTime)).Hour).ToList();

                foreach (var item in dataToSpreadDowntime)
                {
                    var endTime = DateTime.Now;
                    var isCompleted = true;
                    if (item.CompletedDateTime == null)
                    {
                        item.CompletedDateTime = endTime; //if null get current date time
                        isCompleted = false;
                    }

                    var completedDateTime = Convert.ToDateTime(item.CompletedDateTime);
                    var tempStart = item.RequestDateTime.Date + new TimeSpan(item.RequestDateTime.Hour, 0, 0);
                    var tempEnd = completedDateTime.Date + new TimeSpan(completedDateTime.Hour, 0, 0);
                    var tempEndHour = tempEnd.Hour;
                    var tempEndDate = tempEnd.Date;

                    //defaults
                    var timeOfCall = item.RequestDateTime;
                    var timeOfArrival = Convert.ToDateTime(item.WorkingDateTime);
                    var timeOfCompletion = dh.EndOfHour(timeOfCall);

                    //spread hours
                    while (tempStart <= tempEnd)
                    {
                        var hour = tempStart.Hour;
                        var date = tempStart.Date;

                        var itemCopy = FastDeepCloner.DeepCloner.Clone(item);

                        //assign new datetime values
                        itemCopy.RequestDateTime = timeOfCall;
                        itemCopy.WorkingDateTime = timeOfArrival;
                        itemCopy.CompletedDateTime = timeOfCompletion;

                        //itemCopy.IsSpreadDowntime = true;

                        var com = $"<b>Auto-generated Comment:</b> <br><br> <b>Time of Call:</b> {item.RequestDateTime} <br><br> <b>Time of Arrival:</b> {item.RequestDateTime} <br><br> <b>Time of Completion:</b> {(isCompleted ? item.CompletedDateTime.ToString() : "n/a")} <br><br> <small>Downtime loss is spread out through out hour loss</small>";

                        itemCopy.CompletionComment = com;

                        //for the next iteration we want to change the time of call to the next hour so add 1 seconds from the time of completion
                        timeOfCall = timeOfCompletion.AddSeconds(1);
                        timeOfArrival = timeOfCall; //set time of arrival same as time of call

                        if (hour == tempEndHour && date == tempEndDate)
                        {
                            //if last hour get the original time of completion
                            timeOfCompletion = Convert.ToDateTime(item.CompletedDateTime);
                            itemCopy.CompletedDateTime = timeOfCompletion; //override time of completion
                            itemCopy.CompletionComment = item.CompletionComment + $"<br><br>{com}";
                        }
                        else
                        {
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
            catch (Exception ex)
            {
                throw new Exception($"Message: {ex.Message} - Stack Trace: {ex.StackTrace}");
            }
        }
    }
}
