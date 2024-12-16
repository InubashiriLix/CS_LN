#define DEBUG
using System;

namespace namespace_custom_attribute
{
    [AttributeUsage(
        AttributeTargets.Class
            | AttributeTargets.Constructor
            | AttributeTargets.Field
            | AttributeTargets.Method
            | AttributeTargets.Property,
        AllowMultiple = true
    )]
    public class DebugInfo : System.Attribute
    {
        private int bugNo;
        private string developer;
        private string lastReview;
        public string message;

        public DebugInfo(int bugNo, string developer, string lastReview, string message)
        {
            this.bugNo = bugNo;
            this.developer = developer;
            this.lastReview = lastReview;
            this.message = message;
        }

        public int BugNo
        {
            get { return bugNo; }
        }

        public string Developer
        {
            get { return developer; }
        }
        public string LastReview
        {
            get { return lastReview; }
        }

        public string Message
        {
            get { return message; }
            set { message = value; }
        }
    }

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
    }

    public class Rectangle : Shape
    {
        public Rectangle(double width, double length)
            : base(width, length) { }

        [DebugInfo(55, "Inubashiri", "19/10/10", "this is just a test")]
        public void Show()
        {
            Console.WriteLine($"the area of thie rectangle is {Area}");
            Console.WriteLine($"with the width {Width}, {Length}");
        }
    }
}
