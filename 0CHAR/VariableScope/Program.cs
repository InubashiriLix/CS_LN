using System;

namespace VariableScopeTest
{
    class VariableScopeClass
    {
        public static double localVar = 20;
        static int globalVar = 100;

        // this is a test method for vaiable in the function
        public static void scopeTest()
        {
            int localVar = 10;

            Console.WriteLine($"the variable in the method should be 10 -> {localVar}");

            // in the C# 7 ++, any content inn the {} can be define a
            // variable scope
            {
                int localVar1 = 30;
                Console.WriteLine($"the variable in the current block should be 30 -> {localVar1}");
                Console.WriteLine($"time for the global variable -> {globalVar}");
            }

            // the variable in the for can only be used in the for
            // for example: int i can only used in the for struct
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i.ToString());
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            VariableScopeClass.scopeTest();
            Console.WriteLine("Done");
        }
    }
}
