using System;

namespace namespace_abstract_property
{
    public abstract class Person
    {
        public abstract string Name { get; set; }
        public abstract int Age { get; set; }
    }

    class Student : Person
    {
        public string Code { get; set; } = "N.A";
        public override string Name { get; set; } = "N.A";
        public override int Age { get; set; } = 0;

        public override string ToString()
        {
            return $"Code = {Code}, Name = {Name}, Age = {Age}";
        }
    }

    public class Example
    {
        public static void main()
        {
            Student s = new Student
            {
                Code = "001",
                Name = "Zara",
                Age = 9,
            };
            Console.WriteLine(s);
            s.Age += 1;
            Console.WriteLine("age has ++");
            Console.WriteLine(s);
        }
    }
}
