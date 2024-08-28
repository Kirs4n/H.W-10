using System;

namespace ДЗ_последовательность
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dayeYears = 365;
            int reportingDate = 5;
            int weekdays = 7;
            for (reportingDate  = 5; reportingDate <= dayeYears; reportingDate += weekdays)
            {
                Console.WriteLine(reportingDate);
            }
        }
    }
}
