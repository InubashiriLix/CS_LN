using System;

namespace namespace_indexerappli
{
    class IndexerNames
    {
        private string[] namelist = new string[size];
        public static int size = 10;

        public IndexerNames()
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
                if (index >= 0 && index <= size - 1)
                    namelist[index] = value;
            }
        }

        public static void main()
        {
            IndexerNames names = new IndexerNames();
            names[0] = "Zara";
            names[1] = "Riz";
            names[2] = "Nuha";
            names[3] = "Asif";
            names[4] = "Davinder";

            for (int i = 0; i < IndexerNames.size; i++)
            {
                Console.WriteLine(names[i]);
            }
        }
    }
}
