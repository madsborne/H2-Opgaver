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

        }
    }

    class PhillControl
    {
        
        object _lock = new object();

        User phillOne = new User(0, 1);
        User phillTwo = new User(1, 2);
        User phillThree = new User(2, 3);
        User phillFour = new User(3, 4);
        User phillFive = new User(4, 0);

        public void EatingNow()
        {
            ThreadPool.QueueUserWorkItem(ForkChecker);
        }

        public void ForkChecker(object arg)
        {
            phillOne.rightHand = true;
            phillOne.leftHand = true;
            while (true)
            {
                if (phillOne.rightHand && phillOne.leftHand == true)
                {
                    phillOne.eating = true;
                    phillFour.eating = true;

                    phillFour.rightHand = true;
                    phillFour.leftHand = true;
                }
                if (phillOne.eating && phillFour.eating == true)
                {
                    phillOne.eating = false;
                    phillFour.eating = false;

                    phillOne.rightHand = false;
                    phillFour.rightHand = true;
                    phillFour.leftHand = true;
                }
            }

        }
    }

    class User
    {
        public int[] forks = new int[2];
        public bool rightHand = false;
        public bool leftHand = false;
        public bool eating = false;

        public User(int forkOne, int forkTwo)
        {
            forks[0] = forkOne;
            forks[1] = forkTwo;
        }


    }
}
