using static System.Console;
using System.Collections.Generic;
using System;

namespace ProgrammingProblems
{
    /*
     * Quick Report:
     * 
     * Create a program which will accept a series of numbers(these could for instance be a series of marks for an assessment) and then produce a quick report.The report should include the mean, mode and median.You could also include standard deviations if you're up to it. 
     * 
     * Your report should also include a histogram of the values, eg:
     * 
     * 1 | ***
	 * 2 | *
	 * 3 | *******
	 * 4 | ****
	 * 5 | **
     *
     */

    class QuickReport
    {
        List<int> input = new List<int>();

        private readonly int nums = 20;

        double _mean;
        double _median;
        double _sd;

        public QuickReport()
        {
            int min = 1, max = 100;
            int nums = 20;
            Random rnd = new Random();
            for (int i = 0; i < nums; i++)
            {
                input.Add(rnd.Next(min, max));
            }
        }
        public QuickReport(int[] numbers)
        {
            nums = numbers.Length;
            for (int i = 0; i < nums; i++)
            {
                input.Add(numbers[i]);
            }
        }

        public double Mean()
        {
            double mean = 0;

            for (int i = 0; i < nums; i++)
            {
                mean += input[i];
            }

            _mean = mean / nums;

            return _mean;
        }

        public double Median()
        {
            double median = 0;

            List<int> temp = input.GetRange(0, input.Count);
            temp.Sort();

            int center = nums / 2;

            if (nums % 2 == 0)
            {
                median = (temp[center] + temp[center + 1]) / 2.0;
            }
            else
            {
                median = temp[center];
            }

            _median = median;

            return median;
        }

        public double StandarDeviation()
        {
            _sd = 0;
            double sum = 0;

            for (int i = 0; i < nums; i++)
            {
                sum += Math.Pow(input[i] - _mean, 2);
            }

            _sd = Math.Sqrt(sum / nums);

            return _sd;
        }

        public void Histogram()
        {
            for (int i = 1; i <= nums; i++)
            {
                WriteLine($"{input[i - 1],2} | {new string('*', input[i - 1])}");
            }
        }

    }

}


