using static System.Console;

namespace ProgrammingProblems.Test
{
    class SequentialListTest
    {
        public static void Run()
        {
            int[] a = { 1, 3, 5, 7, 9, 10, 11, 13 };
            int[] b = { 5, 7, 13 };

            SequentialList list = new SequentialList(a);

            WriteLine($"{b.Print()} is subset of {a.Print()} = {list.IsSubset(b)}");

            WriteLine(new string('═', 100));

            int[] c = { 1, 3, 5, 7 };
            int[] d = { 1, 4 };

            list = new SequentialList(c);

            WriteLine($"{d.Print()} is subset of {c.Print()} = {list.IsSubset(d)}");

            WriteLine(new string('═', 100));

            string[] str1 = { "one", "three", "five", "seven" };
            string[] str2 = { "one", "four" };

            SequentialList<string> glist = new SequentialList<string>(str1);

            WriteLine($"{str2.Print()} is subset of {str1.Print()} = {glist.IsSubset(str2)}");

            WriteLine(new string('═', 100));
        }
    }
}
