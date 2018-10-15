using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    class Program
    {
        static void Main(string[] args)
        {

            OrderService Zz = new OrderService();
            OrderDetails a = new OrderDetails();
            a.productName = "hand";
            a.productNumber = "24562";
            a.productPrice = 120000;
            OrderDetails b = new OrderDetails();
            b.productName = "last";
            b.productNumber = "000";
            b.productPrice = 120;
            OrderDetails[] z = new OrderDetails[] { a };
            OrderDetails[] z1 = new OrderDetails[] { b };
            Zz.AddOrder("12345", "MANZ", z);
            Zz.AddOrder("1", "LADYZ", z1);
            Zz.calOrderPri();
            var result1 = from n in Zz.order from m in n.orderdetails where m.productName == "hand" select n;
            foreach (var n in result1)
            {
                n.outOrder();
            }
            var result2 = from n in Zz.order where n.clientName == "LADYZ" select n;
            foreach (var n in result2)
            {
                n.outOrder();
            }
            var result3 = from n in Zz.order  where n.orderPrice > 10000  select n;
            foreach (var n in result2)
            {
                n.outOrder();
            }
        }
    }
}
