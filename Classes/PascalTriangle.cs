using static System.Console;
using System.Collections.Generic;

namespace ProgrammingProblems
{
    class PascalTriangle
    {
        /*
         * Pascal Triangle
         */

        public static void Draw(int n)
        {
            List<int> current = new List<int>();
            List<int> previous = new List<int>();

            int num = 1;

            for (int i = 1; i <= n; i++)
            {
                Write(new string(' ', n - i));

                for (int j = 1; j <= i; j++)
                {
                    if (j == 1 || j == i)
                    {
                        num = 1;
                    }
                    else
                    {
                        num = previous[j - 1] + previous[j - 2];
                    }

                    Write($"{ num } ");
                    current.Add(num);
                }

                previous = current;
                current = new List<int>();
                WriteLine();
            }
        }
    }
}
