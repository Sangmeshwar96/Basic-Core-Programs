using System;

namespace SwapNumber
{
    class SwapNumbers
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("Enter Two Numbers To Swap a and b");
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Before swap a= " + a + " b= " + b);
            a = a * b;     
            b = a / b;      
            a = a / b;
            Console.Write("After swap a= " + a + " b= " + b);
        }
    }
}