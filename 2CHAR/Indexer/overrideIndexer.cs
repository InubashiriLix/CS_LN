using System;

namespace namespace_OverrideIndexerApplication
{
    class IndexedNames
    {
        private string[] namelist = new string[size];

        public static int size = 10;

        public IndexedNames()
        {
            for (int i = 0; i < size; i++)
            {
                namelist[i] = "N. A.";
            }
        }

        public string this[int index]
        {
            get { return (index >= 0 && index < size) ? namelist[index] : ""; }
            set
            {
                if (index >= 0 && index < size)
                    namelist[index] = value;
            }
        }

        public int this[string name]
        {
            get
            {
                for (int i = 0; i < size; i++)
                {
                    if ((namelist[i]) == name)
                        return i;
                }
                return -1;
            }
        }

        public static void main()
        {
            IndexedNames names = new IndexedNames();
            names[0] = "Zara";
            names[1] = "Riz";
            names[2] = "Nuha";
            names[3] = "Asif";
            names[4] = "Davinder";

            for (int i = 0; i < IndexedNames.size; i++)
            {
                Console.WriteLine(names[i]);
            }

            Console.WriteLine($"the index of the name Riz: {names["Riz"]}");
        }
    }
}
