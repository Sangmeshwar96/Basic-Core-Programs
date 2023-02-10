using System;

namespace Leap_year_Program
{
    class Leap_year
    {
        public static void Main(string[] args)
        {
            int year;
            Console.WriteLine("Enter The Year : ");
            year = Convert.ToInt32(Console.ReadLine());
            if (((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0)))
            {
                Console.WriteLine("The year " + year + " is a leap year.");
            }
            else
            {
                Console.WriteLine("The year " + year + " is not a leap year.");
            }
            Console.ReadLine();
        }
    }
}


