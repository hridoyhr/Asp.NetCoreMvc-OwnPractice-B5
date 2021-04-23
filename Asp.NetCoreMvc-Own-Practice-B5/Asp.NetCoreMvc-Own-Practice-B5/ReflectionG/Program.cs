using System;
using System.Collections.Generic;
using System.Reflection;

namespace ReflectionG
{
    class Program
    {
        static void Main(string[] args)
        {

            GetDetails<Student>();
            
        }
        public static void GetDetails<T>() where T : class
        {
            List<Student> studentList = new List<Student>();

            
        }
    }
}
