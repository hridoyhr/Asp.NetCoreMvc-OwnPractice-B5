using System;
using System.Reflection;

namespace ReflectionEx
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 42;
            Type type = i.GetType();
            Console.WriteLine($"{type}\n");

            Assembly info = typeof(int).Assembly;
            Console.WriteLine($"{info}\n");

            TimeZoneInfo local = TimeZoneInfo.Local;
            Console.WriteLine($"{local}\n");

            DateTime dateTime = DateTime.Now;
            Console.WriteLine($"{dateTime}\n");

            string s = "Hasan";
            Type type1 = s.GetType();
            Console.WriteLine($"{type1}\n");
        }
    }
}
