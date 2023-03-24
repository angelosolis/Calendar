using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a year: ");
            int year = int.Parse(Console.ReadLine());
            for (int month = 1; month <= 12; month++)
            {
                PrintCalendarMonth(year, month);
                Console.WriteLine();
            }
        }

        static void PrintCalendarMonth(int year, int month)
        {
            DateTime firstDayOfMonth = new DateTime(year, month, 1);
            Console.WriteLine(firstDayOfMonth.ToString("MMMM"));
            Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");
            int dayOfWeek = (int)firstDayOfMonth.DayOfWeek;
            for (int i = 0; i < dayOfWeek; i++)
                Console.Write("    ");
            int daysInMonth = DateTime.DaysInMonth(year, month);
            for (int day = 1; day <= daysInMonth; day++)
            {
                Console.Write("{0,3} ", day);
                if ((day + dayOfWeek) % 7 == 0)
                    Console.WriteLine();
            }
        }
    }
}
