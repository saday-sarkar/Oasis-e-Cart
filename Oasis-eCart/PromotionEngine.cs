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
            //Promotion Type 1 (Promo 1 and 2)
            try
            {
                foreach (var promo in Promotions.Where(y => y.Type == 1).ToList())
                {
                    while (myCart.MyCartItems.Where(x => x.MyCartItemID == promo.SKUID1).FirstOrDefault()?.MyCartItemUnit >= promo.SKUUnit)
                    {
                        Result += promo.Price;
                        myCart.MyCartItems.Where(x => x.MyCartItemID == promo.SKUID1).FirstOrDefault().MyCartItemUnit -= promo.SKUUnit;
                    }
                }

                //Promotion Type 2 ( Promotion 3 )
                foreach (var promo in Promotions.Where(y => y.Type == 2).ToList())
                {
                    while (myCart.MyCartItems.Where(x => x.MyCartItemID == promo.SKUID1).FirstOrDefault()?.MyCartItemUnit >= 1 && myCart.MyCartItems.Where(x => x.MyCartItemID == promo.SKUID2).FirstOrDefault()?.MyCartItemUnit >= 1)
                    {
                        Result += promo.Price;
                        myCart.MyCartItems.Where(x => x.MyCartItemID == promo.SKUID1).FirstOrDefault().MyCartItemUnit -= 1;
                        myCart.MyCartItems.Where(x => x.MyCartItemID == promo.SKUID2).FirstOrDefault().MyCartItemUnit -= 1;
                    }
                }

                //With No Promotion
                while (myCart.MyCartItems.Count() > 0)
                {
                    var item = myCart.MyCartItems.FirstOrDefault();
                    Result += (RepositoryItems.Where(z => z.SKUID == item.MyCartItemID).FirstOrDefault().SKUUnitPrice * item.MyCartItemUnit);
                    myCart.MyCartItems.Remove(item);
                }
            }
            catch( Exception ex)
            {
                throw new Exception("Promotion failed to apply : " + ex.Message);
            }
            return Result;
        }
    }
}
