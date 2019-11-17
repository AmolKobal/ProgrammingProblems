using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgrammingProblems.Classes
{
    class LargestSumOfNonAdjecent
    {
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

        public static long Sum(int[] input)
        {
            long sum = 0;

            int[] temp = (int[])input.Clone();

            Array.Sort(temp);
            Array.Reverse(temp);

            for (int i = 0; i < temp.Length; i++)
            {
                //input.()
            }

            return sum;
        }
    }
}
