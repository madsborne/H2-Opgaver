using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSolidMyBanker
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput;
            while (true)
            {
                Console.WriteLine("Hello welcome to the world trade");
                Console.WriteLine("we hand out free cards we just need some basic info");
                Console.WriteLine("how old are you?");
                userInput = Int32.Parse(Console.ReadLine());

                if (userInput < 15)
                {
                    Console.WriteLine("You can get");
                    Console.WriteLine("1: Visa Electron");
                    Console.WriteLine("2: Mastercard");
                    Console.WriteLine("3: Debitcard");
                    userInput = Int32.Parse(Console.ReadLine());
                    switch (userInput)
                    {
                        case 1:
                            Console.WriteLine("you picked Visa Electron");
                            break;
                        case 2:
                            break;
                        case 3:
                            break;

                    }
                } 
            }
            
        }
    }
}
