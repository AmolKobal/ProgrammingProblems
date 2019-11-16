using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgrammingProblems
{
    // Armstrong number is a number that is equal to the sum of cubes of its digits.
    class ArmstrongNumber
    {
        public static bool Find(int n)
        {
            long sum = 0;
            int num = n, remainder;


            while (num > 0)
            {
                remainder = num % 10;
                sum += (remainder * remainder * remainder);
                //sum += (long)Math.Pow(remainder, 3);
                num = num / 10;
            }

            return (sum == n);
        }
    }
}
