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
            return 0;
        }
    }
}
