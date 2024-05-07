using SalesSystem.Business;
using SalesSystem.Repository;
using System;

namespace SalesSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var monthlyAverageValue = new BusinessSales(new SalesRepository()).CalculateMonthlyAverage(04, 2021);

            Console.WriteLine($"Average Sales Value for the Month: {monthlyAverageValue}");
        }
    }
}
