using System;

namespace TypeConversionApplication
{
    class ExplicitConversion
    {
        public static void Converting()
        {
            double d = 5677.2324;
            int i;

            // type casting the double to int
            i = (int)d;
            Console.WriteLine($"double {d} -> int : {i}");

            int a = 1;
            bool b = Convert.ToBoolean(a);
            Console.WriteLine($"{b}");

            int g = 75;
            float f = 53.005f;
            double h = 22345.3425;
            bool e = true;
            Console.WriteLine(i.ToString());
            Console.WriteLine(f.ToString());
            Console.WriteLine(e.ToString());
            Console.WriteLine(h.ToString());
            Console.WriteLine(g.ToString());
            Console.WriteLine(Convert.ToBoolean(f));
        }

        public static void ParseTest()
        {
            string str = "123";
            int num = Convert.ToInt32(str);
            Console.WriteLine(num.ToString());

            try
            {
                string strDouble = "123.123";
                double d = Convert.ToDouble(strDouble);
                Console.WriteLine(d);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void tryParseTest()
        {
            string str = "123.123";
            double d;
            bool success = double.TryParse(str, out d);
            if (success)
            {
                Console.WriteLine("convert success");
            }
            else
            {
                Console.WriteLine("convert failed");
            }
        }
    }
}
