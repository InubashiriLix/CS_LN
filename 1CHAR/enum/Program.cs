using convert_namespace;
using permssion_namespace;

namespace enum_namespace
{
    enum Days
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday,
    };

    enum Jumps
    {
        zero,
        fourty = 40,
        fourty_one,
        fourty_two,
    }

    enum Len : long
    {
        length,
        width,
        height,
    }

    public enum Gender
    {
        Male,
        Female,
    }

    class RunEnum
    {
        private static int[] len = new int[3] { 10, 20, 30 };
        private static int[] LEN
        {
            set
            {
                len = value;
                Console.WriteLine($"{value}");
            }
            get { return len; }
        }

        private static Gender gender = Gender.Male;
        int genderInt = (int)gender;
        Gender gender1 = (Gender)0;
        string genderStr = gender.ToString();
        Gender gender2 = (Gender)Enum.Parse(typeof(Gender), "Female");

        public static void Main(string[] args)
        {
            Console.WriteLine("this is a test");
            Console.WriteLine("print the int of Tuesday {0}", (int)Days.Tuesday);

            foreach (var day in Enum.GetValues(typeof(Days)))
            {
                Console.WriteLine("this is the index {0} -> {1}", (int)day, day);
            }

            foreach (var jump in Enum.GetValues(typeof(Jumps)))
            {
                Console.WriteLine($"{(int)jump} -> {jump}");
            }

            foreach (var single_len in Enum.GetValues(typeof(Len)))
            {
                Console.WriteLine($"{(long)single_len} -> {len[(long)single_len]}");
            }

            for (int i = 0; i < 3; i++)
            {
                LEN[i] += 10;
            }
            foreach (var single_len in Enum.GetValues(typeof(Len)))
            {
                Console.WriteLine($"{(long)single_len} -> {len[(long)single_len]}");
            }

            testEnumConvert.Run();

            testPermission test = new testPermission();
            test.run();
        }
    }
}
