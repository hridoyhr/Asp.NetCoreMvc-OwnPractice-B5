using System;

namespace FunActionEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, bool> checkPrimeNumber = X =>
            {
                bool isPrime = false;
                int i;
                for (i = 2; i <= X - 1; i++)
                {
                    if (X % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (i == X)
                {
                    isPrime = true;
                }
                return isPrime;
            };

            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());

            bool isPrimeNumber = checkPrimeNumber(number);
            Console.WriteLine($"{number} is {(isPrimeNumber ? ""  : "not")} prime number");
           
        }
    }
}
