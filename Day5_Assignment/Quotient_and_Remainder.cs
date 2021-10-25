using System;
using System.Collections.Generic;
using System.Text;

namespace Day5_Assignment
{
    class Quotient_and_Remainder
    {
        public void Quotient_remmainder()
        {
            Console.Write("enter the number dividend :");
            int dividend = Convert.ToInt32(Console.ReadLine());

            Console.Write("enter the number divisor :");
            int divisor = Convert.ToInt32(Console.ReadLine());

            int Quotient = dividend / divisor;
            int Remainder = dividend % divisor;

            Console.WriteLine($"Quotient :{Quotient}");
            Console.WriteLine($"Remainder :{Remainder}");

        }
    }
}
