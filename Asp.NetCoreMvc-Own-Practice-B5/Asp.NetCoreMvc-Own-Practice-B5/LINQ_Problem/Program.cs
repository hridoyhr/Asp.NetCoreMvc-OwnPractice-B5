using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numberList = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var nQuery =
                from value in numberList
                where (value % 2) == 0
                select value;

            var lastElement = nQuery.ToList().Count-1;


            int count = 0;
            foreach (var value in nQuery)
            {
                Console.Write(value);
                if(lastElement != count)
                    Console.Write(", ");
                count++;
            }
            Console.WriteLine();
        }
    }
}
