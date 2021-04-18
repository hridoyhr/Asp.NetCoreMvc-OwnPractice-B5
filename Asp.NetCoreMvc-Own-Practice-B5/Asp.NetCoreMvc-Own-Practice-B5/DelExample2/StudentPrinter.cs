using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelExample2
{
    public class StudentPrinter
    {
        public void BBAstudent(int id, string name)
        {
            Console.WriteLine($"----Id {id}----Name---{name}---");
        }

        public void CSEstudent(int id, string name)
        {
            Console.WriteLine($"---@@@@-{id}--@@@@ Name @@@{name}--");
        }

    }
}
