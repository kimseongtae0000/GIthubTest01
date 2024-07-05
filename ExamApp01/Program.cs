using System.Diagnostics.Metrics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ExamApp01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("﻿첫 번째 숫자를 입력하세요 : ");
            int number1 = Int32.Parse(Console.ReadLine());

            Console.Write("﻿연산자 (+, -, *, /)를 입력하세요 : ");
            string modify = Console.ReadLine();

            Console.Write("﻿두 번째 숫자를 입력하세요 : ");
            int number2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine(number1 modify number2);
        }
    }
}
