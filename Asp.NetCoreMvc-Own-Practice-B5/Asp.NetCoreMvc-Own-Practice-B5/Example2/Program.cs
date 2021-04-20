using System;
using System.Reflection;
using System.Linq;

namespace Example2
{
    class Program
    {
        static void Main(string[] args)
        {
            var types = Assembly.GetExecutingAssembly().GetTypes();

            Console.WriteLine("Please choose a game item::\n");
            foreach(var type in types)
            {
                if (type.GetInterfaces().Any(x => x.Name == "IGameItem"))
                    Console.WriteLine(type.Name);
            }

            while (true)
            {
                var input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                    break;

                var item = new GameItemFactory().CreateItem(input);

                item.PrintMe();
            }
        }
    }
}
