﻿using System;

namespace CSVReader.Core.Models
{
    public class TOUFileModel
    {
        public double MeterPointCode { get; set; }
        public double SerialNumber { get; set; }
        public string PlantCode { get; set; }
        public DateTime DateAndTime { get; set; }
        public string DataType { get; set; }
        public double Energy { get; set; }
        public double MaximumDemand { get; set; }
        public DateTime TimeOfMaximumDemand { get; set; }
        public string Units { get; set; }
        public string Status { get; set; }
        public string Period { get; set; }
        public bool DLSActive { get; set; }
        public double BillingResetCount { get; set; }
        public DateTime BillingResetDateTime { get; set; }
        public string Rate { get; set; }

        public static TOUFileModel MapItems(string csvLine)
        {
            var values = csvLine.Split(',');
            return new TOUFileModel
            {
                MeterPointCode = Double.Parse(values[0]),
                SerialNumber = Double.Parse(values[1]),
                PlantCode = Convert.ToString(values[2]),
                DateAndTime = Convert.ToDateTime(values[3]),
                DataType = Convert.ToString(values[4]),
                Energy = Double.Parse(values[5]),
                MaximumDemand = Double.Parse(values[6]),
                TimeOfMaximumDemand = Convert.ToDateTime(values[7]),
                Units = Convert.ToString(values[8]),
                Status = Convert.ToString(values[9]),
                Period = Convert.ToString(values[10]),
                DLSActive = Convert.ToBoolean(values[11]),
                BillingResetCount = Double.Parse(values[12]),
                BillingResetDateTime = Convert.ToDateTime(values[13]),
                Rate = Convert.ToString(values[14]),
            };
        }
    }
}