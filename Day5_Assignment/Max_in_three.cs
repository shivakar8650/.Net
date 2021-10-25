using System;
using System.Collections.Generic;
using System.Text;

namespace Day5_Assignment
{
    class Max_in_three
    {
        public void chak_max()
        {
            Console.Write("enter the number1 :");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter the number2 :");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter the number3 :");
            int num3 = Convert.ToInt32(Console.ReadLine());


            if (num1 > num2 && num1 > num3)
                Console.WriteLine($"number {num1} is maximum");
            else if (num2 > num1 && num2 > num3)
                Console.WriteLine($"number {num2} is maximum");
            else
                Console.WriteLine($"number  {num3} is maximum");
        }
    }
}
