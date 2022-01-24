using System;
using Xunit;
using System;
using System.Globalization;
using DateRange;
using DateRange.Strategy;
namespace UnitTest
{
    public class JapaneseFormatTests
    {
        [Fact]
        public void When_provided_dates_differ_by_day_return_correct_format_in_JP_format()
        {
            // Arrage
            CultureInfo.CurrentCulture = new CultureInfo("ja-JP", false);
            DateTime BeginDate = DateTime.Parse("2017/01/01");
            DateTime EndDate = DateTime.Parse("2017/01/05");
            var getTimeService = new DateRangeService();
            // Act
            var result = getTimeService.DateRange(BeginDate, EndDate);
            // Assert
            Assert.Equal("2017/01/01-05",result);
        }
        [Fact]
        public void When_provided_dates_differ_by_month_return_correct_format_in_JP_format()
        {
            // Arrage
            CultureInfo.CurrentCulture = new CultureInfo("ja-JP", false);
            DateTime BeginDate = DateTime.Parse("2017/01/01");
            DateTime EndDate = DateTime.Parse("2017/02/01");
            var getTimeService = new DateRangeService();
            // Act
            var result = getTimeService.DateRange(BeginDate, EndDate);
            // Assert
            Assert.Equal("2017/01/01-02/01",result);
        }
        [Fact]
        public void When_provided_dates_differ_by_year_return_correct_format_in_JP_format()
        {
            // Arrage
            CultureInfo.CurrentCulture = new CultureInfo("ja-JP", false);
            DateTime BeginDate = DateTime.Parse("2016/01/01");
            DateTime EndDate = DateTime.Parse("2017/02/01");
            var getTimeService = new DateRangeService();
            // Act
            var result = getTimeService.DateRange(BeginDate, EndDate);
            // Assert
            Assert.Equal("2016/01/01-2017/02/01",result);
        }
    }
        public class USFormatTests
    {
        [Fact]
        public void When_provided_dates_differ_by_day_return_correct_format_in_US_format()
        {
            // Arrage
            CultureInfo.CurrentCulture = new CultureInfo("en-US", false);
            DateTime BeginDate = DateTime.Parse("01/01/2017");
            DateTime EndDate = DateTime.Parse("01/05/2017");
            var getTimeService = new DateRangeService();
            // Act
            var result = getTimeService.DateRange(BeginDate, EndDate);
            // Assert
            Assert.Equal("01-01/05/2017",result);
        }
        [Fact]
        public void When_provided_dates_differ_by_month_return_correct_format_in_US_format()
        {
            // Arrage
            CultureInfo.CurrentCulture = new CultureInfo("en-US", false);
            DateTime BeginDate = DateTime.Parse("01/01/2017");
            DateTime EndDate = DateTime.Parse("02/01/2017");
            var getTimeService = new DateRangeService();
            // Act
            var result = getTimeService.DateRange(BeginDate, EndDate);
            // Assert
            Assert.Equal("01/01-02/01/2017",result);
        }
        [Fact] 
        public void When_provided_dates_differ_by_year_return_correct_format_in_US_format()
        {
            // Arrage
            CultureInfo.CurrentCulture = new CultureInfo("en-US", false);
            DateTime BeginDate = DateTime.Parse("01/01/2016");
            DateTime EndDate = DateTime.Parse("02/01/2017");
            var getTimeService = new DateRangeService();
            // Act
            var result = getTimeService.DateRange(BeginDate, EndDate);
            // Assert
            Assert.Equal("01/01/2016-02/01/2017",result);
        }
    }
            public class DefaultFormatTests
    {
        [Fact] 
        public void When_provided_dates_differ_by_day_return_correct_format_in_Default_format()
        {
            // Arrage
            CultureInfo.CurrentCulture = new CultureInfo("pl-PL", false);
            DateTime BeginDate = DateTime.Parse("01.01.2017");
            DateTime EndDate = DateTime.Parse("05.01.2017");
            var getTimeService = new DateRangeService();
            //Act
            var result = getTimeService.DateRange(BeginDate, EndDate);
            // Assert
            Assert.Equal("01-05.01.2017",result);
        }
        [Fact] 
        public void When_provided_dates_differ_by_month_return_correct_format_in_Default_format()
        {
            // Arrage
            CultureInfo.CurrentCulture = new CultureInfo("pl-PL", false);
            DateTime BeginDate = DateTime.Parse("01.01.2017");
            DateTime EndDate = DateTime.Parse("05.02.2017");
            var getTimeService = new DateRangeService();
            //Act
            var result = getTimeService.DateRange(BeginDate, EndDate);
            // Assert
            Assert.Equal("01.01-05.02.2017",result);
        }
        [Fact] 
        public void When_provided_dates_differ_by_year_return_correct_format_in_Default_format()
        {
            // Arrage
            CultureInfo.CurrentCulture = new CultureInfo("pl-PL", false);
            DateTime BeginDate = DateTime.Parse("01.01.2016");
            DateTime EndDate = DateTime.Parse("05.01.2017");
            var getTimeService = new DateRangeService();
            //Act
            var result = getTimeService.DateRange(BeginDate, EndDate);
            // Assert
            Assert.Equal("01.01.2016-05.01.2017",result);
        }
    }
}
