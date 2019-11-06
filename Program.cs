using static System.Console;
using ProgrammingProblems.Test;

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

            ReadLine();
            return;

        }
    }
}