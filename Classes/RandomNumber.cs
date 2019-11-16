using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgrammingProblems.Classes
{
    class RandomNumber
    {
        /*
         *  Create a program which accepts two numbers then prints out a random number somewhere between those two numbers.
         *  Make sure you write your own code to generate the random number (ie.don't use the built in random function).
         *  You can be quite creative in how you achieve this but a common approach is to make use of the current time 
         *  as part of your method.
         */
        public static int Generate(int num1, int num2)
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
