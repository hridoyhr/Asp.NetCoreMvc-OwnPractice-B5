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

            foreach(var type in types)
            {
                if (type.GetInterfaces().Any(x => x.Name == "IGameItem"))
                    Console.WriteLine(type.Name);
            }


        }
    }
}
