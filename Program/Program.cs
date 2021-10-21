using System;

namespace TriangleDetermination
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("To be able to determine the type of triangle, please enter the length of each side.");
            
            Input("1");
            Input("2");
            Input("3");

            Console.WriteLine("Determining the type of triangle...");

            var triangleEnum = TriangleEnum.Scalene;

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
