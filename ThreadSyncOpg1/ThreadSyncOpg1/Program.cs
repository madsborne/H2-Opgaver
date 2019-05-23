using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadSyncOpg1
{
    class Program
    {
        static int adding = 0;
        static void Main(string[] args)
        {
            CounterOne one = new CounterOne();
            one.CounterNumberOne();
            Console.ReadLine();
        }
    }

    class CounterOne
    {
        
        public void CounterNumberOne()
        {
            Thread threadOne = new Thread(CounterNumberOne);
            threadOne.Start();
            while (true)
            {
                adding = +2;
                Console.WriteLine(adding);
                Thread.Sleep(2000);
            }
        }

        public void CounterRemoveOne()
        {
           ThreadPool.qu
            while (true)
            {
                adding = -1;
                Console.WriteLine(adding);
                threadTwo.
            }
        }

    }
}
