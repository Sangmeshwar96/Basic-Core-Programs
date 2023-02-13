using System;

namespace EvenAndOdd
{
    class EvenAndOdd
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("--Welcome To Even Or Odd Number Program--");
            Console.WriteLine("Enter a Number to find it is Even or Odd : ");
            int num = Int32.Parse(Console.ReadLine());
            int rem;
            rem = num % 2;
            if (rem == 0)
            {
                Console.WriteLine("{0} Entered Number is Even", num);
            }
            else
            {
                Console.WriteLine("{0} Entered Number is odd", num);
            }
            Console.ReadLine();
        }
    }
}