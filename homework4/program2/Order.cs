using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2
{
    class Order
    {
        public string orderNumber;
        public string clientName;
        public List<OrderDetails> orderdetails;
        public Order()
        {
              orderdetails = new List<OrderDetails>();
        }
    }
}
