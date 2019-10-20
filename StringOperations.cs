﻿using System;
using static System.Console;

namespace ProgrammingProblems
{
    class StringOperations
    {
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
    }
}
