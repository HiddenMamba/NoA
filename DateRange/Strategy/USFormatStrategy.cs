namespace DateRange.Strategy
{
    class USFormatStrategy : FormatStrategy
    { 
        public override string GetDate(DateTime beginDate, DateTime endDate)
        {
            switch (getDashSpace(beginDate,endDate))
            {
                case (DashSpace.year):
                    return $"{beginDate.ToString("MM/dd/yyyy")}-{endDate.ToString("MM/dd/yyyy")}";

                case (DashSpace.month):
                    return $"{beginDate.ToString("MM/dd")}-{endDate.ToString("MM/dd/yyyy")}";

                case (DashSpace.day):
                    return $"{beginDate.ToString("dd")}-{endDate.ToString("MM/dd/yyyy")}";
                default:
                    throw new Exception("Unreachable code detected!");                
            }
        }
    }
}
