using System;
using System.Collections.Generic;
using System.Linq;

namespace PopulateObjCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            //This program show how to merge data from different source into a sequence of new types.
            //disimilar LINQ

            //Each line of  names.csv consists of last name,first name and
            //an ID number, separated by commas. For example
            string[] names = System.IO.File.ReadAllLines(@"../../../names.csv");

            //Each line  of scores.csv consits of an ID number and four test
            string[] scores = System.IO.File.ReadAllLines(@"../../../scores.csv");

            //Merge the data sources using a named type.
            var queryNamesScores =
                from nameLine in names
                let splitName = nameLine.Split(',')
                from scoreLine in scores
                let splitScoreLine = scoreLine.Split(',')
                where Convert.ToInt32(splitName[2]) == Convert.ToInt32(splitScoreLine[0])
                select new Student()
                {
                    FirstName = splitName[0],
                    LastName = splitScoreLine[1],
                    ID = Convert.ToInt32(splitName[2]),
                    ExamScores = (from scoreAsText in splitScoreLine.Skip(1)
                                  select Convert.ToInt32(scoreAsText)).
                                  ToList()
                };

            List<Student> students = queryNamesScores.ToList();

            //Display each sutdent name and exam score average.
            foreach(var student in students)
            {
                Console.WriteLine("The average score {0} {1} is {2}.",
                    student.FirstName, student.LastName,
                    student.ExamScores.Average());
            }
            Console.WriteLine("Press any key to exit");
        }
    }
}
