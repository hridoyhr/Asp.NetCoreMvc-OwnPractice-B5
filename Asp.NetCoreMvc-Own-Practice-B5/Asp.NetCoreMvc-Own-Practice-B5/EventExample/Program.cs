using System;

namespace EventExample
{
    class Program
    {
        public delegate void Message(string message);

        static void Main(string[] args)
        {
            Message print = Output;
            print("Hey I am Here");

        }

        public static void Output(string text)
        {
            Console.WriteLine(text);
        }

        
    }
}
