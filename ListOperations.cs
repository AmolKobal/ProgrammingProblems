using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgrammingProblems
{
    class ListOperations
    {
        /*
            Given a list of numbers and a number k, return whether any two numbers from the list add up to k.

            For example, given [10, 15, 3, 7] and k of 17, return true since 10 + 7 is 17.
        */
        public static bool IsSumOfTwoNumbers(int[] list, int k)
        {
            for (int i = 0; i < list.Length; i++)
            {
                for (int j = i + 1; j < list.Length; j++)
                {
                    if (list[i] + list[j] == k)
                        return true;
                }
            }

            return false;
        }

        /*
         * Given an array of integers, return a new array such that each element at index i of the new array 
         * is the product of all the numbers in the original array except the one at i.
         * 
         * For example, if our input was[1, 2, 3, 4, 5], the expected output would be [120, 60, 40, 30, 24]. 
         * If our input was [3, 2, 1], the expected output would be[2, 3, 6].
         */

        public static int[] NumberProduct(int[] source)
        {
            int[] output = new int[source.Length];
            int product;

            for (int i = 0; i < source.Length; i++)
            {
                product = 1;

                for (int j = 0; j < source.Length; j++)
                {
                    if (i != j)
                        product *= source[j];
                }

                output[i] = product;
            }

            return output;
        }
    }
}
