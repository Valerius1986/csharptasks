System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTriangles
{
    internal class Triangle
    {
        public double side1;
        public double side2;
        public double side3;

        public void determineTriangeType(double side1, double side2, double side3 ) 
        {
            if (side1 == side2 && side2 == side3)
            {
                Console.WriteLine("This triangle is equilateral");
            }
            else if (side1 == side2 || side2 == side3 || side3 == side1)
            {
                Console.WriteLine("This triangle is isosceles");
            }
            else
            {
                Console.WriteLine("This triangle is oblique");
            };
        }
    }
}

