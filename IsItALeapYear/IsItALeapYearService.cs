using System;

namespace IsItALeapYear.Services
{
    public class IsItALeapYearService
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Leap Year");
        }
        public bool IsItALeapYear(int year)
        {
            if (year % 400 == 0)
            {
                return true;
            }
            else
            {
                return year % 100 != 0 && year % 4 == 0;
            }
        }
    }
}
