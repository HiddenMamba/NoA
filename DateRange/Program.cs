using System;
using System.Globalization;
using DateRange;

if (args.Length != 2)
{
    Console.WriteLine("Error, wrong amount of input parameters (should be 2)");
}
else if(DateTime.TryParse(args[0], out var beginDate) && DateTime.TryParse(args[1], out var secondDate)) 
{
    var dateRangeService = new DateRangeService(); 
    Console.WriteLine(dateRangeService.DateRange(beginDate, secondDate));
}
else
{
    Console.WriteLine("Parsing data to date failed! Check your input parameters!");
}
