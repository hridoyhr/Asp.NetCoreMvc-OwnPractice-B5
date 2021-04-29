using System;
using System.Collections.Generic;
using System.Linq;

namespace GroupingData
{
    class Program
    {
        static void Main(string[] args)
        {
            #region GroupBy Even and Odd number
            List<int> numbers = new List<int>() { 5,3,43,63,44,85,96,102};

            var query = from number in numbers
                        group number by number % 2;

            foreach(var group in query)
            {
                Console.WriteLine(group.Key == 0 ? "\nEven numbers: " : "\nOdd Numbers:");
                foreach(var i in group)
                {
                    Console.WriteLine(i);
                }
            }
            #endregion
        }
    }
}
