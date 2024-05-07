using SalesSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SalesSystem.Repository
{
    public class SalesRepository : ISalesRepository
    {
        public IList<Sales> SearchSales(short month, short year) 
        {
            return new List<Sales>
            {
                new Sales
                {
                    Date = new DateTime(2024, 05, 07),
                    Value = 500.00m
                }
            };
        }
    }
}
