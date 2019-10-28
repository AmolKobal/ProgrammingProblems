using static System.Console;

namespace ProgrammingProblems.Test
{
    class OtherTest
    {
        public static void Run()
        {
            Fibonacci.Draw(20);

            int number = 6;
            long fact = Factorial.Calculate(number);
            WriteLine($"\nFactorial of {number} is {fact}");

            number = 371;
            WriteLine($"{number} is{(ArmstrongNumber.Find(number) ? "" : " NOT")} Armstrong Number");
        }
    }
}
