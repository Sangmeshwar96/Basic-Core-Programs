namespace PowerOf2
{
    class Program
    {
        public static void Main(string[] args)
        {
            int value = 2;
            for (int i = 0; i <= 31; i++)
            {
                Console.WriteLine($"{value}^{i} = {(long)Math.Pow(value, i):N0}");
            }
        }
    }
}