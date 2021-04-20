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

                var userSelection = Type.GetType("Example2." + input);
                var constructor = userSelection.GetConstructor(new Type[] { });
                var item = (IGameItem)constructor.Invoke(new object[] { });

                item.PrintMe();
            }
        }
    }
}
