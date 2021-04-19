using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_1
{
    //Custom Attribute
    [AttributeUsage(
        AttributeTargets.Class |
        AttributeTargets.Constructor |
        AttributeTargets.Field |
        AttributeTargets.Method |
        AttributeTargets.Property,
        AllowMultiple = true)]

    public class DeBugInfo : System.Attribute
    {
        private int bugNo;
        private string Developer;
        private string lastReview;
        public string Messege;

        public DeBugInfo(int bg, string dev, string d)
        {
            this.bugNo = bg;
            this.Developer = dev;
            this.lastReview = d;
        }

        public int BugNo
        {
            get
            {
                return bugNo;
            }
        }

        public string Developers
        {
            get
            {
                return Developer;
            }
        }

        public string LastReview
        {
            get
            {
                return lastReview;
            }
        }

        public string Messages
        {
            get
            {
                return Messege;
            }
            set
            {
                Messege = value;
            }
        }
    }

    [DeBugInfo(45, "Hridoy", "12-04-2020", Messages = "Return type mismatch")]
    [DeBugInfo(34, "hasan", "12-04-2021", Messages = "Un Used variable")]

    class Rectangle
    {
        //member varibale
        protected double length;
        protected double width;

        public Rectangle(double l , double w)
        {
            length = l;
            width = w;
        }

        [DeBugInfo(55, "Rakib", "18-04-21", Messages ="Retrun type missmatch")]
        
        public double GetArea()
        {
            return length * width;
        }
        [DeBugInfo(56, "Zara ALif", "19-04-2021")]
        
        public void Display()
        {
            Console.WriteLine($"Length: {length}");
            Console.WriteLine($"Width: {width}");
            Console.WriteLine($"Area: {GetArea()}");
        }
        //End rectangle class

    }
}
