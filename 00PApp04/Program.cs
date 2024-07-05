using System.Drawing;

namespace _00PApp04
{
    abstract class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("도형을 그리다.");
        }
    }
    class Triangle : Shape
    {
        //Draw() Overeiding하세요. 삼각형을 그리다.
        public override void Draw()
        {
            Console.WriteLine("도형을 그리다.");
        }
    }
    class Rectangle : Shape
    {
        //Draw() Overeiding하세요. 사각형을 그리다.
        public override void Draw()
        {
            Console.WriteLine("사각형을 그리다.");
        }
    }
    class Circle : Shape
    {
        //Draw() Overeiding하세요. 원을 그리다.
        public override void Draw()
        {
            Console.WriteLine("원을 그리다.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Shape shape = new Shape();
            Triangle triangle = new Triangle();
            Rectangle rectangle = new Rectangle();
            Circle circle = new Circle();

            triangle.Draw();
            rectangle.Draw();
            circle.Draw();
        }
    }
}
