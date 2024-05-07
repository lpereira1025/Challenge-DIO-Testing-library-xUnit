using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesSystem.Business
{
    public class BusinessSales
    {
        private ISalesRepository _salesRepository;

        public BusinessSales(ISalesRepository salesRepository)
        {
            _salesRepository = salesRepository;
        }

        public decimal CalculateMonthlyAverage(short month, short year)
        {
            var sales = _salesRepository.SearchSales(month, year);

            var salesMonth = sales.Sum(s => s.Value) / sales.Count();

            return Math.Round(salesMonth, 2);
        }
    }
}
