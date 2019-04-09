using CSVReader.Core.Enums;
using CSVReader.Core.Models;
using System;

namespace CSVReader.Classes
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
                    var selectedValues = GetValuesForPrint(values, System.IO.Path.GetFileNameWithoutExtension(file));
                    PrintValues(selectedValues);
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
