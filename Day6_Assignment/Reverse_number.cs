using System;
using System.Collections.Generic;
using System.Text;

namespace Day6_Assignment
{
    class Reverse_number
    {

        public static void reverse()
        {
            Console.Write("enter the Number  :");
            int num = Convert.ToInt32(Console.ReadLine());
            int r, reverse=0;
            //int temp = num;
            while(num>0)
            {
                 r = num % 10;
                 reverse = reverse * 10 + r;
                 num = num / 10;

            }
            Console.WriteLine($"reverse number is :{reverse}");

        }
    }
}
