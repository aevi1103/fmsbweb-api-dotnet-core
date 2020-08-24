using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DateShiftMethods.Helpers;
using FmsbwebCoreApi.Context.QualityCheckSheets;
using FmsbwebCoreApi.Entity.QualityCheckSheets;
using FmsbwebCoreApi.Models.QualityCheckSheets;
using FmsbwebCoreApi.Repositories.QualityCheckSheets;
using FmsbwebCoreApi.Services.Interfaces.QualityCheckSheets;
using Microsoft.AspNetCore.Mvc;

namespace FmsbwebCoreApi.Services.QualityCheckSheets
{
    public class CheckSheetService : CheckSheetRepository, ICheckSheetService
    {
        private readonly DateShift _dateShift;

        public CheckSheetService(QualityCheckSheetsContext context, DateShift dateShift) : base(context)
        {
            _dateShift = dateShift ?? throw new ArgumentNullException(nameof(dateShift));
        }

        public async Task<CheckSheet> Login(CheckSheetDto data)
        {
            var ds = _dateShift.GetCurrentDateShift("Machining");

            var body = new CheckSheet
            {
                ControlMethodId = data.ControlMethodId,
                LineId = data.LineId,
                OrganizationPartId = data.OrganizationPartId,
                ShiftDate = ds.ShiftDate,
                Shift = ds.Shift,
                ClockNumber = data.ClockNumber,
                HourId = data.HourId,
                TimeStamp = DateTime.Now
            };

            return await IsExist(body) ?? await Create(body);
        }
    }
}
