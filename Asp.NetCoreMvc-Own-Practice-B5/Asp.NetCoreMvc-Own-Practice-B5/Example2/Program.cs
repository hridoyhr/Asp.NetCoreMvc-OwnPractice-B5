﻿using System;
using System.Reflection;

namespace Example2
{
    class Program
    {
        static void Main(string[] args)
        {
            var types = Assembly.GetExecutingAssembly().GetTypes();

            foreach(var type in types)
            {
                Console.WriteLine(type.FullName);
            }


        }
    }
}