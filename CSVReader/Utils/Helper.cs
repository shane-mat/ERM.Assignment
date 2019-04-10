using System;
using System.Collections.Generic;
using System.Linq;

namespace CSVReader.Utils
{
   public static class Helper
    {
        public static T GetMedianValue<T>(this IEnumerable<T> items)
        {
            var i = (int)Math.Ceiling((double)(items.Count() - 1) / 2);
            if (i >= 0)
            {
                var values = items.ToList();
                values.Sort();
                return values[i];
            }
            return default(T);
        }

        public static double CalculatePercentageValue(double value,int percentage)
        {
            return (value / 100) * percentage;
        }

        public static bool CheckAlmostEquals(double value1, double value2)
        {
            return Math.Abs(value1 - value2) <= 0.0001;
        }
    }
}
