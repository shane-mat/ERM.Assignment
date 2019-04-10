using CSVReader.Core.Interfaces;
using CSVReader.FileProcessor;
using System;
using System.Configuration;

namespace CSVReader
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var path = ConfigurationManager.AppSettings["CSVFilePath"];
            IFileProcessor fileProcessor;

            Console.WriteLine($"Configured path for reading the csv files is: {path}");
            Console.WriteLine($"It reads LP and TOU files and find values that are 20% above or below the median, and print to the console\n");

            try
            {
                fileProcessor = new LPFileProcessor();
                fileProcessor.ProcessFiles(path);

                fileProcessor = new TOUFileProcessor();
                fileProcessor.ProcessFiles(path);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
