using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleExamples.CollectionClasses
{
    #region [ ArrayList Example ]
        class ArrayListDemo
        {
            ArrayList al = null;
            public ArrayListDemo()
            {
                al = new ArrayList();
            }
            ~ArrayListDemo()
            {
                al = null;
            }
            public void AddNew()
            {
                al.Add(3);
                al.Add(50);
                al.Add(14);
                al.Add(300);
                al.Add(-130);
            }

            public void Display()
            {
                foreach (object obj in al)
                    Console.WriteLine(obj);
            }
            public void Sort()
            {
                try
                {
                    al.Sort();
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    #endregion
    
    #region [ Stack Example ]
        class StackDemo
        {
            public StackDemo()
            {
                Stack st = new Stack();
                st.Push(10);
                st.Push(20);
                st.Push(30);

                foreach (object obj in st)
                    Console.WriteLine(obj);

                Console.WriteLine("-- Pop--");
                do
                {
                    Console.WriteLine(st.Pop());
                } while (st.Count > 0);
                try
                {
                    Console.WriteLine(st.Pop());
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                st = null;
            }
        }
    #endregion

    #region [ Queue Example ]
        class QueueDemo
        {
            public QueueDemo()
            {
                Queue q = new Queue();
                q.Enqueue(1);
                q.Enqueue(2);
                q.Enqueue(3);
                q.Enqueue(4);

                Console.WriteLine("-- Queue --");
                foreach (object obj in q)
                    Console.WriteLine(obj);

                //foreach (object obj in q.Peek())
                //    Console.WriteLine(obj);

                Console.WriteLine("-- Dequeue --");
                do
                {
                    Console.WriteLine(q.Dequeue());
                }
                while (q.Count > 0);
                try
                {
                    q.Peek();
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    #endregion
}
