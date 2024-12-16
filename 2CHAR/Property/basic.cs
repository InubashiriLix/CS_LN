using System;

namespace namespace_property_basic
{
    public class Rectangle
    {
        private double length;
        private double width;

        public double Length
        {
            get
            {

                return length;
            }
            set
            {
                if (value < 0)
                    Console.WriteLine("Length cannot be negative");
                length = Math.Abs(value);
            }
        }

        public double Width
        {
            get { return width; }
            set
            {
                if (value < 0)
                    Console.WriteLine("Length cannot be negative");
                width = Math.Abs(value);
            }
        }

        public double Area
        {
            get { return length * width; }
        }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }
    }
}
