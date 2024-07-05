using System;

namespace CToF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("반지름 값을 입력해 주세요 : ");
            double radius = Int32.Parse(Console.ReadLine());
            
            double area = Math.PI * radius * radius;

            Console.WriteLine($"{area:F2}");
        }
    }
}
