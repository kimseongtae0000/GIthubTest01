using System;

namespace RandomApp01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[7];
            Random random = new Random();

            for (int i = 0; i < 7; i++)
            {
                numbers[i] = random.Next(1, 46);
                //전수조사
                for (int j = 0; j < i; j++)
                {
                    if(numbers[j] == numbers[i])
                    {
                        i--;
                        break;
                    }
                }
            }
            int bonusNumber = numbers[6];
            int[] lottoNumbers = new int[6];
            Array.Copy(numbers, 0, lottoNumbers, 0, 6);

            Array.Sort(lottoNumbers);
            foreach (int i in lottoNumbers)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"보너스 번호 {bonusNumber}");
        }
    }
}
