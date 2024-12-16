using constTest;

namespace EscapeChar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello\tWorld\n\n");
            Console.ReadLine();

            ConstTest.SampleClass cons = new ConstTest.SampleClass(1, 2);
            cons.test();
        }
    }
}
