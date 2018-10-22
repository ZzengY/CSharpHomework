using Microsoft.VisualStudio.TestTools.UnitTesting;
using homework6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework6.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        [TestMethod()]
        public void DeleteOrderTest()
        {
            OrderService Zz = new OrderService();
            bool n = Zz.DeleteOrder(1);
            Assert.IsFalse(n);
            //Assert.IsTrue(n);
        }

        [TestMethod()]
        public void ModifyOrderTest()
        {
            OrderService Zz = new OrderService();
            string n = Zz.ModifyOrder(1, 1, 1, "n");
            Assert.AreEqual("f", n);
           // Assert.AreEqual("a", n);
        }
    }
}