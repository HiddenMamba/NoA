using System;
using System.Globalization;
using DateRange.Strategy;

namespace DateRange
{

    public class DateRangeService
    { 
        public string DateRange(DateTime firstDate, DateTime secondDate)
        {
            TimeSpan timeSpan = secondDate - firstDate;            
            switch (timeSpan.TotalDays)
            {
                case <  0:
                    return $"First date should be greater than second one in current culture: ({CultureInfo.CurrentCulture.Name})!";

                case    0:
                    return firstDate.ToString("d");

                case >  0:
                    return FormatFactory.GetFormatStrategy(CultureInfo.CurrentCulture).GetDate(firstDate, secondDate);
                
                default:
                    throw new Exception("Time span conversion failed!");  
                
            }            
        }
    }
}