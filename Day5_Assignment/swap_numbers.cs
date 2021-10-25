using System;
using System.Collections.Generic;
using System.Text;

namespace Day5_Assignment
{
    class swap_numbers
    {
        public void swap()
        {
            Console.Write("enter the num1 :");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter the num2 :");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int temp = 0;
            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine($" num1 :{num1}");
            Console.WriteLine($" num2 :{num2}");



        }
    }
}
