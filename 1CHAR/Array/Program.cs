using System;

namespace ArrayTest
{
    class Arraytest
    {
        static void testArrayAddress()
        {
            int[] arr1 = { 1, 2, 3 };
            int[] arr2 = arr1;

            foreach (int i in arr1)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            arr2[2] = 1000;

            foreach (int i in arr1)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        static void testForeachList()
        {
            List<string> names = new List<string> { "Inubashiri", "Aya", "Odome" };
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }

        static void testDictionary()
        {
            Dictionary<int, string> testDic = new Dictionary<int, string>
            {
                { 1, "test1" },
                { 2, "test2" },
                { 3, "test3" },
            };

            foreach (var item in testDic)
                Console.WriteLine($"{item.Key}: {item.Value}");
        }

        static void Main(string[] args)
        {
            testArrayAddress();
            testForeachList();
            testDictionary();
        }
    }
}
