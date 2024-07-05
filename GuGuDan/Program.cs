namespace GuGuDan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N = ");
            int t = Int32.Parse(Console.ReadLine());
            for (int i = 1; i <= t; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = t-i; j >= 0; j--)
                {
                    Console.Write("*");
                }
                    Console.WriteLine();
            }
        }
    }
}