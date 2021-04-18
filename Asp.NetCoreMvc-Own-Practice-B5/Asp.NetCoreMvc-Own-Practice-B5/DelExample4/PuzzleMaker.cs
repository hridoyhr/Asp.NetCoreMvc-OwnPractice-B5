using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelExample4
{
    public class PuzzleMaker
    {
        public delegate void Design(int width, int height);

        public void GeneratePuzzle(Design design, int width, int height)
        {
            Console.WriteLine("Hello From puzzle.\nWe are Generating a puzzle");

            Console.WriteLine("Printing Puzzle");
            design(width, height);

            Console.WriteLine("Done");
        }

        public void startPuzzle()
        {
            Console.WriteLine("Starting Puzzle Game");
        }
    }

    
}
