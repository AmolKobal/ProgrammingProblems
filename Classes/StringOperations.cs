using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace ProgrammingProblems
{
    class StringOperations
    {
        /*
        Write a program which will accept a line of text and tell you if any of the words appear within any of the other words in the line.
        Here is an example:
        
            Enter sentence  : There is a palm tree on the island.
            Answer          : The word is appears in the word island.
    */
        public static void WordsWithinWords(string input)
        {
            string[] words = input.Split(' ');

            WriteLine($"Input: {input}");

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words.Length; j++)
                {
                    if (i != j)
                    {
                        if (words[j].Contains(words[i]))
                        {
                            WriteLine($"The word '{words[i]}' appears in the word '{words[j]}'");
                        }
                    }
                }
            }
        }

        /*
        Write a program which will accept a line of text and tell you if any of the words are made up of the same letters.
        Here is an example:
            
            How can you listen if you are not silent?
            => listen = silent

        */

        public static void WordsOfSameLetter(string input)
        {
            StringBuilder output = new StringBuilder();
            int count = 0;

            WriteLine($"Input: {input}");

            string[] words = input.Split(' ');

            string tempWord1 = "", tempWord2 = "";

            for (int i = 0; i < words.Length; i++)
            {
                tempWord1 = words[i].ToLower();
                tempWord1 = String.Concat(tempWord1.OrderBy(c => c));

                for (int j = i + 1; j < words.Length; j++)
                {
                    tempWord2 = words[j].ToLower();
                    if (tempWord1.Length != tempWord2.Length)
                        continue;

                    tempWord2 = String.Concat(tempWord2.OrderBy(c => c));

                    if (tempWord1 == tempWord2)
                    {
                        output.AppendLine($"{words[i]} = {words[j]}");
                        count++;
                    }
                }
            }

            WriteLine($" Words Found {count}\n{output.ToString() }");
        }

        /*
         
        Implement an Autocomplete system.That is, given a query string s and a set of all possible query strings, 
        return all strings in the set that have s as a prefix.
        
        For example, given the query string de and the set of strings[dog, deer, deal], return [deer, deal].

        Hint: Try preprocessing the dictionary into a more efficient data structure to speed up queries.
        
         */

        public static void AutoCompleteWords(string[] input, string querystring)
        {
            WriteLine($"Input: {input.Print()}");
            WriteLine($"Query String: {querystring}");

            List<string> output = new List<string>();

            foreach (string s in input)
            {
                if (s.StartsWith(querystring))
                    output.Add(s);
            }

            WriteLine($"Output: {output.ToArray().Print()}");
        }

        /*
         * This problem was asked by Amazon.
         * Given a string s and an integer k, break up the string into multiple lines such that each line has a length of k or less.
         * You must break it up so that words don't break across lines. Each line has to have the maximum possible amount of words. 
         * If there's no way to break the text up, then return null.
         * 
         * You can assume that there are no spaces at the ends of the string and that there is exactly one space between each word.
         * 
         * For example, given the string "the quick brown fox jumps over the lazy dog" and k = 10, 
         * you should return: ["the quick", "brown fox", "jumps over", "the lazy", "dog"]. 
         * No string in the list has a length of more than 10.
         * 
         */

        public static string[] SplitStringInLengths(string input, int length)
        {
            StringBuilder sbOutput = new StringBuilder();
            StringBuilder temp = new StringBuilder();

            char[] wordSeparator = { ' ', '\n' };
            char[] punctuations = { '.', ',', ';', '!', '?' };

            string[] split = input.Replace(".", "").Replace(",", "").Split(wordSeparator);

            for (int i = 0; i < split.Length; i++)
            {
                if (split[i].Length > length)
                {
                    sbOutput.AppendLine(split[i] + " ");
                    continue;
                }

                if (temp.Length + split[i].Length > length)
                {
                    sbOutput.AppendLine(temp.ToString());
                    temp = new StringBuilder();
                }

                temp.Append(split[i] + " ");
            }
            sbOutput.AppendLine(temp.ToString());

            return sbOutput.ToString().Split('\n');
        }
    }
}
