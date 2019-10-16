using static System.Console;

namespace ProgrammingProblems.Test
{
    class NumberOperationsTest
    {
        public static void Run()
        {
            int number1 = 3;
            int number2 = 5;
            int endNumber = 10;

            WriteLine($"Sum: {NumberOperations.SumOfMultiples(number1, number2, endNumber)}");
        }
    }
}
