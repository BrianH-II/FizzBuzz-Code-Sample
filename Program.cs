﻿using System;

namespace FizzBuzz
{

    /*
     *  This program is the traditional "Fizzbuzz" program.
     *  It prints the numbers 1 - 100, with exceptions for multiples of 3 and 5.
     *  Any multiple of 3 prints the word "Fizz".
     *  Any multiple of 5 prints the word "Buzz".
     *  Any multiple of 3 and 5 prints the word "Fizzbuzz".
     */

    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 100)
            {
                string printText = "";
                if (i % 3 == 0)
                {
                    printText = "Fizz";
                }

                if (i % 5 == 0)
                {
                    printText = printText + "Buzz";
                }

                if (printText == "")
                {
                    printText = i.ToString();
                }
                
                Console.WriteLine(printText);
                i++;
            }

            Console.WriteLine(Environment.NewLine + "Press 'Enter' to end");
            Console.ReadLine();
        }
    }
}
