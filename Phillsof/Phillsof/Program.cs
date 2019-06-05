using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Phillsof
{
    class Program
    {
        static void Main(string[] args)
        {
            PhillControl control = new PhillControl();

            control.ForkChecker();
        }
    }

    class PhillControl
    {
        
        object _lock = new object();

        User phillZero = new User(false, false);
        User phillOne = new User(true, true);
        User phillTwo = new User(false, false);
        User phillThree = new User(false, false);
        User phillFour = new User(true, true);

        public void ForkChecker()
        {
            
            while (true)
            {
                if (phillOne.forks[0] && phillOne.forks[1] && phillFour.forks[0] == true)
                {
                    // sets phill 1 and 4 to false
                    Console.WriteLine("Phil 1 and 4 eating");
                    phillOne.forks[0] = false;
                    phillOne.forks[1] = false;

                    phillFour.forks[0] = false;
                    phillFour.forks[1] = false;

                    // sets Phill 2 and 0 to true
                    phillTwo.forks[0] = true;
                    phillTwo.forks[1] = true;

                    phillZero.forks[0] = true;
                    phillZero.forks[1] = true;

                    Thread.Sleep(1000);
                }
                else if (phillTwo.forks[0] && phillTwo.forks[1] && phillZero.forks[0] == true)
                {
                    // sets phill 2 and 0 to false
                    Console.WriteLine("Phil 2 and 0 eating");
                    phillTwo.forks[0] = false;
                    phillTwo.forks[1] = false;

                    phillZero.forks[0] = false;
                    phillZero.forks[1] = false;

                    // sets Phill 3 and 1 to true
                    phillThree.forks[0] = true;
                    phillThree.forks[1] = true;

                    phillOne.forks[0] = true;
                    phillOne.forks[1] = true;

                    Thread.Sleep(1000);
                }
                else if (phillThree.forks[0] && phillThree.forks[1] && phillOne.forks[0] == true)
                {
                    // sets phill 3 and 1 to false
                    Console.WriteLine("Phil 3 and 1 eating");
                    phillThree.forks[0] = false;
                    phillThree.forks[1] = false;

                    phillOne.forks[0] = false;
                    phillOne.forks[1] = false;

                    // sets Phill 4 and 2 to true
                    phillFour.forks[0] = true;
                    phillFour.forks[1] = true;

                    phillTwo.forks[0] = true;
                    phillTwo.forks[1] = true;

                    Thread.Sleep(1000);
                }
                else if (phillFour.forks[0] && phillFour.forks[1] && phillTwo.forks[0] == true)
                {
                    // sets phill 4 and 2 to false
                    Console.WriteLine("Phil 4 and 2 eating");
                    phillFour.forks[0] = false;
                    phillFour.forks[1] = false;

                    phillTwo.forks[0] = false;
                    phillTwo.forks[1] = false;

                    // sets Phill 0 and 3 to true
                    phillZero.forks[0] = true;
                    phillZero.forks[1] = true;

                    phillThree.forks[0] = true;
                    phillThree.forks[1] = true;

                    Thread.Sleep(1000);
                }
                else if (phillZero.forks[0] && phillZero.forks[1] && phillThree.forks[0] == true)
                {
                    // sets phill 0 and 3 to false
                    Console.WriteLine("Phil 0 and 3 eating");
                    phillZero.forks[0] = false;
                    phillZero.forks[1] = false;

                    phillThree.forks[0] = false;
                    phillThree.forks[1] = false;

                    // sets Phill 1 and 4 to true
                    phillOne.forks[0] = true;
                    phillOne.forks[1] = true;

                    phillFour.forks[0] = true;
                    phillFour.forks[1] = true;

                    Thread.Sleep(1000);
                }
            }

        }
    }

    class User
    {
        public bool[] forks = new bool[] { false, false };

        public User(bool rightHand, bool leftHand)
        {
            forks[0] = rightHand;
            forks[1] = leftHand;
        }
    }
}
