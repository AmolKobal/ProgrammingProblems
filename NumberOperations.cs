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

    }
}
