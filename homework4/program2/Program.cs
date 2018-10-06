using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService Zz = new OrderService();
            OrderDetails a = new OrderDetails();
            a.productName = "hand";
            a.productNumber = "24562";
            a.productPrice = 12.14;
            OrderDetails[] z = new OrderDetails[] { a };
           
            Zz.AddOrder("12455", "LADYZ", z);
            Zz.AddOrder("1", "LADYZ", z);
            Zz.ModifyOrder(1, 1, 3, "33");
            Zz.CheckOrder(1, "1");
            Zz.OrderStorage();
        }
    }
}
