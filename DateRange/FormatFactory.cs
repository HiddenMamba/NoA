using System;
using System.Globalization;
using DateRange.Strategy;

namespace DateRange 
{
    static class FormatFactory
    {
        public static FormatStrategy GetFormatStrategy(CultureInfo cultureInfo)
        {
            switch(cultureInfo.Name)
            {
                case "en-US":
                    return new USFormatStrategy(); 
                case "pl-PL":
                    return new DefaultFormatStrategy();
                case "ja-JP":
                    return new JPFormatStrategy();
                default:
                    return new DefaultFormatStrategy();
            }
        }
    }
}
