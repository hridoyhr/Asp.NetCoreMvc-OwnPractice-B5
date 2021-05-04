using System;

namespace ArrayProb_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[6];

            for(int i = 0; i < 6; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            int a = 0;
            for(int i =0; i < 6; i++)
            {
                a += 10;
                arr[i] = a;
            }

            foreach (int i in arr)
                Console.Write(i + " ");
        }
    }
}
