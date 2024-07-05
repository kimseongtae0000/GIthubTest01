using System.Net.Http.Headers;

namespace Quiz07
{
    abstract class Mammal
    {
        //멤버변수
        public string name;
        //생성자
        Mammal()
        {
            this.name = "포유류";
        }
        //멤버메소드
        public abstract string Eat();
    }
    class Lion : Mammal
    {
        public Lion()
        {
            this.name = "사자";
        }
        public override string Eat()
        {
            return $"{this.name}가 먹습니다.";
        }
    }
    class Tiger : Mammal
    {
        public override string Eat()
        {
            return "호랑이가 먹습니다.";
        }
    }
    class Dog : Mammal
    {
        public override string Eat()
        {
            return "개가 먹습니다.";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Mammal[] mammals = new Mammal[3];
            mammals[0] = new Lion();
            mammals[1] = new Tiger();
            mammals[2] = new Dog();

            for (int i = 0; i <  mammals.Length; i++)
            {
                Console.WriteLine(mammals[i].Eat());
            }
        }
    }
}
