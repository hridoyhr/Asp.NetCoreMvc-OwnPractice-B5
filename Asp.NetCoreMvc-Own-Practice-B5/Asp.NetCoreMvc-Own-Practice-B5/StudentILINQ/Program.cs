using StudentsILINQ;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentILINQ
{
    class Program
    {
        static List<Students> students = new List<Students>
        {
            new Students {First="Hridoy", Last="Hasan", ID = 111, Scores = { 75, 84, 91, 81} },
            new Students {First="Claire", Last="O'Donnell", ID=112, Scores= new List<int> {75, 84, 91, 39}},
            new Students {First="Sven", Last="Mortensen", ID=113, Scores= new List<int> {88, 94, 65, 91}},
            new Students {First="Cesar", Last="Garcia", ID=114, Scores= new List<int> {97, 89, 85, 82}},
            new Students {First="Debra", Last="Garcia", ID=115, Scores= new List<int> {35, 72, 91, 70}},
            new Students {First="Fadi", Last="Fakhouri", ID=116, Scores= new List<int> {99, 86, 90, 94}},
            new Students {First="Hanying", Last="Feng", ID=117, Scores= new List<int> {93, 92, 80, 87}},
            new Students {First="Hugo", Last="Garcia", ID=118, Scores= new List<int> {92, 90, 83, 78}},
            new Students {First="Lance", Last="Tucker", ID=119, Scores= new List<int> {68, 79, 88, 92}},
            new Students {First="Terry", Last="Adams", ID=120, Scores= new List<int> {99, 82, 81, 79}},
            new Students {First="Eugene", Last="Zabokritski", ID=121, Scores= new List<int> {96, 85, 91, 60} }
        };
        static void Main(string[] args)
        {
            var studentQuery1 =
                from student in students
                group student by student.Last[0];

            foreach(Students students in studentQuery1)
            {
                Console.WriteLine("{0} , {1}", students.First, students.Last);
            }
        }
    }
}
