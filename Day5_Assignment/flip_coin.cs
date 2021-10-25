using System;
using System.Collections.Generic;
using System.Text;

namespace Day5_Assignment
{
    class flip_coin
    {
        public void flipCoin()
        {
            int n;
            int i = 1;
            int count_head = 0;
            int count_tails = 0;
            float head_percentage = 0;
            float tails_percentage = 0;
            Console.Write("Enter the no of time to flip the coin :");
            n = Convert.ToInt32(Console.ReadLine());

            while (i<=n)
            {
                Random random = new Random();
                int value = random.Next(1, 3);
                switch (value)
                {
                    case 1:
                        count_head++;
                        break;
                    default:
                        count_tails++;
                        break;
                }
                i++;
            }
            Console.WriteLine($"head comes :{count_head}times");
            Console.WriteLine($"tails comes :{count_tails}times");
            //head_percentage = ((( count_head*100) / n));
            head_percentage =(float)(0.5f + ((100f * count_head) / n));

            Console.WriteLine($"head percentage : {Math.Round(head_percentage,2)}%");
            tails_percentage = 100 - head_percentage;
            Console.WriteLine($"tails percentage : {Math.Round(tails_percentage,2)}%");

        }
    }
}
