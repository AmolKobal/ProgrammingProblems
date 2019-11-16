using System;
using System.Threading;

namespace ProgrammingProblems
{
    public class OneThread
    {
        Thread thread;
        public OneThread()
        {
            this.thread = new Thread(new ThreadStart(this.Run));
            thread.Name = "ThreadDemo";
            thread.Start();
        }
        public OneThread(string threadName)
        {
            this.thread = new Thread(new ThreadStart(this.Run));
            thread.Name = threadName;
            thread.Start();
        }
        private void Run()
        {
            for (Int32 i = 0; i < 10; i++)
            {
                Console.WriteLine($"{thread.Name} : {i}");
                Thread.Sleep(1800);
            }
        }
    }

    public class TwoThreads
    {
        Thread thread1;
        Thread thread2;
        public TwoThreads()
        {
            this.thread1 = new Thread(new ThreadStart(this.Run1));
            thread1.Name = "Child Thread 1";
            thread1.Start();
            this.thread2 = new Thread(new ThreadStart(this.Run2));
            thread2.Name = "Child Thread 2";
            thread2.Start();
        }
        public TwoThreads(string threadName1, string threadName2)
        {
            this.thread1 = new Thread(new ThreadStart(this.Run1));
            thread1.Name = threadName1;
            thread1.Start();
            this.thread2 = new Thread(new ThreadStart(this.Run2));
            thread2.Name = threadName2;
            thread2.Start();
        }
        private void Run1()
        {
            for (Int32 i = 0; i < 10; i++)
            {
                Console.WriteLine($"{thread1.Name} : {i}");
                Thread.Sleep(1500);
            }
        }
        private void Run2()
        {
            for (Int32 i = 30; i < 40; i++)
            {
                Console.WriteLine($"{thread2.Name} : {i}");
                Thread.Sleep(2000);
            }
        }
    }
}