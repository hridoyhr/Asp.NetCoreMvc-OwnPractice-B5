using System;
using System.Linq;
using System.Reflection;

namespace RefEx4
{
    class Program
    {
        static void Main(string[] args)
        {
            var types = Assembly.GetExecutingAssembly().GetTypes();

            foreach(var type in types)
            {
                if (type.GetInterfaces().Any(x => x.Name == "IStudent"))
                {
                    Console.WriteLine(type.GetProperties());
                }
            }
        }
    }
}
