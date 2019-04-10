using System;
using CSVReader.Core.Enums;
using CSVReader.Core.Models;
using System.Linq;
using CSVReader.Utils;

namespace CSVReader.FileProcessor
{
    public class LPFileProcessor : FileProcessorBase<LPFileModel>
    {
        public override void ProcessFiles(string filePath)
        {
            try
            {
                foreach (var file in GetFileNames(filePath, FileType.LP.ToString()))
                {
                    var values = ReadFile(file, LPFileModel.MapItems);
                    var median = values.Select(ComparisonValue).GetMedianValue();
                    var fileName = System.IO.Path.GetFileNameWithoutExtension(file);
                    var selectedValues = SelectValuesSatisfiedTheCondition(values, fileName, median);
                    PrintValues(selectedValues, fileName, median);
                }                 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        protected override double ComparisonValue(LPFileModel model)
        {
            return model.DataValue;
        }

        protected override DateTime DateTimeValue(LPFileModel model)
        {
            return model.DateAndTime;
        }
    }
}