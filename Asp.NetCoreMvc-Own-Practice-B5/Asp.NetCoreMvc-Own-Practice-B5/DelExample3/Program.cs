using System;

namespace DelExample3
{
    class Program
    {
        public delegate bool my_Deligate(string myString);

        static void Main(string[] args)
        {
            my_Deligate my_Deligate = myFunction;

            Console.WriteLine(my_Deligate("Mah"));
        }

        public static bool myFunction(string mystring)
        {
            if (mystring.Length < 7)
            {
                return true;
            }
            else
            {
                return false;
            }
                
        }
    }
}
