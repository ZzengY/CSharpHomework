using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Data.Entity;

namespace homework10
{

    public class OrderService
    {
        public void Add(Order order)
        {
            using (var db = new Model1())
            {
               
                    db.Order.Add(order);

                    db.SaveChanges();
                
            }
        }
        public void DeleteOrder(String findNum)
        {

            using (var db = new Model1())
            {
                var order = db.Order.Include("Orderitems").SingleOrDefault(o => o.Id == findNum);
                db.OrderItem.RemoveRange(order.Orderitems);
                db.Order.Remove(order);
                db.SaveChanges();

            }
        }
        public void ModifyOrder(Order order)
        {
            using (var db = new Model1())
            {
                db.Order.Attach(order);
                db.Entry(order).State = EntityState.Modified;
                order.Orderitems.ForEach(
                    item => db.Entry(item).State = EntityState.Modified);
                db.SaveChanges();
            }

        }
      

        public Order GetOrder(String Id)
        {
            using (var db = new Model1())
            {
                return db.Order.Include("Orderitems").
                  SingleOrDefault(o => o.Id == Id);
            }
        }

        public List<Order> GetAllOrders()
        {
            using (var db = new Model1())
            {
                return db.Order.Include("Orderitems").ToList<Order>();
            }
        }


        public List<Order> QueryByCustormer(String custormer)
        {
            
            using (var db = new Model1())
            {
               return db.Order.Include("Orderitems")
                  .Where(o => o.Customer.Equals(custormer)).ToList<Order>();
            }
        }

        public List<Order> QueryByGoods(String product)
        {
            using (var db = new Model1())
            {
                var query = db.Order.Include("Orderitems")
                  .Where(o => o.Orderitems.Where(
                    orderitems => orderitems.ProductName.Equals(product)).Count() > 0);
                return query.ToList<Order>();
            }
        }


        public void OrderStorage()
        {
            using (var db = new Model1())
            {
                foreach (Order i in db.Order)
                {
                    System.Console.WriteLine(i.Id + " " + i.Customer);
                    foreach (OrderItem o in i.Orderitems)
                    {
                        System.Console.WriteLine(o.ProductName + " " + o.Id + " " + o.ProductPrice);
                    }
                }
            }
        }
    }
}
        