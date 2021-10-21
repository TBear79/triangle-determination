using System;

namespace TriangleDetermination
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("To be able to determine the type of triangle, please enter the length of each side.");
            
            var side1 = Input("1");
            var side2 = Input("2");
            var side3 = Input("3");

            Console.WriteLine("Determining the type of triangle...");

            var triangleEnum = TriangleBl.DetermineType(side1, side2, side3);

            Console.WriteLine($"The triangle is a \"{triangleEnum}\"");
        }

        public static int Input(string side)
        {
            Console.WriteLine($"Length of side {side}");
            if(Int32.TryParse(Console.ReadLine(), out var sideLength) && sideLength > 0)
            {
                return sideLength;
            }

            Console.WriteLine($"Only positive numbers are allowed. No letters. Please try again :-)");
            return Input(side);
        }
    }
}
