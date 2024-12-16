using System;

namespace namespace_delegate_basic
{
    public delegate void MyDelegate(string msg);

    public class Program
    {
        public static void Hello(string message)
        {
            Console.WriteLine($"Hello, {message}");
        }

        public static void Goodbye(string message)
        {
            Console.WriteLine($"GoodBye, {message}");
        }

        public static void main()
        {
            MyDelegate del = Hello;
            del("World");

            del = Goodbye;
            del("World");
        }
    }
}
