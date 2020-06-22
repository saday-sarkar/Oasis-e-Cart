using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oasis_eCart
{
    public interface ISKURepository
    {
        IEnumerable<StockKeepingUnit> GetStockKeepingUnits();
    }
}
