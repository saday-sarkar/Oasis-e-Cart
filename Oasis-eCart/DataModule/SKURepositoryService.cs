using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oasis_eCart
{
    public class SKURepositoryService : ISKURepository
    {
        /*
         * Useing Hard coded repository for this assignment. It should be from DB
         * */
        public IEnumerable<StockKeepingUnit> GetStockKeepingUnits()
        {
            return new List<StockKeepingUnit>
            {
                new StockKeepingUnit
                {
                     SKUID='A',
                      SKUName = "Apple",
                       SKUUnitPrice = 50
                },
                new StockKeepingUnit
                {
                     SKUID='B',
                      SKUName = "Banana",
                       SKUUnitPrice = 30
                },
                new StockKeepingUnit
                {
                     SKUID='C',
                      SKUName = "Cherrie",
                       SKUUnitPrice = 20
                },
                new StockKeepingUnit
                {
                     SKUID='D',
                      SKUName = "Damson",
                       SKUUnitPrice = 15
                }
            };
        }
    }
}
