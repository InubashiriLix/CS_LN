using System;

namespace FibonacciAppli
{
    class Fibonacci
    {
        public static void FibonacciNormal(int a, int b, int num)
        {
            Console.WriteLine("{0}, {1}", a, b);
            for (int i = 0; i < num; i++)
            {
                int temp = a + b;
                a = b;
                b = temp;
                Console.WriteLine("{0} {1}", a, b);
            }
        }

        public static void FibonacciRecursive(int[] arr, int num)
        {
            if (num > 0)
            {
                int temp = arr[0] + arr[1];
                arr[0] = arr[1];
                arr[1] = temp;
                Console.WriteLine("{0}, {1}", arr[0], arr[1]);
                FibonacciRecursive(arr, num - 1);
            }
            else
                Console.WriteLine("END {0}, {1}", arr[0], arr[1]);
        }

        public static void Main(string[] args)
        {
            FibonacciNormal(1, 1, 4);
            int[] arr = new int[] { 1, 1 };
            FibonacciRecursive(arr, 4);
        }
    }
}
