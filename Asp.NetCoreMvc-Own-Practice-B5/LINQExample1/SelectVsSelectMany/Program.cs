using System;
using System.Collections.Generic;
using System.Linq;

namespace SelectVsSelectMany
{
    class Program
    {
        static List<Flower> flowers = new List<Flower>()
        {
            new Flower { Flowers = new List<string> { "Sunflower", "Daisy", "daffodil", "larkspur"} },
            new Flower { Flowers = new List<string> { "tulipe", "rose", "orchid"} },
            new Flower { Flowers = new List<string> { "gladiolis", "lily", "snapdragon", "aster", "protea"} },
            new Flower { Flowers = new List<string> { "larkspur", "lilac", "irish", "dalia"} }
        };
        static void Main(string[] args)
        {
            //select
            var query1 = flowers.Select(bq => bq.Flowers);

            //select many
            var query2 = flowers.SelectMany(bq => bq.Flowers);

            Console.WriteLine("Result by using Select() : \n");

            
            foreach(var collection in query1)
            {
                foreach(var item in collection)
                    Console.WriteLine(item);
            }
            

            Console.WriteLine("\nResult by using Selectmany() : \n");
            foreach(var item in query2)
                Console.WriteLine(item);
        }
    }
}
