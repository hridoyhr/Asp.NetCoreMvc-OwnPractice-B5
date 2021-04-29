using System;

namespace SubString
{
    class Program
    {
        static void Main(string[] args)
        {
            String value = "This is a String";
            int startIndex = 10;
            int length = 5;

            String substring = value.Substring(startIndex, length);
            Console.WriteLine(substring);

            Trail obj = new Trail();
            
            obj.Sum(20,20);
        }
    }
}
