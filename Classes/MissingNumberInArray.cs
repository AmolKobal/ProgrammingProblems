using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgrammingProblems.Classes
{
    class MissingNumberInArray
    {
        /*
         * Given an array of integers, find the first missing positive integer in linear time and constant space.
         * In other words, find the lowest positive integer that does not exist in the array.
         * The array can contain duplicates and negative numbers as well.
         * 
         * For example, the input [3, 4, -1, 1] should give 2. 
         * The input [1, 2, 0] should give 3.
         *
         */
        public static int Find(int[] input)
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
