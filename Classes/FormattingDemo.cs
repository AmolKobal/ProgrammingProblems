using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Globalization;

namespace ConsoleExamples.FormattingClasses
{
    class FormattingDemo
    {
        public static void Display()
        {
            CultureInfo ci = Thread.CurrentThread.CurrentCulture;

            double MyDouble = 123456789;

            Thread.CurrentThread.CurrentCulture = new CultureInfo("de-DE");
            Console.WriteLine("The examples in de-DE culture.\n");
            Console.WriteLine(MyDouble.ToString("C"));
            Console.WriteLine(MyDouble.ToString("E"));
            Console.WriteLine(MyDouble.ToString("P"));
            Console.WriteLine(MyDouble.ToString("N"));
            Console.WriteLine(MyDouble.ToString("F"));

            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-us");
            Console.WriteLine("\nThe examples in en-US culture.\n");
            Console.WriteLine(MyDouble.ToString("C"));
            Console.WriteLine(MyDouble.ToString("E"));
            Console.WriteLine(MyDouble.ToString("P"));
            Console.WriteLine(MyDouble.ToString("N"));
            Console.WriteLine(MyDouble.ToString("F"));

            Thread.CurrentThread.CurrentCulture = ci;

            Console.WriteLine("\n New Example");
            double MyPos = 3219.9574, MyNeg = -19.95, MyZero = 0.0;

            Console.WriteLine(MyPos.ToString("$#,##0.00;($#,##0.00);Zero"));

            // In the U.S. English culture, MyString has the value: $19.95.

            Console.WriteLine(MyNeg.ToString("$#,##0.00;($#,##0.00);Zero"));

            // In the U.S. English culture, MyString has the value: ($19.95).
            // The minus sign is omitted by default.

            Console.WriteLine(MyZero.ToString("$#,##0.00;($#,##0.00);Zero"));

            // In the U.S. English culture, MyString has the value: Zero.

            Int32 value = 234567;
            Double doublevalue = 1234576.586798;
            Console.WriteLine(value.ToString("##,##0.00"));
            Console.WriteLine(doublevalue.ToString("#0.##"));


            Console.WriteLine("-- Custom Number Formatting --");
            Double myDouble = 1234567890;
            Console.WriteLine(myDouble.ToString("(###) ### - ####"));
            // The value of myString is "(123) 456 – 7890".

            int MyInt = 42;
            Console.WriteLine(MyInt.ToString("My Number \n= #"));
            // In the U.S. English culture, MyString has the value: 
            // "My Number
            // = 42".

            MyDouble = 1234567890;
            Console.WriteLine(MyDouble.ToString("#"));
            Console.WriteLine(MyDouble.ToString("#,"));
            Console.WriteLine(MyDouble.ToString("#,,"));
            Console.WriteLine(MyDouble.ToString("#,,,"));
            Console.WriteLine(MyDouble.ToString("#,,,,"));
        }
    }
}
