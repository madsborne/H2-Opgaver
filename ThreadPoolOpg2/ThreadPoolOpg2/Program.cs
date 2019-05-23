using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadPoolOpg2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates a thread and gives it the Background prop
            // also assing it the abovenormal prop
            // and starts it 
            Thread t = new Thread(Process);
            t.IsBackground = true;
            t.Priority = ThreadPriority.AboveNormal;
            t.Start();
            while (t.IsAlive)
            {
                Thread.Sleep(2000);
                bool threadAlive = t.IsAlive;
                if (threadAlive)
                {
                    Console.WriteLine("....");
                }
            }
            t.Join();
            Console.WriteLine("It's Dead oh no");
            Console.ReadLine();
        }

        static void Process(object arg)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Hello");
            }
        }

        static void Printing()
        {
            for (int i = 0; i < 4; i++)
            {
                ThreadPool.QueueUserWorkItem(Process);
            }
            
        }
    }
}
