using System;

namespace interface_test_namespace
{
    public interface IBuck
    {
        void buck();
    }

    public interface ILive
    {
        void born();
        void grow();
        void die();
    }

    public interface IAnimal : IBuck, ILive
    {
        void eat();
        void sleep();
    }

    public class Deer : IBuck, ILive
    {
        public void buck()
        {
            Console.WriteLine("Deer bucking");
        }

        public void die()
        {
            Console.WriteLine("Deer dying");
        }

        public void born()
        {
            Console.WriteLine("Welcome to hell");
        }

        public void sleep()
        {
            Console.WriteLine("the moment most close to death comes");
        }

        public void grow()
        {
            Console.WriteLine("Stirb fur mich");
        }
    }

    public class Dog : IBuck
    {
        public void buck()
        {
            Console.WriteLine("Deer bucking");
        }

        public void born()
        {
            Console.WriteLine("shit");
        }

        public void die()
        {
            Console.WriteLine("Deer dying");
        }

        public void sleep()
        {
            Console.WriteLine("the moment most close to death comes");
        }

        public void grow()
        {
            Console.WriteLine("Stirb fur mich");
        }
    }

    public class AnimalGrinder
    {
        public static void test()
        {
            Dog d = new Dog();

            Deer d1 = new Deer();
            d.born();
            d1.born();
            d.die();
            d1.die();
        }
    }
}
