using System;

namespace OperatorsAppli
{
    class Program
    {
        public void calculateOperators()
        {
            int a = 21;
            int b = 10;
            int c;

            c = a + b;
            Console.WriteLine($"c value: {c}");

            c = a - b;
            Console.WriteLine($"c value: {c}");

            c = a * b;
            Console.WriteLine($"c value: {c}");

            c = a / b;
            Console.WriteLine($"c value: {c}");

            c = a % b;
            Console.WriteLine($"c value: {c}");

            c = ++a;
            Console.WriteLine($"c = ++a -> {c}");

            c = --a;
            Console.WriteLine($"c = --a -> {c}");

            c = a++;
            Console.WriteLine($"c = a++ -> {c}");

            c = a--;
            Console.WriteLine($"c = a-- -> {c}");
            Console.WriteLine("Done");
        }

        public void logicOperators()
        {
            bool a = true;
            bool b = true;

            if (a && b)
                Console.WriteLine("true && true -> true");
            if (a || b)
                Console.WriteLine("true || true -> true");
        }

        public void bitwiseOperators()
        {
            int A = 60;
            int B = 13;

            int c = A & B;
            Console.WriteLine("&");
            Console.WriteLine("Expected -> 0b00001100");
            Console.WriteLine($"Actually -> {"0b" + Convert.ToString(c, 2)}");

            c = A | B;
            Console.WriteLine("|");
            Console.WriteLine("Expected -> 0b00111101");
            Console.WriteLine($"Actually -> {"0b" + Convert.ToString(c, 2)}");

            c = A ^ B;
            Console.WriteLine("^");
            Console.WriteLine("Expected -> 0b00110001");
            Console.WriteLine($"Actually -> {"0b" + Convert.ToString(c, 2)}");

            c = ~A;
            Console.WriteLine("~");
            Console.WriteLine("Expected -> 0b11000011");
            Console.WriteLine($"Actually -> {"0b" + Convert.ToString(c, 2)}");

            c = A << 2;
            Console.WriteLine("<<");
            Console.WriteLine("Expected -> 0b11110000");
            Console.WriteLine($"Actually -> {"0b" + Convert.ToString(c, 2)}");

            c = A >> 2;
            Console.WriteLine(">>");
            Console.WriteLine("Expected -> 0b00001111");
            Console.WriteLine($"Actually -> {"0b" + Convert.ToString(c, 2)}");
        }

        public void otherOperators()
        {
            int a = 10;
            Console.WriteLine($"sizeof int -> {sizeof(int)}");
            Console.WriteLine($"typeof int -> {typeof(Program)}");
            int b = (a == 1) ? 20 : 30;

            Console.WriteLine(b.ToString());

            Type type = typeof(string);
            Console.WriteLine(type.FullName);
        }

        public static void Main(string[] args)
        {
            Program program = new Program();

            program.calculateOperators();
            program.logicOperators();
            program.bitwiseOperators();
            program.otherOperators();
        }
    }
}
