using System;
using System.Collections.Generic;
using System.Text;

namespace Day6_Assignment
{
    class Perfact_Number
    {
        public static void check_perfect()
        {
            Console.Write("Enter the number :");
            int num = Convert.ToInt32(Console.ReadLine());
            List<int> store_element = new List<int>();
         
            int i = 1;
            int sum = 0;
            while (i < num)
            {
                if (num % i == 0)
                {
                    sum = sum + i;
                    store_element.Add(i);
                  
                }
                i++;
            }
            if (sum == num)
            {
                Console.WriteLine(" is a perfect number!");
                foreach (int k in store_element)
                Console.WriteLine(k);
            }
            else
            {
                Console.WriteLine("not a perfect number!");
                store_element.Clear();
            }
        }
    } 
}
