using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oasis_eCart
{
    public class PromotionEngine
    {
        private readonly SKURepositoryService SKURepoService;
        private readonly PromotionRepositoryService promotionRepositoryService;
        public PromotionEngine()
        {
            SKURepoService = new SKURepositoryService();
            promotionRepositoryService = new PromotionRepositoryService();
        }
        public int CheckOutCart (MyCart myCart)
        {
            var RepositoryItems = this.SKURepoService.GetStockKeepingUnits();
            var Promotions = this.promotionRepositoryService.GetPromotions();
            return ApplyPromotions(myCart, RepositoryItems, Promotions);
        }
        private int ApplyPromotions(MyCart myCart, IEnumerable<StockKeepingUnit> RepositoryItems, IEnumerable<Promotion> Promotions)
        {
            int Result = 0;
            //With No Promotion
            while (myCart.MyCartItems.Count() > 0)
            {
                var item = myCart.MyCartItems.FirstOrDefault();
                Result += (RepositoryItems.Where(z => z.SKUID == item.MyCartItemID).FirstOrDefault().SKUUnitPrice * item.MyCartItemUnit);
                myCart.MyCartItems.Remove(item);
            }
            return Result;
        }
    }
}
