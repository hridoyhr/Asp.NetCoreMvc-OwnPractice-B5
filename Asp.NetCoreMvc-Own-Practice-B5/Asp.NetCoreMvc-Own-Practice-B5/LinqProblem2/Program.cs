using System;
using System.Linq;

namespace LINQProblem2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 9, 8, 6, 5, 4, 3};

            var arrayQuery =
                from int Number in array
                let SqrNo = Number * Number
                where SqrNo > 20
                select new { Number, SqrNo };

            foreach (var a in arrayQuery)
            {
                Console.WriteLine(a);
            }

            Console.ReadLine();

        }
    }
}
