using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayPorb_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int testCase = int.Parse(Console.ReadLine());
            //var list = new List<int>();
            //for (int i = 0; i < testCase; i++)
            //{
            //    int temp = int.Parse(Console.ReadLine());
            //    list.Add(temp);
            //}

            //string[] cars = { "volvo", "audi", "mazda", "ferrari" };
            //cars[0] = "lamborghini";
            //Array.Reverse(cars);
            //Array.Sort(cars);
            //foreach (var print in cars)
            //    Console.WriteLine(print);

            //int[] mynumber = { 1, 3, 4, 3, 78, 56 };

            //Console.WriteLine(mynumber.Max());
            //Console.WriteLine(mynumber.Min());
            //Console.WriteLine(mynumber.Sum());

            int[] num = { 1, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            foreach(var i in num)
                Console.WriteLine(num[i]);
            

            
            
        }
    }
}
