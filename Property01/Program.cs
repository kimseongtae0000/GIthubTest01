﻿namespace Property01
{
    class Person
    {

        public Person()
        {
            
        }
        public Person(double d)
        {
        }
        public Person(string name)
        {
        }
        public string Name { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Name = "Bob";
            Console.WriteLine("안녕하세요. " + p.Name + "씨");
        }
    }
}
