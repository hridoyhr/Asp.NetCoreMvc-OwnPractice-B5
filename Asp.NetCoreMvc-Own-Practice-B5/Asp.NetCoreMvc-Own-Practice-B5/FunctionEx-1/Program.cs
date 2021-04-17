using System;
using System.Collections;
using System.Collections.Generic;

namespace FunctionEx_1
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> xs = OddSequence(76, 7);
            Console.WriteLine("Retrived enumerat0");

            foreach(var x in xs)
            {
                Console.Write($"{x}");
            }
        }

        public static IEnumerable<int> OddSequence (int start, int end)
        {
            if (start < 0 || start > 99)
                throw new ArgumentOutOfRangeException(nameof(start), "Start must be between 0 and 99");
            if (end >= 100)
                throw new ArgumentOutOfRangeException(nameof(end), "end must be less then or equal to 100");
            if (start >= end)
                throw new ArgumentException("start must be less then to end");

            for(int i = start; i <= end; i++)
            {
                if (i % 2 == 0)
                    yield return i;
            }
        }
    }
}
