using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekdaysIndex
{
    class Weekdays
    {
        private string[] weekdays = new string[7] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

        public string this[int index]
        {
            get
            {
                if (index > weekdays.Length && index<0)
                    throw new IndexOutOfRangeException();
                return weekdays[index];
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Weekdays days = new Weekdays();

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"The {i+1}st day of the week is {days[i]}");
            }
        }
    }
}
