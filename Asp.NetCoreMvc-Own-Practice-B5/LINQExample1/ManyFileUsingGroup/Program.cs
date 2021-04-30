using System;
using System.Linq;

namespace ManyFileUsingGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            //This program show one way to merge the contents of tw file &
            //then create a set of new file.
            string[] fileA = System.IO.File.ReadAllLines(@"../../../names1.txt");
            string[] fileB = System.IO.File.ReadAllLines(@"../../../names2.txt");

            var mergeQuery = fileA.Union(fileB);

            //Group the names by the first letter in the last name
            var groupQuery = from name in mergeQuery
                             let n = name.Split(',')
                             group name by n[0][0] into g
                             orderby g.Key
                             select g;

            //Create a new file for each group that was created
            //Note that nested foreach loop are requierd to access
            //individual items with each group
            foreach(var g in groupQuery)
            {
                //Create the new file name.
                string fileName = @"../../../testFile_" + g.Key + ".txt";
                //Output to display
                Console.WriteLine(g.Key);

                //write file
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(fileName))
                {
                    foreach(var item in g)
                    {
                        sw.WriteLine(item);
                        Console.WriteLine("{0}",item);
                    }
                }
            }
            Console.WriteLine("Files Have been written. press any key to exit");
        }
    }
}
