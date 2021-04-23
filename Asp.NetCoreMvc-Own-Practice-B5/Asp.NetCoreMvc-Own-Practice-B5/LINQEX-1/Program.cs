using System;
using System.Linq;

namespace LINQEX_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "hello", "beautifull", "like", "some"};

            var shortWord = from word in words
                            where word.Length <= 5
                            select word;

            foreach(var word in shortWord)
                Console.WriteLine(word);
        }
    }
}
