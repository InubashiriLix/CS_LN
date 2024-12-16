using System;

namespace namesapce_multi
{
    public delegate void delegation(string message);

    public class Multi
    {
        public static void Hello(string message) => Console.WriteLine($"Hello, {message}");

        public static void Goodbye(string message) => Console.WriteLine($"Goodbye, {message}");

        public static void Main()
        {
            delegation del = Hello;
            del += Goodbye;
            del("World");
        }
    }
}
