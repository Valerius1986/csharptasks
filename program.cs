using System;

namespace TaskTriangles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instructions
            //Determine if a triangle is equilateral, isosceles, or scalene.

            //An equilateral triangle has all three sides the same length.

            //An isosceles triangle has at least two sides the same length. 
            //(It is sometimes specified as having exactly two sides the same length, 
            //but for the purposes of this exercise we'll say at least two.)

            //A scalene triangle has all sides of different lengths.
            
            Triangle tr = new Triangle();

            Console.WriteLine("Enter the value of side AB:");
            tr.side1 = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter the value of side BC:");
            tr.side2 = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter the value of side CA:");
            tr.side3 = double.Parse(Console.ReadLine());

            tr.determineTriangeType(tr.side1, tr.side2, tr.side3);




        }
    }
}
