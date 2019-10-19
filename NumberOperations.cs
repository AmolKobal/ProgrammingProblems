using System;
using System.Collections.Generic;
using static System.Console;

namespace ProgrammingProblems
{
    class NumberOperations
    {
        /*
         *  Gets sum of all numbers from 1 to TotalNumbers, which are divisible by Number1 and Number2.
         *  
         *  For example:  
         *      If we have list all the Natural numbers from 1 to TotalNumbers that are multiples of 3 or 5, we get 3, 5, 6 and 9. 
         *      The sum of these multiples is 23.
        */

        public static long SumOfMultiples(int number1, int number2, int totalNumbers)
        {
            long output = 0;

            for (int num = 1; num < totalNumbers; num++)
            {
                if ((num % number1 == 0) || (num % number2 == 0))
                    output += num;
            }

            return output;
        }

        /*
         * Pascal Triangle
         */

        public static void PascalTriangle(int n)
        {
            List<int> current = new List<int>();
            List<int> previous = new List<int>();

            int num = 1;

            for (int i = 1; i <= n; i++)
            {
                Write(new string(' ', n - i));

                for (int j = 1; j <= i; j++)
                {
                    if (j == 1 || j == i)
                    {
                        num = 1;
                    }
                    else
                    {
                        num = previous[j - 1] + previous[j - 2];
                    }

                    Write($"{ num } ");
                    current.Add(num);
                }

                previous = current;
                current = new List<int>();
                WriteLine();
            }
        }


        /*
         * Given an array of integers, find the first missing positive integer in linear time and constant space.
         * In other words, find the lowest positive integer that does not exist in the array.
         * The array can contain duplicates and negative numbers as well.
         * 
         * For example, the input [3, 4, -1, 1] should give 2. 
         * The input [1, 2, 0] should give 3.
         *
         */
        public static int MissingPositiveNumberInArray(int[] input)
        {
            int output = 0;

            Array.Sort<int>(input);

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == input[i - 1] + 1)
                {
                    continue;
                }
                else
                {
                    if (input[i - 1] + 1 > 0)
                    {
                        output = input[i - 1] + 1;
                        break;
                    }
                }
            }

            return output;
        }
    }
}
