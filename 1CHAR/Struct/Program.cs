using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace testStruct
{
    struct Books
    {
        public string title { get; set; }
        public string author { get; set; }
        public string subject { get; set; }
        public int book_id { get; set; }
    };

    class TestStructClass
    {
        public static void running()
        {
            Books Book1 = new Books()
            {
                title = "How To Kill you all",
                author = "stirb",
                subject = "Kill you all",
                book_id = 11,
            };
            Books Book2 = new Books()
            {
                title = "I want to KILL YOU ALL",
                author = "KILL YOU ALL",
                subject = "KILLYOUALL",
                book_id = 13,
            };

            Console.WriteLine("Book1");
            foreach (
                PropertyInfo propertyInfo in typeof(Books).GetProperties(
                    BindingFlags.Public | BindingFlags.Instance
                )
            )
            {
                Console.WriteLine($"{propertyInfo.Name} = {propertyInfo.GetValue(Book1)}");
            }

            Console.WriteLine("Book2");
            foreach (
                PropertyInfo propertyInfo in typeof(Books).GetProperties(
                    BindingFlags.Public | BindingFlags.Instance
                )
            )
            {
                Console.WriteLine($"{propertyInfo.Name} = {propertyInfo.GetValue(Book2)}");
            }
        }
    }
}
