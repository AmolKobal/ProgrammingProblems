using static System.Console;
using ProgrammingProblems.Test;
using System.Threading;

namespace ProgrammingProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            QuickReportTest.Run();

            NumberOperationsTest.Run();

            ListOperationsTest.Run();

            SequentialListTest.Run();

            StringOperationsTest.Run();

            OtherTest.Run();

            //ThreadOperationsTest.Run();

            //JobSchedulerTest.Run();

            for (int i = 0; i < 100; i++)
            {
                NumberOperationsTest.Run();
                Thread.Sleep(100);
            }

            ReadLine();

            return;

        }
    }
}