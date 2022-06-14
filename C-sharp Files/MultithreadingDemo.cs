using System;
using System.Threading;
namespace C_sharp_Files
{
    class MultithreadingDemo
    {

        public class Multithreading
        {
            public void Run()
            {
                Thread t = Thread.CurrentThread;
                lock (this)
                {
                    for (int i = 1; i < 11; i++)
                    {
                        Console.WriteLine(t.Name);
                        Console.WriteLine(i);
                        /*if(i==9)
                        {
                            t.Abort();
                        }*/
                    }
                }

            }
        }
        static void Main(string[] args)
        {
            Multithreading demo = new Multithreading();
            Thread t1 = new Thread(new ThreadStart(demo.Run));
            Thread t2 = new Thread(new ThreadStart(demo.Run));
            Thread t3 = new Thread(new ThreadStart(demo.Run));
            t1.Name = "T1 Thread";
            t2.Name = "T2 Thread";
            t3.Name = "T3 Thread";
            t1.Priority = ThreadPriority.Lowest;
            t2.Priority = ThreadPriority.AboveNormal;
            t3.Priority = ThreadPriority.Highest;
            t1.Start();
            //t1.Join();
            t2.Start();
            t3.Start();

        }
    }
}