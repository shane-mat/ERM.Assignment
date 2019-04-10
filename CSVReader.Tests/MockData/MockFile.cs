using CSVReader.Core.Models;
using System;
using System.Collections.Generic;

namespace CSVReader.Tests.MockData
{
    public class MockFile
    {
        public static List<LPFileModel> GetMockLPData()
        {
            return  new List<LPFileModel>
            {
                new LPFileModel
                {
                    DataValue = 2.0003, DateAndTime = DateTime.Parse("31/08/2015 00:45:00"), DataType = "Import Wh Total",
                    MeterPointCode = 210095893, PlantCode = "ED031000001", SerialNumber = 210095893, Status = "",
                    Units = "kwh"
                },
                new LPFileModel
                {
                    DataValue = 3.0003, DateAndTime = DateTime.Parse("31/08/2015 00:45:00"), DataType = "Import Wh Total",
                    MeterPointCode = 210095873, PlantCode = "ED031000001", SerialNumber = 210095893, Status = "",
                    Units = "kwh"
                },
                new LPFileModel
                {
                    DataValue = 4.0003, DateAndTime = DateTime.Parse("31/08/2015 00:45:00"), DataType = "Import Wh Total",
                    MeterPointCode = 210096893, PlantCode = "ED031000001", SerialNumber = 210095893, Status = "",
                    Units = "kwh"
                },
                new LPFileModel
                {
                    DataValue = 2.50003, DateAndTime = DateTime.Parse("31/08/2015 00:45:00"), DataType = "Import Wh Total",
                    MeterPointCode = 215095893, PlantCode = "ED031000001", SerialNumber = 210095893, Status = "",
                    Units = "kwh"
                },
                new LPFileModel
                {
                    DataValue = 5.50003, DateAndTime = DateTime.Parse("31/08/2015 00:45:00"), DataType = "Import Wh Total",
                    MeterPointCode = 210055893, PlantCode = "ED031000001", SerialNumber = 210095893, Status = "",
                    Units = "kwh"
                },
                new LPFileModel
                {
                    DataValue = 6.50003, DateAndTime = DateTime.Parse("31/08/2015 00:45:00"), DataType = "Import Wh Total",
                    MeterPointCode = 210495893, PlantCode = "ED031000001", SerialNumber = 210095893, Status = "",
                    Units = "kwh"
                }
            };
        }

        public static List<TOUFileModel> GetMockTOUData()
        {
            return new List<TOUFileModel>
            {
                new TOUFileModel
                {
                    Energy = 2.0003, DateAndTime = DateTime.Parse("31/08/2015 00:45:00"), DataType = "Import Wh Total",
                    MeterPointCode = 210095893, PlantCode = "ED031000001", SerialNumber = 210095893, Status = "",
                    Units = "kwh",BillingResetCount = 222,BillingResetDateTime =  DateTime.Parse("31/08/2015 00:45:00"),
                    DLSActive = true,MaximumDemand = 2,Period = "",Rate = "",TimeOfMaximumDemand = DateTime.Parse("31/08/2015 00:45:00")
                },
                new TOUFileModel
                {
                    Energy = 3.0003, DateAndTime = DateTime.Parse("31/08/2015 00:45:00"), DataType = "Import Wh Total",
                    MeterPointCode = 210095873, PlantCode = "ED031000001", SerialNumber = 210095893, Status = "",
                    Units = "kwh",BillingResetCount = 222,BillingResetDateTime =  DateTime.Parse("31/08/2015 00:45:00"),
                    DLSActive = true,MaximumDemand = 2,Period = "",Rate = "",TimeOfMaximumDemand = DateTime.Parse("31/08/2015 00:45:00")
                },
                new TOUFileModel
                {
                    Energy = 4.0003, DateAndTime = DateTime.Parse("31/08/2015 00:45:00"), DataType = "Import Wh Total",
                    MeterPointCode = 210096893, PlantCode = "ED031000001", SerialNumber = 210095893, Status = "",
                    Units = "kwh",BillingResetCount = 222,BillingResetDateTime =  DateTime.Parse("31/08/2015 00:45:00"),
                    DLSActive = true,MaximumDemand = 2,Period = "",Rate = "",TimeOfMaximumDemand = DateTime.Parse("31/08/2015 00:45:00")
                },
                new TOUFileModel
                {
                    Energy = 2.50003, DateAndTime = DateTime.Parse("31/08/2015 00:45:00"), DataType = "Import Wh Total",
                    MeterPointCode = 215095893, PlantCode = "ED031000001", SerialNumber = 210095893, Status = "",
                    Units = "kwh",BillingResetCount = 222,BillingResetDateTime =  DateTime.Parse("31/08/2015 00:45:00"),
                    DLSActive = true,MaximumDemand = 2,Period = "",Rate = "",TimeOfMaximumDemand = DateTime.Parse("31/08/2015 00:45:00")
                },
                new TOUFileModel
                {
                    Energy = 5.50003, DateAndTime = DateTime.Parse("31/08/2015 00:45:00"), DataType = "Import Wh Total",
                    MeterPointCode = 210055893, PlantCode = "ED031000001", SerialNumber = 210095893, Status = "",
                    Units = "kwh",BillingResetCount = 222,BillingResetDateTime =  DateTime.Parse("31/08/2015 00:45:00"),
                    DLSActive = true,MaximumDemand = 2,Period = "",Rate = "",TimeOfMaximumDemand = DateTime.Parse("31/08/2015 00:45:00")
                },
                new TOUFileModel
                {
                    Energy = 6.50003, DateAndTime = DateTime.Parse("31/08/2015 00:45:00"), DataType = "Import Wh Total",
                    MeterPointCode = 210495893, PlantCode = "ED031000001", SerialNumber = 210095893, Status = "",
                    Units = "kwh",BillingResetCount = 222,BillingResetDateTime =  DateTime.Parse("31/08/2015 00:45:00"),
                    DLSActive = true,MaximumDemand = 2,Period = "",Rate = "",TimeOfMaximumDemand = DateTime.Parse("31/08/2015 00:45:00")
                }
            };
        }
    }
}
