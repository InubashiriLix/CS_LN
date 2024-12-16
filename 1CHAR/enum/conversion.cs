using System;

namespace convert_namespace
{
    public enum Days
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday,
    }

    class testEnumConvert
    {
        public static void Run()
        {
            Console.WriteLine($"convert the int to the day (enum) {(Days)1}");
            Console.WriteLine($"day -> {Days.Tuesday}, {(int)Days.Tuesday}");
        }
    }
}
