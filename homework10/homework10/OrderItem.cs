using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace homework10
{
    
    public class OrderItem
    {
        [Key]
        public string Id { get; set; }
        public string ProductName { get; set; }        
        public double ProductPrice { get; set; }

        public OrderItem(string productName, string productNumber, double productPrice)
        {
            this.ProductName = productName;
            this.Id = productNumber;
            this.ProductPrice = productPrice;
        }
        public OrderItem()
        {
            Id = Guid.NewGuid().ToString();
        }

    }
}
