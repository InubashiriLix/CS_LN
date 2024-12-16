using System;
using System.Diagnostics;

namespace namespace_obsolete
{
    // [Obsolete("this is a obsolete test", true)]
    public class ObsoleteTest
    {
        [Obsolete("this is a obsolete test", false)]
        public void OldMethod()
        {
            Console.WriteLine("it is a old method");
        }

        public void NewMethod()
        {
            Console.WriteLine("it is a new method");
        }

        public static void run()
        {
            ObsoleteTest test = new ObsoleteTest();
            test.OldMethod();
            test.NewMethod();
        }
    }
}
