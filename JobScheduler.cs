using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ProgrammingProblems
{
    // Implement a job scheduler which takes in a function f and an integer n, and calls f after n milliseconds.
    class JobScheduler
    {
        public static bool Abort { get; set; }

        public static int SecondsCounter { get; set; }
        public static int Increment { get; set; }

        // Counter used for Testing Purpose only; to stop the Job after certain interval; otherwise it will run forever.
        private static int counter = 0;

        public static void Schedule(Delegate f, int n)
        {
            while (!Abort)
            {
                Thread.Sleep(n);

                f.DynamicInvoke(counter);

                // Counter used for Testing Purpose only;
                counter += Increment;
                if (counter > SecondsCounter)
                    Abort = true;
            }
        }
    }
}
