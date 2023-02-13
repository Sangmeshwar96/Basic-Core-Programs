using System;

namespace LargestNumber
{
    class LargestNumber
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Three Numbers :");
            int num1, num2, num3;
            num1 = Int32.Parse(Console.ReadLine());
            num2 = Int32.Parse(Console.ReadLine());
            num3 = Int32.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write("The 1st Number is the Largest among three. \n\n");
                }
                else
                {
                    Console.Write("The 3rd Number is the Largest among three. \n\n");
                }
            }
            else if (num2 > num3)
            {
                Console.Write("The 2nd Number is the Largest among three \n\n");
            }
            else
            {
                Console.Write("The 3rd Number is the Largest among three \n\n");
            }
            Console.ReadLine();
        }
    }
}