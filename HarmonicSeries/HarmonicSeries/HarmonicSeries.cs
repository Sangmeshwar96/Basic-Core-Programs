using System;

namespace HarmonicSeries
{
    class HarmonicSeries
    {
        static void Main(string[] args)
        {
            int n;
            float sum = 0;
            Console.Clear();
            Console.WriteLine("Enter the value of n: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("1/" + i + " +");
                sum = sum + (float)1 / i;
            }
            Console.WriteLine("Sum of Harmonic Series is: " + sum);
            Console.ReadLine();
        }
    }
}