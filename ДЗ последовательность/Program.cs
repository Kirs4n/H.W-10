using System;

namespace ДЗ_последовательность
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dayeYears = 365;
            for (int i = 5; i <= dayeYears; i += 7)
            {
                Console.WriteLine($"День {i} c начала отчета");
            }
        }
    }
}
