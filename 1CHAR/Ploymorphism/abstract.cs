using System;

namespace abstract_namespace
{
    abstract class Shape
    {
        public abstract double area();
    }

    class Rectangle : Shape
    {
        private double length;
        private double width;

        public Rectangle(double a = 0, double b = 0)
        {
            length = a;
            width = b;
        }

        public override double area()
        {
            Console.WriteLine("Rectangle area: ");
            return (width * length);
        }
    }

    class RectangleTester
    {
        public static void run()
        {
            Rectangle r = new Rectangle(10, 7);
            double a = r.area();
            Console.WriteLine("Area: {0}", a);
        }
    }
}
