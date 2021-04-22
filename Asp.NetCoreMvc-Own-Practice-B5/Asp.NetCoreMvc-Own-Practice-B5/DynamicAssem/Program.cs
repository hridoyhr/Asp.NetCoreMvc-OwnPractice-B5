using System;
using System.Reflection;

namespace DynamicAssem
{
    class Program
    {
        static void Main(string[] args)
        {
 
            try
            {
                string info = @"System.windows," + "Version=4.4.4.0," + "PublicKey=B555c4H4,"
                + "Culture=";
                Assembly asm = Assembly.Load(info);
                DisplayAssembly(asm);
            }
            catch
            {
                Console.WriteLine("Can't load Assembly");
            }
            Console.ReadKey();
        }

        static void DisplayAssembly(Assembly a)
        {
            //Console.WriteLine("Content is Assembly");
            //Console.WriteLine("Information: {0}", a.FullName);

            //Type[] asm = a.GetTypes();

            //foreach(Type type in asm)
            //{
            //    Console.WriteLine("Type : {0}",type);
            //}

            Console.WriteLine("Name : {0}", a.GetName().Name);
            Console.WriteLine("Version : {0}", a.GetName().Version);
            Console.WriteLine("Culture : {0}", a.GetName().CultureInfo.DisplayName);
            Console.WriteLine("Loaded From GAC : {0}", a.GlobalAssemblyCache);
        }
    }
}
