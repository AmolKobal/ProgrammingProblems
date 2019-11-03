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

        /*
         * This problem was asked by Airbnb.
         * 
         * Given a list of integers, write a function that returns the largest sum of non-adjacent numbers. 
         * Numbers can be 0 or negative.
         * 
         * For example, 
         *  [2, 4, 6, 2, 5] should return 13, since we pick 2, 6, and 5. 
         *  [5, 1, 1, 5] should return 10, since we pick 5 and 5.
         *  
         *  Follow-up: Can you do this in O(N) time and constant space?
         */

        public static long LargestSumOfNonAdjecent(int[] input)
        {
            long sum = 0;

            int[] temp = (int[])input.Clone();

            Array.Sort(temp);
            Array.Reverse(temp);

            for(int i=0; i < temp.Length; i++)
            {
                //input.()
            }

            return sum;
        }
    }
}
