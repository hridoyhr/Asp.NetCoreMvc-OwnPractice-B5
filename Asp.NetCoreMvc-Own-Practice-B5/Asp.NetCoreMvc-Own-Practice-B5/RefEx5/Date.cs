using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefEx5
{
    public class Date
    {
        int number;
        int month;
        int year;

        public int GetNumber() { return number; }
        public int GetMonth() { return month; }
        public int GetYear() { return year; }

        public void SetNumber(int number) { this.number = number; }
        public void GetMonth(int month) { this.month = month; }
        public void GetYear(int year) { this.year = year; }
    }
}
