using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework10
{
    public class Problem
    {
        static void Main(string[] args)
        {
            OrderService orderService = new OrderService();
            //orderService.Delete("001");

            List<OrderItem> orderDetails = new List<OrderItem>() {
                new OrderItem("apple", "1", 10.0),
                new OrderItem("egg", "2", 2.2)
            };

            Order order = new Order("001", "jia",112 , orderDetails);

            orderService.Add(order);

            Order order2 = new Order("001", "jia2",22 , orderDetails);
            orderService.ModifyOrder(order2);


            List<Order> orders = orderService.QueryByCustormer("jia2");
            orders.ForEach(
              o => Console.WriteLine($"{o.Id},{o.Customer}"));


        }
    }
}
