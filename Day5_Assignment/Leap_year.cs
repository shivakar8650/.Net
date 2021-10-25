using System;
using System.Collections.Generic;
using System.Text;

namespace Day5_Assignment
{
    class Leap_year
    {
        public void LeapYear()
        {
            Console.Write("Enter the year in YYYY format :");
            int year= Convert.ToInt32(Console.ReadLine());

            if (year < 1000)
            {
                Console.WriteLine("invalid input enter YYYY format only");

            }
            else if (((year % 4 == 0) && (year % 100 != 0)) || (year %400 ==0))
            {
                Console.WriteLine($"{year} is a leap year");

            }
            else
                Console.WriteLine("not a leap year");
          
        }
    }
}
