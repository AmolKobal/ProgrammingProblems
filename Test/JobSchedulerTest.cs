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

            JobScheduler.Schedule(f, 100);
        }

        public static void FuncImplemention(int counter)
        {
            Console.WriteLine($"Calling Function {counter}");
        }
    }
}
