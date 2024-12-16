using System;

namespace virtual_method_namespace
{
    public class Shape
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Height { get; set; }
        public int Width { get; set; }

        public virtual void Draw()
        {
            Console.WriteLine("Perform the base class's drawing method");
        }
    }

    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Circle Drawing");
            base.Draw();
        }
    }

    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Rectangle Drawing");
        }
    }
}
