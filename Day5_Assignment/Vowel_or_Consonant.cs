using System;
using System.Collections.Generic;
using System.Text;

namespace Day5_Assignment
{
    class Vowel_or_Consonant
    {
        public void CheckAlphabet()
        {
            Console.WriteLine("the number is alphabet :");
            string alpha=Console.ReadLine();
            int check = 0;
            switch(alpha)
            {
                case "a":
                    check = 1;
                    break;
                case "A":
                    check = 1;
                    break;
                case "e":
                    check = 1;
                    break;
                case "E":
                    check = 1;
                    break;
                case "i":
                    check = 1;
                    break;
                case "I":
                    check = 1;
                    break;
                case "o":
                    check = 1;
                    break;
                case "O":
                    check = 1;
                    break;
                case "u":
                    check = 1;
                    break;
                case "U":
                    check = 1;
                    break;
                default:
                    Console.WriteLine("input is consonant.");
                    break;
            }
            if(check==1)
                Console.WriteLine("input is Vowel.");
        }

    }
}
