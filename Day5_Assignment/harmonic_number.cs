using System;
using System.Collections.Generic;
using System.Text;

namespace Day5_Assignment
{
    class harmonic_number
    {
        public void harmonic()
        {
            Console.Write("enter the number :");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num);
            int i = 1;
            double harmonic_number = 0;
            Console.Write($"1/1");
            for (i = 1; i <= num; i++)
             {
                Console.Write($"+ 1/{i}  ");
                harmonic_number += 1/(float)i ;
                //Console.WriteLine(harmonic_number);
            }
            Console.WriteLine(" ");
            Console.WriteLine(Math.Round(harmonic_number,2));

        }
    }
}