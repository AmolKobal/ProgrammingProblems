using static System.Console;

namespace ProgrammingProblems
{
    class Fibonacci
    {
        public static void Draw(int n)
        {
            if (n <= 0)
            {
                WriteLine("Invalid input for Fibonacci Series.");
                return;
            }

            int n1 = 0, n2 = 1;
            int nextNum;

            Write($"{0} {1} ");

            for (int i = 2; i < n; i++)
            {
                nextNum = n1 + n2;

                Write($"{nextNum} ");
                n1 = n2;
                n2 = nextNum;
            }
        }
    }
}
