using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    public class Ball : IGameItem
    {
        public void PrintMe()
        {
            Console.WriteLine("I am a Ball..");
        }
    }
}
