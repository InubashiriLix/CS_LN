using System;

namespace first_name
{
    class abc
    {
        public void func()
        {
            Console.WriteLine("Inside first_name");
        }
    }
}

namespace second_name
{
    class efg
    {
        public void func()
        {
            Console.WriteLine("Inside second_name");
        }
    }
}

namespace namespace_big_test
{
    namespace namespace_big_test_1
    {
        class Test
        {
            public static void run()
            {
                Console.WriteLine("Inside namespace_big_test_1");
            }
        }
    }

    namespace namespace_big_test_2
    {
        class Test
        {
            public static void run()
            {
                Console.WriteLine("Inside namespace_big_test2");
            }
        }
    }
}
