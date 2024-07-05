namespace _00PApp05
{
    abstract class Mammal
    {
        public abstract void Eat(); //추상 메소드 abstract Methood
    }
    class Lion : Mammal
    {
        public override void Eat()
        {
            Console.WriteLine("사자가 먹습니다.");
        }
    }
    class Tiger : Mammal
    {
        public override void Eat()
        {
            Console.WriteLine("호랑이가 먹습니다.");
        }
    }
    class Dog : Mammal 
    {
        public override void Eat()
        {
            Console.WriteLine("강아지가 먹습니다.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Car car = new Car();  //Car 클래스를 abstract 클래스로 만들었기 때문.
            Lion lion = new Lion();
            Tiger tiger = new Tiger();
            Dog dog = new Dog();
            lion.Eat();
            tiger.Eat();
            dog.Eat();
        }
    }
}
