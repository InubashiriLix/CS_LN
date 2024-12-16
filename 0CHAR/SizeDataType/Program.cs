// See https://aka.ms/new-console-template for more information
using System;

namespace sizeDataType
{
    class SizeDataType
    {
        public static void ShowSize()
        {
            Console.WriteLine("the size of byte is 1 -> {0}", sizeof(byte));
            Console.WriteLine("the size of sbyte is 1 -> {0}", sizeof(sbyte));
            Console.WriteLine("the size of int in arm64 should be 4 -> {0}", sizeof(int));
            Console.WriteLine("the size of uint in arm64 should be 8 -> {0}", sizeof(uint));
            Console.WriteLine("the size of long in arm64 should be 8 -> {0}", sizeof(long));
            Console.WriteLine("the size of ulong in arm64 should be 8 -> {0}", sizeof(ulong));
            Console.WriteLine("the size of decimal in arm64 should be 16 -> {0}", sizeof(decimal));
            Console.WriteLine("the size of float in arm64 should be 4 -> {0}", sizeof(float));
            Console.WriteLine("the size of double in arm64 should be 8 -> {0}", sizeof(double));
            Console.WriteLine("the size of short in arm64 should be 22 -> {0}", sizeof(short));
            Console.WriteLine("the size of ushort in arm64 should be 2 -> {0}", sizeof(ushort));

            String msg = @"this is a message: C:\Windows";
            String msg1 = "this is a message: C:\\Windows";

            Console.WriteLine(msg);
            Console.WriteLine(msg1);
        }

        public static void Main(string[] args)
        {
            ShowSize();
        }
    }
}
