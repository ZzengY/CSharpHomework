using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2
{
    class program1
    {
        static void Main(string[] args)
        {
          
            Console.Write("Please input a positive int:");         
            int num = 0;
            bool valid = Int32.TryParse(Console.ReadLine(), out num);
            if (valid)
            {
                if (num <= 0)
                {
                    Console.WriteLine("ERROR!");
                }
                else if (num == 1)
                {
                    Console.WriteLine("The int has no prime factors!");
                }
                else {
                    Console.WriteLine("The prime factors of the int :");
                    int k = num;
                    for(int i = 2; i < k; i++)
                    {
                        if (k % i == 0)
                        {
                            int priFac = i;
                            k = k / i;
                            i = 1;
                            Console.WriteLine(priFac + ",");
                        }
                    }
                    Console.WriteLine(k);   
                }
            }
            else
            {
                Console.WriteLine("input error!");
            }
           
        }
    }
}
