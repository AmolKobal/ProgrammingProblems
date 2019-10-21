using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgrammingProblems.Test
{
    class ThreadOperationsTest
    {
        public static void Run()
        {
            OneThread thread1 = new OneThread("Test for One Thread");

            TwoThreads thread2 = new TwoThreads("Thread 2.1", "Thread 2.2");
        }
    }
}
