using LINQ;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExample
{
    class Program
    {
        //Create a data source by using a collection initializer.
        static List<Student> students = new List<Student>
        {
            new Student {First ="Mahmudul", Last ="Hridy", ID =205, Scores = new List<int> { 97, 98, 76, 70} },
            new Student {First ="Fahmida", Last="Akther", ID =206, Scores = new List<int> { 63, 60, 78, 84} },
            new Student {First ="Mustazwir", Last= "Zaif", ID =207, Scores = new List<int> { 85, 89, 75, 66} },
            new Student {First ="Keioum", Last= "Miah", ID =245, Scores = new List<int> { 90, 94, 45, 76}}
        };
        static void Main(string[] args)
        {
            //Student Query2 is an IEnumerable

            //IEnumerable<IGrouping<char, Student>>
                var studentQuery2 =
                from student in students
                group student by student.Last[0];

            foreach(var studentGroup in studentQuery2)
            {
                Console.WriteLine(studentGroup.Key);
                foreach(Student student in studentGroup)
                {
                    Console.WriteLine("  {0}, {1}", student.First, student.Last);
                }
            }
        }
    }
}
