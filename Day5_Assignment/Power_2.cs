using System;
using System.Collections.Generic;
using System.Text;

namespace Day5_Assignment
{
    class Power_2
    {
        public void Power_of_2()
        { int N;
            double value = 0;
            Console.Write("enter the input :");
            N = Convert.ToInt32(Console.ReadLine());
            double limit = Math.Pow(2,N);
            for (int i = 1; value <limit; i++)
             {
                value = Math.Pow(2, i);
                Console.WriteLine(value);
            }
        }
    }
}
