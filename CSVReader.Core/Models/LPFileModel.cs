using System;

namespace CSVReader.Core.Models
{
    public class LPFileModel
    {
        public double MeterPointCode { get; set; }
        public double SerialNumber { get; set; }
        public string PlantCode { get; set; }
        public DateTime DateAndTime { get; set; }
        public string DataType { get; set; }
        public double DataValue { get; set; }
        public string Units { get; set; }
        public string Status { get; set; }

        public static LPFileModel MapItems(string csvLine)
        {
            var values = csvLine.Split(',');
            return new LPFileModel
            {
                MeterPointCode = double.Parse(values[0]),
                SerialNumber = double.Parse(values[1]),
                PlantCode = Convert.ToString(values[2]),
                DateAndTime = DateTime.Parse(values[3]),
                DataType = Convert.ToString(values[4]),
                DataValue = double.Parse(values[5]),
                Units = Convert.ToString(values[6]),
                Status = Convert.ToString(values[7]),
            };
        }
    }
}
