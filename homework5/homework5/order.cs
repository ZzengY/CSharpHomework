using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    class Order
    {
        public string orderNumber;
        public string clientName;
        public double orderPrice;
        public List<OrderDetails> orderdetails;
        public Order()
        {
            orderdetails = new List<OrderDetails>();
        }
        public void outOrder()
        {
            Console.WriteLine(this.orderNumber + " " + this.clientName + " " + this.orderPrice);
            foreach(OrderDetails o in this.orderdetails) {
                Console.WriteLine(o.productName + " " + o.productNumber + " " + o.productPrice);
            }
        }
    }
}

