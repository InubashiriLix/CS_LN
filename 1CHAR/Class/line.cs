using System;

namespace LineApplication
{
    class Line
    {
        private double Length { get; set; }

        public Line(double len)
        {
            Console.WriteLine("Object has created, length = {0}", len);
            Length = len;
        }

        public void running()
        {
            Line line = new Line(10);
            Console.WriteLine($"the Length of the line is {line.Length}");
            line.Length = 20;
            Console.WriteLine($"the Length of the line is {line.Length}");
        }
    }
}
