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

    }
}
