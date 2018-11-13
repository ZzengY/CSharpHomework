using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace homework7
{
    [Serializable]
    public class OrderService
    {
        
        public List<Order> order { get; set; }
        public OrderService()
        {
            order = new List<Order>();
        }
        public void AddOrder(string oNum, string cName,string cPhoNum, OrderDetails[] or)
        {
           
            Order a = new Order();
            a.orderNumber = oNum;
            a.clientName = cName;
            a.cliPhoNum = cPhoNum;
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

        public bool oExam(string s)
        {
            if ( s.Length != 11)
            {
                return false;
            }
            else
            {
                try

                {
                    string strDate = s.Substring(0, 8);
                    DateTime dt = DateTime.ParseExact(strDate, "yyyyMMdd", System.Globalization.CultureInfo.CurrentCulture);
                    
                }

                catch(Exception )

                {
                    return false;

                }
                foreach (Order i in order)
                {
                    if (i.orderNumber == s)
                    {
                        return false;
                    }
                }
                string backNum = s.Substring(s.Length - 3, 3);
                string patten = "[0-9]{3}";
                if (!Regex.IsMatch(backNum, patten))
                {
                    return false;
                }               
                else
                    return true;
            }
        }
       public bool phoExam(string s)
        {
            if (s.Length != 11)
            {
                return false;
            }
            else if (!Regex.IsMatch(s, @"^[1]+[3,5,7,8]+[0-9]{9}"))
            {
                return false;
            }                        
            else
                return true;
        }

        public void Export(List<Order> or, string xmlFileName)
        {
            XmlSerializer xmlser = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(xmlFileName, FileMode.Create))
            {
                xmlser.Serialize(fs, or);
            }
        }

        public void Import(string xmlFileName)
        {
            if (Path.GetExtension(xmlFileName) != ".xml")
                throw new ArgumentException("It isn't a xml file!");
            using (FileStream fs = new FileStream(xmlFileName, FileMode.Open))
            {
                XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
                List<Order> pl = (List<Order>)xs.Deserialize(fs);
                order.AddRange(pl);
                
            }

        }
    }
}
