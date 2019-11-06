using static System.Console;

namespace ProgrammingProblems.Test
{
    class StringOperationsTest
    {
        public static void Run()
        {
            WordsWithinWordsTest();
            WordsOfSameLetterTest();
            AutoCompleteWordsTest();
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
