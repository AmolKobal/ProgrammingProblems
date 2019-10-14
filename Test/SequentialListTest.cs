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

            WriteLine($"{SequentialList.Print(b)} is subset of {SequentialList.Print(a)} = {list.IsSubset(b)}");

            int[] c = { 1, 3, 5, 7 };
            int[] d = { 1, 4 };

            list = new SequentialList(c);

            WriteLine($"{SequentialList.Print(d)} is subset of {SequentialList.Print(c)} = {list.IsSubset(d)}");

            string[] str1 = { "one", "three", "five", "seven" };
            string[] str2 = { "one", "four" };

            SequentialList<string> glist = new SequentialList<string>(str1);

            WriteLine($"{SequentialList<string>.Print(str2)} is subset of {SequentialList<string>.Print(str1)} = {glist.IsSubset(str2)}");

        }
    }
}
