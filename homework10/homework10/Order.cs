using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework10
{
    
    public class Order
    {
        [Key]
        public string Id { get; set; }
        public string Customer { get; set; }       
        public string Phone { get; set; }
        public List<OrderItem> Orderitems { get; set; }
        public Order()
        {
            Orderitems = new List<OrderItem>();
        }
        public Order(string num, string cli, double pri, List<OrderItem> orderDetails)
        {
            Id = num;
            Customer = cli;
            
            Orderitems = orderDetails;
        }
        public void outOrder()
        {
            Console.WriteLine(this.Id + " " + this.Customer + " ");
            foreach (OrderItem o in this.Orderitems)
            {
                Console.WriteLine(o.ProductName + " " + o.Id + " " + o.ProductPrice);
            }

        }

    }
}
