using static System.Console;

namespace ProgrammingProblems.Test
{
    class StringOperationsTest
    {
        public static void Run()
        {
            WordsWithinWordsTest();
            WordsOfSameLetterTest();
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

    }
}
