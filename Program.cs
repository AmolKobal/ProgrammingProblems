using static System.Console;
using ProgrammingProblems.Test;

namespace Example
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

            ThreadOperationsTest.Run();

            JobSchedulerTest.Run();

            ReadLine();
            return;

        }
    }
}