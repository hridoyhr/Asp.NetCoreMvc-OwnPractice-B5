using System;

namespace DeligateSum
{
    class Program
    {
        public delegate int operation(int x, int y);

        static void Main(string[] args)
        {
            operation obj = new operation(Program.Addition);

            Console.WriteLine("Additon = {0}", obj(20, 20));
        }

        static int Addition(int a, int b)
        {
            return a + b;
        }
    }
}
