using System;
using System.Collections.Generic;
using System.Text;

namespace Day5_Assignment
{
    class Even_and_odd
    {
        public void check_even()
        {
            Console.Write("enter the number :");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num != 0)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine("the number is even!");

                }
                else
                    Console.WriteLine("the number is odd!");
            }
            else
            {
                Console.WriteLine("Enter number other than 0. ");
            }
        }


    }
}
