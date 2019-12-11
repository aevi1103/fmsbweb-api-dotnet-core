using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FmsbwebCoreApi.Models.Logistics;

using FmsbwebCoreApi.Context.SAP;
using FmsbwebCoreApi.Context.Fmsb2;
using AutoMapper;
using FmsbwebCoreApi.Entity.SAP;

namespace FmsbwebCoreApi.Services.Logistics
{
    public class LogisticsLibraryRepository : ILogisticsLibraryRepository, IDisposable
    {
        private readonly SapContext _context;
        private readonly Fmsb2Context _fmsb2Context;
        private readonly IMapper _mapper;

        private readonly List<string> valuationClass = new List<string>() { "Finished products", "Semifinished products" };

        public LogisticsLibraryRepository(SapContext context, Fmsb2Context fmsb2Context, IMapper mapper)
        {
            _context = context ??
                throw new ArgumentNullException(nameof(context));

            _fmsb2Context = fmsb2Context ??
                throw new ArgumentNullException(nameof(fmsb2Context));

            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }

        public IEnumerable<GetStockOverviewDto> GetStockOverview(DateTime date)
        {
            var stockOverview = _context.SapDumpNew
                        .Where(x => x.Date == date)
                        .Where(x => valuationClass.Contains(x.ValuationClass))
                        .ToList();

            var mappedData = _mapper.Map<IEnumerable<SapDumpNewDto>>(stockOverview);

            var res = mappedData.GroupBy(x => new { x.Program, x.Date })
                        .Select(x => new GetStockOverviewDto
                        {
                            Program = x.Key.Program,
                            Date = (DateTime)x.Key.Date,
                            Total = (int)x.Sum(s => s.Total),
                            _0111 = (int)x.Sum(s => s._0111),
                            _0115 = (int)x.Sum(s => s._0115),
                            _4000 = (int)x.Sum(s => s._4000),
                            _5000 = (int)x.Sum(s => s._5000),
                            Qc01 = (int)x.Sum(s => s.Qc01),
                            Qc02 = (int)x.Sum(s => s.Qc02),
                            _0130 = (int)x.Sum(s => s._0130),
                            _0131 = (int)x.Sum(s => s._0131),
                            _0135 = (int)x.Sum(s => s._0135),
                            _0160 = (int)x.Sum(s => s._0160),
                            _0300 = (int)x.Sum(s => s._0300),
                            _0125 = (int)x.Sum(s => s._0125)
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
                            .Where(x => valuationClass.Contains(x.ValuationClass))
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
                        result.Add(stock.Where(x => x.Sloc == location.Sloc && x.Program == program).First());
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
                       ? targets.Where(t => t.Sloc == x.Sloc).FirstOrDefault().Min
                       : 0
            }).OrderBy(x => x.SlocOrder).ToList();

            var maxSeries = uniqueSloc.Select(x => new StockOverviewBySlocDto
            {
                SlocOrder = x.SlocOrder,
                Sloc = x.Sloc,
                SlocName = x.SlocName,
                Program = "Max",
                Stock = targets.Any(t => t.Sloc == x.Sloc)
                       ? targets.Where(t => t.Sloc == x.Sloc).FirstOrDefault().Max
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

        public List<SapDumpNewView> GetInventory(DateTime start, DateTime end)
        {
            return _context.SapDumpNewView.Where(x => x.Date >= start && x.Date <= end).ToList();
        }

        public List<string> GetDmaxParts()
        {
            return _context.DmaxParts.Select(x => x.MaterialDmax).ToList();
        }

        public List<LogisticsCommentDto> GetLogisticsComments(DateTime start, DateTime end)
        {
            return (from inv in _fmsb2Context.LogisticsInventory
                    join mm in _fmsb2Context.LogisticsMm
                    on inv.LogisticsId equals mm.Id
                    where mm.Date >= start && mm.Date <= end
                    select new LogisticsCommentDto
                    {
                        Date = (DateTime)mm.Date,
                        Category = inv.Category,
                        Comments = inv.Comments
                    }).ToList();
        }

        public List<RawMatInv> GetRawMaterialsInventory(List<string> dmax, DateTime start, DateTime end)
        {
            return _context.RawMatInv
                    .Where(x => x.Date >= start && x.Date <= end)
                    .Where(x => !dmax.Contains(x.Material))
                    .ToList();
        }

        public IEnumerable<LogisticsDollarsDto> GetLogisticsDollars(DateTime start, DateTime end)
        {
            var inboundOutbound = new List<string> { "Inbound", "Outbound" };

            return (from d in _fmsb2Context.LogisticsDollars
                    join m in _fmsb2Context.LogisticsMm
                    on d.LogisticsId equals m.Id
                    where m.Date >= start && m.Date <= end && inboundOutbound.Contains(d.Category)
                    select new LogisticsDollarsDto
                    {
                        Date = (DateTime)m.Date,
                        Category = d.Category,
                        Cost = (decimal)d.Actual,
                        Target = (decimal)d.Target
                    }).ToList();
        }

        public IEnumerable<InventoryStatusDto> GetInventoryStatus(
                List<SapDumpNewView> inventoryData,
                List<string> dmax, 
                List<LogisticsCommentDto> logiticsComments)
        {
            const int DAILY_AVG = 50000;

            var foundry = inventoryData
                            .Where(x => x.TypeSap == "P5C")
                            .GroupBy(x => new { x.Date })
                            .Select(x => new InventoryStatusDto
                            {
                                Sort = 1,
                                Date = x.Key.Date,
                                Category = "Foundry Casting (0115, 0125)",
                                Total = (decimal)x.Sum(t => t.TotalUnrestInv),
                                AvergageDays = (decimal)x.Sum(t => t.TotalUnrestInv) / DAILY_AVG
                            });

            var mach = inventoryData
                            .Where(x => x.TypeSap == "P3M")
                            .GroupBy(x => new { x.Date })
                            .Select(x => new InventoryStatusDto
                            {
                                Sort = 2,
                                Date = x.Key.Date,
                                Category = "Machine WIP (0130)",
                                Total = (decimal)x.Sum(t => t.TotalUnrestInv),
                                AvergageDays = (decimal)x.Sum(t => t.TotalUnrestInv) / DAILY_AVG
                            });

            var fin = inventoryData
                            .Where(x => x.TypeSap == "P2F")
                            .GroupBy(x => new { x.Date })
                            .Select(x => new InventoryStatusDto
                            {
                                Sort = 3,
                                Date = x.Key.Date,
                                Category = "Finishing (P2F)",
                                Total = (decimal)x.Sum(t => t.TotalUnrestInv),
                                AvergageDays = (decimal)x.Sum(t => t.TotalUnrestInv) / DAILY_AVG
                            });

            var assyExcludeDmax = inventoryData
                            .Where(x => x.TypeSap == "P1A")
                            .Where(x => !dmax.Contains(x.Material))
                            .GroupBy(x => new { x.Date })
                            .Select(x => new InventoryStatusDto
                            {
                                Sort = 3,
                                Date = x.Key.Date,
                                Category = "SB – Finish Goods",
                                Total = (decimal)x.Sum(t => t._0300),
                                AvergageDays = (decimal)x.Sum(t => t.TotalUnrestInv) / DAILY_AVG
                            });

            var dmaxOnly = inventoryData
                            .Where(x => x.TypeSap == "P1A")
                            .Where(x => dmax.Contains(x.Material))
                            .GroupBy(x => new { x.Date })
                            .Select(x => new InventoryStatusDto
                            {
                                Sort = 3,
                                Date = x.Key.Date,
                                Category = "SBT – Finish Goods",
                                Total = (decimal)x.Sum(t => t._0300),
                                AvergageDays = (decimal)x.Sum(t => t.TotalUnrestInv) / DAILY_AVG
                            });

            var inventoryStaus = foundry
                                .Concat(mach)
                                .Concat(fin)
                                .Concat(assyExcludeDmax)
                                .Concat(dmaxOnly);

            var result = inventoryStaus
                            .Select(x => new InventoryStatusDto
                            {
                                Sort = x.Sort,
                                Date = x.Date,
                                Category = x.Category,
                                Total = x.Total,
                                AvergageDays = Math.Round((x.Total / DAILY_AVG),1),
                                Comments = logiticsComments.Any(c => c.Category == x.Category)
                                            ? logiticsComments.Where(c => c.Category == x.Category).First().Comments
                                            : ""
                            })
                            .ToList();

            return result;
        }

        public IEnumerable<InventoryCostDto> GetInventoryCost(List<SapDumpNewView> inventoryData, DateTime start, DateTime end)
        {
            throw new NotImplementedException();
        }

        public StockStatusDto GetStockStatus(DateTime start, DateTime end)
        {
            var inventoryData = GetInventory(start, end);
            var dmax = GetDmaxParts();
            var comments = GetLogisticsComments(start, end);

            return new StockStatusDto
            {
                Start = start,
                End = end,
                InventoryStatus = GetInventoryStatus(inventoryData, dmax, comments)
            };
        }

        

        public IEnumerable<CustomerCommentsDto> GetCustomerComments(DateTime start, DateTime end)
        {
            throw new NotImplementedException();
        }
    }
}
