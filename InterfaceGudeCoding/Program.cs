namespace InterfaceGudeCoding
{
    interface IWing
    {
        public void Fly();
        public void Fly2()
        {
            Console.WriteLine("이렇게 코딩하세요");
        }
    }
    class Unicon : IWing
    {
        public void Fly()
        {
            Console.WriteLine("나는 동작을 코딩한다~~~!!");
        }
        public void Fly2()
        {
            Console.WriteLine("이렇게 코딩하세요");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Unicon u = new Unicon();
            u.Fly2();
        }
    }
}
