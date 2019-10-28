using static System.Console;

namespace ProgrammingProblems
{
    class Factorial
    {
        public static long Calculate(int n)
        {
            if (n <= 0)
            {
                return 0;
            }

            if (n == 1)
                return n;

            return n * Calculate(n - 1);
        }
    }
}
