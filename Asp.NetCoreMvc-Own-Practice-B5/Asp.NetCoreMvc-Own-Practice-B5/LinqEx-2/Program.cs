using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqEx_2
{
    class Program
    {
        static List<Student> students = new List<Student>
        {

            new Student {First="Svetlana", Last="Omelchenko", ID=111, Scores= new List<int> {97, 92, 81,
            60}},
            new Student {First="Claire", Last="O'Donnell", ID=112, Scores= new List<int> {75, 84, 91, 39}},
            new Student {First="Sven", Last="Mortensen", ID=113, Scores= new List<int> {88, 94, 65, 91}},
            new Student {First="Cesar", Last="Garcia", ID=114, Scores= new List<int> {97, 89, 85, 82}},
            new Student {First="Debra", Last="Garcia", ID=115, Scores= new List<int> {35, 72, 91, 70}},
            new Student {First="Fadi", Last="Fakhouri", ID=116, Scores= new List<int> {99, 86, 90, 94}},
            new Student {First="Hanying", Last="Feng", ID=117, Scores= new List<int> {93, 92, 80, 87}},
            new Student {First="Hugo", Last="Garcia", ID=118, Scores= new List<int> {92, 90, 83, 78}},
            new Student {First="Lance", Last="Tucker", ID=119, Scores= new List<int> {68, 79, 88, 92}},
            new Student {First="Terry", Last="Adams", ID=120, Scores= new List<int> {99, 82, 81, 79}},
            new Student {First="Eugene", Last="Zabokritski", ID=121, Scores= new List<int> {96, 85, 91, 60}},
            new Student {First="Michael", Last="Tucker", ID=122, Scores= new List<int> {94, 92, 91, 91}}

        };
        static void Main(string[] args)
        {
            #region Where Clasues
            //IEnumerable<Student> studentQuery =
            //    from student in students
            //    where student.Scores[0] > 90
            //    select student;

            //foreach (Student student1 in studentQuery)
            //{
            //    Console.WriteLine("{0}, {1}", student1.First, student1.Last);
            //}
            #endregion

            #region Where Clause Multiple query
            //var studenQuery2 =
            //    from student in students
            //    where student.Scores[0] > 90 && student.Scores[3] < 80
            //    select student;

            //foreach(Student student2 in studenQuery2)
            //{
            //    Console.WriteLine("{0}", student2.Last);
            //}
            #endregion

            #region Modify the Query "OrderBY"
            //var studentQuery3 =
            //    from student in students
            //    orderby student.Last descending
            //    select student;

            //foreach(Student student1 in studentQuery3)
            //{
            //    //Console.WriteLine("{0}", student1.Last);
            //    Console.WriteLine("{0} , {1}, {2}", student1.Last, student1.First, student1.Scores[0]);
            //}
            #endregion

            #region Group Query
            //var studentQuery4 =
            //    from student in students
            //    group student by student.Last[0];

            //foreach(var studentGroup in studentQuery4)
            //{
            //    Console.WriteLine(studentGroup.Key);
            //    foreach(Student student in studentGroup)
            //    {
            //        Console.WriteLine("{0},{1}", student.Last, student.First);
            //    }
            //}
            #endregion

            #region Order the groups by their key value
            var studentQuery5 =
                from student in students
                group student by student.Last[0] into studentGroup
                orderby studentGroup.Key
                select studentGroup;

            foreach(var groupOFStudent in studentQuery5)
            {
                Console.WriteLine(groupOFStudent.Key);
                foreach(var student in groupOFStudent)
                {
                    Console.WriteLine("{0} {1}", student.Last, student.First);
                }
            }
            #endregion
        }
    }
}
