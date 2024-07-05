namespace Quiz03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("﻿첫 번째 숫자를 입력하세요 : ");
                int value1 = Int32.Parse(Console.ReadLine());

                Console.Write("﻿연산자 (+, -, *, /)를 입력하세요 : ");
                string op = Console.ReadLine();

                Console.Write("﻿두 번째 숫자를 입력하세요 : ");
                int value2 = Int32.Parse(Console.ReadLine());

                if (op == "+")
                {
                    Console.WriteLine(value1 + value2);
                }
                else if (op == "-")
                {
                    Console.WriteLine(value1 - value2);
                }
                else if (op == "*")
                {
                    Console.WriteLine(value1 * value2);
                }
                else if (op == "/")
                {
                    Console.WriteLine((double)value1 / value2);
                }
                while (true)
                {
                    Console.Write("계산을 계속하시겠습니까? (y/n) : ");
                    string answer = Console.ReadLine();
                    if (answer.ToLower() == "n")
                    {
                        Console.WriteLine("계산을 종료합니다.");
                        break;
                    }
                    else
                    {
                        if (answer.ToLower() == "y")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("단어를 다시 확인해 주세요");
                            continue;
                        }
                    }
                }
            }
        }
    }
}
