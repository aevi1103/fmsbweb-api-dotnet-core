using AutoMapper;
using FmsbwebCoreApi.Context.Fmsb2;
using FmsbwebCoreApi.Context.SAP;
using FmsbwebCoreApi.Entity.SAP;
using FmsbwebCoreApi.Models.Logistics;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Services.Logistics
{
    public class LogisticsLibraryRepository : ILogisticsLibraryRepository, IDisposable
    {
        private readonly SapContext _context;
        private readonly Fmsb2Context _fmsb2Context;
        private readonly IMapper _mapper;

        private readonly List<string> _valuationClass = new List<string>() { "Finished products", "Semifinished products" };
        private readonly List<string> _partTypes = new List<string>() { "P5C", "P4H", "P3M", "P2F", "P2A", "P1A" };
        private const int DailyAvg = 50000;

        public LogisticsLibraryRepository(SapContext context, Fmsb2Context fmsb2Context, IMapper mapper)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _fmsb2Context = fmsb2Context ?? throw new ArgumentNullException(nameof(fmsb2Context));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public IEnumerable<GetStockOverviewDto> GetStockOverview(DateTime date)
        {
            var stockOverview = _context.SapDumpWithSafetyStock
                        .Where(x => x.Date == date)
                        .Where(x => _valuationClass.Contains(x.ValuationClass))
                        .ToList();

            var mappedData = _mapper.Map<IEnumerable<SapDumpNewDto>>(stockOverview);

            var res = mappedData.GroupBy(x => new { x.Program, x.Date })
                        .Select(x => new GetStockOverviewDto
                        {
                            Program = x.Key.Program,
                            Date = x.Key.Date,
                            Total = (int)x.Sum(s => s.Total ?? 0),
                            _0111 = (int)x.Sum(s => s._0111 ?? 0),
                            _0115 = (int)x.Sum(s => s._0115 ?? 0),
                            _4000 = (int)x.Sum(s => s._4000 ?? 0),
                            _5000 = (int)x.Sum(s => s._5000 ?? 0),

                            Qc01 = (int)x.Sum(s => s.Qc01 ?? 0),
                            Qc02 = (int)x.Sum(s => s.Qc02 ?? 0),
                            Qc03 = (int)x.Sum(s => s.Qc03 ?? 0),
                            Qc04 = (int)x.Sum(s => s.Qc04 ?? 0),
                            Qc05 = (int)x.Sum(s => s.Qc05 ?? 0),

                            _0130 = (int)x.Sum(s => s._0130 ?? 0),
                            _0131 = (int)x.Sum(s => s._0131 ?? 0),
                            _0135 = (int)x.Sum(s => s._0135 ?? 0),
                            _0160 = (int)x.Sum(s => s._0160 ?? 0),
                            _0300 = (int)x.Sum(s => s._0300 ?? 0),
                            _0125 = (int)x.Sum(s => s._0125 ?? 0)
                        })
                        .OrderByDescending(x => x.Total)
                        .ToList();

            return res;
        }

        public IEnumerable<InvProgramTargets> GetProgramTargets()
        {
            return _context.InvProgramTargets.ToList();
        }

        public IEnumerable<StockOverviewBySlocDto> GetStockOverviewBySloc(DateTime date)
        {
            var sloc = _context.SlocOrder.ToList();
            var targets = _context.InvProgramTargets
                            .GroupBy(x => new { x.Sloc })
                            .Select(x => new
                            {
                                x.Key.Sloc,
                                Min = x.Sum(s => s.Min),
                                Max = x.Sum(s => s.Max)
                            })
                            .OrderBy(x => x.Sloc)
                            .ToList();

            var stock = _context
                            .SapDumpNewUnpivot
                            .Where(x => _valuationClass.Contains(x.ValuationClass))
                            .Where(x => x.Qty > 0)
                            .Where(x => x.Date == date)
                            .GroupBy(x => new { x.Program, x.Date, x.Location, x.SlocOrder })
                            .Select(x => new StockOverviewBySlocDto
                            {
                                SlocOrder = x.Key.SlocOrder,
                                Sloc = x.Key.Location,
                                Program = x.Key.Program,
                                Stock = (int)x.Sum(s => s.Qty)
                            })
                            .ToList()
                            .Select(x => new StockOverviewBySlocDto
                            {
                                SlocOrder = x.SlocOrder,
                                Sloc = x.Sloc,
                                Program = x.Program,
                                Stock = x.Stock,
                                SlocName = sloc.FirstOrDefault(s => s.Sloc == x.Sloc)?.Slocname
                            })
                            .OrderBy(x => x.SlocName)
                            .ThenByDescending(x => x.Stock)
                            .ToList();

            var uniquePrograms = stock.Select(x => x.Program).Distinct().ToList(); //series
            var uniqueSloc = stock.Select(x => new { x.Sloc, x.SlocName, x.SlocOrder }).Distinct(); //categories

            var result = new List<StockOverviewBySlocDto>();

            foreach (var program in uniquePrograms)
            {
                foreach (var location in uniqueSloc)
                {
                    var isExist = stock.Any(x => x.Sloc == location.Sloc && x.Program == program);

                    if (isExist)
                    {
                        result.Add(stock.First(x => x.Sloc == location.Sloc && x.Program == program));
                    }
                    else
                    {
                        result.Add(new StockOverviewBySlocDto
                        {
                            SlocOrder = location.SlocOrder,
                            Sloc = location.Sloc,
                            SlocName = location.SlocName,
                            Stock = 0,
                            Program = program
                        });
                    }
                }
            }

            var minSeries = uniqueSloc.Select(x => new StockOverviewBySlocDto
            {
                SlocOrder = x.SlocOrder,
                Sloc = x.Sloc,
                SlocName = x.SlocName,
                Program = "Min",
                Stock = targets.Any(t => t.Sloc == x.Sloc)
                       ? targets.FirstOrDefault(t => t.Sloc == x.Sloc)?.Min ?? 0
                       : 0
            }).OrderBy(x => x.SlocOrder).ToList();

            var maxSeries = uniqueSloc.Select(x => new StockOverviewBySlocDto
            {
                SlocOrder = x.SlocOrder,
                Sloc = x.Sloc,
                SlocName = x.SlocName,
                Program = "Max",
                Stock = targets.Any(t => t.Sloc == x.Sloc)
                       ? targets.FirstOrDefault(t => t.Sloc == x.Sloc)?.Max ?? 0
                       : 0
            }).OrderBy(x => x.SlocOrder).ToList();

            result.AddRange(minSeries);
            result.AddRange(maxSeries);

            return result;
        }

        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
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

        public async Task<List<SapDumpNewView>> GetInventory(DateTime start, DateTime end)
        {
            return await _context.SapDumpNewView.Where(x => x.Date >= start && x.Date <= end).ToListAsync().ConfigureAwait(false);
        }

        public List<string> GetDmaxParts()
        {
            return _context.DmaxParts.Select(x => x.MaterialDmax).ToList();
        }

        public async Task<List<LogisticsCommentDto>> GetLogisticsComments(DateTime start, DateTime end)
        {
            return await (from inv in _fmsb2Context.LogisticsInventory
                            join mm in _fmsb2Context.LogisticsMm
                            on inv.LogisticsId equals mm.Id
                            where mm.Date >= start && mm.Date <= end
                            select new LogisticsCommentDto
                            {
                                Date = (DateTime)mm.Date,
                                Category = inv.Category,
                                Comments = inv.Comments
                            }).ToListAsync().ConfigureAwait(false);
        }

        public async Task<List<RawMatInv>> GetRawMaterialsInventory(DateTime start, DateTime end)
        {
            return await _context.RawMatInv.Where(x => x.Date >= start && x.Date <= end).ToListAsync().ConfigureAwait(false);
        }

        public async Task<List<LogisticsDollarsDto>> GetLogisticsDollars(DateTime start, DateTime end)
        {
            var inboundOutbound = new List<string> { "Inbound", "Outbound" };

            return await (from d in _fmsb2Context.LogisticsDollars
                    join m in _fmsb2Context.LogisticsMm
                    on d.LogisticsId equals m.Id
                    where m.Date >= start && m.Date <= end && inboundOutbound.Contains(d.Category)
                    select new LogisticsDollarsDto
                    {
                        Date = (DateTime)m.Date,
                        Category = d.Category,
                        Cost = (decimal)d.Actual,
                        Target = (decimal)d.Target
                    }).ToListAsync().ConfigureAwait(false);
        }

        public IEnumerable<InventoryStatusDto> GetInventoryStatus(
                List<SapDumpNewView> inventoryData,
                List<string> dmax,
                List<LogisticsCommentDto> logiticsComments)
        {


            var foundryCasting = inventoryData
                            .Where(x => x.TypeSap == "P5C")
                            .GroupBy(x => new { x.Date })
                            .Select(x => new InventoryStatusDto
                            {
                                Sort = 1,
                                Date = x.Key.Date,
                                Category = "Foundry Casting (0115, 0125)",
                                Total = (decimal)x.Sum(t => t.TotalUnrestInv),
                                AvgDays = (decimal)x.Sum(t => t.TotalUnrestInv) / DailyAvg
                            });

            var machineWip = inventoryData
                            .Where(x => x.TypeSap == "P3M")
                            .GroupBy(x => new { x.Date })
                            .Select(x => new InventoryStatusDto
                            {
                                Sort = 2,
                                Date = x.Key.Date,
                                Category = "Machine WIP (0130)",
                                Total = (decimal)x.Sum(t => t.TotalUnrestInv),
                                AvgDays = (decimal)x.Sum(t => t.TotalUnrestInv) / DailyAvg
                            });

            var finishing = inventoryData
                            .Where(x => x.TypeSap == "P2F")
                            .GroupBy(x => new { x.Date })
                            .Select(x => new InventoryStatusDto
                            {
                                Sort = 3,
                                Date = x.Key.Date,
                                Category = "Finishing (P2F)",
                                Total = (decimal)x.Sum(t => t.TotalUnrestInv),
                                AvgDays = (decimal)x.Sum(t => t.TotalUnrestInv) / DailyAvg
                            });

            var sbFinGood = inventoryData
                            .Where(x => x.TypeSap == "P1A")
                            .Where(x => !dmax.Contains(x.Material))
                            .GroupBy(x => new { x.Date })
                            .Select(x => new InventoryStatusDto
                            {
                                Sort = 3,
                                Date = x.Key.Date,
                                Category = "SB – Finish Goods",
                                Total = (decimal)x.Sum(t => t._0300),
                                AvgDays = (decimal)x.Sum(t => t.TotalUnrestInv) / DailyAvg
                            });

            var sbtFinGood = inventoryData
                            .Where(x => x.TypeSap == "P1A")
                            .Where(x => dmax.Contains(x.Material))
                            .GroupBy(x => new { x.Date })
                            .Select(x => new InventoryStatusDto
                            {
                                Sort = 3,
                                Date = x.Key.Date,
                                Category = "SBT – Finish Goods",
                                Total = (decimal)x.Sum(t => t._0300),
                                AvgDays = (decimal)x.Sum(t => t.TotalUnrestInv) / DailyAvg
                            });

            var inventoryStaus = foundryCasting
                                .Concat(machineWip)
                                .Concat(finishing)
                                .Concat(sbFinGood)
                                .Concat(sbtFinGood);

            var result = inventoryStaus
                            .Select(x => new InventoryStatusDto
                            {
                                Sort = x.Sort,
                                Date = x.Date,
                                Category = x.Category,
                                Total = x.Total,
                                AvgDays = Math.Round((x.Total / DailyAvg), 1),
                                Comments = logiticsComments.Any(c => c.Category == x.Category)
                                            ? logiticsComments.First(c => c.Category == x.Category).Comments
                                            : ""
                            })
                            .ToList();

            return result;
        }

        public IEnumerable<InventoryCostDto> GetInventoryCost(
            List<SapDumpNewView> data,
            List<RawMatInv> rawMatData,
            List<LogisticsDollarsDto> dollarsData,
            List<string> dmax)
        {
            /*
             * SB - Raw Material => Raw material exclude DMAX
             * SB - WIP => "P5C", "P4H", "P3M", "P2F", "P2A", "P1A" and exclude DMAX
             * SB Fin Good => P1A exclude DMAX
             * SBT Raw Materials => Dmax Raw Material
             */


            var sbRawMaterial = rawMatData
                                .Where(x => !dmax.Contains(x.Material))
                                .GroupBy(x => new { x.Date })
                                .Select(x => new InventoryCostDto
                                {
                                    Sort = 1,
                                    Date = (DateTime)x.Key.Date,
                                    Category = "SB – Raw Material",
                                    Cost = x.Sum(c => (decimal)c.TotalUnrestInv),
                                    Target = 8000000 //hard coded target need to put in db
                                })
                                .ToList();

            var sbWip = data
                            .Where(x => _partTypes.Contains(x.TypeSap))
                            .Where(x => !dmax.Contains(x.Material))
                            .GroupBy(x => new { x.Date })
                            .Select(x => new InventoryCostDto
                            {
                                Sort = 2,
                                Date = (DateTime)x.Key.Date,
                                Category = "SB – WIP",
                                Cost = x.Sum(c => (decimal)c.InventoryNotIn03001),
                                Target = 0
                            })
                            .ToList();

            var sbFinGoods = data
                            .Where(x => x.TypeSap == "P1A")
                            .Where(x => !dmax.Contains(x.Material))
                            .GroupBy(x => new { x.Date })
                            .Select(x => new InventoryCostDto
                            {
                                Sort = 3,
                                Date = (DateTime)x.Key.Date,
                                Category = "SB – Finish Goods",
                                Cost = x.Sum(c => (decimal)c._0300FinGdsSb),
                                Target = 3200000 //hard coded target
                            })
                            .ToList();

            var sbtRawMat = rawMatData
                                .Where(x => dmax.Contains(x.Material))
                                .GroupBy(x => new { x.Date })
                                .Select(x => new InventoryCostDto
                                {
                                    Sort = 4,
                                    Date = (DateTime)x.Key.Date,
                                    Category = "SBT – Raw Material",
                                    Cost = x.Sum(c => (decimal)c.TotalUnrestInv),
                                    Target = 0
                                })
                                .ToList();

            var sbtWip = data
                            .Where(x => _partTypes.Contains(x.TypeSap))
                            .Where(x => dmax.Contains(x.Material))
                            .GroupBy(x => new { x.Date })
                            .Select(x => new InventoryCostDto
                            {
                                Sort = 5,
                                Date = (DateTime)x.Key.Date,
                                Category = "SBT – WIP",
                                Cost = x.Sum(c => (decimal)c.InventoryNotIn03001),
                                Target = 0
                            })
                            .ToList();

            var sbtFinGoods = data
                                .Where(x => x.TypeSap == "P1A")
                                .Where(x => dmax.Contains(x.Material))
                                .GroupBy(x => new { x.Date })
                                .Select(x => new InventoryCostDto
                                {
                                    Sort = 6,
                                    Date = (DateTime)x.Key.Date,
                                    Category = "SBT – Finish Goods",
                                    Cost = x.Sum(c => (decimal)c._0300FinGdsSb),
                                    Target = 3200000 //hard coded target
                                })
                                .ToList();

            var inboundOutbound = dollarsData.Select(x => new InventoryCostDto
            {
                Sort = 7,
                Date = x.Date,
                Category = x.Category,
                Cost = x.Cost,
                Target = (double)x.Target
            });

            var cost = sbRawMaterial
                        .Concat(sbWip)
                        .Concat(sbFinGoods)
                        .Concat(sbtRawMat)
                        .Concat(sbtWip)
                        .Concat(sbtFinGoods)
                        .Concat(inboundOutbound);

            return cost.ToList();
        }

        public async Task<IEnumerable<CustomerCommentsDto>> GetCustomerComments(DateTime start, DateTime end)
        {
            return await (from c in _fmsb2Context.LogisticsCustomer
                    join m in _fmsb2Context.LogisticsMm
                    on c.LogisticsId equals m.Id
                    where m.Date >= start && m.Date <= end
                    select new CustomerCommentsDto
                    {
                        Date = (DateTime)m.Date,
                        Customer = c.Customer,
                        Comments = c.Comment
                    }).ToListAsync().ConfigureAwait(false);
        }

        public DaysOnHandColorCode DaysOnHandStatusColor(decimal daysOnHand, int InvQty)
        {
            var bgColor = "#FAFAFA"; //white
            var fontColor = "#f44336"; //red

            if (InvQty > 0)
            {
                if (daysOnHand >= 0 && daysOnHand < 2)
                {
                    bgColor = "#e33545"; //red
                    fontColor = "#FAFAFA"; //white
                }
                else if (daysOnHand >= 2 && daysOnHand <= 3)
                {
                    bgColor = "#ffc107"; //yellow
                    fontColor = "#212121"; //black
                }
                else if (daysOnHand > 3 && daysOnHand <= 5)
                {
                    bgColor = "#28a745"; //green
                    fontColor = "#FAFAFA"; //white
                }
                else if (daysOnHand > 5)
                {
                    bgColor = "#2196F3"; //blue
                    fontColor = "#FAFAFA"; //white
                }
                else
                {
                    bgColor = "#546e7a"; //white
                    fontColor = "#f44336"; //red
                }
            }

            var res = new DaysOnHandColorCode
            {
                BgColor = bgColor,
                FontColor = fontColor
            };

            return res;
        }

        public async Task<IEnumerable<InventoryDaysOnHandDto>> GetInventoryDaysOnHand(DateTime start, DateTime end)
        {

            var avgShip = await (from d in _context.SapDumpNewView
                           from v in _context.AvgShipDayPart
                               .Where(m => m.Material == d.Material).DefaultIfEmpty()
                           where d.Date >= start && d.Date <= end && ((v.Show ?? false) == true)
                           select new
                           {
                               d.Date,
                               d.Material,
                               d.TotalUnrestInv,
                               d._0300,
                               AvgShipDay = v.AvgShipDay ?? 0,
                               d.SafeftyStock
                           }).ToListAsync().ConfigureAwait(false);

            var logisticsParts = await _fmsb2Context.LogisticsParts.ToListAsync().ConfigureAwait(false);

            var result = avgShip
                            .Select(x => new InventoryDaysOnHandDto
                            {
                                Date = (DateTime)x.Date,
                                Sort = logisticsParts.Any(p => p.Part == x.Material) ? (int)logisticsParts.First(p => p.Part == x.Material).Sort : -1,
                                Program = logisticsParts.Any(p => p.Part == x.Material) ? logisticsParts.First(p => p.Part == x.Material).Program : null,
                                Material = x.Material,
                                TotalUnreistrictedQty = (int)x.TotalUnrestInv,
                                FinGoodIn0300 = (int)x._0300,
                                SafetyStock = (int)x.SafeftyStock,
                                AvgShipDay = (int)x.AvgShipDay,
                                DaysOnHand = x.SafeftyStock == 0 ? 0 : Math.Floor(((decimal)x._0300 / (decimal)x.SafeftyStock)),
                                ColorCode = DaysOnHandStatusColor(
                                                x.SafeftyStock == 0 ? 0 : Math.Floor(((decimal)x._0300 / (decimal)x.SafeftyStock)),
                                                (int)x._0300)
                            })
                            .Where(x => x.Program != null)
                            .OrderBy(x => x.Sort)
                            .ToList();

            return result;
        }

        public async Task<StockStatusDto> GetStockStatus(DateTime start, DateTime end)
        {
            var inventoryData = await GetInventory(start, end).ConfigureAwait(false); //sap dump view 
            var dmax = GetDmaxParts();
            var comments = await GetLogisticsComments(start, end).ConfigureAwait(false);
            var rawMat = await GetRawMaterialsInventory(start, end).ConfigureAwait(false);
            var dollars = await GetLogisticsDollars(start, end).ConfigureAwait(false);
            var customerComments = await GetCustomerComments(start, end).ConfigureAwait(false);

            var daysOnHand = await GetInventoryDaysOnHand(start, end).ConfigureAwait(false);

            return new StockStatusDto
            {
                Start = start,
                End = end,
                InventoryStatus = GetInventoryStatus(inventoryData, dmax, comments),
                InventoryCost = GetInventoryCost(inventoryData, rawMat, dollars, dmax),
                CustomerComments = customerComments,
                DaysOnHand = daysOnHand
            };
        }
    }
}
