using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args) 
        {
            string greet = "반갑습니다.";
            string greet2 = "안녕하세요";
            string name = "이순신";
            int age = 40;
            Console.WriteLine("{0} {1}", greet, greet2);
            Console.WriteLine($"나는 {name} {age}살 입니다.");
        }
    }
}
