using System;

namespace CalculateApplication
{
    class NullableAtShow
    {
        static void nullableTest()
        {
            int? num1 = null;
            int? num2 = 45;
            double? num3 = new double?();
            double? num4 = 3.14157;

            bool? boolval = new bool?();

            Console.WriteLine("showing the nullable value: ");
            Console.WriteLine($"{num1}, {num2}, {num3}, {num4}, {boolval}");
            if (num1 is null)
            {
                Console.WriteLine("num1 is null");
            }
        }

        static void nullCoalescingOperator()
        {
            int? a = new int?();
            int b = 1;
            var result = a ?? b;
            Console.WriteLine($"{result}");
        }

        static void Main(string[] args)
        {
            nullableTest();
            nullCoalescingOperator();
        }
    }
}
