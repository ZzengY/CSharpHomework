using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework7
{
    public class Problem
    {
        static void Main(string[] args)
        {
            OrderService Zz = new OrderService();

            OrderDetails a = new OrderDetails("hand", "24562", 120000);
            OrderDetails b = new OrderDetails("second", "000", 120);
            OrderDetails c = new OrderDetails("third", "022", 33333);

            OrderDetails[] z = new OrderDetails[] { a };
            OrderDetails[] z1 = new OrderDetails[] { b };
            OrderDetails[] z2 = new OrderDetails[] { c };

            Zz.AddOrder("12345", "MANZ","", z);
            Zz.AddOrder("1", "LADYZ","" ,z1);
            Zz.AddOrder("333", "CHILDZ","", z2);

            Zz.calOrderPri();
            Zz.OrderStorage();
        }
    }
}
