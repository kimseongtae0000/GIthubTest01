﻿namespace TestApp01
{
    class Person
    {
        public Person()
        {
            Console.WriteLine("디폴트 생성자 호출");
        }
        ~Person()
        {
            Console.WriteLine("소멸자 호출");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
        }
    }
}
