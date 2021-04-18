using System;

namespace DelExample1
{
    class Program
    {
        delegate void Perform(string text);

        static void Main(string[] args)
        {

            var text = "my message";
            ProcessText(text);

        }

        static void PrintMethod(string textPoint)
        {
            Console.WriteLine($"--{textPoint}---");
        }
        

        static void ProcessText(string text)
        {
            if(!string.IsNullOrWhiteSpace(text))
            {
                Console.WriteLine(text);
            }
        }
    }
}
