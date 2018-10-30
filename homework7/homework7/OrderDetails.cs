using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework7
{
    public class OrderDetails
    {
        public string productName { get; set; }
        public string productNumber { get; set; }
        public double productPrice { get; set; }

        public OrderDetails(string productName, string productNumber, double productPrice)
        {
            this.productName = productName;
            this.productNumber = productNumber;
            this.productPrice = productPrice;
        }
        public OrderDetails()
        {

        }
    }
}
