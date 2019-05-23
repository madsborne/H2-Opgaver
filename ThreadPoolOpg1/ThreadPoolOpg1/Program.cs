using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace ThreadPoolOpg1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch myWatch = new Stopwatch();
            Console.WriteLine("Threadpool excution");
            myWatch.Start();
            ProcessWithThreadPoolMethod();
            myWatch.Stop();

            Console.WriteLine("Time consumed by ProcessWithThreadPoolMethod is - " + myWatch.ElapsedTicks.ToString());
            myWatch.Reset();
            Console.WriteLine("Thread Excute");

            myWatch.Start();
            ProcessWithThreadMethod();
            myWatch.Stop();

            Console.WriteLine("Time consumed by ProcessWithThreadMethod is - " + myWatch.ElapsedTicks.ToString());
        }

        static void Process(object callBack)
        {
            for (int i = 0; i < 100000; i++)
            {
                for (int j = 0; j < 100000; j++)
                {
                }
            }
        }

        static void ProcessWithThreadMethod()
        {
            for (int i = 0; i <= 10; i++)
            {
                Thread obj = new Thread(Process);
                obj.Start();
            }
        }

        static void ProcessWithThreadPoolMethod()
        {
            for (int i = 0; i <= 10; i++)
            {
                ThreadPool.QueueUserWorkItem(Process);
            }
        }
    }
}
