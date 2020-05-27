using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Helpers
{
    public class TrendLine
    {
        public double Slope { get; private set; }
        public double Intercept { get; private set; }
        public double Start { get; private set; }
        public double End { get; private set; }


        public double GetYValue(double xValue)
        {
            return Intercept + Slope * xValue;
        }

        public TrendLine(IList<double> yAxisValues, IList<double> xAxisValues) : this(yAxisValues.Select((t, i) => new Tuple<double, double>(xAxisValues[i], t)))
        {
        }

        public TrendLine(IEnumerable<Tuple<double, double>> data)
        {
            var cachedData = data.ToList();

            var n = cachedData.Count;

            var sumX = cachedData.Sum(x => x.Item1);
            var sumY = cachedData.Sum(x => x.Item2);

            var sumX2 = cachedData.Sum(x => x.Item1 * x.Item1);
            var sumXY = cachedData.Sum(x => x.Item1 * x.Item2);

            //b = (sum(x*y) - sum(x)sum(y)/n)
            //      / (sum(x^2) - sum(x)^2/n)
            Slope = (sumXY - ((sumX * sumY) / n))
                        / (sumX2 - (sumX * sumX / n));

            //a = sum(y)/n - b(sum(x)/n)
            Intercept = (sumY / n) - (Slope * (sumX / n));

            Start = GetYValue(cachedData.Min(a => a.Item1));
            End = GetYValue(cachedData.Max(a => a.Item1));
        }

        public static TrendLine GetTrendLine<T>(IEnumerable<T> data, string propName)
        {
            if (data == null) throw new ArgumentNullException(nameof(data));

            var tupleData = new List<Tuple<double, double>>();
            int i = 0;
            foreach (var item in data)
            {
                i++;
                var val = item.GetType().GetProperty(propName).GetValue(item, null);
                tupleData.Add(new Tuple<double, double>(i, item2: Convert.ToDouble(val)));
            }
            return new TrendLine(tupleData);

        }

        public TrendLine()
        {

        }
    }
}
