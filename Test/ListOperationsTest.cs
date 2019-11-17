using static System.Console;
using ProgrammingProblems.Classes;

namespace ProgrammingProblems.Test
{
    class ListOperationsTest
    {
        public static void Run()
        {
            SumOfTwoNumbersTest();

            MissingPositiveNumberInArrayTest();
        }

        private static void SumOfTwoNumbersTest()
        {
            int[] list = { 10, 15, 3, 7 };

            int k = 17;
            if (SumOfTwoNumbers.IsSumOfTwoNumbers(list, k))
                WriteLine($"{k} is SUM of two numbers of list {list.Print()}");
            else
                WriteLine($"{k} is not SUM of two numbers of list {list.Print()}");

            WriteLine(new string('═', 100));
            k = 50;
            if (SumOfTwoNumbers.IsSumOfTwoNumbers(list, k))
                WriteLine($"{k} is SUM of two numbers of list {list.Print()}");
            else
                WriteLine($"{k} is NOT SUM of two numbers of list {list.Print()}");

            WriteLine(new string('═', 100));
            WriteLine($"Source List {list.Print()}");
            WriteLine($"Product of List elements excluding Index itself: {NumberProduct.Calculate(list).Print()}");

            WriteLine(new string('═', 100));
        }

        private static void MissingPositiveNumberInArrayTest()
        {
            // int[] input = { 1, 2, 0 };

            int[] input = { 3, 4, -1, 1 };

            WriteLine("Missing Element: " + MissingNumberInArray.Find(input));
        }
    }
}
