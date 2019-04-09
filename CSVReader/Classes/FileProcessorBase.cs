using CSVReader.Core.Interfaces;
using CSVReader.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CSVReader.Classes
{
    public abstract class FileProcessorBase<T> : IFileProcessor
    {
        protected const int percentage = 20;

        public abstract void ProcessFiles(string filePath);

        protected abstract double ComparisonValue(T model);

        protected abstract DateTime DateTimeValue(T model);

        protected IEnumerable<T> ReadFile(string file, Func<string, T> func)
        {
            return File.ReadAllLines(file).Skip(1).Select(func);
        }

        protected IEnumerable<string> GetFileNames(string filePath, string fileType)
        {
            return Directory.EnumerateFiles(filePath).Where(w => w.Contains(fileType));
        }

        protected List<string> GetValuesForPrint(IEnumerable<T> values, string file)
        {
            try
            {
                var median = values.Select(ComparisonValue).GetMedian();
                var percentofMedian = Helper.CalculatePercentageValue(median, percentage);
                var selectedValues = values.Where(c => !Helper.CheckNearlyEquals(ComparisonValue(c), 0) &&
                             Helper.CheckNearlyEquals(Math.Abs(median - ComparisonValue(c)), percentofMedian)).Select(r => r);

                return FormatValues(selectedValues, file, median);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return new List<string>();
        }

        protected void PrintValues(List<string> values)
        {
            foreach (var value in values)
            {
                Console.Write(value);
            }
        }

        private List<string> FormatValues(IEnumerable<T> values, string file, double median)
        {
            var formatedValues = new List<string>();

            formatedValues.AddRange(values.Select(value => $"{file} {DateTimeValue(value)} {ComparisonValue(value)} {median}   \n"));
            return formatedValues;
        }
    }
}
