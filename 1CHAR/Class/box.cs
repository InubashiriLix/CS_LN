using System;

namespace BoxClass1
{
    public class Box
    {
        public Box(double len, double hei, double bre)
        {
            length = len;
            height = hei;
            breadth = bre;
        }

        public double length { get; set; }
        public double height { get; set; }
        public double breadth { get; set; }

        protected internal double Space()
        {
            return length * height * breadth;
        }

        protected internal void Show()
        {
            Console.WriteLine($"the space -> {Space()}");
        }

        ~Box()
        {
            Console.WriteLine("Stirb");
        }
    }

    class Boxtester
    {
        private Box box1 = new Box(1, 2, 3);
        private Box box2 = new Box(3, 2, 1);

        public Boxtester()
        {
            box1.Show();
            box2.Show();
        }
    }
}
