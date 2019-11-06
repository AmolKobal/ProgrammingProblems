using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgrammingProblems
{
    public static class Extensions
    {
        public static string Print(this int[] list)
        {
            string output = "";
            output = "[ ";
            foreach (int item in list)
                output += item + ", ";
            output = output.Substring(0, output.Length - 2) + " ]";
            return output;
        }

        public static string Print(this string[] list)
        {
            string output = "";
            output = "[ ";
            foreach (string item in list)
                output += item + ", ";
            output = output.Substring(0, output.Length - 2) + " ]";
            return output;
        }
    }
}
