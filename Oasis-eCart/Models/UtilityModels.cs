using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oasis_eCart
{
    public class MyCart
    {
        public List<MyCartItem> MyCartItems { get; set; }
    }

    public class MyCartItem
    {
        public char MyCartItemID { get; set; }
        public string MyCartItemName { get; set; }
        public int MyCartItemUnit { get; set; }
    }
    public class StockKeepingUnit
    {
        public char SKUID { get; set; }
        public string SKUName { get; set; }
        public int SKUUnitPrice { get; set; }

    }
    public class Promotion
    {
        public int PromotionId { get; set; }
        public string Description { get; set; }
        public int Type { get; set; }
        public char SKUID1 { get; set; }
        public char SKUID2 { get; set; }
        public int SKUUnit { get; set; }
        public int Price { get; set; }

    }
}
