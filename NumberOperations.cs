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
         *  Create a program which accepts two numbers then prints out a random number somewhere between those two numbers.
         *  Make sure you write your own code to generate the random number (ie.don't use the built in random function).
         *  You can be quite creative in how you achieve this but a common approach is to make use of the current time 
         *  as part of your method.
         */
        public static int RandomNumber(int num1, int num2)
        {
            int random = 0;

            if (num1 > num2)
                return random;

            random = DateTime.Now.Second * DateTime.Now.Millisecond;

            if (random < num1)
            {
                while (random < num2)
                {
                    random = random * num1;

                    if (random == 0)
                    {
                        random = num2 - num1;
                    }
                }

                if (random > num1)
                    random -= num2 - num1;
            }
            else if (random > num2)
            {
                while (random > num2)
                {
                    random = random / num2;

                    if (random == 0)
                    {
                        random = num2 - num1;
                    }
                }

                if (random < num1)
                    random += num2 - num1;
            }

            return random;
        }

    }
}
