using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDOpg1
{
    class Square
    {
        private int side;
        public int Side
        {
            get
            {
                return side;
            }
            set
            {
                side = value;
            }
        }
        
        public Square(int areaNumber, int steepNumber)
        {
            Side = areaNumber;
        }

        public double Circumference()
        {
            int circumNumber = side * 4;

            return circumNumber;
        }

        /// <summary>
        /// takes the side number that we get from the constructer and * it 4 times and then returns the number
        /// </summary>
        /// <returns></returns>
        public virtual int Area()
        {
            int areaNumber = side * side;

            return areaNumber;
        }
    }
}
