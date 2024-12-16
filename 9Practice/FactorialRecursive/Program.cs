using System;

namespace Factorial
{
    class Factorial
    {
        public static int fac(int newNum)
        {
            if (newNum > 1)
            {
                return newNum * fac(--newNum);
            }
            return 1;
        }

        public static int facRecusive(int newNum)
        {
            return newNum > 0 ? (newNum * facRecusive(newNum - 1)) : 1;
        }

        public static void Main()
        {
            Console.WriteLine($"{Factorial.fac(4)}");
            Console.WriteLine($"{Factorial.facRecusive(4)}");
        }
    }
}
