using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgrammingProblems.Test
{
    class QuickReportTest
    {
        public static void Run()
        {
            //int[] input = { 56, 35, 45, 67, 12, 24, 48, 55, 58, 30 };

            int[] input = { 6, 8, 10, 14 };

            QuickReport rpt = new QuickReport(input);

            WriteLine($"Mean: {rpt.Mean()}");
            WriteLine($"Median: {rpt.Median()}");
            WriteLine($"Standard Deviation: {rpt.StandarDeviation()}");
            rpt.Histogram();
        }
    }
}
