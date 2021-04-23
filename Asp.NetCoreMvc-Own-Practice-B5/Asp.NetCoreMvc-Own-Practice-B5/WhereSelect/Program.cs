using System;
using System.Linq;
using System.Collections.Generic;


namespace WhereSelect
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = new int[] { 97, 60, 80, 220, 104};

            var scoreQuery =
                from score in scores
                where score > 80
                select score;


            foreach (var print in scoreQuery)
            {
                Console.WriteLine(print + " ");
            }
        }
    }
}
