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

            MissingPositiveNumberInArray();
        }

        private static void PascalTriangleTest()
        {
            int num = 15;

            PascalTriangle.Draw(num);
        }

        private static void SumOfMultipleTest()
        {
            int number1 = 3;
            int number2 = 5;
            int endNumber = 10;

            WriteLine($"Sum: {NumberOperations.SumOfMultiples(number1, number2, endNumber)}");
        }

        private static void MissingPositiveNumberInArray()
        {
            // int[] input = { 1, 2, 0 };

            int[] input = { 3, 4, -1, 1 };

            WriteLine("Missing Element: " + NumberOperations.MissingPositiveNumberInArray(input));
        }

    }
}
