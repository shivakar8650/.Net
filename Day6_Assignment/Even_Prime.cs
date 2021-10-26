using System;
using System.Collections.Generic;
using System.Text;

namespace Day6_Assignment
{
    class Even_Prime
    {

        public static void check_even()
        {
            List<int> even_prime = new List<int>();
            Console.Write("enter the Number to get  even prime factors :");
            int num=Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= num; i++)
                if (num % i == 0)
                {
                    int count = 0;
                    for(int j=2;j<i;j++)
                    if( i%j == 0)
                    {     count = 1;
                    }
                    if (count == 0 && i%2 ==0)
                    {
                        even_prime.Add(i);
                    }
                }
                  foreach (int k in even_prime)
                  Console.Write($" {k}");
              
        }
    }
}
