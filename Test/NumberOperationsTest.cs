using System;
using static System.Console;

namespace ProgrammingProblems.Test
{
    class NumberOperationsTest
    {
        public static void Run()
        {
            PascalTriangleTest();

            SumOfMultipleTest();
        }

        private static void PascalTriangleTest()
        {
            int num = 15;

            NumberOperations.PascalTriangle(num);
        }

        private static void SumOfMultipleTest()
        {
            int number1 = 3;
            int number2 = 5;
            int endNumber = 10;

            WriteLine($"Sum: {NumberOperations.SumOfMultiples(number1, number2, endNumber)}");
        }
    }
}
