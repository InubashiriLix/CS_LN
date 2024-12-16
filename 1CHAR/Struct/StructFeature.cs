namespace featureStruct
{
    public struct withConstructor
    {
        public string name;
        public byte age;

        public withConstructor(string Name, int Age)
        {
            name = Name;
            age = (byte)Age;
        }

        public void show()
        {
            Console.WriteLine("withConstructor Showing");
            Console.WriteLine($"name -> {name}");
            Console.WriteLine($"age -> {age}");
        }
    }

    public interface IShape
    {
        double Area();
    }

    public struct Circle : IShape
    {
        public double Radius;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }

    public readonly struct ImmutableStruct
    {
        // no setter there
        public string test1 { get; }
        public string test2 { get; }

        public ImmutableStruct(string new1, string new2)
        {
            test1 = new1;
            test2 = new2;
        }
    }

    public class FeatureStruct
    {
        public string msg = "STIRB!";

        public FeatureStruct()
        {
            Console.WriteLine(msg);
        }

        public static void TestStructConstrutor()
        {
            withConstructor wc = new withConstructor("stirb!", 11);
            wc.show();
        }

        public static void testInterafceStruct()
        {
            Circle cle = new Circle(1.1);
            Console.WriteLine($"the Area: {cle.Area()}");
        }

        public static void testReadOnly()
        {
            ImmutableStruct readIm = new ImmutableStruct("Kill you", "all");
            Console.WriteLine($"{readIm.test1}");
            Console.WriteLine($"{readIm.test2}");

            // try
            // {
            //     readIm.test1 = "SHIT";
            // }
            // catch (Exception e)
            // {
            //     Console.WriteLine(e.Message);
            // }
        }
    }
}
