using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CSVReader.Core.Interfaces;
using CSVReader.Utils;

namespace CSVReader.FileProcessor
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

        public IEnumerable<T> SelectValuesSatisfiedTheCondition(IEnumerable<T> values, string file, double median)
        {
            try
            {
                var percentofMedian = Helper.CalculatePercentageValue(median, percentage);
                return values.Where(c => !Helper.CheckAlmostEquals(ComparisonValue(c), 0) &&
                              Helper.CheckAlmostEquals(Math.Abs(median - ComparisonValue(c)), percentofMedian)).Select(r => r);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return new List<T>();
        }

        protected void PrintValues(IEnumerable<T> values, string file, double median)
        {
            var formatedValues = values.Select(value => $"{file} {DateTimeValue(value)} {ComparisonValue(value)} {median}   \n");

            foreach (var value in formatedValues)
            {
                Console.Write(value);
            }
        }
    }
}