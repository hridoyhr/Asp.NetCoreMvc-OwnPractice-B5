using System;
using System.Collections.Generic;
using System.Linq;

namespace Example1
{
    class Program
    {
        static List<Student> students = new List<Student>
        {
            new Student {First="Mahmudul", Last="Hasan", ID=205, Scores= new List<int>{ 97,88,84,70} },
            new Student {First="Rony", Last="Fardin", ID=206, Scores= new List<int>{ 78, 84, 89,70} },
            new Student {First="Raju", Last="Rastogir", ID=208, Scores= new List<int>{ 88, 80,92,67} },
            new Student {First="Farhan", Last="Korish", ID=209, Scores= new List<int>{ 97, 87,79,80} },
            new Student {First="Anik", Last="Mahmud", ID=204, Scores=new List<int>{ 66,78,74,72} }
        };
        private static int averageScore;

        static void Main(string[] args)
        {
            #region Group By LINQ
            //var studentQuery1 =
            //    from student in students
            //    group student by student.Last[0];

            //foreach (var studentGroup in studentQuery1)
            //{
            //    Console.WriteLine(studentGroup.Key);
            //    foreach (Student student in studentGroup)
            //    {
            //        Console.WriteLine("{0} , {1}", student.First, student.Last);
            //    }
            //}
            #endregion

            #region Where LINQ QueryOne
            //write the same query and foreach loop much more conveniently by using var.
            //var studentQuery2 =
            //    from student in students
            //    where student.Scores[0] > 60
            //    select student;

            //foreach (var student in studentQuery2)
            //{
            //    Console.WriteLine("{0} , {1}", student.Last, student.First);
            //}

            #endregion

            #region Where Multiple Boolen Condition LINQ QueryTwo
            //IEnumerable<Student> studentQuery3 =
            //    from student in students
            //    where student.Scores[0] > 90 && student.Scores[3] < 80
            //    select student;

            //foreach (Student student in studentQuery3)
            //{
            //    Console.WriteLine("{0} , {1}", student.Scores[0], student.Scores[3]);
            //}
            #endregion

            #region OrderBy Ascending
            //IEnumerable<Student> studentQuery4 =
            //    from student in students
            //    orderby student.Scores[0] ascending
            //    select student;

            //foreach (Student student in studentQuery4)
            //{
            //    Console.WriteLine("{0} ", student.Scores[1]);
            //}

            //IEnumerable<Student> studentQuery5 =
            //    from student in students
            //    orderby student.First ascending
            //    select student;

            //foreach (Student student in studentQuery5)
            //{
            //    Console.WriteLine("{0}", student.First);
            //}

            //IEnumerable<Student> studentQuery6 =
            //    from student in students
            //    orderby student.Scores[0] descending
            //    select student;

            //foreach (Student student in studentQuery6)
            //{
            //    Console.WriteLine("{0} , {1} , {2}", student.Last, student.First, student.Scores[0]);
            //}
            #endregion

            #region Group Query
            //var studentQuery8 =
            //    from student in students
            //    group student by student.Last[0];

            //foreach (var studentGroup in studentQuery4)
            //{
            //    Console.WriteLine(studentGroup.Key);
            //    foreach (Student student in studentGroup)
            //    {
            //        Console.WriteLine("{0} , {1}", student.Last, student.First);
            //    }
            //}

            //var studentQuery5 =
            //    from student in students
            //    group student by student.Last[2];

            //foreach (var studentGroup in studentQuery5)
            //{
            //    Console.WriteLine(studentGroup.Key);
            //    foreach (Student student in studentGroup)
            //    {
            //        Console.WriteLine(" {0}, {1}", student.Last, student.First);
            //    }
            //}
            #endregion

            #region To order the groups by their "Let" key value
            //var studentQuery1 =
            //    from student in students
            //    group student by student.Last[0] into studentGroup
            //    orderby studentGroup.Key
            //    select studentGroup;

            //foreach (var groupOfStudents in studentQuery1)
            //{
            //    Console.WriteLine(groupOfStudents.Key);
            //    foreach (var student in groupOfStudents)
            //    {
            //        Console.WriteLine("{0} , {1}", student.Last, student.First);
            //    }
            //}
            #endregion


            #region Introduce an identifier by using let
            //var studentQuery =
            //    from student in students
            //    let totalScore = student.Scores[0] + student.Scores[1] +
            //        student.Scores[2] + student.Scores[3]
            //    where totalScore / 4 < student.Scores[0]
            //    select student.Last + " " + student.First;

            //foreach(string print in studentQuery)
            //{
            //    Console.WriteLine(print);
            //}
            #endregion

            #region User method syntax in a query expression
            //var studentQuery6 =
            //    from student in students
            //    let totalScore = student.Scores[0] + student.Scores[1] +
            //        student.Scores[2] + student.Scores[3]
            //    select totalScore;

            //double averageScore = studentQuery6.Average();
            //Console.WriteLine("Class average score: {0}", averageScore);
            #endregion

            #region Select Query
            //var studentQuery8 =
            //    from student in students
            //    let x = student.Scores[0] + student.Scores[1] +
            //            student.Scores[2] + student.Scores[3]
            //    where x > averageScore
            //    select new { id = student.ID, score = x };

            //foreach (var item in studentQuery8)
            //{
            //    Console.WriteLine("Student ID: {0}, Score: {1}", item.id, item.score);
            //}

            #endregion

            #region  Split the string into individual words to create a collection
            //string sentence = "the quick brown fox jums over the lazy dog";
            //string[] words = sentence.Split(' ');

            //var query =
            //    from word in words
            //    group word.ToUpper() by word.Length into gr
            //    orderby gr.Key
            //    select new { Length = gr.Key, Words = gr};

            ////using method-based query Syntax

            //var query2 = words.
            //    GroupBy(w => w.Length, w => w.ToUpper()).
            //    Select(g => new { Length = g.Key, Words = g }).
            //    OrderBy( o => o.Length );

            //foreach(var obj in query)
            //{
            //    Console.WriteLine("Word of length{0}: ", obj.Length);
            //    foreach(string word in obj.Words)
            //    {
            //        Console.WriteLine(word);
            //    }
            //}
            #endregion

            //Primary Sort Example
            #region Primary Assending Sort
            //string[] words = { "the", "what", "they", "Can", "do", "where"};

            //var query = from word in words
            //            orderby word.Length
            //            select word;

            //foreach(string str in query)
            //    Console.WriteLine(str);
            #endregion

            #region Primary Descending sory
            //string[] words = { "the", "comge", "go","greatefull","Enjoy"};

            //var query = from word in words
            //            orderby word.Substring(0, 1) descending
            //            select word;

            //foreach(string str in query)
            //    Console.WriteLine(str);
            #endregion

            #region Secondary Ascending sort
            //string[] words = { "the", "quick", "brown", "fox", "jumps"};

            //var query = from word in words
            //            orderby word.Length, word.Substring(0, 1)
            //            select word;

            //foreach(string str in query)
            //{
            //    Console.WriteLine(str);
            //}
            #endregion

            #region Secondary Decending Sort
            //string[] words = { "the", "quick", "brown", "fox", "jumps"};

            //var query = from word in words
            //            orderby word.Length, word.Substring(0, 1) descending
            //            select word;

            //foreach(var str in query)
            //    Console.WriteLine(str);
            #endregion

            //Set Operator In LINQ
            #region Distinct Remove duplicate value

            //string[] words = { "home", "keyboard", "to", "home", "to", "others"};

            //var query = from word in words.Distinct()
            //            orderby word.Length, word.Substring(0,1)
            //            select word;

            //foreach(var str in query)
            //    Console.WriteLine(str);
            #endregion

            #region Except the first input sequence that are not in the second input seqence
            //string[] Product1 = { "oil","potato", "shampo", "juice"};
            //string[] Product2 = { "oil","apple", "shampo", "juice"};

            //var query = from product in Product1.Except(Product2)
            //            select product;

            //foreach(var str in query)
            //    Console.WriteLine(str);
            #endregion

            #region Intersect the element that are to both input sequence
            //string[] planets1 = { "Mercury", "Venus", "Earth", "Jupiter" };
            //string[] planets2 = { "Mercury", "Earth", "Mars", "Jupiter" };

            //var query = from planet in planets1.Intersect(planets2)
            //            orderby planet.Length, planet.Substring(0,1)
            //            select planet;

            //foreach(var str in query)
            //    Console.WriteLine(str);

            #endregion

            #region Union unique elements from both input sequence
            //string[] planets1 = { "Mercury", "Venus", "Earth", "Jupiter" };
            //string[] planets2 = { "Mercury", "Earth", "Mars", "Jupiter" };

            //var query = from planet in planets1.Union(planets2)
            //            orderby planet.Length, planet.Substring(0, 1)
            //            select planet;

            //foreach(var str in query)
            //    Console.WriteLine(str);
            #endregion

            #region Filter From an Array
            string[] words = { "the", "up", "down", "on", "top", "fil"};

            var query = from word in words
                        where word.Length == 3
                        select word;

            foreach(var str in query)
                Console.WriteLine(str);
            #endregion

        }
    }
}
