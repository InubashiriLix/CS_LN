using System;

namespace InterfaceInheritance
{
    internal interface desire
    {
        bool killing(int index);
    }

    internal interface grinderDesire : desire
    {
        bool running();
    }

    class Grinder : grinderDesire
    {
        public List<string> killingList = new List<string> { "You", "Me", "All" };
        public List<bool> killingListStatus = new List<bool> { false, false, false };

        public bool killing(int index)
        {
            if (index < 3 && index >= 0)
            {
                Console.WriteLine($"I killed {killingList[index]}");
                if (killingList[index].Equals("Me"))
                {
                    Console.WriteLine("I want to live");
                    return false;
                }
                return true;
            }
            return false;
        }

        public bool running()
        {
            for (int i = 0; i < 3; i++)
            {
                if (!killing(i))
                {
                    Console.WriteLine("Refuse to KILL");
                }
            }
            return true;
        }

        public static void go()
        {
            Grinder g = new Grinder();
            g.running();
        }
    }
}
