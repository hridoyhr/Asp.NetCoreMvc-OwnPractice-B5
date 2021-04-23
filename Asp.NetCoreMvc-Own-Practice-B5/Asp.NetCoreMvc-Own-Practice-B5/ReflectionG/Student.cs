using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionG
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }

        public Info info { get; set; }
    }

    public class Info
    {
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
    }
}
