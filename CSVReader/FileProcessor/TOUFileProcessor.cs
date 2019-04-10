using System;
using CSVReader.Core.Enums;
using CSVReader.Core.Models;
using System.Linq;
using CSVReader.Utils;

namespace CSVReader.FileProcessor
{
    public class TOUFileProcessor : FileProcessorBase<TOUFileModel>
    {
        public override void ProcessFiles(string filePath)
        {
            try
            {
                foreach (var file in GetFileNames(filePath, FileType.TOU.ToString()))
                {
                    var values = ReadFile(file, TOUFileModel.MapItems);
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

        protected override double ComparisonValue(TOUFileModel model)
        {
            return model.Energy;
        }

        protected override DateTime DateTimeValue(TOUFileModel model)
        {
            return model.DateAndTime;
        }
    }
}