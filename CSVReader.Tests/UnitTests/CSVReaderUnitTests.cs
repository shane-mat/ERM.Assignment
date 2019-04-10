using System;
using System.Linq;
using Xunit;
using CSVReader.Core.Models;
using CSVReader.Utils;
using CSVReader.Tests.MockData;
using CSVReader.FileProcessor;

namespace CSVReader.Tests.UnitTests
{
    public class CSVReaderUnitTests
    {
        [Fact]
        public void check_LP_file_values()
        {
            FileProcessorBase<LPFileModel> lp = new LPFileProcessor();
            Assert.NotNull(lp.SelectValuesSatisfiedTheCondition(MockFile.GetMockLPData(), "LPFile", 2.5));
        }

        [Fact]
        public void check_TOU_file_values()
        {
            FileProcessorBase<TOUFileModel> tou = new TOUFileProcessor();
            Assert.NotNull(tou.SelectValuesSatisfiedTheCondition(MockFile.GetMockTOUData(), "LPFile", 2.5));
        }
        
        [Fact]
        public void check_median_from_list()
        {
            var values = new double[]{ 1, 3,2, 5,4 };

            var listvalues = values.Select(i => Convert.ToDouble(i)).ToList();
            var median = listvalues.GetMedianValue();
            Assert.Equal(3,median);
        }
        
        [Fact]
        public void check_datavalue_in_lp_model()
        {
            var type = typeof(LPFileModel);
            var property = type.GetProperty("DataValue");
            Assert.NotNull(property);
        }

        [Fact]
        public void check_energy_in_tou_model()
        {
            var type = typeof(TOUFileModel);
            var property = type.GetProperty("Energy");
            Assert.NotNull(property);
        }

        [Fact]
        public void check_dateandtime_in_lp_model()
        {
            var type = typeof(LPFileModel);
            var property = type.GetProperty("DateAndTime");
            Assert.NotNull(property);
        }

        [Fact]
        public void check_dateandtime_in_tou_model()
        {
            var type = typeof(TOUFileModel);
            var property = type.GetProperty("DateAndTime");
            Assert.NotNull(property);
        }
    }
}
