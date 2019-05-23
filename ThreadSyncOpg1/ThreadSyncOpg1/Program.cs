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
        // my statics the will be used to count up and to debug 
        public static int counter = 0;
        public static int doubleCounter = 0;
        static void Main(string[] args)
        {
            // Creates two threads that runs the two call back methods
            Thread threadOne = new Thread(CounterOne.CounterNumberOne);
            threadOne.Start();
            Thread threadTwo = new Thread(Remover.CounterRemoveOne);
            threadTwo.Start();

            threadTwo.Join();
            threadOne.Join();

            Console.ReadLine();
        }

        
    }

    class CounterOne
    {
        // creats my lock object 
        public static object gridLock = new object();

        public static void CounterNumberOne(object arg)
        {
            while (true)
            {

                // these are for the assignment 1 and 2 
                //Program.counter += 2;
                //Console.WriteLine(Program.counter);

                // locking off the double counter to make sure it has the right to it and then sleeps for two seconds
                lock (gridLock)
                {
                    Program.doubleCounter += 60;
                    Console.WriteLine("************************************************************ " + Program.doubleCounter);
                }
                Thread.Sleep(2000);
            }
        }
    }

    // the name makes sense for assignment 1 but i combined it for the two others
    class Remover
    {
        public static void CounterRemoveOne(object arg)
        {
            while (true)
            {
                // these are for the assignment 1 and 2
                //Program.counter -= 1;
                //Console.WriteLine(Program.counter);

                // makes the thread sleep for 1mill sec to then run the rest just to make sure it comes in second 
                Thread.Sleep(100);
                Program.doubleCounter += 60;
                Console.WriteLine("############################################################ " + Program.doubleCounter);
                Thread.Sleep(2000);
            }
        }
    }
}
