using System;

namespace DelExample1
{
    class Program
    {
        delegate void Perform(string text);

        static void Main(string[] args)
        {
            var printer = new PrintFormat();

            var logic =new Perform(printer.Print1);
            var logic2 = new Perform(printer.Print2);

            var logic3 = logic + logic2;

            var text = "my message";
            ProcessText(text, logic3);

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
