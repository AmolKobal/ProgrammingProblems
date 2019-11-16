using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Xml;

using ConsoleExamples.CollectionClasses;
using ConsoleExamples.GenericClassess;
using ConsoleExamples.ExceptionClasses;
using ConsoleExamples.FormattingClasses;
using ConsoleExamples.AbstractClasses;
using ConsoleExamples.YieldExample;
using ConsoleExamples.ThreadClasses;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-- ArrayList --");
            ArrayListDemo AlDemo = new ArrayListDemo();
            AlDemo.AddNew();
            AlDemo.Display();
            AlDemo.Sort();
            Console.WriteLine("Sorted List.");
            AlDemo.Display();

            Console.WriteLine("-- Stack --");
            StackDemo st = new StackDemo();

            QueueDemo Q = new QueueDemo();

            Console.WriteLine("-- Generic List --");
            MyGeneric<string> gen = new MyGeneric<string>();
            gen.AddItem("abc");
            gen.AddItem("xyz");
            Console.WriteLine(gen.GetItem());
            Console.WriteLine(gen.GetItem(1));

            Console.WriteLine("-- Exceptions --");
            //UserDefinedException uexp = new UserDefinedException();
            try
            {
                UserDefinedException.ThrowUserDefinedException();
            }
            catch (UserDefinedException ex)
            {
                Console.WriteLine("Exception : " + ex.Message);
            }
            try
            {
                UserDefinedException.ThrowUserDefinedException("New Message");
            }
            catch (UserDefinedException ex)
            {
                Console.WriteLine("Exception : " + ex.Message);
            }

            Console.WriteLine("\n-- Format Deemo --");
            FormattingDemo.Display();

            DisplayXMLContents();


            MyList list = new MyList();
            Console.WriteLine(list.ToString());

            Console.WriteLine("-- AbstractClass static methos--");
            Console.WriteLine(AbstractClass.Display("Hello"));

            Console.WriteLine("-- Yield Example --");
            foreach (int i in YieldExample.Power(2, 8))
            {
                Console.Write("{0} ", i);
            }

            //// Single Thread Example.
            Console.WriteLine("\n\nSingle Thread Example.\n");
            ThreadDemo thread1 = new ThreadDemo();
            ThreadDemo thread2 = new ThreadDemo("FromMain");

            Console.WriteLine("Single Thread Ended");
            
            //// Single Thread Example.
            Console.WriteLine("\n\nTwo Threads Example.\n");
            TwoThreads twoThreads = new TwoThreads("Child#1", "Child#2");

            Console.WriteLine("Two Threads Ended");
            Console.ReadKey();
        }

        private static void DisplayXMLContents()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("books.xml");

            Console.WriteLine("XML Contents...");
            XmlNode node = doc.DocumentElement.FirstChild;
            Console.WriteLine(node.FirstChild.InnerText);            

            Console.WriteLine("Display all the books...");

            XmlNode root = doc.DocumentElement;
            IEnumerator ienum = root.GetEnumerator();
            XmlNode book;
            while (ienum.MoveNext())
            {
                book = (XmlNode)ienum.Current;
                Console.WriteLine(book.OuterXml);
                Console.WriteLine();
            }

        }
    }

    #region [ GetType Defined ]
        //class ObjectDerived1 : Object
        //{       
        //}

        //class ObjectDerived2 : Object
        //{
        //    public System.Type GetType()
        //    {
        //        string str = "abc";
        //        return str.GetType();
        //    }
        //    public void Display()
        //    {
        //        Console.WriteLine("-- GetType Not Overriden --");
        //        ObjectDerived1 obj1 = new ObjectDerived1();
        //        Console.WriteLine("Type of ObjectDerived1 : " + obj1.GetType());
        //        Console.WriteLine("-- GetType Overriden --");
        //        ObjectDerived2 obj2 = new ObjectDerived2();
        //        Console.WriteLine("Type of ObjectDerived2 : " + obj2.GetType());
        //    }
        //}
    #endregion
}