using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleExamples.AbstractClasses
{
    public abstract class AbstractClass
    {
        public abstract void Display();
        public static Boolean Display(string name)
        {
            Console.Write(name + " ");
            return true;
        }
    }
}
