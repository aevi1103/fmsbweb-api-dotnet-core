using FmsbwebCoreApi.Context.Fmsb2;
using FmsbwebCoreApi.Context.FmsbMvc;
using FmsbwebCoreApi.Entity.Fmsb2;
using FmsbwebCoreApi.Entity.FmsbMvc;
using FmsbwebCoreApi.Helpers;
using FmsbwebCoreApi.Models.FMSB2;
using FmsbwebCoreApi.ResourceParameters.FMSB;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DateShiftLib.Helpers;
using DateShiftMethods.Helpers;
using FmsbwebCoreApi.Models;

namespace FmsbwebCoreApi.Services.FmsbMvc
{
    public class FmsbMvcLibraryRepository : IFmsbMvcLibraryRepository, IDisposable
    {
        private readonly FmsbMvcContext _context;
        private readonly Fmsb2Context _fmsbContext;
        private readonly DateShift _dateShift;
        private readonly Hour _hour;

        public FmsbMvcLibraryRepository(
            FmsbMvcContext context,
            Fmsb2Context fmsb2Context,
            DateShift dateShift,
            Hour hour)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _fmsbContext = fmsb2Context ?? throw new ArgumentNullException(nameof(fmsb2Context));
            _dateShift = dateShift ?? throw new ArgumentNullException(nameof(dateShift));
            _hour = hour ?? throw new ArgumentNullException(nameof(hour));
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
            if (parameter == null) throw new ArgumentNullException(nameof(parameter));

            var start = parameter.Start.AddMonths(-1);
            var end = parameter.End.AddDays(1).Date; //to get end of that day

            var machines = await _fmsbContext.MachineList.Where(x => x.MachineMapper != null).ToListAsync().ConfigureAwait(false);
            var owners = await GetDowntimeOwner().ConfigureAwait(false);

            // Get data in parallel
            var tasks = new List<Task>();

            // Get call box downtime records
            var callBoxQry = _context.OverallCallbox.AsQueryable();
            callBoxQry = callBoxQry.Where(x => x.RequestDateTime >= start && x.RequestDateTime <= end);

            callBoxQry = parameter.Lines.Any() 
                ? callBoxQry.Where(x => parameter.Lines.Contains(x.HxHLine)) 
                : !string.IsNullOrEmpty(parameter.Line) 
                    ? callBoxQry.Where(x => x.HxHLine == parameter.Line)
                    : callBoxQry;

            var callBoxTask = callBoxQry.ToListAsync();

            // Get manual downtime records
            var manualDowntimeQry = _fmsbContext.DowntimeDataList2.AsQueryable();
            manualDowntimeQry = manualDowntimeQry.Where(x => x.Shiftdate >= parameter.Start && x.Shiftdate <= parameter.End);
            manualDowntimeQry = manualDowntimeQry.Where(x => x.DeptName.ToLower().Contains(parameter.Dept.Trim().ToLower()));
            manualDowntimeQry = manualDowntimeQry.Where(x => x.Shift.ToLower().Contains(parameter.Shift.Trim().ToLower()));

            manualDowntimeQry = parameter.Lines.Any()
                ? manualDowntimeQry.Where(x => parameter.Lines.Contains(x.MachineName))
                : !string.IsNullOrEmpty(parameter.Line) 
                    ? manualDowntimeQry.Where(x => x.MachineName.ToLower() == parameter.Line.ToLower())
                    : manualDowntimeQry;

            var manualDowntimeEntryTask = manualDowntimeQry.ToListAsync();

            tasks.Add(callBoxTask);
            tasks.Add(manualDowntimeEntryTask);

            await Task.WhenAll(tasks).ConfigureAwait(false);
            var callBox = callBoxTask.Result;
            var manualDowntimeEntry = manualDowntimeEntryTask.Result;
            var spreadDowntimeData = SpreadHours(callBox);

