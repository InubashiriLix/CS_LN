using System;

namespace constTest
{
    public class ConstTest
    {
        public class SampleClass
        {
            public int x;
            public int y;
            public const int c1 = 5;
            public const int c2 = c1 + 4;

            public SampleClass(int p1, int p2)
            {
                x = p1;
                y = p2;
            }

            public void test()
            {
                try
                {
                    Console.WriteLine("the const value should not been assigned!");
                    Console.WriteLine($"const1 = {c1}, const2 = {c2}");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
