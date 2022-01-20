namespace DateRange.Strategy
{
    class JPFormatStrategy : FormatStrategy
    {
        public override string GetDate(DateTime beginDate, DateTime endDate)
        {
            switch (getDashSpace(beginDate,endDate))
            {
                case (DashSpace.year):
                    return $"{beginDate.ToString("yyyy/MM/dd")}-{endDate.ToString("yyyy/MM/dd")}"; 

                case (DashSpace.month):
                    return $"{beginDate.ToString("yyyy/MM/dd")}-{endDate.ToString("MM/dd")}"; 

                case (DashSpace.day):
                    return $"{beginDate.ToString("yyyy/MM/dd")}-{endDate.ToString("dd")}"; 
                default:
                    throw new Exception("Unreachable code detected!");  
            }
        }
    }
}
