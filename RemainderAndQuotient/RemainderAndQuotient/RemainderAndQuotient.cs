using System;

namespace RemainderAndQuotient
{
    class RemainderAndQuotient
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Dividend and Divisor value For Quotient and Remainder ");
            int dividend = Int32.Parse(Console.ReadLine());
            int divisor = Int32.Parse(Console.ReadLine());
            int quotient = dividend / divisor;
            int remainder = dividend % divisor;
            Console.WriteLine("Dividend : " + dividend);
            Console.WriteLine("Divisor :" + divisor);
            Console.WriteLine("Quotinet = " + quotient);
            Console.WriteLine("Remaider = " + remainder);
        }
    }
}