using System;
using System.Threading;

namespace ThreadsEx1
{
    class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();
            var thread1 = new Thread(new ThreadStart(WriteFile));
            var thread2 = new Thread(new ThreadStart(WriteFile));

            thread1.Start();
            thread2.Start();

        }

        static void PrintNumber2()
        {
            for(var i = 0; i < 100; i += 2)
            {
                Console.WriteLine($"Number: {i}");
                Thread.Sleep(500);
            }
        }

        static void PrintNumber()
        {
            for(var i = 1; i < 100; i += 2)
            {
                Console.WriteLine($"Number: {i}");
                Thread.Sleep(500);
            }
        }

        public static void WriteFile()
        {
            var path = @"C:\Training\aspnet-b5\Console\CSharp-Features\Threads\File.txt";
            lock (path)
            {
                File.WriteAllText(path, "Hello");
            }
        }
    }
}
