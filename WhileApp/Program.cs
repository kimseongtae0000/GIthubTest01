namespace WhileApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int sum1 = 0;
            int sum2 = 0;
         
            while(i<=100)
            {
                if (i % 2 == 0)
                {
                    sum1 = sum1 + i;
                }
                else
                {
                    sum2 = sum2 + i;
                }
                i++;
            }

            Console.WriteLine(sum2);
            Console.WriteLine(sum1);
        }
    }
}