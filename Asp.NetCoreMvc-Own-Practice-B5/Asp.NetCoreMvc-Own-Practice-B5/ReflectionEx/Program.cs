using System;

namespace ReflectionEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Type info = typeof(string);

            Console.WriteLine($"Name = {info.Name}");
            Console.WriteLine($"Full Name = {info.FullName}");
            Console.WriteLine($"Namespace = {info.Namespace}");
            Console.WriteLine($"Base type = {info.BaseType}");

        }
    }
}
