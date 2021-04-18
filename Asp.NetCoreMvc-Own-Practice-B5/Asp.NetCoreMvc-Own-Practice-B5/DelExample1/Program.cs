using System;

namespace DelExample1
{
    class Program
    {
        delegate void Perform(string text);

        static void Main(string[] args)
        {
            var logic =new Perform(PrintMethod);
            var text = "my message";
            ProcessText(text, logic);

        }

        public static void PrintMethod(string textToPrint)
        {
            Console.WriteLine($"---{textToPrint}:::--");
        }

        static void ProcessText(string text, Perform perform)
        {
            if(!string.IsNullOrWhiteSpace(text))
            {
                perform(text);
            }
        }
    }
}
