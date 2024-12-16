using System;

namespace CalculateApplication
{
    class NumberManipulator
    {
        // the swap method with ref
        public static void swap(ref int x, ref int y)
        {
            int temp = y;
            x = y;
            y = temp;
        }

        public static void runTest()
        {
            int a = 10;
            int b = 20;
            Console.WriteLine("{0}, {1}", a, b);

            swap(ref a, ref b);
            Console.WriteLine("{0}, {1}", a, b);
        }

        public static void getValue(out int x)
        {
            int temp = 5;
            x = temp;
        }

        public static void runOutTest()
        {
            int shit = 10;
            Console.WriteLine($"{shit}");
            getValue(out shit);
            Console.WriteLine($"{shit}");
        }
    }
}
