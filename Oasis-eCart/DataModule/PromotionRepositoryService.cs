using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oasis_eCart
{
    class PromotionRepositoryService : IPromotionRepository
    {
        public IEnumerable<Promotion> GetPromotions()
        {
            return new List<Promotion>
            {
                new Promotion
                {
                     PromotionId=1,
                     Description = "3 of As for 130",
                     Type = 1,
                     SKUID1 = 'A',
                     SKUID2 = 'x',
                     SKUUnit = 3,
                     Price = 130 
                },
                new Promotion
                {
                     PromotionId=2,
                     Description = "2 of Bs for 45",
                     Type = 1,
                     SKUID1 = 'B',
                     SKUID2 = 'x',
                     SKUUnit = 2,
                     Price = 45
                },
                new Promotion
                {
                     PromotionId=3,
                     Description = "C & D for 30",
                     Type = 2,
                     SKUID1 = 'C',
                     SKUID2 ='D',
                     SKUUnit =1,
                     Price = 30
                }
            };
        }
    }
}
