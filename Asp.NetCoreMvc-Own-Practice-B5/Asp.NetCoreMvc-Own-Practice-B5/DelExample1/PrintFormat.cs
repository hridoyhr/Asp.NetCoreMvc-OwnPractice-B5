using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelExample1
{
    public class PrintFormat
    {
        public void Print1(string text)
        {
            Console.WriteLine($"----{text}----");
        }

        public void Print2(string text)
        {
            Console.WriteLine($"---@@@@-{text}--@@@@--");
        }
    }
}
