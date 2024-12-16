using System;

namespace ploymorphism_namespace
{
    public class ploymorphism
    {
        public void Add(int a, int b)
        {
            Console.WriteLine("Addition of two numbers is: " + (a + b));
        }

        public void Add(int a, int b, int c)
        {
            Console.WriteLine("Addition of three numbers is: " + (a + b + c));
        }

        public void Add(int a, int b, int c, int d)
        {
            Console.WriteLine("Addition of four numbers is: " + (a + b + c + d));
        }

        public static void run()
        {
            ploymorphism obj = new ploymorphism();
            obj.Add(10, 20);
            obj.Add(10, 20, 30);
            obj.Add(10, 20, 30, 40);
        }
    }
}
