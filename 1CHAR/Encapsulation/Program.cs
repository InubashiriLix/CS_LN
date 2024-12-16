using System;
using CalculateApplication;

namespace RectangleApplicatoin
{
    class Rectangle
    {
        private double length;
        private double width;

        public double GetArea()
        {
            return length * width;
        }

        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("width: {0}", width);
            Console.WriteLine("Area: {0}", length * width);
        }

        public void AcceptDetails()
        {
            Console.WriteLine("Enter the length:");
            length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the width:");
            width = Convert.ToDouble(Console.ReadLine());
        }
    }

    class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            // r.length = 4.5;
            // r.width = 3.5;
            r.AcceptDetails();
            r.Display();
            Console.ReadLine();

            NumberManipulator.runTest();
            NumberManipulator.runOutTest();
        }
    }
}
