using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework7
{
    [Serializable]
    public class Order
    {
        public string orderNumber { get; set; }
        public string clientName { get; set; }
        public double orderPrice { get; set; }
        public string cliPhoNum { get; set; }
        public List<OrderDetails> orderdetails { get; set; }
        public Order()
        {
            orderdetails = new List<OrderDetails>();
        }
        public void outOrder()
        {
            Console.WriteLine(this.orderNumber + " " + this.clientName + " " + this.orderPrice);
            foreach (OrderDetails o in this.orderdetails)
            {
                Console.WriteLine(o.productName + " " + o.productNumber + " " + o.productPrice);
            }

        }
       
    }
}
