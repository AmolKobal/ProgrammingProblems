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
            BalancedBracketsTest();
            SplitStringInLengthsTest();
        }

        private static void SplitStringInLengthsTest()
        {
            string input = "the quick brown fox jumps over the lazy dog";
            int length = 10;

            string[] output = StringOperations.SplitStringInLengths(input, length);

            WriteLine("*****     SplitStringInLengths     *****");
            foreach (string str in output)
            {
                WriteLine(str);
            }
        }

        private static void BalancedBracketsTest()
        {
            string input = "([])[]({})";
            input = "((()))";
            WriteLine($"{input} is balanced: {BalancedBrackets.IsBalanced(input)}");
        }

        private static void RunLengthEncodingTest()
        {
            string input = "AAAABBBCCDAE";
            WriteLine("RunLengthEncoding");

            string encodedOutput = RunLengthEncoding.Encode(input);

            WriteLine($"Input : {input} , Encoded : {encodedOutput}");

            string decodedOutput = RunLengthEncoding.Decode(encodedOutput);

            WriteLine($"Input : {input} , Decoded : {decodedOutput}");

            WriteLine(input == decodedOutput);

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
