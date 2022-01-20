using System;
using System.Globalization;
namespace DateRange.Strategy
{
    abstract class FormatStrategy
    {
        protected enum DashSpace
        {
            day = 0,
            month = 1,
            year = 2,
        }

        protected DashSpace getDashSpace(DateTime first_date, DateTime second_date)
        {
            if (first_date.Year != second_date.Year)
            {
                return DashSpace.year;
            }

            if (first_date.Month != second_date.Month)
            { 
                return DashSpace.month;
            }

            return DashSpace.day;
        }

        public abstract string GetDate(DateTime first_date, DateTime second_date);
    }
}
