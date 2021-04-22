using System;
using System.Linq;
using System.Reflection;

namespace RefEx_4
{
    class Program
    {
        static void Main(string[] args)
         {
            var types = Assembly.GetExecutingAssembly().GetTypes();

            Console.WriteLine("Please Choose your item\n");

            foreach (var type in types)
            {
                if (type.GetInterfaces().Any(x => x.Name == "IProduct"))
                    Console.WriteLine(type.Name);
            }

            while(true)
            {
                var input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                    break;

                var item = new ProductFactory().CreateItem(input);

                item.PrintMe();
            }
        }
    }
}
