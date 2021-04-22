using System;
using System.Reflection;

namespace RefEx5
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime dateTime = (DateTime)Activator.CreateInstance(typeof(DateTime));
            //Console.WriteLine(dateTime);

            Type type = Type.GetType("RefEx5");

            MethodInfo[] methodInfos = type.GetMethods();

            int i = 0;

            foreach(MethodInfo mi in methodInfos)
            {
                i++;
                Console.WriteLine("Method[{0}] = {1}", i, mi.Name);
            }
        }

    }
}
