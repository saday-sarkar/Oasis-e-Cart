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
}
