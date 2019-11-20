using System;
using static System.Console;
using ProgrammingProblems.Classes;

namespace ProgrammingProblems.Test
{
    class StringOperationsTest
    {
        public static void Run()
        {
            WordsWithinWordsTest();
            WordsOfSameLetterTest();
            AutoCompleteWordsTest();
            RunLengthEncodingTest();
        }

        private static void RunLengthEncodingTest()
        {
            string input = "AAAABBBCCDAE";
            WriteLine("RunLengthEncoding");
            WriteLine($"{input} : {RunLengthEncoding.Encode(input)}");
        }

        public static void WordsWithinWordsTest()
        {
            string input = "There is a palm tree on the island.";

            StringOperations.WordsWithinWords(input);
        }

        public static void WordsOfSameLetterTest()
        {
            string input = "How can you listen if you are not silent ?";

            StringOperations.WordsOfSameLetter(input);
        }

        public static void AutoCompleteWordsTest()
        {
            string[] input = new string[3];

            input[0] = "dogrs";
            input[1] = "deer";
            input[2] = "deal";

            string querystring = "de";

            StringOperations.AutoCompleteWords(input, querystring);

        }
    }
}
