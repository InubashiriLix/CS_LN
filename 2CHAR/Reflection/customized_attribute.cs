#define DEBUG
using System;
using System.Reflection;

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
                if (value < 0)
                    Console.WriteLine("Invalid Entering!");
                width = Math.Max(0, value);
            }
        }

        public double Length
        {
            get { return length; }
            set
            {
                if (value < 0)
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

    [DebugInfo(11, "Aya", "19/11/10", "this is just a test -- aya")]
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

    public class CustomAttributeReflectionTester
    {
        public static void main()
        {
            Console.WriteLine("main start now");
            Type rectangleType = typeof(Rectangle);
            System.Reflection.MethodInfo? methodInfo = rectangleType.GetMethod("Show");
            if (methodInfo != null)
            {
                object[] attributes = methodInfo.GetCustomAttributes(true);
                foreach (var attribute in attributes)
                {
                    Console.WriteLine(attribute);
                }
            }

            // testing for the instances
            Rectangle r = new Rectangle(2, 3);
            r.Show();
            Type type = typeof(Rectangle);

            Console.WriteLine("GetCustomAttributes false");
            foreach (Object attributes in type.GetCustomAttributes(false))
            {
                DebugInfo dbi = (DebugInfo)attributes;
                if (null != dbi)
                {
                    Console.WriteLine("Bug no: {0}", dbi.BugNo);
                    Console.WriteLine("Developer: {0}", dbi.Developer);
                    Console.WriteLine("Last Review: {0}", dbi.LastReview);
                    Console.WriteLine("Remark: {0}", dbi.Message);
                }
            }

            Console.WriteLine("GetCustomAttributes true");
            foreach (System.Reflection.MethodInfo m in type.GetMethods())
            {
                foreach (Attribute a in m.GetCustomAttributes(true))
                {
                    if (a is DebugInfo dbi)
                    {
                        Console.WriteLine("Bug no: {0}", dbi.BugNo);
                        Console.WriteLine("Developer: {0}", dbi.Developer);
                        Console.WriteLine("Last Review: {0}", dbi.LastReview);
                        Console.WriteLine("Remark: {0}", dbi.Message);
                    }
                    else
                    {
                        Console.WriteLine("Found attribute of type: {0}", a.GetType().Name);
                    }
                }
            }
        }
    }
}
