using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    public class Wicket : IGameItem
    {
        public void PrintMe()
        {
            Console.WriteLine("I am Wicket!!");
        }
    }
}
