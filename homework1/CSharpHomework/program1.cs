using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    //接收两个数字，然后计算它们的积
    public class program1
    {
         static void Main(string[] args)
        {
            string s = "";
            double a = 0, b = 0;
            Console.Write("Please input the first number:");
            s = Console.ReadLine();
            a = Double.Parse(s);
            Console.Write("Please input the second number:");
            s = Console.ReadLine();
            b = Double.Parse(s);
            Console.WriteLine("Their product:" + (a * b));
           
        }
    }

   

