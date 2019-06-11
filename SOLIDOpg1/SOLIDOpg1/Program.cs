using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDOpg1
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square(5);
            Rectangle rectangle = new Rectangle(5);
            Trapeze trapeze = new Trapeze(5);
            Parallelogram parallelogram = new Parallelogram(5);

            Console.WriteLine(square.Area() + " Area number");
            Console.WriteLine(square.Circumference() + " Circum number");

            Console.WriteLine(rectangle.Area() + " This uses a method from Square but is a Rectangle");
            Console.WriteLine(trapeze.Area() + " This uses a method from Square but is a Trapeze");
            Console.WriteLine(parallelogram.Area() + " This uses a method from Square but is a Parallelogram");
        }
    }
}
