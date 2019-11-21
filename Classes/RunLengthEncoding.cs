using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgrammingProblems.Classes
{
    /*
     * 
     * This problem was asked by Amazon.
     * 
     * Run-length encoding is a fast and simple method of encoding strings. 
     * The basic idea is to represent repeated successive characters as a single count and character.
     * 
     * For example, the string "AAAABBBCCDAA" would be encoded as "4A3B2C1D2A".
     * 
     * Implement run-length encoding and decoding. 
     * You can assume the string to be encoded have no digits and consists solely of alphabetic characters.
     * You can assume the string to be decoded is valid.
     * */

    class RunLengthEncoding
    {
        public static string Encode(string input)
        {
            if (input.Length <= 0)
                return "";

            StringBuilder output = new StringBuilder();
            int count = 0;
            char lastChar = input[0];

            foreach (char c in input)
            {
                if (lastChar == c)
                    count++;
                else
                {
                    if (count > 0)
                    {
                        output.Append($"{count}{lastChar}");
                        lastChar = c;
                        count = 1;
                    }
                    else
                        output.Append(c);
                }
            }

            // For last character.
            if (count > 0)
                output.Append($"{count}{lastChar}");
            else
                output.Append(input[input.Length - 1]);

            return output.ToString();
        }

        public static string Decode(string input)
        {
            if (input.Length <= 0)
                return "";

            StringBuilder output = new StringBuilder();
            char outchar = input[0];

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    outchar = input[i + 1];
                    int count = input[i] - 48;
                    output.Append(new string(outchar, count));
                    i++;
                }
            }

            return output.ToString();
        }
    }
}
