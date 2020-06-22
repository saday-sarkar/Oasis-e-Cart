using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oasis_eCart
{
    [TestFixture]
    class PromotionEngineTest
    {
        [TestCase]
        public void CheckoutCartTestScenarioA()
        {
            MyCart myCart = new MyCart
            {
                MyCartItems = new List<MyCartItem>()
                {
                    new MyCartItem
                    {
                        MyCartItemName = "Apple",
                        MyCartItemID = 'A',
                        MyCartItemUnit = 1
                    },
                    new MyCartItem
                    {
                        MyCartItemName = "Banana",
                        MyCartItemID = 'B',
                        MyCartItemUnit = 1
                    },
                    new MyCartItem
                    {
                        MyCartItemName = "Cherrie",
                        MyCartItemID = 'C',
                        MyCartItemUnit = 1
                    }
                }
            };
            Assert.AreEqual(PromotionEngine.CheckOutCart(myCart), 100);

        }
        [TestCase]
        public void CheckoutCartTestScenarioB()
        {
            MyCart myCart = new MyCart
            {
                MyCartItems = new List<MyCartItem>()
                {
                    new MyCartItem
                    {
                        MyCartItemName = "Apple",
                        MyCartItemID = 'A',
                        MyCartItemUnit = 5
                    },
                    new MyCartItem
                    {
                        MyCartItemName = "Banana",
                        MyCartItemID = 'B',
                        MyCartItemUnit = 5
                    },
                    new MyCartItem
                    {
                        MyCartItemName = "Cherrie",
                        MyCartItemID = 'C',
                        MyCartItemUnit = 1
                    }
                }
            };
            Assert.AreEqual(PromotionEngine.CheckOutCart(myCart), 370);

        }
        [TestCase]
        public void CheckoutCartTestScenarioC()
        {
            MyCart myCart = new MyCart
            {
                MyCartItems = new List<MyCartItem>()
                {
                    new MyCartItem
                    {
                        MyCartItemName = "Apple",
                        MyCartItemID = 'A',
                        MyCartItemUnit = 3
                    },
                    new MyCartItem
                    {
                        MyCartItemName = "Banana",
                        MyCartItemID = 'B',
                        MyCartItemUnit = 5
                    },
                    new MyCartItem
                    {
                        MyCartItemName = "Cherrie",
                        MyCartItemID = 'C',
                        MyCartItemUnit = 1
                    },
                    new MyCartItem
                    {
                        MyCartItemName = "Damson",
                        MyCartItemID = 'D',
                        MyCartItemUnit = 1
                    }
                }
            };
            Assert.AreEqual(PromotionEngine.CheckOutCart(myCart), 280);
        }
    }
}
