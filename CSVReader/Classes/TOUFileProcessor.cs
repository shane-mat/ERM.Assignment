using CSVReader.Core.Enums;
using CSVReader.Core.Models;
using System;

namespace CSVReader.Classes
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
                    var selectedValues = GetValuesForPrint(values, System.IO.Path.GetFileNameWithoutExtension(file));
                    PrintValues(selectedValues);
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