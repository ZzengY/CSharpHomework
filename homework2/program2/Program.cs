using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2
{
    class Program
    {
        static int[] array = new int[11] { 3, 6, 8, 9, 22, 56, 77, 83, 1, 3, 15 };
        public static void max()
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            Console.WriteLine("The maximum value of the array:" + max);
        }
        public static void min()
        {
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            Console.WriteLine("The minimum value of the array:" + min);
        }
        public static void ave()
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            int ave = sum / array.Length;
            Console.WriteLine("The average value of the array:" + ave);
        }
        public static void sum()
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine("The average value of the array:" + sum);
        }
        public static void Main()
        {
            max();
            min();
            ave();
            sum();

        }    
    }
}