            var spreadCallBoxData = spreadDowntimeData
            .Select(x =>
            {
                var dept = machines.FirstOrDefault(m => string.Equals(m.MachineMapper, x.Line, StringComparison.CurrentCultureIgnoreCase))?.DeptName ?? x.Department;
                var line = machines.FirstOrDefault(m => string.Equals(m.MachineMapper, x.Line, StringComparison.CurrentCultureIgnoreCase))?.MachineName ?? x.Line;

                var dto = new DowntimeDto
                {
                    Dept = dept,
                    Line = line,
                    Machine = x.Machine,
                    Reason1 = x.PrimaryReason,
                    Reason2 = x.SecondaryReason,
                    Comments = $"<b>Operator Comment:</b> {x.OperatorComment} <br> <b>{x.Type} Comment:</b> {x.CompletionComment}",
                    DowntimeLoss = (decimal) _dateShift.ElapsedTime(x.RequestDateTime, x.CompletedDateTime),
                    ShifDate = _dateShift.GetDateShift(x.RequestDateTime, dept).ShiftDate,
                    Shift = _dateShift.GetDateShift(x.RequestDateTime, dept).Shift,
                    ModifiedDate = x.RequestDateTime,
                    Hour = _hour.GetHour(x.CompletedDateTime, dept),
                    Type = x.Type,
                    TypeColor = owners.FirstOrDefault(o => o.Owner == x.Type)?.Color ?? ""
                };
                return dto;
            })
            .Where(x => x.ShifDate >= parameter.Start && x.ShifDate <= parameter.End)
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
                Type = "Operator (Manual)",
                TypeColor = owners.FirstOrDefault(o => o.Owner == "Operator (Manual)")?.Color ?? ""
            })
            .ToList();

            spreadCallBoxData.AddRange(manualDowntime);

            return spreadCallBoxData
                        .Where(x => x.Dept.ToLower().Contains(parameter.Dept.Trim().ToLower()))
                        .OrderBy(x => x.ShifDate)
                        .ThenBy(x => x.Shift)
                        .ThenBy(x => x.Hour)
                        .ToList();
        }

        private IEnumerable<OverallCallBoxDto> SpreadHours(List<OverallCallbox> data)
        {
            if (data == null) throw new ArgumentNullException(nameof(data));

            try
            {
                var list = new List<OverallCallBoxDto>();
                if (!data.Any()) return list;

                var callBoxDto = data.Select(x => new OverallCallBoxDto
                    {
                        Department = x.Department,
                        Line = x.Line,
                        Machine = x.Machine,
                        PrimaryReason = x.PrimaryReason,
                        SecondaryReason = x.SecondaryReason,
                        RequestDateTime = x.RequestDateTime,
                        WorkingDateTime = x.WorkingDateTime,
                        CompletedDateTime = x.CompletedDateTime,
                        OperatorComment = x.OperatorComment,
                        CompletionComment = x.CompletionComment,
                        WaitingTimeMinutes = x.WaitingTimeMinutes,
                        RepairTimeMinutes = x.RepairTimeMinutes,
                        DowntimeMinutes = x.DowntimeMinutes,
                        Type = x.Type
                    })
                    .OrderBy(x => x.StartDateTime)
                    .ToList();

                var dataToSpreadDowntime = callBoxDto.Where(x => x.RequestDateTime.Hour != Convert.ToDateTime(x.CompletedDateTime ?? DateTime.Now).Hour).ToList();
                var others = callBoxDto.Where(x => x.RequestDateTime.Hour == Convert.ToDateTime(x.CompletedDateTime ?? DateTime.Now).Hour).ToList();

                foreach (var item in dataToSpreadDowntime)
                {
                    var start = item.StartDateTime;
                    while (start <= item.EndDateTime)
                    {
                        // Get end of the hour based on start time
                        var endTime = _dateShift.EndOfHour(start);

                        // copy the current entity
                        var itemCopy = FastDeepCloner.DeepCloner.Clone(item);

                        var workTime = item.WorkingDateTime >= start && item.WorkingDateTime <= endTime //if working date is between start and end time 
                            ? item.WorkingDateTime // get working date time
                            : endTime;

                        itemCopy.RequestDateTime = start;
                        itemCopy.WorkingDateTime = workTime > endTime ? start : workTime;
                        itemCopy.CompletedDateTime = endTime;

                        var com = $"<br><small> <b>Original Work Request:</b> {item.StartDateTime} <br><b>Start:</b> {item.WorkingDateTime} <br><b>End:</b> {item.CompletedDateTime}</small>";
                        itemCopy.CompletionComment = "<span>On Progress...</span>" + com;

                        // Check if dates are the same, if yes split the hours, and continue to next item
                        if (start.Date != item.EndDateTime.Date)
                        {
                            list.Add(itemCopy);
                            start = endTime.AddMinutes(1);
                            continue;
                        }

                        // At this point the dates are the same.
                        // Now, check if the hours are the same
                        if (start.Hour != item.EndDateTime.Hour)
                        {
                            list.Add(itemCopy);
                            start = endTime.AddMinutes(1);
                        }
                        else
                        {
                            itemCopy.CompletionComment = item.CompletionComment + com;
                            itemCopy.WorkingDateTime = workTime > item.CompletedDateTime ? start : workTime;
                            itemCopy.CompletedDateTime = item.CompletedDateTime;
                            list.Add(itemCopy);
                            break;
                        }
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

        public async Task<List<DowntimeOwner>> GetDowntimeOwner()
        {
            return await _fmsbContext.DowntimeOwner.ToListAsync().ConfigureAwait(false);
        }

        public async Task<dynamic> GetDowntimeByOwner(DowntimeResourceParameter parameters)
        {
            var data = await GetDowntime(parameters).ConfigureAwait(false);

            var res = data
                        .Where(x => x.DowntimeLoss > 0)
                        .GroupBy(x => new { x.Type })
                        .Select(x => new
                        {
                            x.Key.Type,
                            DowntimeLoss = x.Sum(t => t.DowntimeLoss),
                            LineDetails = x.GroupBy(l => new { l.Line })
                                            .Select(l => new
                                            {
                                                x.Key.Type,
                                                l.Key.Line,
                                                MachineLine = l.Key.Line,
                                                DowntimeLoss = l.Sum(t => t.DowntimeLoss),
                                                MahcineDetails = l.GroupBy(m => new { m.Machine })
                                                                    .Select(m => new
                                                                    {
                                                                        x.Key.Type,
                                                                        l.Key.Line,
                                                                        m.Key.Machine,
                                                                        DowntimeLoss = m.Sum(t => t.DowntimeLoss),
                                                                        ReasonDetails = m.GroupBy(r => new { r.Reason2 })
                                                                                            .Select(r => new
                                                                                            {
                                                                                                x.Key.Type,
                                                                                                l.Key.Line,
                                                                                                m.Key.Machine,
                                                                                                r.Key.Reason2,
                                                                                                DowntimeLoss = r.Sum(t => t.DowntimeLoss),
                                                                                            }).Take(10).OrderByDescending(r => r.DowntimeLoss)
                                                                    }).OrderByDescending(m => m.DowntimeLoss)
                                            }).OrderByDescending(l => l.DowntimeLoss)
                        })
                        .OrderByDescending(x => x.DowntimeLoss)
                        .ToList();

            return res;
        }
    }
}
