using static System.Console;

namespace ProgrammingProblems.Test
{
    class ListOperationsTest
    {
        public static void Run()
        {
            int[] list = { 10, 15, 3, 7 };

            int k = 17;
            if (ListOperations.IsSumOfTwoNumbers(list, k))
                WriteLine($"{k} is SUM of two numbers of list {SequentialList.Print(list)}");
            else
                WriteLine($"{k} is not SUM of two numbers of list {SequentialList.Print(list)}");

            k = 50;
            if (ListOperations.IsSumOfTwoNumbers(list, k))
                WriteLine($"{k} is SUM of two numbers of list {SequentialList.Print(list)}");
            else
                WriteLine($"{k} is NOT SUM of two numbers of list {SequentialList.Print(list)}");

        }
    }
}
