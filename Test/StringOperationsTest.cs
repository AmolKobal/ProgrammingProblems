using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgrammingProblems.Test
{
    class StringOperationsTest
    {
        public static void Run()
        {
            WordsWithinWordsTest();
        }

        public static void WordsWithinWordsTest()
        {
            string input = "There is a palm tree on the island.";

            StringOperations.WordsWithinWords(input);
        }

    }
}
