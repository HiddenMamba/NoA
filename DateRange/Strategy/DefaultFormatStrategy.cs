namespace DateRange.Strategy
{
    class DefaultFormatStrategy : FormatStrategy
    { 
        public override string GetDate(DateTime beginDate, DateTime endDate)
        {
            switch (getDashSpace(beginDate,endDate))
            {
                case (DashSpace.year):
                    return $"{beginDate.ToString("dd/MM/yyyy")}-{endDate.ToString("dd/MM/yyyy")}"; 

                case (DashSpace.month):
                    return $"{beginDate.ToString("dd/MM")}-{endDate.ToString("dd/MM/yyyy")}"; 

                case (DashSpace.day):
                    return $"{beginDate.ToString("dd")}-{endDate.ToString("dd/MM/yyyy")}";
                default:
                    throw new Exception("Unreachable code detected!");  
            }
        }
    }
}
