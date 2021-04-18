using System;

namespace DelExample2
{
    class Program
    {
        public delegate void studentInfo(int ID, string Name);
        
        static void Main(string[] args)
        {
            StudentPrinter studentPrinter = new StudentPrinter();

            studentPrinter.BBAstudent(205, "Hasan");
            studentPrinter.CSEstudent(342, "Rakib");

            studentInfo student = anotherPattern;
            student(444, "isamil");
        }

        public static void anotherPattern(int id, string name)
        {
            Console.WriteLine($"I am {name}, my id is {id}");
        }

        
    }
}
