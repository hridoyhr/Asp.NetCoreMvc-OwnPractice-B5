using System;

namespace DelExample4
{
    class Program
    {
        static void Main(string[] args)
        {
            var design1 = new PuzzleDesing1();
            var designer = new PuzzleMaker.Design(design1.Print);

            var puzzleMaker = new PuzzleMaker();
            puzzleMaker.GeneratePuzzle(designer, 3, 3);
        }

        
    }
}
