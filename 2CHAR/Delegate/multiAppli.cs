using System;
using System.IO;

namespace namespace_multiapplication
{
    public class Mine
    {
        private FileStream fs;
        private StreamReader sr;
        private StreamWriter sw;
        private const String LOG_PATH = "log.txt";
        protected internal delegate void del(string input);

        public Mine()
        {
            fs = new FileStream(LOG_PATH, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            sr = new StreamReader(fs);
            sw = new StreamWriter(fs);
        }

        protected internal void logging(string msg)
        {
            sw.WriteLine(msg);
            sw.Flush();
            sw.Close();
        }

        protected internal void calling(string msg)
        {
            Console.WriteLine(msg);
        }

        protected internal void recording(del dele, string msg)
        {
            dele(msg);
        }

        public void working()
        {
            string msg = "this is a test";
            del del1 = calling;
            del del2 = logging;
            del1 += del2;
            recording(del1, msg);
        }
    }
}
