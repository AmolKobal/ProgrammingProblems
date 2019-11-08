using static System.Console;

namespace ProgrammingProblems.Test
{
    class ListOperationsTest
    {
        public static void Run()
        {
            SumOfTwoNumbers();

            MissingPositiveNumberInArray();
        }

        private static void SumOfTwoNumbers()
        {
            int[] list = { 10, 15, 3, 7 };

            int k = 17;
            if (ListOperations.IsSumOfTwoNumbers(list, k))
                WriteLine($"{k} is SUM of two numbers of list {list.Print()}");
            else
                WriteLine($"{k} is not SUM of two numbers of list {list.Print()}");

            WriteLine(new string('═', 100));
            k = 50;
            if (ListOperations.IsSumOfTwoNumbers(list, k))
                WriteLine($"{k} is SUM of two numbers of list {list.Print()}");
            else
                WriteLine($"{k} is NOT SUM of two numbers of list {list.Print()}");

            WriteLine(new string('═', 100));
            WriteLine($"Source List {list.Print()}");
            WriteLine($"Product of List elements excluding Index itself: {ListOperations.NumberProduct(list).Print()}");

            WriteLine(new string('═', 100));
        }

        private static void MissingPositiveNumberInArray()
        {
            // int[] input = { 1, 2, 0 };

            int[] input = { 3, 4, -1, 1 };

            WriteLine("Missing Element: " + ListOperations.MissingPositiveNumberInArray(input));
        }
    }
}
