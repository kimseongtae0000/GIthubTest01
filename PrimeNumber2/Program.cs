﻿namespace PrimeNumber2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cnt = 0;
            for (int i = 2; i <= 100; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        cnt++;
                        break;
                    }
                }
                if (cnt == 0)
                {
                    Console.WriteLine(i);
                }
                cnt = 0;
            }
        }
    }
}
