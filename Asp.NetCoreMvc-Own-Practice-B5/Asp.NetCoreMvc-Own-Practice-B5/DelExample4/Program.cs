using System;

namespace DelExample4
{
    class Program
    {
        static void Main(string[] args)
        {
            var designerr = new PuzzleMaker.Design(StrangeDesing);
            Print(designerr);
        }

        static void StrangeDesing(int x, int y)
        {
            Console.WriteLine($"Printing from static method: {x}, {y}");
        }

        static void Print(PuzzleMaker.Design designer)
        {
            Console.WriteLine("Welcome to printing: ");
            designer(5, 7);
        }
    }
}
