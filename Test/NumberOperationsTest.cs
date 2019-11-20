using System;
using static System.Console;
using ProgrammingProblems.Classes;

namespace ProgrammingProblems.Test
{
    class NumberOperationsTest
    {
        public static void Run()
        {
            //PascalTriangleTest();

            //SumOfMultipleTest();

            //RandomNumerTest();
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

            WriteLine($"Sum: {SumOfMultiples.Sum(number1, number2, endNumber)}");
        }

        private static void RandomNumerTest()
        {
            int num1 = 10;
            int num2 = 50;

            WriteLine($"Random Number Between {num1} and {num2} is {RandomNumber.Generate(num1, num2)}");
        }

    }
}
