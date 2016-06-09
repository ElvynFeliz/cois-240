using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIRCLE
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle myCircle1 = new Circle();
            myCircle1.radius = 5;
            myCircle1.calculateArea();
            Console.WriteLine("The area of the circle is {1} and the radius is {0}.", myCircle1.radius, myCircle1.area);
            Console.ReadLine();
               
        }
    }
}
