using SalesSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesSystem
{
    public interface ISalesRepository
    {
        IList<Sales> SearchSales(short month, short  year);
    }
}
