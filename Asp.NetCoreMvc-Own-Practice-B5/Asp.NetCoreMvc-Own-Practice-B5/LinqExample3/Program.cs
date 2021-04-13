using System;
using System.Linq;

namespace LinqExample3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arra1 = new int[] { 5, 9, 1, 2, 3, 7, 5, 3, 7, 6, 8, 5, 4, 9, 7 };

            int count = 0;
            var lastElement = arra1.ToList().Count - 1;
            Console.WriteLine("Array :");

            foreach(var print in arra1)
            {
                Console.Write( print);
                if(lastElement != count)
                    Console.Write(",");
                count++;

            }

            var n = from x in arra1
                    group x by x into y
                    select y;

            foreach(var arrNo in n)
            {
                Console.WriteLine("Number " + arrNo.Key + " appears " + arrNo.Count() + " times");
                Console.WriteLine("\n");
            }

            
            
        }
    }
}
