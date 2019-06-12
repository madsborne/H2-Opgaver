using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDragRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            // creates two strings to store info from user
            string userPickOne;
            string userPickTwo;
            while (true)
            {
                // creates the track
                RaceTrack track;

                Console.WriteLine("Hello user welcome to this dragrace");
                Console.WriteLine("please pick a car color and engine");
                Console.WriteLine("type your car color now");

                // here we get info from the user and stores it
                userPickOne = Console.ReadLine();
                Console.WriteLine("please select a engine");
                Console.WriteLine("1: Jonda Engine - Topspeed 280, in 2.5 sec");
                Console.WriteLine("2: Poyota Engine - Topspeed 330, in 4 sec");
                userPickTwo = Console.ReadLine();

                // uses userPickTwo to determin what engine the user picked and starts the race
                switch (userPickTwo)
                {
                    case "1":
                        track = new RaceTrack(userPickOne, 1);
                        Console.WriteLine(track.StartRace());
                        break;
                    case "2":
                        track = new RaceTrack(userPickOne, 2);
                        Console.WriteLine(track.StartRace());
                        break;
                    default:
                        Console.WriteLine("not a valid input");
                        break;
                }
            }
            
        }
    }
}
