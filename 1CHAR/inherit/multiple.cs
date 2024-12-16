using System;
using ShapeInheritInstance;

namespace MultipleInheritance
{
    public interface PaintCost
    {
        double getCost();
    }

    class NewRetangle : Rectangle, PaintCost
    {
        public double Price { get; set; }
        public double Cost
        {
            get { return Price * Area; }
        }

        public NewRetangle(double hei, double wei, double price)
            : base(hei, wei)
        {
            Height = hei;
            Weight = wei;
            Price = price;
        }

        public double getCost()
        {
            return Area * Price;
        }

        public static void go()
        {
            NewRetangle n = new NewRetangle(30, 30, 10);
            Console.WriteLine($"the areea of the new retangle is {n.Area}");
            Console.WriteLine($"the cost of the new rectangle is {n.getCost()}");
        }
    }
}
