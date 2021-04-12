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
            new Student {First ="Fahmida", Last="Akther", ID =206, Scores = new List<int> { 99, 98, 78, 84} },
            new Student {First ="Mustazwir", Last= "Zaif", ID =207, Scores = new List<int> { 85, 89, 75, 66} },
            new Student {First ="Keioum", Last= "Miah", ID =245, Scores = new List<int> { 90, 94, 45, 76}}
        };
        static void Main(string[] args)
        {
            IEnumerable<Student> studentQuery =
                from student in students
                where student.Scores[0] > 90
                select student;

            foreach(Student student in studentQuery)
            {
                Console.WriteLine("{0}, {1}, {2}", student.First, student.Last, student.ID);
            }
        }
    }
}
