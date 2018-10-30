using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework7
{
    public class OrderService
    {
        public List<Order> order { get; set; }
        public OrderService()
        {
            order = new List<Order>();
        }
        public void AddOrder(string oNum, string cName, OrderDetails[] or)
        {
            
            Order a = new Order();
            a.orderNumber = oNum;
            a.clientName = cName;
            for (int i = 0; i < or.Length; i++)
            {
                a.orderdetails.Add(or[i]);               
                a.orderPrice += or[i].productPrice;
                  
            }
            order.Add(a);

        }
        public void DeleteOrder(int findNum)
        {
            if (findNum <= 0 || findNum > order.Count)
            {
                System.Console.WriteLine("ERROR!You failed to delete order!");                
            }
            else
            {
                order.RemoveAt(findNum - 1);                
            }
        }
        public string ModifyOrder(int findNum, int n, int i, string modCon)
        {
            if (findNum <= 0 || findNum > order.Count || i < order[findNum - 1].orderdetails.Count)
            {
                System.Console.WriteLine("ERROR!You failed to modify order!");
                return "f";
            }
            switch (n)
            {
                case 1:
                    order[findNum - 1].orderNumber = modCon;
                    return "a";
                case 2:
                    order[findNum - 1].clientName = modCon;
                    return "b";
                case 3:
                    order[findNum - 1].orderdetails[i - 1].productName = modCon;
                    return "c";
                case 4:
                    order[findNum - 1].orderdetails[i - 1].productNumber = modCon;
                    return "d";
                case 5:
                    order[findNum - 1].orderdetails[i - 1].productPrice = double.Parse(modCon);
                    return "e";
                default:
                    System.Console.WriteLine("ERROR!");
                    return "f";
            }

        }
        public void calOrderPri()
        {
            foreach (Order e in order)
            {
                foreach (OrderDetails o in e.orderdetails)
                {
                    e.orderPrice += o.productPrice;
                }
            }
        }

        public void CheckOrder(int i, string n)
        {
            switch (i)
            {
                case 1:
                    foreach (Order e in order)
                    {
                        if (e.orderNumber == n)
                        {
                            System.Console.WriteLine(e.orderNumber + " " + e.clientName);
                            foreach (OrderDetails o in e.orderdetails)
                            {
                                System.Console.WriteLine(o.productName + " " + o.productNumber + " " + o.productPrice);
                            }
                        }
                    }
                    break;
                case 2:
                    foreach (Order e in order)
                    {
                        if (e.clientName == n)
                        {
                            System.Console.WriteLine(e.orderNumber + " " + e.clientName);
                            foreach (OrderDetails o in e.orderdetails)
                            {
                                System.Console.WriteLine(o.productName + " " + o.productNumber + " " + o.productPrice);
                            }
                        }
                    }
                    break;
                case 3:
                    foreach (Order e in order)
                    {
                        foreach (OrderDetails o in e.orderdetails)
                        {
                            if (o.productName == n)
                            {
                                System.Console.WriteLine(e.orderNumber + " " + e.clientName);
                                System.Console.WriteLine(o.productName + " " + o.productNumber + " " + o.productPrice);
                            }
                        }
                    }
                    break;
                case 4:
                    foreach (Order e in order)
                    {
                        foreach (OrderDetails o in e.orderdetails)
                        {
                            if (o.productNumber == n)
                            {
                                System.Console.WriteLine(e.orderNumber + " " + e.clientName);
                                System.Console.WriteLine(o.productName + " " + o.productNumber + " " + o.productPrice);
                            }
                        }
                    }
                    break;
                case 5:
                    foreach (Order e in order)
                    {
                        foreach (OrderDetails o in e.orderdetails)
                        {
                            if (o.productPrice == double.Parse(n))
                            {
                                System.Console.WriteLine(e.orderNumber + " " + e.clientName);
                                System.Console.WriteLine(o.productName + " " + o.productNumber + " " + o.productPrice);
                            }
                        }
                    }
                    break;
                default:
                    System.Console.WriteLine("We don not find!");
                    break;
            }

        }

        public void OrderStorage()
        {
            foreach (Order i in order)
            {
                System.Console.WriteLine(i.orderNumber + " " + i.clientName);
                foreach (OrderDetails o in i.orderdetails)
                {
                    System.Console.WriteLine(o.productName + " " + o.productNumber + " " + o.productPrice);
                }
            }
        }

       

    }
}
