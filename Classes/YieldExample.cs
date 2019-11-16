using System;
using System.Collections;

namespace ConsoleExamples.YieldExample
{
    class YieldExample
    {

        public static IEnumerable Power(int number, int exponent)
        {
            int counter = 0;
            int result = 1;
            while (counter++ < exponent)
            {
                result = result * number;
                yield return result;
            }
        }
    }
}
