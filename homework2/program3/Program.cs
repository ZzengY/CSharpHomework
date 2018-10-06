using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program3
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Console.WriteLine("The prime number in 2~100:");

                for (int i = 2; i < 100; i++)
                {
                    bool k = true;
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            k = false;
                        }
                    }
                    if (k)
                    {
                        Console.WriteLine(i);
                    }
                }
            
        }
    }
}
