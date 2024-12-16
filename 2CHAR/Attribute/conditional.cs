#define DEBUG
#undef DEBUG

using System;
using System.Diagnostics;

namespace namespace_conditional
{
    public class Shape
    {
        private double width;
        private double length;
        public double Width
        {
            get { return width; }
            set
            {
                Console.WriteLine("Invalid Entering!");
                width = Math.Max(0, value);
            }
        }

        public double Length
        {
            get { return length; }
            set
            {
                Console.WriteLine("Invalid Entering!");
                length = Math.Max(0, value);
            }
        }

        public double Area
        {
            get { return Width * Length; }
        }

        public Shape(double width, double length)
        {
            Width = width;
            Length = length;
        }

        [Conditional("DEBUG")]
        public void show()
        {
            Console.WriteLine($"the width is {Width}, the length is {Length}, the area is {Area}");
        }
    }

    public class Test
    {
        public static void main()
        {
            Shape shape = new Shape(1, 2);
            shape.show();
        }
    }
}
