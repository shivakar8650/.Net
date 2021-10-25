using System;
using System.Collections.Generic;
using System.Text;

namespace Day5_Assignment
{
    class factors
    {
        public void prime_factors()
        {
            int count = 0;
            Console.Write("enter the number :");
            int num = Convert.ToInt32(Console.ReadLine());
            /* for (int i = 2; i * i <= num; i++)
             {
                 if (num % i == 0)
                 {
                     count = 0;
                     for (int j = 2; j <= i / 2; j++)
                     {
                         if (i % j == 0)
                         {
                             count = 1;
                             break;
                         }
                     }

                     if (count == 0)

                     {
                         Console.WriteLine(i);
                     }
                 }
             }*/

            Console.Write("prime factor :");
            for (int i = 2; i * i <= num; i++)
            if(num % i == 0)
                {
                    count = 0;
                    while(num % i == 0)
                    {
                        num /= i;
                        count++;
                    }
                    Console.Write( $" {i} ");



                }
            if(num>1)
            {
                Console.WriteLine($" {num}");

            }




        }
    }
}
