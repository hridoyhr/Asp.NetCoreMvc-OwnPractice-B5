using System;
using System.Linq;
using System.Reflection;

namespace Example_3_R
{
    class Program
    {
        static void Main(string[] args)
        {
            var types = Assembly.GetExecutingAssembly().GetTypes();

            Console.WriteLine("Please choose a game item::\n");

            foreach (var type in types)
            {
                if (type.GetInterfaces().Any(x => x.Name == "IDepartmen"))
                    Console.WriteLine(type.Name);
            }

            while (true)
            {
                var input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                    break;

                var item = new DepartmentFactory().CreateItem(input);

                item.PrintMe();
            }
        }
    }
}
