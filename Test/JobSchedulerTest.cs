using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgrammingProblems.Test
{
    class JobSchedulerTest
    {
        public delegate void Function(int counter);

        public static void Run()
        {
            Function f = new Function(FuncImplemention);

            int sleepDuration = 100;
            int increment = 10;
            JobScheduler.SecondsCounter = 500;
            JobScheduler.Increment = increment;
            JobScheduler.Schedule(f, sleepDuration);
        }

        public static void FuncImplemention(int counter)
        {
            Console.WriteLine($"Calling Function {counter}");
        }
    }
}
