using System;

namespace namesapce_attribute
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public class Shape : Attribute
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
    }
}
