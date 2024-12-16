using System;

namespace VariableDefinition
{
    class Program
    {
        static void Main(string[] args)
        {
            short a;
            int b;
            double c;

            a = 10;
            b = 1000;
            c = a + b;

            Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);

            Console.WriteLine();

            Console.WriteLine("Enter an int that you like");

            try
            {
                int g = -1;
                bool result = false;
                while (!result)
                {
                    result = int.TryParse(Console.ReadLine(), out g);
                    if (!result)
                    {
                        Console.WriteLine("Parse Wrong");
                    }
                }
                if (result)
                    Console.WriteLine("new int! {0}", g);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
