using System;

namespace ShapeInheritInstance
{
    class Shape
    {
        protected double Weight { get; set; }
        protected double Height { get; set; }

        protected internal Shape(double hei, double wei)
        {
            Height = hei;
            Weight = wei;
        }

        protected internal void Show()
        {
            Console.WriteLine(
                $"the height of the shape: {Height}\nthe weight of the shape: {Weight}"
            );
        }
    }

    class Rectangle : Shape
    {
        protected internal Rectangle(double hei, double wei)
            : base(hei, wei)
        {
            Height = hei;
            Weight = wei;
        }

        protected double Area
        {
            get { return Weight * Height; }
        }

        protected internal new void Show()
        {
            base.Show();
            Console.WriteLine($"the Area of the rectangle: {Area}");
        }
    }

    class TestRetangle
    {
        public static void running()
        {
            Rectangle r = new Rectangle(10, 10);
            r.Show();
        }
    };
}
